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
using Azure.ResourceManager.GuestConfiguration.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.GuestConfiguration
{
    /// <summary>
    /// A Class representing a GuestConfigurationVmAssignment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="GuestConfigurationVmAssignmentResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetGuestConfigurationVmAssignmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetGuestConfigurationVmAssignment method.
    /// </summary>
    public partial class GuestConfigurationVmAssignmentResource : GuestConfigurationAssignmentResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GuestConfigurationVmAssignmentResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vmName, string guestConfigurationAssignmentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics;
        private readonly GuestConfigurationAssignmentsRestOperations _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient;
        private readonly ClientDiagnostics _guestConfigurationAssignmentReportsClientDiagnostics;
        private readonly GuestConfigurationAssignmentReportsRestOperations _guestConfigurationAssignmentReportsRestClient;

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationVmAssignmentResource"/> class for mocking. </summary>
        protected GuestConfigurationVmAssignmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "GuestConfigurationVmAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GuestConfigurationVmAssignmentResource(ArmClient client, GuestConfigurationAssignmentData data) : base(client, data)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationVmAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GuestConfigurationVmAssignmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.GuestConfiguration", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string guestConfigurationVmAssignmentGuestConfigurationAssignmentsApiVersion);
            _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient = new GuestConfigurationAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, guestConfigurationVmAssignmentGuestConfigurationAssignmentsApiVersion);
            _guestConfigurationAssignmentReportsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.GuestConfiguration", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _guestConfigurationAssignmentReportsRestClient = new GuestConfigurationAssignmentReportsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.GuestConfiguration/guestConfigurationAssignments";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<GuestConfigurationAssignmentResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = await _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a guest configuration assignment
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<GuestConfigurationVmAssignmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken);
            return Response.FromValue((GuestConfigurationVmAssignmentResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<GuestConfigurationAssignmentResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a guest configuration assignment
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<GuestConfigurationVmAssignmentResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((GuestConfigurationVmAssignmentResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// Delete a guest configuration assignment
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new GuestConfigurationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a guest configuration assignment
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new GuestConfigurationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates an association between a VM and guest configuration
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update guest configuration assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GuestConfigurationVmAssignmentResource>> UpdateAsync(WaitUntil waitUntil, GuestConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = await _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new GuestConfigurationArmOperation<GuestConfigurationVmAssignmentResource>(Response.FromValue(new GuestConfigurationVmAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Creates an association between a VM and guest configuration
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update guest configuration assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GuestConfigurationVmAssignmentResource> Update(WaitUntil waitUntil, GuestConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new GuestConfigurationArmOperation<GuestConfigurationVmAssignmentResource>(Response.FromValue(new GuestConfigurationVmAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override AsyncPageable<GuestConfigurationAssignmentReport> GetReportsCoreAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GuestConfigurationAssignmentReport>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _guestConfigurationAssignmentReportsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentResource.GetReports");
                scope.Start();
                try
                {
                    var response = await _guestConfigurationAssignmentReportsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Pageable<GuestConfigurationAssignmentReport> GetReportsCore(CancellationToken cancellationToken = default)
        {
            Page<GuestConfigurationAssignmentReport> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _guestConfigurationAssignmentReportsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentResource.GetReports");
                scope.Start();
                try
                {
                    var response = _guestConfigurationAssignmentReportsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> placeholder. </summary>
        /// <param name="reportId"> The GUID for the guest configuration assignment report. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportId"/> is null. </exception>
        protected override async Task<Response<GuestConfigurationAssignmentReport>> GetReportCoreAsync(string reportId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportId, nameof(reportId));

            using var scope = _guestConfigurationAssignmentReportsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentResource.GetReport");
            scope.Start();
            try
            {
                var response = await _guestConfigurationAssignmentReportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reportId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> placeholder. </summary>
        /// <param name="reportId"> The GUID for the guest configuration assignment report. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportId"/> is null. </exception>
        protected override Response<GuestConfigurationAssignmentReport> GetReportCore(string reportId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportId, nameof(reportId));

            using var scope = _guestConfigurationAssignmentReportsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentResource.GetReport");
            scope.Start();
            try
            {
                var response = _guestConfigurationAssignmentReportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reportId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
