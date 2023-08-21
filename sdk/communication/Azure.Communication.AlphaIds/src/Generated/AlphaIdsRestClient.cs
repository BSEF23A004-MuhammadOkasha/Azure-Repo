// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Communication.AlphaIds.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.AlphaIds
{
    internal partial class AlphaIdsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of AlphaIdsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://resourcename.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public AlphaIdsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2022-09-26-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateGetConfigurationRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/alphaIds/configuration", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get the Alpha IDs configuration that's applied for the current resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AlphaIdConfiguration>> GetConfigurationAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetConfigurationRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AlphaIdConfiguration value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AlphaIdConfiguration.DeserializeAlphaIdConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the Alpha IDs configuration that's applied for the current resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AlphaIdConfiguration> GetConfiguration(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetConfigurationRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AlphaIdConfiguration value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AlphaIdConfiguration.DeserializeAlphaIdConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpsertConfigurationRequest(bool enabled)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/alphaIds/configuration", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            var model = new AlphaIdConfiguration(enabled);
            var content = new Core.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates Alpha ID Configuration for the current resource. </summary>
        /// <param name="enabled"> Indicates whether the use of Alpha IDs is supported for a specific resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AlphaIdConfiguration>> UpsertConfigurationAsync(bool enabled, CancellationToken cancellationToken = default)
        {
            using var message = CreateUpsertConfigurationRequest(enabled);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AlphaIdConfiguration value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AlphaIdConfiguration.DeserializeAlphaIdConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates Alpha ID Configuration for the current resource. </summary>
        /// <param name="enabled"> Indicates whether the use of Alpha IDs is supported for a specific resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AlphaIdConfiguration> UpsertConfiguration(bool enabled, CancellationToken cancellationToken = default)
        {
            using var message = CreateUpsertConfigurationRequest(enabled);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AlphaIdConfiguration value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AlphaIdConfiguration.DeserializeAlphaIdConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
