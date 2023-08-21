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

namespace Azure.MixedReality.Authentication
{
    internal partial class MixedRealityStsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of MixedRealityStsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public MixedRealityStsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2019-02-28-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://sts.mixedreality.azure.com");
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateGetTokenRequest(Guid accountId, MixedRealityTokenRequestOptions tokenRequestOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/Accounts/", false);
            uri.AppendPath(accountId, true);
            uri.AppendPath("/token", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (tokenRequestOptions?.ClientRequestId != null)
            {
                request.Headers.Add("X-MRC-CV", tokenRequestOptions.ClientRequestId);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets an access token to be used with Mixed Reality services. </summary>
        /// <param name="accountId"> The Mixed Reality account identifier. </param>
        /// <param name="tokenRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<StsTokenResponseMessage, MixedRealityStsGetTokenHeaders>> GetTokenAsync(Guid accountId, MixedRealityTokenRequestOptions tokenRequestOptions = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetTokenRequest(accountId, tokenRequestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new MixedRealityStsGetTokenHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StsTokenResponseMessage value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = StsTokenResponseMessage.DeserializeStsTokenResponseMessage(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets an access token to be used with Mixed Reality services. </summary>
        /// <param name="accountId"> The Mixed Reality account identifier. </param>
        /// <param name="tokenRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<StsTokenResponseMessage, MixedRealityStsGetTokenHeaders> GetToken(Guid accountId, MixedRealityTokenRequestOptions tokenRequestOptions = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetTokenRequest(accountId, tokenRequestOptions);
            _pipeline.Send(message, cancellationToken);
            var headers = new MixedRealityStsGetTokenHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StsTokenResponseMessage value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = StsTokenResponseMessage.DeserializeStsTokenResponseMessage(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
