﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using Microsoft.Azure.Management.DataFactories;
using Microsoft.Azure.Management.DataFactories.Models;
using Rm = Microsoft.Azure.Management.ResourceManager; // Collides with Microsoft.Rest.Serialization on SafeJsonConvert
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataFactory.Tests.Utils
{
    public static class ExampleHelpers
    {
        /// <summary>
        /// Work around issue where apparently no version of client runtime fully supports .net standard
        /// </summary>
        class CertificateCredentials: ServiceClientCredentials
        {
            private X509Certificate2 cert;
            public CertificateCredentials(X509Certificate2 cert)
            {
                this.cert = cert;
            }
            public override void InitializeServiceClient<T>(ServiceClient<T> client)
            {
                HttpClientHandler handler = client.HttpMessageHandlers.FirstOrDefault(h => h is HttpClientHandler) as HttpClientHandler;
                handler.ClientCertificates.Add(this.cert);
            }
        }

        /// <summary>
        /// Work around issue where apparently no version of ADAL fully supports .net standard
        /// </summary>
        class ClientAssertionCertificate : IClientAssertionCertificate
        {
            private string clientId;
            private X509Certificate2 cert;

            public ClientAssertionCertificate(string clientId, X509Certificate2 cert)
            {
                this.clientId = clientId;
                this.cert = cert;
            }

            public string ClientId
            {
                get
                {
                    return this.clientId;
                }
            }

            public string Thumbprint
            {
                get
                {
                    // NOT the cert's thumbprint
                    return Base64UrlEncoder.Encode(this.cert.GetCertHash());
                }
            }

            public byte[] Sign(string message)
            {
                using (RSA key = this.cert.GetRSAPrivateKey())
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    byte[] signed256 = key.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                    return signed256;
                }
            }
        }

        public static ExampleSecrets ReadSecretsFile(string path)
        {
            string json = File.ReadAllText(path);
            return SafeJsonConvert.DeserializeObject<ExampleSecrets>(json);
        }
        
        public static Rm.IResourceManagementClient GetRealRmClient(ExampleSecrets secrets)
        {
            Rm.IResourceManagementClient client = null;
            if (secrets.Environment == "test")
            {
                string ArmTenant = secrets.TenantId;
                string ArmServicePrincipalIdentity = secrets.ClientId;
                string SubId = secrets.SubId;
                string Thumb = secrets.ClientSecret;
                // Use service principal with cert to authenticate against Azure
                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);
                X509Certificate2 cert = store.Certificates.Find(X509FindType.FindByThumbprint, Thumb, false)[0];
                ClientAssertionCertificate cac = new ClientAssertionCertificate(ArmServicePrincipalIdentity, cert);
                var context = new AuthenticationContext("https://login.windows-ppe.net/" + ArmTenant);
                AuthenticationResult result = context.AcquireTokenAsync("https://management.core.windows.net/", cac).Result;
                ServiceClientCredentials creds = new TokenCredentials(result.AccessToken);
                client = new Rm.ResourceManagementClient(creds) { SubscriptionId = secrets.SubId };
                client.BaseUri = new Uri("https://api-dogfood.resources.windows-int.net/");
            }
            else if (secrets.Environment == "prod")
            {
                // Use Service Principal to authenticate against Azure
                var context = new AuthenticationContext("https://login.windows.net/" + secrets.TenantId);
                ClientCredential cc = new ClientCredential(secrets.ClientId, secrets.ClientSecret);
                AuthenticationResult result = context.AcquireTokenAsync("https://management.azure.com/", cc).Result;
                ServiceClientCredentials creds = new TokenCredentials(result.AccessToken);
                client = new Rm.ResourceManagementClient(creds) { SubscriptionId = secrets.SubId };
            }
            else if (secrets.Environment == "nightly")
            {
                return null; // Nightly environment is direct access to our RP, so no ARM
            }
            else
            {
                throw new ArgumentException("Secrets environment must be test, prod, or nightly, currently {0}", secrets.Environment);
            }
            return client;

        }

        public static IDataFactoryManagementExtendedClient GetRealClient(ExampleSecrets secrets)
        {
            IDataFactoryManagementExtendedClient client = null;
            if (secrets.Environment == "test")
            {
                string ArmTenant = secrets.TenantId;
                string ArmServicePrincipalIdentity = secrets.ClientId;
                string SubId = secrets.SubId;
                string Thumb = secrets.ClientSecret;
                // Use service principal with cert to authenticate against Azure
                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);
                X509Certificate2 cert = store.Certificates.Find(X509FindType.FindByThumbprint, Thumb, false)[0];
                ClientAssertionCertificate cac = new ClientAssertionCertificate(ArmServicePrincipalIdentity, cert);
                var context = new AuthenticationContext("https://login.windows-ppe.net/" + ArmTenant);
                AuthenticationResult result = context.AcquireTokenAsync("https://management.core.windows.net/", cac).Result;
                ServiceClientCredentials creds = new TokenCredentials(result.AccessToken);
                client = new DataFactoryManagementExtendedClient(creds) { SubscriptionId = SubId };
                client.BaseUri = new Uri("https://api-dogfood.resources.windows-int.net/");
            }
            else if (secrets.Environment == "prod")
            {
                // Use Service Principal to authenticate against Azure
                var context = new AuthenticationContext("https://login.windows.net/" + secrets.TenantId);
                ClientCredential cc = new ClientCredential(secrets.ClientId, secrets.ClientSecret);
                AuthenticationResult result = context.AcquireTokenAsync("https://management.azure.com/", cc).Result;
                ServiceClientCredentials creds = new TokenCredentials(result.AccessToken);
                client = new DataFactoryManagementExtendedClient(creds) { SubscriptionId = secrets.SubId };
            }
            else if (secrets.Environment == "nightly")
            {
                // Use certificate for direct access to RP
                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);
                X509Certificate2 cert = store.Certificates.Find(X509FindType.FindByThumbprint, "CF6DCEF6F6EB497A1B2A569319D157F875019A9E", false)[0];
                CertificateCredentials creds = new CertificateCredentials(cert);
                client = new DataFactoryManagementExtendedClient(creds) { SubscriptionId = secrets.SubId };
                client.BaseUri = new Uri("https://adfrpnightly.svc.datafactory-test.azure.com");
            }
            else
            {
                throw new ArgumentException("Secrets environment must be test or prod, currently {0}", secrets.Environment);
            }
            return client;
        }

        public static JsonSerializerSettings GetFullSerializerSettings(IDataFactoryManagementExtendedClient client, bool includeNulls = false)
        {
            // Issue: The client's serializer ignores read-only properties like resource Name and Id, and also ignores nulls.
            // That's fine for serializing requests, but not for serializing responses or testing JSON round-trip through OM.
            // So, we make our own serializer that differs from the client's only in that it also serializes read-only properties,
            // and optionally also serializes nulls.
            JsonSerializerSettings fullSerializationSettings = new JsonSerializerSettings
            {
                Formatting = client.SerializationSettings.Formatting,
                DateFormatHandling = client.SerializationSettings.DateFormatHandling,
                DateTimeZoneHandling = client.SerializationSettings.DateTimeZoneHandling,
                NullValueHandling = includeNulls ? NullValueHandling.Include : client.SerializationSettings.NullValueHandling,
                ReferenceLoopHandling = client.SerializationSettings.ReferenceLoopHandling,
                ContractResolver = new DefaultContractResolver(), // not the one that drops read-only properties
                Converters = client.SerializationSettings.Converters
            };
            return fullSerializationSettings;
        }

        public static void WriteTextFile(string text, string folder, string fileName)
        {
            if (folder != null)
            {
                Directory.CreateDirectory(folder);
                File.WriteAllText(Path.Combine(folder, fileName), text);
            }
        }

        public static bool TryMerge(Example exampleExisting, Example exampleNew)
        {
            // either merge exampleNew response into exampleExisting and return true, or return false
            if (exampleExisting.Name != exampleNew.Name)
                return false; // must have same name
            if (exampleNew.Responses.Count != 1)
                return false; // new must have exactly one response
            KeyValuePair<string, Example.Response> newResponse = exampleNew.Responses.First();
            if (exampleExisting.Responses.ContainsKey(newResponse.Key))
                return false; // existing must not already contain an example of the new response code
            if (!exampleNew.Parameters.ContainsKey("operationUrl"))
            {
                // new example must either be a long-running operation result match parameters of existing example
                if (exampleExisting.Parameters.Count() != exampleNew.Parameters.Count())
                    return false; // must have same number of parameters
                foreach (var kvp in exampleNew.Parameters)
                {
                    object val;
                    if (!exampleExisting.Parameters.TryGetValue(kvp.Key, out val))
                    {
                        return false; // all parameter names need to match
                    }
                    if (!kvp.Value.Equals(val))
                        return false; // all parameter values need to match
                }
            }
            // Now we know they're compatible, so actually merge
            exampleExisting.Responses.Add(newResponse.Key, newResponse.Value);
            return true;
        }

        public static List<Example> GetMergedExamples(ExampleTracingInterceptor interceptor)
        {
            Dictionary<string, Example> merged = new Dictionary<string, Example>();
            foreach (long id in interceptor.InvocationIdToExample.Keys.OrderBy(k => k))
            {
                Example exampleNew = interceptor.InvocationIdToExample[id];
                Example exampleExisting;
                if (merged.TryGetValue(exampleNew.Name, out exampleExisting))
                {
                    if (!TryMerge(exampleExisting, exampleNew))
                    {
                        exampleNew.Name = id.ToString() + exampleNew.Name; // give a unique name
                        merged.Add(exampleNew.Name, exampleNew);
                    }
                }
                else
                {
                    merged.Add(exampleNew.Name, exampleNew);
                }
            }
            return merged.Values.ToList();
        }

        /// <summary>
        /// Ensures correct generic json serialization of example parameters.
        /// For all parameter values that have client model types, use the client
        /// serializer to get the correct json, then replace the parameter value
        /// with the generic object deserialization of that json.
        /// </summary>
        /// <param name="examples"></param>
        /// <param name="client"></param>
        public static void FixExampleModelParameters(List<Example> examples, IDataFactoryManagementExtendedClient client)
        {
            foreach (Example example in examples)
            {
                Dictionary<string, object> fixes = new Dictionary<string, object>();
                foreach (KeyValuePair<string, object> kvp in example.Parameters)
                {
                    if (kvp.Value != null && kvp.Value.GetType().Namespace == typeof(GatewayExtended).Namespace)
                    {
                        string jsonFixed = SafeJsonConvert.SerializeObject(kvp.Value, client.SerializationSettings);
                        object objectFixed = SafeJsonConvert.DeserializeObject<object>(jsonFixed);
                        fixes.Add(kvp.Key, objectFixed);
                    }
                }
                foreach (KeyValuePair<string, object> kvpFixed in fixes)
                {
                    example.Parameters[kvpFixed.Key] = kvpFixed.Value;
                }
            }
        }

        private static T Clone<T>(T o)
        {
            string json = SafeJsonConvert.SerializeObject(o);
            T ret = SafeJsonConvert.DeserializeObject<T>(json);
            return ret;
        }

        public static void ApplyTemporaryWorkaroundsForServiceDefects(List<Example> examples, IDataFactoryManagementExtendedClient client)
        {
            foreach (Example example in examples)
            {
                if (example.Name == "GatewayExtended_Update" || example.Name == "GatewayExtended_Get")
                {
                    object body = example.Responses["200"].Body;
                    string bodyJson = SafeJsonConvert.SerializeObject(body);
                    JObject bodyJObject = JObject.Parse(bodyJson);
                    JObject properties = bodyJObject["properties"] as JObject;
                    properties.Remove("isCredentialSyncFailed");
                    string bodyJsonNew = bodyJObject.ToString(Formatting.None);
                    example.Responses["200"].Body = SafeJsonConvert.DeserializeObject<object>(bodyJsonNew);
                }
            }
        }

        public static void WriteExamples(List<Example> examples, string folder, ExampleSecrets secrets, string folderWorkarounds = null)
        {
            foreach (Example example in examples)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings() { Formatting = Formatting.Indented };
                string json = SafeJsonConvert.SerializeObject(example, settings);
                if (secrets != null)
                {
                    json = secrets.ReplaceSecretsWithExampleStrings(json);
                }
                WriteTextFile(json, folder, example.Name + ".json");
            }
        }
    }
}
