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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Maintenance
{
    /// <summary>
    /// A class representing a collection of <see cref="MaintenanceApplyUpdateResource" /> and their operations.
    /// Each <see cref="MaintenanceApplyUpdateResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="MaintenanceApplyUpdateCollection" /> instance call the GetMaintenanceApplyUpdates method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class MaintenanceApplyUpdateCollection : ArmCollection
    {
        private readonly ClientDiagnostics _maintenanceApplyUpdateApplyUpdatesClientDiagnostics;
        private readonly ApplyUpdatesRestOperations _maintenanceApplyUpdateApplyUpdatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MaintenanceApplyUpdateCollection"/> class for mocking. </summary>
        protected MaintenanceApplyUpdateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MaintenanceApplyUpdateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MaintenanceApplyUpdateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _maintenanceApplyUpdateApplyUpdatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Maintenance", MaintenanceApplyUpdateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MaintenanceApplyUpdateResource.ResourceType, out string maintenanceApplyUpdateApplyUpdatesApiVersion);
            _maintenanceApplyUpdateApplyUpdatesRestClient = new ApplyUpdatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, maintenanceApplyUpdateApplyUpdatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Apply maintenance updates to resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplyUpdates_CreateOrUpdateOrCancel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="applyUpdateName"> ApplyUpdate name. </param>
        /// <param name="data"> The ApplyUpdate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/>, <paramref name="applyUpdateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MaintenanceApplyUpdateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string providerName, string resourceType, string resourceName, string applyUpdateName, MaintenanceApplyUpdateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(applyUpdateName, nameof(applyUpdateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _maintenanceApplyUpdateApplyUpdatesClientDiagnostics.CreateScope("MaintenanceApplyUpdateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _maintenanceApplyUpdateApplyUpdatesRestClient.CreateOrUpdateOrCancelAsync(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceType, resourceName, applyUpdateName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MaintenanceArmOperation<MaintenanceApplyUpdateResource>(Response.FromValue(new MaintenanceApplyUpdateResource(Client, response), response.GetRawResponse()));
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
        /// Apply maintenance updates to resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplyUpdates_CreateOrUpdateOrCancel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="applyUpdateName"> ApplyUpdate name. </param>
        /// <param name="data"> The ApplyUpdate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/>, <paramref name="applyUpdateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MaintenanceApplyUpdateResource> CreateOrUpdate(WaitUntil waitUntil, string providerName, string resourceType, string resourceName, string applyUpdateName, MaintenanceApplyUpdateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(applyUpdateName, nameof(applyUpdateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _maintenanceApplyUpdateApplyUpdatesClientDiagnostics.CreateScope("MaintenanceApplyUpdateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _maintenanceApplyUpdateApplyUpdatesRestClient.CreateOrUpdateOrCancel(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceType, resourceName, applyUpdateName, data, cancellationToken);
                var operation = new MaintenanceArmOperation<MaintenanceApplyUpdateResource>(Response.FromValue(new MaintenanceApplyUpdateResource(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Track maintenance updates to resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplyUpdates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="applyUpdateName"> applyUpdate Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is null. </exception>
        public virtual async Task<Response<MaintenanceApplyUpdateResource>> GetAsync(string providerName, string resourceType, string resourceName, string applyUpdateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(applyUpdateName, nameof(applyUpdateName));

            using var scope = _maintenanceApplyUpdateApplyUpdatesClientDiagnostics.CreateScope("MaintenanceApplyUpdateCollection.Get");
            scope.Start();
            try
            {
                var response = await _maintenanceApplyUpdateApplyUpdatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceType, resourceName, applyUpdateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MaintenanceApplyUpdateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Track maintenance updates to resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplyUpdates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="applyUpdateName"> applyUpdate Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is null. </exception>
        public virtual Response<MaintenanceApplyUpdateResource> Get(string providerName, string resourceType, string resourceName, string applyUpdateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(applyUpdateName, nameof(applyUpdateName));

            using var scope = _maintenanceApplyUpdateApplyUpdatesClientDiagnostics.CreateScope("MaintenanceApplyUpdateCollection.Get");
            scope.Start();
            try
            {
                var response = _maintenanceApplyUpdateApplyUpdatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceType, resourceName, applyUpdateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MaintenanceApplyUpdateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplyUpdates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="applyUpdateName"> applyUpdate Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string providerName, string resourceType, string resourceName, string applyUpdateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(applyUpdateName, nameof(applyUpdateName));

            using var scope = _maintenanceApplyUpdateApplyUpdatesClientDiagnostics.CreateScope("MaintenanceApplyUpdateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _maintenanceApplyUpdateApplyUpdatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceType, resourceName, applyUpdateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplyUpdates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="applyUpdateName"> applyUpdate Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is null. </exception>
        public virtual Response<bool> Exists(string providerName, string resourceType, string resourceName, string applyUpdateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(applyUpdateName, nameof(applyUpdateName));

            using var scope = _maintenanceApplyUpdateApplyUpdatesClientDiagnostics.CreateScope("MaintenanceApplyUpdateCollection.Exists");
            scope.Start();
            try
            {
                var response = _maintenanceApplyUpdateApplyUpdatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceType, resourceName, applyUpdateName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplyUpdates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="applyUpdateName"> applyUpdate Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is null. </exception>
        public virtual async Task<NullableResponse<MaintenanceApplyUpdateResource>> GetIfExistsAsync(string providerName, string resourceType, string resourceName, string applyUpdateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(applyUpdateName, nameof(applyUpdateName));

            using var scope = _maintenanceApplyUpdateApplyUpdatesClientDiagnostics.CreateScope("MaintenanceApplyUpdateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _maintenanceApplyUpdateApplyUpdatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceType, resourceName, applyUpdateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MaintenanceApplyUpdateResource>(response.GetRawResponse());
                return Response.FromValue(new MaintenanceApplyUpdateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplyUpdates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="applyUpdateName"> applyUpdate Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="applyUpdateName"/> is null. </exception>
        public virtual NullableResponse<MaintenanceApplyUpdateResource> GetIfExists(string providerName, string resourceType, string resourceName, string applyUpdateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(applyUpdateName, nameof(applyUpdateName));

            using var scope = _maintenanceApplyUpdateApplyUpdatesClientDiagnostics.CreateScope("MaintenanceApplyUpdateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _maintenanceApplyUpdateApplyUpdatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceType, resourceName, applyUpdateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MaintenanceApplyUpdateResource>(response.GetRawResponse());
                return Response.FromValue(new MaintenanceApplyUpdateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
