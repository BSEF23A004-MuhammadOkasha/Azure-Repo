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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    internal partial class ManagedDatabaseTablesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of ManagedDatabaseTablesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public ManagedDatabaseTablesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null)
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateListBySchemaRequest(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter)
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
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendPath("/tables", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", "2020-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> List managed database tables. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, or <paramref name="schemaName"/> is null. </exception>
        public async Task<Response<DatabaseTableListResult>> ListBySchemaAsync(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }

            using var message = CreateListBySchemaRequest(resourceGroupName, managedInstanceName, databaseName, schemaName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseTableListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseTableListResult.DeserializeDatabaseTableListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List managed database tables. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, or <paramref name="schemaName"/> is null. </exception>
        public Response<DatabaseTableListResult> ListBySchema(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }

            using var message = CreateListBySchemaRequest(resourceGroupName, managedInstanceName, databaseName, schemaName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseTableListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseTableListResult.DeserializeDatabaseTableListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName)
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
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendPath("/tables/", false);
            uri.AppendPath(tableName, true);
            uri.AppendQuery("api-version", "2020-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get managed database table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/>, or <paramref name="tableName"/> is null. </exception>
        public async Task<Response<DatabaseTableData>> GetAsync(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var message = CreateGetRequest(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseTableData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseTableData.DeserializeDatabaseTableData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseTableData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get managed database table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/>, or <paramref name="tableName"/> is null. </exception>
        public Response<DatabaseTableData> Get(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var message = CreateGetRequest(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseTableData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseTableData.DeserializeDatabaseTableData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseTableData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListBySchemaNextPageRequest(string nextLink, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter)
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

        /// <summary> List managed database tables. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, or <paramref name="schemaName"/> is null. </exception>
        public async Task<Response<DatabaseTableListResult>> ListBySchemaNextPageAsync(string nextLink, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }

            using var message = CreateListBySchemaNextPageRequest(nextLink, resourceGroupName, managedInstanceName, databaseName, schemaName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseTableListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseTableListResult.DeserializeDatabaseTableListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List managed database tables. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, or <paramref name="schemaName"/> is null. </exception>
        public Response<DatabaseTableListResult> ListBySchemaNextPage(string nextLink, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }

            using var message = CreateListBySchemaNextPageRequest(nextLink, resourceGroupName, managedInstanceName, databaseName, schemaName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseTableListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseTableListResult.DeserializeDatabaseTableListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
