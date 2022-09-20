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
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid
{
    internal partial class TopicTypesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of TopicTypesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public TopicTypesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-06-15";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.EventGrid/topicTypes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List all registered topic types. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<TopicTypesListResult>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TopicTypesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TopicTypesListResult.DeserializeTopicTypesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List all registered topic types. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<TopicTypesListResult> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TopicTypesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TopicTypesListResult.DeserializeTopicTypesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string topicTypeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.EventGrid/topicTypes/", false);
            uri.AppendPath(topicTypeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get information about a topic type. </summary>
        /// <param name="topicTypeName"> Name of the topic type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topicTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="topicTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TopicTypeData>> GetAsync(string topicTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicTypeName, nameof(topicTypeName));

            using var message = CreateGetRequest(topicTypeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TopicTypeData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TopicTypeData.DeserializeTopicTypeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TopicTypeData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get information about a topic type. </summary>
        /// <param name="topicTypeName"> Name of the topic type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topicTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="topicTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TopicTypeData> Get(string topicTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicTypeName, nameof(topicTypeName));

            using var message = CreateGetRequest(topicTypeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TopicTypeData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TopicTypeData.DeserializeTopicTypeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TopicTypeData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListEventTypesRequest(string topicTypeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.EventGrid/topicTypes/", false);
            uri.AppendPath(topicTypeName, true);
            uri.AppendPath("/eventTypes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List event types for a topic type. </summary>
        /// <param name="topicTypeName"> Name of the topic type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topicTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="topicTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EventTypesListResult>> ListEventTypesAsync(string topicTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicTypeName, nameof(topicTypeName));

            using var message = CreateListEventTypesRequest(topicTypeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventTypesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EventTypesListResult.DeserializeEventTypesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List event types for a topic type. </summary>
        /// <param name="topicTypeName"> Name of the topic type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topicTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="topicTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EventTypesListResult> ListEventTypes(string topicTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicTypeName, nameof(topicTypeName));

            using var message = CreateListEventTypesRequest(topicTypeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventTypesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EventTypesListResult.DeserializeEventTypesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
