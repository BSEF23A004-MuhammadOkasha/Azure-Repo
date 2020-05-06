// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Template.Models;

namespace Azure.Template
{
    internal partial class MiniSecretRestClient
    {
        private string vaultBaseUrl;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of MiniSecretRestClient. </summary>
        public MiniSecretRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string vaultBaseUrl, string apiVersion = "7.0")
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.vaultBaseUrl = vaultBaseUrl;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetSecretRequest(string secretName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/secrets/", false);
            uri.AppendPath(secretName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> The GET operation is applicable to any secret stored in Azure Key Vault. This operation requires the secrets/get permission. </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<SecretBundle>> GetSecretAsync(string secretName, CancellationToken cancellationToken = default)
        {
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("MiniSecretClient.GetSecret");
            scope.Start();
            try
            {
                using var message = CreateGetSecretRequest(secretName);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            SecretBundle value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = SecretBundle.DeserializeSecretBundle(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The GET operation is applicable to any secret stored in Azure Key Vault. This operation requires the secrets/get permission. </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SecretBundle> GetSecret(string secretName, CancellationToken cancellationToken = default)
        {
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("MiniSecretClient.GetSecret");
            scope.Start();
            try
            {
                using var message = CreateGetSecretRequest(secretName);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            SecretBundle value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = SecretBundle.DeserializeSecretBundle(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
