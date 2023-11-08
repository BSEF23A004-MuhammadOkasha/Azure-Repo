// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlServerDevOpsAuditingSetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SqlServerDevOpsAuditingSettingResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSqlServerDevOpsAuditingSettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerResource" /> using the GetSqlServerDevOpsAuditingSetting method.
    /// </summary>
    public partial class SqlServerDevOpsAuditingSettingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlServerDevOpsAuditingSettingResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="devOpsAuditingSettingsName"> The devOpsAuditingSettingsName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string devOpsAuditingSettingsName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsClientDiagnostics;
        private readonly ServerDevOpsAuditSettingsRestOperations _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsRestClient;
        private readonly SqlServerDevOpsAuditingSettingData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlServerDevOpsAuditingSettingResource"/> class for mocking. </summary>
        protected SqlServerDevOpsAuditingSettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlServerDevOpsAuditingSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlServerDevOpsAuditingSettingResource(ArmClient client, SqlServerDevOpsAuditingSettingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerDevOpsAuditingSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlServerDevOpsAuditingSettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsApiVersion);
            _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsRestClient = new ServerDevOpsAuditSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/devOpsAuditingSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlServerDevOpsAuditingSettingData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a server's DevOps audit settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDevOpsAuditSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerDevOpsAuditingSettingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsClientDiagnostics.CreateScope("SqlServerDevOpsAuditingSettingResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerDevOpsAuditingSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server's DevOps audit settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDevOpsAuditSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerDevOpsAuditingSettingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsClientDiagnostics.CreateScope("SqlServerDevOpsAuditingSettingResource.Get");
            scope.Start();
            try
            {
                var response = _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerDevOpsAuditingSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a server's DevOps audit settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDevOpsAuditSettings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties of DevOps audit settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerDevOpsAuditingSettingResource>> UpdateAsync(WaitUntil waitUntil, SqlServerDevOpsAuditingSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsClientDiagnostics.CreateScope("SqlServerDevOpsAuditingSettingResource.Update");
            scope.Start();
            try
            {
                var response = await _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerDevOpsAuditingSettingResource>(new SqlServerDevOpsAuditingSettingOperationSource(Client), _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsClientDiagnostics, Pipeline, _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a server's DevOps audit settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDevOpsAuditSettings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties of DevOps audit settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerDevOpsAuditingSettingResource> Update(WaitUntil waitUntil, SqlServerDevOpsAuditingSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsClientDiagnostics.CreateScope("SqlServerDevOpsAuditingSettingResource.Update");
            scope.Start();
            try
            {
                var response = _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerDevOpsAuditingSettingResource>(new SqlServerDevOpsAuditingSettingOperationSource(Client), _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsClientDiagnostics, Pipeline, _sqlServerDevOpsAuditingSettingServerDevOpsAuditSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
