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
using Azure.ResourceManager.ContainerRegistry.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    internal partial class ExportPipelinesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ExportPipelinesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ExportPipelinesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-02-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string registryName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerRegistry/registries/", false);
            uri.AppendPath(registryName, true);
            uri.AppendPath("/exportPipelines", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all export pipelines for the specified container registry. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="registryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="registryName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExportPipelineListResult>> ListAsync(string subscriptionId, string resourceGroupName, string registryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, registryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExportPipelineListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExportPipelineListResult.DeserializeExportPipelineListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all export pipelines for the specified container registry. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="registryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="registryName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExportPipelineListResult> List(string subscriptionId, string resourceGroupName, string registryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, registryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExportPipelineListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExportPipelineListResult.DeserializeExportPipelineListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string registryName, string exportPipelineName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerRegistry/registries/", false);
            uri.AppendPath(registryName, true);
            uri.AppendPath("/exportPipelines/", false);
            uri.AppendPath(exportPipelineName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the properties of the export pipeline. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="exportPipelineName"> The name of the export pipeline. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="exportPipelineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="exportPipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExportPipelineData>> GetAsync(string subscriptionId, string resourceGroupName, string registryName, string exportPipelineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(exportPipelineName, nameof(exportPipelineName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, registryName, exportPipelineName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExportPipelineData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExportPipelineData.DeserializeExportPipelineData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ExportPipelineData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the properties of the export pipeline. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="exportPipelineName"> The name of the export pipeline. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="exportPipelineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="exportPipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExportPipelineData> Get(string subscriptionId, string resourceGroupName, string registryName, string exportPipelineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(exportPipelineName, nameof(exportPipelineName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, registryName, exportPipelineName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExportPipelineData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExportPipelineData.DeserializeExportPipelineData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ExportPipelineData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string registryName, string exportPipelineName, ExportPipelineData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerRegistry/registries/", false);
            uri.AppendPath(registryName, true);
            uri.AppendPath("/exportPipelines/", false);
            uri.AppendPath(exportPipelineName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates an export pipeline for a container registry with the specified parameters. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="exportPipelineName"> The name of the export pipeline. </param>
        /// <param name="data"> The parameters for creating an export pipeline. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="exportPipelineName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="exportPipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string registryName, string exportPipelineName, ExportPipelineData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(exportPipelineName, nameof(exportPipelineName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, registryName, exportPipelineName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates an export pipeline for a container registry with the specified parameters. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="exportPipelineName"> The name of the export pipeline. </param>
        /// <param name="data"> The parameters for creating an export pipeline. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="exportPipelineName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="exportPipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string registryName, string exportPipelineName, ExportPipelineData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(exportPipelineName, nameof(exportPipelineName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, registryName, exportPipelineName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string registryName, string exportPipelineName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerRegistry/registries/", false);
            uri.AppendPath(registryName, true);
            uri.AppendPath("/exportPipelines/", false);
            uri.AppendPath(exportPipelineName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes an export pipeline from a container registry. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="exportPipelineName"> The name of the export pipeline. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="exportPipelineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="exportPipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string registryName, string exportPipelineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(exportPipelineName, nameof(exportPipelineName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, registryName, exportPipelineName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes an export pipeline from a container registry. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="exportPipelineName"> The name of the export pipeline. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="exportPipelineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="exportPipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string registryName, string exportPipelineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(exportPipelineName, nameof(exportPipelineName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, registryName, exportPipelineName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string registryName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all export pipelines for the specified container registry. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="registryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="registryName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExportPipelineListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string registryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, registryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExportPipelineListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExportPipelineListResult.DeserializeExportPipelineListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all export pipelines for the specified container registry. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="registryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="registryName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExportPipelineListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string registryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, registryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExportPipelineListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExportPipelineListResult.DeserializeExportPipelineListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
