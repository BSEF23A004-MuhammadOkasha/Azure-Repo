// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DataMigration.Models;

namespace Azure.ResourceManager.DataMigration
{
    internal partial class DatabaseMigrationsSqlVmRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DatabaseMigrationsSqlVmRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DatabaseMigrationsSqlVmRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-03-30-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDBName, Guid? migrationOperationId, string expand)
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
            uri.AppendPath("/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/", false);
            uri.AppendPath(sqlVirtualMachineName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            if (migrationOperationId != null)
            {
                uri.AppendQuery("migrationOperationId", migrationOperationId.Value, true);
            }
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve the specified database migration for a given SQL VM. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DatabaseMigrationSqlVmData>> GetAsync(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName, migrationOperationId, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseMigrationSqlVmData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseMigrationSqlVmData.DeserializeDatabaseMigrationSqlVmData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseMigrationSqlVmData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve the specified database migration for a given SQL VM. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DatabaseMigrationSqlVmData> Get(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName, migrationOperationId, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseMigrationSqlVmData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseMigrationSqlVmData.DeserializeDatabaseMigrationSqlVmData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseMigrationSqlVmData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDBName, DatabaseMigrationSqlVmData data)
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
            uri.AppendPath("/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/", false);
            uri.AppendPath(sqlVirtualMachineName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DatabaseMigrationSqlVmData>(data, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create a new database migration to a given SQL VM. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="data"> Details of SqlMigrationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/>, <paramref name="targetDBName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDBName, DatabaseMigrationSqlVmData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName, data);
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

        /// <summary> Create a new database migration to a given SQL VM. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="data"> Details of SqlMigrationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/>, <paramref name="targetDBName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDBName, DatabaseMigrationSqlVmData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName, data);
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

        internal HttpMessage CreateCancelRequest(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDBName, MigrationOperationInput input)
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
            uri.AppendPath("/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/", false);
            uri.AppendPath(sqlVirtualMachineName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            uri.AppendPath("/cancel", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<MigrationOperationInput>(input, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Stop in-progress database migration to SQL VM. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="input"> The <see cref="MigrationOperationInput"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/>, <paramref name="targetDBName"/> or <paramref name="input"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CancelAsync(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDBName, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(input, nameof(input));

            using var message = CreateCancelRequest(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName, input);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Stop in-progress database migration to SQL VM. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="input"> The <see cref="MigrationOperationInput"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/>, <paramref name="targetDBName"/> or <paramref name="input"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Cancel(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDBName, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(input, nameof(input));

            using var message = CreateCancelRequest(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName, input);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCutoverRequest(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDBName, MigrationOperationInput input)
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
            uri.AppendPath("/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/", false);
            uri.AppendPath(sqlVirtualMachineName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            uri.AppendPath("/cutover", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<MigrationOperationInput>(input, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Initiate cutover for in-progress online database migration to SQL VM. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="input"> The <see cref="MigrationOperationInput"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/>, <paramref name="targetDBName"/> or <paramref name="input"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CutoverAsync(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDBName, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(input, nameof(input));

            using var message = CreateCutoverRequest(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName, input);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Initiate cutover for in-progress online database migration to SQL VM. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="input"> The <see cref="MigrationOperationInput"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/>, <paramref name="targetDBName"/> or <paramref name="input"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Cutover(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDBName, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(input, nameof(input));

            using var message = CreateCutoverRequest(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName, input);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
