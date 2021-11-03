﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using Azure.Data.SchemaRegistry;
using Azure.Identity;
using NUnit.Framework;
using System.IO;
using System.Threading;
using Azure.Messaging.EventHubs;
using TestSchema;

namespace Microsoft.Azure.Data.SchemaRegistry.ApacheAvro.Tests.Samples
{
    public class Sample01_ReadmeSnippets : SamplesBase<SchemaRegistryClientTestEnvironment>
    {
#pragma warning disable IDE1006 // Naming Styles
        private SchemaRegistryClient schemaRegistryClient;
#pragma warning restore IDE1006 // Naming Styles

        [OneTimeSetUp]
        public void CreateSchemaRegistryClient()
        {
            string fullyQualifiedNamespace = TestEnvironment.SchemaRegistryEndpoint;

            #region Snippet:SchemaRegistryAvroCreateSchemaRegistryClient
            // Create a new SchemaRegistry client using the default credential from Azure.Identity using environment variables previously set,
            // including AZURE_CLIENT_ID, AZURE_CLIENT_SECRET, and AZURE_TENANT_ID.
            // For more information on Azure.Identity usage, see: https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/identity/Azure.Identity/README.md
            var schemaRegistryClient = new SchemaRegistryClient(fullyQualifiedNamespace: fullyQualifiedNamespace, credential: new DefaultAzureCredential());
            #endregion

            this.schemaRegistryClient = schemaRegistryClient;
        }

        [Test]
        public void EncodeDecodeEventData()
        {
            string groupName = TestEnvironment.SchemaRegistryGroup;

            #region Snippet:SchemaRegistryAvroEncodeEventData
            var employee = new Employee { Age = 42, Name = "John Doe" };
            var encoder = new SchemaRegistryAvroEncoder(schemaRegistryClient, groupName, new SchemaRegistryAvroObjectEncoderOptions { AutoRegisterSchemas = true });
            var eventData = new EventData();

            encoder.EncodeMessageData(eventData, employee, typeof(Employee));

            // the schema Id will be included as a parameter of the content type
            Console.WriteLine(eventData.ContentType);

            // the serialized Avro data will be stored in the EventBody
            Console.WriteLine(eventData.EventBody);

            // We can also get the Employee model back out from the serialized data
            employee = (Employee) encoder.DecodeMessageData(eventData, typeof(Employee));
            #endregion
        }
    }
}
