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
    internal partial class DatabaseSecurityAlertPoliciesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of DatabaseSecurityAlertPoliciesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public DatabaseSecurityAlertPoliciesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null)
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string serverName, string databaseName, SecurityAlertPolicyName securityAlertPolicyName)
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
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/securityAlertPolicies/", false);
            uri.AppendPath(securityAlertPolicyName.ToString(), true);
            uri.AppendQuery("api-version", "2020-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets a database&apos;s security alert policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the  server. </param>
        /// <param name="databaseName"> The name of the  database for which the security alert policy is defined. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public async Task<Response<DatabaseSecurityAlertPolicyData>> GetAsync(string resourceGroupName, string serverName, string databaseName, SecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var message = CreateGetRequest(resourceGroupName, serverName, databaseName, securityAlertPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseSecurityAlertPolicyData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseSecurityAlertPolicyData.DeserializeDatabaseSecurityAlertPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseSecurityAlertPolicyData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a database&apos;s security alert policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the  server. </param>
        /// <param name="databaseName"> The name of the  database for which the security alert policy is defined. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public Response<DatabaseSecurityAlertPolicyData> Get(string resourceGroupName, string serverName, string databaseName, SecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var message = CreateGetRequest(resourceGroupName, serverName, databaseName, securityAlertPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseSecurityAlertPolicyData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseSecurityAlertPolicyData.DeserializeDatabaseSecurityAlertPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseSecurityAlertPolicyData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string serverName, string databaseName, SecurityAlertPolicyName securityAlertPolicyName, DatabaseSecurityAlertPolicyData parameters)
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
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/securityAlertPolicies/", false);
            uri.AppendPath(securityAlertPolicyName.ToString(), true);
            uri.AppendQuery("api-version", "2020-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Creates or updates a database&apos;s security alert policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the  server. </param>
        /// <param name="databaseName"> The name of the  database for which the security alert policy is defined. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="parameters"> The database security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response<DatabaseSecurityAlertPolicyData>> CreateOrUpdateAsync(string resourceGroupName, string serverName, string databaseName, SecurityAlertPolicyName securityAlertPolicyName, DatabaseSecurityAlertPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, serverName, databaseName, securityAlertPolicyName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DatabaseSecurityAlertPolicyData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseSecurityAlertPolicyData.DeserializeDatabaseSecurityAlertPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a database&apos;s security alert policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the  server. </param>
        /// <param name="databaseName"> The name of the  database for which the security alert policy is defined. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="parameters"> The database security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response<DatabaseSecurityAlertPolicyData> CreateOrUpdate(string resourceGroupName, string serverName, string databaseName, SecurityAlertPolicyName securityAlertPolicyName, DatabaseSecurityAlertPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, serverName, databaseName, securityAlertPolicyName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DatabaseSecurityAlertPolicyData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseSecurityAlertPolicyData.DeserializeDatabaseSecurityAlertPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByDatabaseRequest(string resourceGroupName, string serverName, string databaseName)
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
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/securityAlertPolicies", false);
            uri.AppendQuery("api-version", "2020-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets a list of database&apos;s security alert policies. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the  server. </param>
        /// <param name="databaseName"> The name of the  database for which the security alert policy is defined. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public async Task<Response<DatabaseSecurityAlertListResult>> ListByDatabaseAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var message = CreateListByDatabaseRequest(resourceGroupName, serverName, databaseName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseSecurityAlertListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseSecurityAlertListResult.DeserializeDatabaseSecurityAlertListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of database&apos;s security alert policies. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the  server. </param>
        /// <param name="databaseName"> The name of the  database for which the security alert policy is defined. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public Response<DatabaseSecurityAlertListResult> ListByDatabase(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var message = CreateListByDatabaseRequest(resourceGroupName, serverName, databaseName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseSecurityAlertListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseSecurityAlertListResult.DeserializeDatabaseSecurityAlertListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByDatabaseNextPageRequest(string nextLink, string resourceGroupName, string serverName, string databaseName)
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

        /// <summary> Gets a list of database&apos;s security alert policies. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the  server. </param>
        /// <param name="databaseName"> The name of the  database for which the security alert policy is defined. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public async Task<Response<DatabaseSecurityAlertListResult>> ListByDatabaseNextPageAsync(string nextLink, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var message = CreateListByDatabaseNextPageRequest(nextLink, resourceGroupName, serverName, databaseName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseSecurityAlertListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseSecurityAlertListResult.DeserializeDatabaseSecurityAlertListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of database&apos;s security alert policies. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the  server. </param>
        /// <param name="databaseName"> The name of the  database for which the security alert policy is defined. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public Response<DatabaseSecurityAlertListResult> ListByDatabaseNextPage(string nextLink, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var message = CreateListByDatabaseNextPageRequest(nextLink, resourceGroupName, serverName, databaseName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseSecurityAlertListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseSecurityAlertListResult.DeserializeDatabaseSecurityAlertListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
