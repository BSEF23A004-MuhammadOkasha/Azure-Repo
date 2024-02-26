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
using Azure.ResourceManager.Kusto.Models;

namespace Azure.ResourceManager.Kusto
{
    internal partial class DatabaseRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DatabaseRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DatabaseRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-08-15";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateInviteFollowerRequest(string subscriptionId, string resourceGroupName, string clusterName, string databaseName, DatabaseInviteFollowerContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Kusto/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/inviteFollower", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Generates an invitation token that allows attaching a follower database to this database. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the Kusto cluster. </param>
        /// <param name="databaseName"> The name of the database in the Kusto cluster. </param>
        /// <param name="content"> The follower invitation request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="databaseName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DatabaseInviteFollowerResult>> InviteFollowerAsync(string subscriptionId, string resourceGroupName, string clusterName, string databaseName, DatabaseInviteFollowerContent content, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (clusterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(clusterName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (databaseName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(databaseName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateInviteFollowerRequest(subscriptionId, resourceGroupName, clusterName, databaseName, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseInviteFollowerResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseInviteFollowerResult.DeserializeDatabaseInviteFollowerResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Generates an invitation token that allows attaching a follower database to this database. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the Kusto cluster. </param>
        /// <param name="databaseName"> The name of the database in the Kusto cluster. </param>
        /// <param name="content"> The follower invitation request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="databaseName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DatabaseInviteFollowerResult> InviteFollower(string subscriptionId, string resourceGroupName, string clusterName, string databaseName, DatabaseInviteFollowerContent content, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (clusterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(clusterName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (databaseName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(databaseName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateInviteFollowerRequest(subscriptionId, resourceGroupName, clusterName, databaseName, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseInviteFollowerResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseInviteFollowerResult.DeserializeDatabaseInviteFollowerResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
