// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.DigitalTwins.Core
{
    internal partial class DigitalTwinModelsRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of DigitalTwinModelsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public DigitalTwinModelsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2021-06-30-preview")
        {
            this.endpoint = endpoint ?? new Uri("https://digitaltwins-hostname");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateAddRequest(IEnumerable<object> models, CreateModelsOptions digitalTwinModelsAddOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/models", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (models != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteStartArray();
                foreach (var item in models)
                {
                    content.JsonWriter.WriteObjectValue(item);
                }
                content.JsonWriter.WriteEndArray();
                request.Content = content;
            }
            return message;
        }

        /// <summary>
        /// Uploads one or more models. When any error occurs, no models are uploaded.
        /// Status codes:
        /// * 201 Created
        /// * 400 Bad Request
        ///   * DTDLParserError - The models provided are not valid DTDL.
        ///   * InvalidArgument - The model id is invalid.
        ///   * LimitExceeded - The maximum number of model ids allowed in &apos;dependenciesFor&apos; has been reached.
        ///   * ModelVersionNotSupported - The version of DTDL used is not supported.
        /// * 409 Conflict
        ///   * ModelAlreadyExists - The model provided already exists.
        /// </summary>
        /// <param name="models"> An array of models to add. </param>
        /// <param name="digitalTwinModelsAddOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<IReadOnlyList<DigitalTwinsModelData>>> AddAsync(IEnumerable<object> models = null, CreateModelsOptions digitalTwinModelsAddOptions = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAddRequest(models, digitalTwinModelsAddOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        IReadOnlyList<DigitalTwinsModelData> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<DigitalTwinsModelData> array = new List<DigitalTwinsModelData>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(DigitalTwinsModelData.DeserializeDigitalTwinsModelData(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Uploads one or more models. When any error occurs, no models are uploaded.
        /// Status codes:
        /// * 201 Created
        /// * 400 Bad Request
        ///   * DTDLParserError - The models provided are not valid DTDL.
        ///   * InvalidArgument - The model id is invalid.
        ///   * LimitExceeded - The maximum number of model ids allowed in &apos;dependenciesFor&apos; has been reached.
        ///   * ModelVersionNotSupported - The version of DTDL used is not supported.
        /// * 409 Conflict
        ///   * ModelAlreadyExists - The model provided already exists.
        /// </summary>
        /// <param name="models"> An array of models to add. </param>
        /// <param name="digitalTwinModelsAddOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IReadOnlyList<DigitalTwinsModelData>> Add(IEnumerable<object> models = null, CreateModelsOptions digitalTwinModelsAddOptions = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAddRequest(models, digitalTwinModelsAddOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        IReadOnlyList<DigitalTwinsModelData> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<DigitalTwinsModelData> array = new List<DigitalTwinsModelData>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(DigitalTwinsModelData.DeserializeDigitalTwinsModelData(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(IEnumerable<string> dependenciesFor, bool? includeModelDefinition, GetModelsOptions digitalTwinModelsListOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/models", false);
            if (dependenciesFor != null)
            {
                foreach (var param in dependenciesFor)
                {
                    uri.AppendQuery("dependenciesFor", param, true);
                }
            }
            if (includeModelDefinition != null)
            {
                uri.AppendQuery("includeModelDefinition", includeModelDefinition.Value, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (digitalTwinModelsListOptions?.MaxItemsPerPage != null)
            {
                request.Headers.Add("max-items-per-page", digitalTwinModelsListOptions.MaxItemsPerPage.Value);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary>
        /// Retrieves model metadata and, optionally, model definitions.
        /// Status codes:
        /// * 200 OK
        /// * 400 Bad Request
        ///   * InvalidArgument - The model id is invalid.
        ///   * LimitExceeded - The maximum number of model ids allowed in &apos;dependenciesFor&apos; has been reached.
        /// * 404 Not Found
        ///   * ModelNotFound - The model was not found.
        /// </summary>
        /// <param name="dependenciesFor"> The set of the models which will have their dependencies retrieved. If omitted, all models are retrieved. </param>
        /// <param name="includeModelDefinition"> When true the model definition will be returned as part of the result. </param>
        /// <param name="digitalTwinModelsListOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<PagedDigitalTwinsModelDataCollection>> ListAsync(IEnumerable<string> dependenciesFor = null, bool? includeModelDefinition = null, GetModelsOptions digitalTwinModelsListOptions = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(dependenciesFor, includeModelDefinition, digitalTwinModelsListOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PagedDigitalTwinsModelDataCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PagedDigitalTwinsModelDataCollection.DeserializePagedDigitalTwinsModelDataCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Retrieves model metadata and, optionally, model definitions.
        /// Status codes:
        /// * 200 OK
        /// * 400 Bad Request
        ///   * InvalidArgument - The model id is invalid.
        ///   * LimitExceeded - The maximum number of model ids allowed in &apos;dependenciesFor&apos; has been reached.
        /// * 404 Not Found
        ///   * ModelNotFound - The model was not found.
        /// </summary>
        /// <param name="dependenciesFor"> The set of the models which will have their dependencies retrieved. If omitted, all models are retrieved. </param>
        /// <param name="includeModelDefinition"> When true the model definition will be returned as part of the result. </param>
        /// <param name="digitalTwinModelsListOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PagedDigitalTwinsModelDataCollection> List(IEnumerable<string> dependenciesFor = null, bool? includeModelDefinition = null, GetModelsOptions digitalTwinModelsListOptions = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(dependenciesFor, includeModelDefinition, digitalTwinModelsListOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PagedDigitalTwinsModelDataCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PagedDigitalTwinsModelDataCollection.DeserializePagedDigitalTwinsModelDataCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetByIdRequest(string id, bool? includeModelDefinition, GetModelOptions digitalTwinModelsGetByIdOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/models/", false);
            uri.AppendPath(id, true);
            if (includeModelDefinition != null)
            {
                uri.AppendQuery("includeModelDefinition", includeModelDefinition.Value, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary>
        /// Retrieves model metadata and optionally the model definition.
        /// Status codes:
        /// * 200 OK
        /// * 400 Bad Request
        ///   * InvalidArgument - The model id is invalid.
        ///   * MissingArgument - The model id was not provided.
        /// * 404 Not Found
        ///   * ModelNotFound - The model was not found.
        /// </summary>
        /// <param name="id"> The id for the model. The id is globally unique and case sensitive. </param>
        /// <param name="includeModelDefinition"> When true the model definition will be returned as part of the result. </param>
        /// <param name="digitalTwinModelsGetByIdOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response<DigitalTwinsModelData>> GetByIdAsync(string id, bool? includeModelDefinition = null, GetModelOptions digitalTwinModelsGetByIdOptions = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateGetByIdRequest(id, includeModelDefinition, digitalTwinModelsGetByIdOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DigitalTwinsModelData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DigitalTwinsModelData.DeserializeDigitalTwinsModelData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Retrieves model metadata and optionally the model definition.
        /// Status codes:
        /// * 200 OK
        /// * 400 Bad Request
        ///   * InvalidArgument - The model id is invalid.
        ///   * MissingArgument - The model id was not provided.
        /// * 404 Not Found
        ///   * ModelNotFound - The model was not found.
        /// </summary>
        /// <param name="id"> The id for the model. The id is globally unique and case sensitive. </param>
        /// <param name="includeModelDefinition"> When true the model definition will be returned as part of the result. </param>
        /// <param name="digitalTwinModelsGetByIdOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response<DigitalTwinsModelData> GetById(string id, bool? includeModelDefinition = null, GetModelOptions digitalTwinModelsGetByIdOptions = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateGetByIdRequest(id, includeModelDefinition, digitalTwinModelsGetByIdOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DigitalTwinsModelData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DigitalTwinsModelData.DeserializeDigitalTwinsModelData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string id, IEnumerable<object> updateModel, DecommissionModelOptions digitalTwinModelsUpdateOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/models/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json-patch+json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartArray();
            foreach (var item in updateModel)
            {
                content.JsonWriter.WriteObjectValue(item);
            }
            content.JsonWriter.WriteEndArray();
            request.Content = content;
            return message;
        }

        /// <summary>
        /// Updates the metadata for a model.
        /// Status codes:
        /// * 204 No Content
        /// * 400 Bad Request
        ///   * InvalidArgument - The model id is invalid.
        ///   * JsonPatchInvalid - The JSON Patch provided is invalid.
        ///   * MissingArgument - The model id was not provided.
        /// * 404 Not Found
        ///   * ModelNotFound - The model was not found.
        /// * 409 Conflict
        ///   * ModelReferencesNotDecommissioned - The model refers to models that are not decommissioned.
        /// </summary>
        /// <param name="id"> The id for the model. The id is globally unique and case sensitive. </param>
        /// <param name="updateModel"> An update specification described by JSON Patch. Only the decommissioned property can be replaced. </param>
        /// <param name="digitalTwinModelsUpdateOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="updateModel"/> is null. </exception>
        public async Task<Response> UpdateAsync(string id, IEnumerable<object> updateModel, DecommissionModelOptions digitalTwinModelsUpdateOptions = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (updateModel == null)
            {
                throw new ArgumentNullException(nameof(updateModel));
            }

            using var message = CreateUpdateRequest(id, updateModel, digitalTwinModelsUpdateOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Updates the metadata for a model.
        /// Status codes:
        /// * 204 No Content
        /// * 400 Bad Request
        ///   * InvalidArgument - The model id is invalid.
        ///   * JsonPatchInvalid - The JSON Patch provided is invalid.
        ///   * MissingArgument - The model id was not provided.
        /// * 404 Not Found
        ///   * ModelNotFound - The model was not found.
        /// * 409 Conflict
        ///   * ModelReferencesNotDecommissioned - The model refers to models that are not decommissioned.
        /// </summary>
        /// <param name="id"> The id for the model. The id is globally unique and case sensitive. </param>
        /// <param name="updateModel"> An update specification described by JSON Patch. Only the decommissioned property can be replaced. </param>
        /// <param name="digitalTwinModelsUpdateOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="updateModel"/> is null. </exception>
        public Response Update(string id, IEnumerable<object> updateModel, DecommissionModelOptions digitalTwinModelsUpdateOptions = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (updateModel == null)
            {
                throw new ArgumentNullException(nameof(updateModel));
            }

            using var message = CreateUpdateRequest(id, updateModel, digitalTwinModelsUpdateOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string id, DeleteModelOptions digitalTwinModelsDeleteOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/models/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary>
        /// Deletes a model. A model can only be deleted if no other models reference it.
        /// Status codes:
        /// * 204 No Content
        /// * 400 Bad Request
        ///   * InvalidArgument - The model id is invalid.
        ///   * MissingArgument - The model id was not provided.
        /// * 404 Not Found
        ///   * ModelNotFound - The model was not found.
        /// * 409 Conflict
        ///   * ModelReferencesNotDeleted - The model refers to models that are not deleted.
        /// </summary>
        /// <param name="id"> The id for the model. The id is globally unique and case sensitive. </param>
        /// <param name="digitalTwinModelsDeleteOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response> DeleteAsync(string id, DeleteModelOptions digitalTwinModelsDeleteOptions = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateDeleteRequest(id, digitalTwinModelsDeleteOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Deletes a model. A model can only be deleted if no other models reference it.
        /// Status codes:
        /// * 204 No Content
        /// * 400 Bad Request
        ///   * InvalidArgument - The model id is invalid.
        ///   * MissingArgument - The model id was not provided.
        /// * 404 Not Found
        ///   * ModelNotFound - The model was not found.
        /// * 409 Conflict
        ///   * ModelReferencesNotDeleted - The model refers to models that are not deleted.
        /// </summary>
        /// <param name="id"> The id for the model. The id is globally unique and case sensitive. </param>
        /// <param name="digitalTwinModelsDeleteOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response Delete(string id, DeleteModelOptions digitalTwinModelsDeleteOptions = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateDeleteRequest(id, digitalTwinModelsDeleteOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, IEnumerable<string> dependenciesFor, bool? includeModelDefinition, GetModelsOptions digitalTwinModelsListOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            if (digitalTwinModelsListOptions?.MaxItemsPerPage != null)
            {
                request.Headers.Add("max-items-per-page", digitalTwinModelsListOptions.MaxItemsPerPage.Value);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary>
        /// Retrieves model metadata and, optionally, model definitions.
        /// Status codes:
        /// * 200 OK
        /// * 400 Bad Request
        ///   * InvalidArgument - The model id is invalid.
        ///   * LimitExceeded - The maximum number of model ids allowed in &apos;dependenciesFor&apos; has been reached.
        /// * 404 Not Found
        ///   * ModelNotFound - The model was not found.
        /// </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="dependenciesFor"> The set of the models which will have their dependencies retrieved. If omitted, all models are retrieved. </param>
        /// <param name="includeModelDefinition"> When true the model definition will be returned as part of the result. </param>
        /// <param name="digitalTwinModelsListOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<PagedDigitalTwinsModelDataCollection>> ListNextPageAsync(string nextLink, IEnumerable<string> dependenciesFor = null, bool? includeModelDefinition = null, GetModelsOptions digitalTwinModelsListOptions = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink, dependenciesFor, includeModelDefinition, digitalTwinModelsListOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PagedDigitalTwinsModelDataCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PagedDigitalTwinsModelDataCollection.DeserializePagedDigitalTwinsModelDataCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Retrieves model metadata and, optionally, model definitions.
        /// Status codes:
        /// * 200 OK
        /// * 400 Bad Request
        ///   * InvalidArgument - The model id is invalid.
        ///   * LimitExceeded - The maximum number of model ids allowed in &apos;dependenciesFor&apos; has been reached.
        /// * 404 Not Found
        ///   * ModelNotFound - The model was not found.
        /// </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="dependenciesFor"> The set of the models which will have their dependencies retrieved. If omitted, all models are retrieved. </param>
        /// <param name="includeModelDefinition"> When true the model definition will be returned as part of the result. </param>
        /// <param name="digitalTwinModelsListOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<PagedDigitalTwinsModelDataCollection> ListNextPage(string nextLink, IEnumerable<string> dependenciesFor = null, bool? includeModelDefinition = null, GetModelsOptions digitalTwinModelsListOptions = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink, dependenciesFor, includeModelDefinition, digitalTwinModelsListOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PagedDigitalTwinsModelDataCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PagedDigitalTwinsModelDataCollection.DeserializePagedDigitalTwinsModelDataCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
