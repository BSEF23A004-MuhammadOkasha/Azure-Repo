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
    /// A Class representing a SqlServerAutomaticTuning along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SqlServerAutomaticTuningResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSqlServerAutomaticTuningResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerResource"/> using the GetSqlServerAutomaticTuning method.
    /// </summary>
    public partial class SqlServerAutomaticTuningResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlServerAutomaticTuningResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/automaticTuning/current";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlServerAutomaticTuningServerAutomaticTuningClientDiagnostics;
        private readonly ServerAutomaticTuningRestOperations _sqlServerAutomaticTuningServerAutomaticTuningRestClient;
        private readonly SqlServerAutomaticTuningData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlServerAutomaticTuningResource"/> class for mocking. </summary>
        protected SqlServerAutomaticTuningResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerAutomaticTuningResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlServerAutomaticTuningResource(ArmClient client, SqlServerAutomaticTuningData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerAutomaticTuningResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlServerAutomaticTuningResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerAutomaticTuningServerAutomaticTuningClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerAutomaticTuningServerAutomaticTuningApiVersion);
            _sqlServerAutomaticTuningServerAutomaticTuningRestClient = new ServerAutomaticTuningRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerAutomaticTuningServerAutomaticTuningApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/automaticTuning";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlServerAutomaticTuningData Data
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
        /// Retrieves server automatic tuning options.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/automaticTuning/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAutomaticTuning_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerAutomaticTuningResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAutomaticTuningServerAutomaticTuningClientDiagnostics.CreateScope("SqlServerAutomaticTuningResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerAutomaticTuningServerAutomaticTuningRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAutomaticTuningResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves server automatic tuning options.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/automaticTuning/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAutomaticTuning_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerAutomaticTuningResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAutomaticTuningServerAutomaticTuningClientDiagnostics.CreateScope("SqlServerAutomaticTuningResource.Get");
            scope.Start();
            try
            {
                var response = _sqlServerAutomaticTuningServerAutomaticTuningRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAutomaticTuningResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update automatic tuning options on server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/automaticTuning/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAutomaticTuning_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The requested automatic tuning resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<SqlServerAutomaticTuningResource>> UpdateAsync(SqlServerAutomaticTuningData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerAutomaticTuningServerAutomaticTuningClientDiagnostics.CreateScope("SqlServerAutomaticTuningResource.Update");
            scope.Start();
            try
            {
                var response = await _sqlServerAutomaticTuningServerAutomaticTuningRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SqlServerAutomaticTuningResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update automatic tuning options on server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/automaticTuning/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAutomaticTuning_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The requested automatic tuning resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<SqlServerAutomaticTuningResource> Update(SqlServerAutomaticTuningData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerAutomaticTuningServerAutomaticTuningClientDiagnostics.CreateScope("SqlServerAutomaticTuningResource.Update");
            scope.Start();
            try
            {
                var response = _sqlServerAutomaticTuningServerAutomaticTuningRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                return Response.FromValue(new SqlServerAutomaticTuningResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
