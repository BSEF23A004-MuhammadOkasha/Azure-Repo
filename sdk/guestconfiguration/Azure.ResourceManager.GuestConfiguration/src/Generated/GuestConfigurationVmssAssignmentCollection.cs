// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.GuestConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="GuestConfigurationVmssAssignmentResource"/> and their operations.
    /// Each <see cref="GuestConfigurationVmssAssignmentResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="GuestConfigurationVmssAssignmentCollection"/> instance call the GetGuestConfigurationVmssAssignments method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class GuestConfigurationVmssAssignmentCollection : ArmCollection, IEnumerable<GuestConfigurationVmssAssignmentResource>, IAsyncEnumerable<GuestConfigurationVmssAssignmentResource>
    {
        private readonly ClientDiagnostics _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics;
        private readonly GuestConfigurationAssignmentsVmssRestOperations _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient;

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationVmssAssignmentCollection"/> class for mocking. </summary>
        protected GuestConfigurationVmssAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationVmssAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GuestConfigurationVmssAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.GuestConfiguration", GuestConfigurationVmssAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GuestConfigurationVmssAssignmentResource.ResourceType, out string guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSApiVersion);
            _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient = new GuestConfigurationAssignmentsVmssRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != "Microsoft.Compute/virtualMachineScaleSets")
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, "Microsoft.Compute/virtualMachineScaleSets"), nameof(id));
        }

        /// <summary>
        /// Creates an association between a VMSS and guest configuration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestConfigurationVmssAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the guest configuration assignment. </param>
        /// <param name="data"> Parameters supplied to the create or update guest configuration assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GuestConfigurationVmssAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, GuestConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var uri = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new GuestConfigurationArmOperation<GuestConfigurationVmssAssignmentResource>(Response.FromValue(new GuestConfigurationVmssAssignmentResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates an association between a VMSS and guest configuration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestConfigurationVmssAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the guest configuration assignment. </param>
        /// <param name="data"> Parameters supplied to the create or update guest configuration assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GuestConfigurationVmssAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string name, GuestConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var uri = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new GuestConfigurationArmOperation<GuestConfigurationVmssAssignmentResource>(Response.FromValue(new GuestConfigurationVmssAssignmentResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get information about a guest configuration assignment for VMSS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestConfigurationVmssAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<GuestConfigurationVmssAssignmentResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestConfigurationVmssAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a guest configuration assignment for VMSS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestConfigurationVmssAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<GuestConfigurationVmssAssignmentResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestConfigurationVmssAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all guest configuration assignments for VMSS.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestConfigurationVmssAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GuestConfigurationVmssAssignmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GuestConfigurationVmssAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new GuestConfigurationVmssAssignmentResource(Client, GuestConfigurationAssignmentData.DeserializeGuestConfigurationAssignmentData(e)), _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics, Pipeline, "GuestConfigurationVmssAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all guest configuration assignments for VMSS.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestConfigurationVmssAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GuestConfigurationVmssAssignmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GuestConfigurationVmssAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new GuestConfigurationVmssAssignmentResource(Client, GuestConfigurationAssignmentData.DeserializeGuestConfigurationAssignmentData(e)), _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics, Pipeline, "GuestConfigurationVmssAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestConfigurationVmssAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestConfigurationVmssAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestConfigurationVmssAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<GuestConfigurationVmssAssignmentResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<GuestConfigurationVmssAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new GuestConfigurationVmssAssignmentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestConfigurationVmssAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<GuestConfigurationVmssAssignmentResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<GuestConfigurationVmssAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new GuestConfigurationVmssAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GuestConfigurationVmssAssignmentResource> IEnumerable<GuestConfigurationVmssAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GuestConfigurationVmssAssignmentResource> IAsyncEnumerable<GuestConfigurationVmssAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
