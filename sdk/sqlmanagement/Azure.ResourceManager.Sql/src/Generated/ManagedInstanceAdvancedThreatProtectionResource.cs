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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ManagedInstanceAdvancedThreatProtection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ManagedInstanceAdvancedThreatProtectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetManagedInstanceAdvancedThreatProtectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedInstanceResource" /> using the GetManagedInstanceAdvancedThreatProtection method.
    /// </summary>
    public partial class ManagedInstanceAdvancedThreatProtectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedInstanceAdvancedThreatProtectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, AdvancedThreatProtectionName advancedThreatProtectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics;
        private readonly ManagedInstanceAdvancedThreatProtectionSettingsRestOperations _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient;
        private readonly ManagedInstanceAdvancedThreatProtectionData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceAdvancedThreatProtectionResource"/> class for mocking. </summary>
        protected ManagedInstanceAdvancedThreatProtectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedInstanceAdvancedThreatProtectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedInstanceAdvancedThreatProtectionResource(ArmClient client, ManagedInstanceAdvancedThreatProtectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceAdvancedThreatProtectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceAdvancedThreatProtectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsApiVersion);
            _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient = new ManagedInstanceAdvancedThreatProtectionSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/advancedThreatProtectionSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedInstanceAdvancedThreatProtectionData Data
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
        /// Get a managed instance's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceAdvancedThreatProtectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedInstanceAdvancedThreatProtectionResource.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a managed instance's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceAdvancedThreatProtectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedInstanceAdvancedThreatProtectionResource.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates Advanced Threat Protection settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The managed instance Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedInstanceAdvancedThreatProtectionResource>> UpdateAsync(WaitUntil waitUntil, ManagedInstanceAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedInstanceAdvancedThreatProtectionResource.Update");
            scope.Start();
            try
            {
                var response = await _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstanceAdvancedThreatProtectionResource>(new ManagedInstanceAdvancedThreatProtectionOperationSource(Client), _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Creates or updates Advanced Threat Protection settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The managed instance Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedInstanceAdvancedThreatProtectionResource> Update(WaitUntil waitUntil, ManagedInstanceAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedInstanceAdvancedThreatProtectionResource.Update");
            scope.Start();
            try
            {
                var response = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstanceAdvancedThreatProtectionResource>(new ManagedInstanceAdvancedThreatProtectionOperationSource(Client), _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, Core.OperationFinalStateVia.Location);
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
