// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    internal partial class LinkedServiceRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of LinkedServiceRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public LinkedServiceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            this.endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetLinkedServicesByWorkspaceRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/linkedservices", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists linked services. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<LinkedServiceListResponse>> GetLinkedServicesByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetLinkedServicesByWorkspaceRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LinkedServiceListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LinkedServiceListResponse.DeserializeLinkedServiceListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists linked services. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<LinkedServiceListResponse> GetLinkedServicesByWorkspace(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetLinkedServicesByWorkspaceRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LinkedServiceListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LinkedServiceListResponse.DeserializeLinkedServiceListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateLinkedServiceRequest(string linkedServiceName, LinkedServiceResource linkedService, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/linkedservices/", false);
            uri.AppendPath(linkedServiceName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(linkedService);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="linkedService"> Linked service resource definition. </param>
        /// <param name="ifMatch"> ETag of the linkedService entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="linkedService"/> is null. </exception>
        public async Task<Response> CreateOrUpdateLinkedServiceAsync(string linkedServiceName, LinkedServiceResource linkedService, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (linkedService == null)
            {
                throw new ArgumentNullException(nameof(linkedService));
            }

            using var message = CreateCreateOrUpdateLinkedServiceRequest(linkedServiceName, linkedService, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="linkedService"> Linked service resource definition. </param>
        /// <param name="ifMatch"> ETag of the linkedService entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="linkedService"/> is null. </exception>
        public Response CreateOrUpdateLinkedService(string linkedServiceName, LinkedServiceResource linkedService, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (linkedService == null)
            {
                throw new ArgumentNullException(nameof(linkedService));
            }

            using var message = CreateCreateOrUpdateLinkedServiceRequest(linkedServiceName, linkedService, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetLinkedServiceRequest(string linkedServiceName, string ifNoneMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/linkedservices/", false);
            uri.AppendPath(linkedServiceName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="ifNoneMatch"> ETag of the linked service entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public async Task<Response<LinkedServiceResource>> GetLinkedServiceAsync(string linkedServiceName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            using var message = CreateGetLinkedServiceRequest(linkedServiceName, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LinkedServiceResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LinkedServiceResource.DeserializeLinkedServiceResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue((LinkedServiceResource)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="ifNoneMatch"> ETag of the linked service entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public Response<LinkedServiceResource> GetLinkedService(string linkedServiceName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            using var message = CreateGetLinkedServiceRequest(linkedServiceName, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LinkedServiceResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LinkedServiceResource.DeserializeLinkedServiceResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue((LinkedServiceResource)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteLinkedServiceRequest(string linkedServiceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/linkedservices/", false);
            uri.AppendPath(linkedServiceName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public async Task<Response> DeleteLinkedServiceAsync(string linkedServiceName, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            using var message = CreateDeleteLinkedServiceRequest(linkedServiceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public Response DeleteLinkedService(string linkedServiceName, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            using var message = CreateDeleteLinkedServiceRequest(linkedServiceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRenameLinkedServiceRequest(string linkedServiceName, ArtifactRenameRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/linkedservices/", false);
            uri.AppendPath(linkedServiceName, true);
            uri.AppendPath("/rename", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Renames a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="request"/> is null. </exception>
        public async Task<Response> RenameLinkedServiceAsync(string linkedServiceName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameLinkedServiceRequest(linkedServiceName, request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Renames a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="request"/> is null. </exception>
        public Response RenameLinkedService(string linkedServiceName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameLinkedServiceRequest(linkedServiceName, request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetLinkedServicesByWorkspaceNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists linked services. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<LinkedServiceListResponse>> GetLinkedServicesByWorkspaceNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetLinkedServicesByWorkspaceNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LinkedServiceListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LinkedServiceListResponse.DeserializeLinkedServiceListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists linked services. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<LinkedServiceListResponse> GetLinkedServicesByWorkspaceNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetLinkedServicesByWorkspaceNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LinkedServiceListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LinkedServiceListResponse.DeserializeLinkedServiceListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
