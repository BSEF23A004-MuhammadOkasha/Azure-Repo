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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    internal partial class DatastoresRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of DatastoresRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public DatastoresRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-10-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateListRequest(string resourceGroupName, string workspaceName, string skip, int? count, bool? isDefault, IEnumerable<string> names, string searchText, string orderBy, bool? orderByAsc)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/datastores", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (skip != null)
            {
                uri.AppendQuery("$skip", skip, true);
            }
            if (count != null)
            {
                uri.AppendQuery("count", count.Value, true);
            }
            if (isDefault != null)
            {
                uri.AppendQuery("isDefault", isDefault.Value, true);
            }
            if (names != null)
            {
                uri.AppendQueryDelimited("names", names, ",", true);
            }
            if (searchText != null)
            {
                uri.AppendQuery("searchText", searchText, true);
            }
            if (orderBy != null)
            {
                uri.AppendQuery("orderBy", orderBy, true);
            }
            if (orderByAsc != null)
            {
                uri.AppendQuery("orderByAsc", orderByAsc.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> List datastores. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="count"> Maximum number of results to return. </param>
        /// <param name="isDefault"> Filter down to the workspace default datastore. </param>
        /// <param name="names"> Names of datastores to return. </param>
        /// <param name="searchText"> Text to search for in the datastore names. </param>
        /// <param name="orderBy"> Order by property (createdtime | modifiedtime | name). </param>
        /// <param name="orderByAsc"> Order by property in ascending order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        public async Task<Response<DatastoreResourceArmPaginatedResult>> ListAsync(string resourceGroupName, string workspaceName, string skip = null, int? count = null, bool? isDefault = null, IEnumerable<string> names = null, string searchText = null, string orderBy = null, bool? orderByAsc = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateListRequest(resourceGroupName, workspaceName, skip, count, isDefault, names, searchText, orderBy, orderByAsc);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatastoreResourceArmPaginatedResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatastoreResourceArmPaginatedResult.DeserializeDatastoreResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List datastores. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="count"> Maximum number of results to return. </param>
        /// <param name="isDefault"> Filter down to the workspace default datastore. </param>
        /// <param name="names"> Names of datastores to return. </param>
        /// <param name="searchText"> Text to search for in the datastore names. </param>
        /// <param name="orderBy"> Order by property (createdtime | modifiedtime | name). </param>
        /// <param name="orderByAsc"> Order by property in ascending order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        public Response<DatastoreResourceArmPaginatedResult> List(string resourceGroupName, string workspaceName, string skip = null, int? count = null, bool? isDefault = null, IEnumerable<string> names = null, string searchText = null, string orderBy = null, bool? orderByAsc = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateListRequest(resourceGroupName, workspaceName, skip, count, isDefault, names, searchText, orderBy, orderByAsc);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatastoreResourceArmPaginatedResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatastoreResourceArmPaginatedResult.DeserializeDatastoreResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string workspaceName, string name)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/datastores/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Delete datastore. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, or <paramref name="name"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string workspaceName, string name, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateDeleteRequest(resourceGroupName, workspaceName, name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete datastore. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, or <paramref name="name"/> is null. </exception>
        public Response Delete(string resourceGroupName, string workspaceName, string name, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateDeleteRequest(resourceGroupName, workspaceName, name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string workspaceName, string name)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/datastores/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get datastore. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, or <paramref name="name"/> is null. </exception>
        public async Task<Response<DatastoreResourceData>> GetAsync(string resourceGroupName, string workspaceName, string name, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGetRequest(resourceGroupName, workspaceName, name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatastoreResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatastoreResourceData.DeserializeDatastoreResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatastoreResourceData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get datastore. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, or <paramref name="name"/> is null. </exception>
        public Response<DatastoreResourceData> Get(string resourceGroupName, string workspaceName, string name, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGetRequest(resourceGroupName, workspaceName, name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatastoreResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatastoreResourceData.DeserializeDatastoreResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatastoreResourceData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string workspaceName, string name, Datastore properties, bool? skipValidation)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/datastores/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", apiVersion, true);
            if (skipValidation != null)
            {
                uri.AppendQuery("skipValidation", skipValidation.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new DatastoreResourceData(properties);
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Create or update datastore. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="name"> Datastore name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="skipValidation"> Flag to skip validation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="name"/>, or <paramref name="properties"/> is null. </exception>
        public async Task<Response<DatastoreResourceData>> CreateOrUpdateAsync(string resourceGroupName, string workspaceName, string name, Datastore properties, bool? skipValidation = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, workspaceName, name, properties, skipValidation);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DatastoreResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatastoreResourceData.DeserializeDatastoreResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create or update datastore. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="name"> Datastore name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="skipValidation"> Flag to skip validation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="name"/>, or <paramref name="properties"/> is null. </exception>
        public Response<DatastoreResourceData> CreateOrUpdate(string resourceGroupName, string workspaceName, string name, Datastore properties, bool? skipValidation = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, workspaceName, name, properties, skipValidation);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DatastoreResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatastoreResourceData.DeserializeDatastoreResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListSecretsRequest(string resourceGroupName, string workspaceName, string name)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/datastores/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/listSecrets", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get datastore secrets. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, or <paramref name="name"/> is null. </exception>
        public async Task<Response<DatastoreSecrets>> ListSecretsAsync(string resourceGroupName, string workspaceName, string name, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateListSecretsRequest(resourceGroupName, workspaceName, name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatastoreSecrets value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatastoreSecrets.DeserializeDatastoreSecrets(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get datastore secrets. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, or <paramref name="name"/> is null. </exception>
        public Response<DatastoreSecrets> ListSecrets(string resourceGroupName, string workspaceName, string name, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateListSecretsRequest(resourceGroupName, workspaceName, name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatastoreSecrets value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatastoreSecrets.DeserializeDatastoreSecrets(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceGroupName, string workspaceName, string skip, int? count, bool? isDefault, IEnumerable<string> names, string searchText, string orderBy, bool? orderByAsc)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> List datastores. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="count"> Maximum number of results to return. </param>
        /// <param name="isDefault"> Filter down to the workspace default datastore. </param>
        /// <param name="names"> Names of datastores to return. </param>
        /// <param name="searchText"> Text to search for in the datastore names. </param>
        /// <param name="orderBy"> Order by property (createdtime | modifiedtime | name). </param>
        /// <param name="orderByAsc"> Order by property in ascending order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public async Task<Response<DatastoreResourceArmPaginatedResult>> ListNextPageAsync(string nextLink, string resourceGroupName, string workspaceName, string skip = null, int? count = null, bool? isDefault = null, IEnumerable<string> names = null, string searchText = null, string orderBy = null, bool? orderByAsc = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, workspaceName, skip, count, isDefault, names, searchText, orderBy, orderByAsc);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatastoreResourceArmPaginatedResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatastoreResourceArmPaginatedResult.DeserializeDatastoreResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List datastores. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="count"> Maximum number of results to return. </param>
        /// <param name="isDefault"> Filter down to the workspace default datastore. </param>
        /// <param name="names"> Names of datastores to return. </param>
        /// <param name="searchText"> Text to search for in the datastore names. </param>
        /// <param name="orderBy"> Order by property (createdtime | modifiedtime | name). </param>
        /// <param name="orderByAsc"> Order by property in ascending order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public Response<DatastoreResourceArmPaginatedResult> ListNextPage(string nextLink, string resourceGroupName, string workspaceName, string skip = null, int? count = null, bool? isDefault = null, IEnumerable<string> names = null, string searchText = null, string orderBy = null, bool? orderByAsc = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, workspaceName, skip, count, isDefault, names, searchText, orderBy, orderByAsc);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatastoreResourceArmPaginatedResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatastoreResourceArmPaginatedResult.DeserializeDatastoreResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
