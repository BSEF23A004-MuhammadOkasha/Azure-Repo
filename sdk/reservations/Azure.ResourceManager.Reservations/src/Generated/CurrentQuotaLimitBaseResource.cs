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

namespace Azure.ResourceManager.Reservations
{
    /// <summary>
    /// A Class representing a CurrentQuotaLimitBase along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CurrentQuotaLimitBaseResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCurrentQuotaLimitBaseResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetCurrentQuotaLimitBase method.
    /// </summary>
    public partial class CurrentQuotaLimitBaseResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CurrentQuotaLimitBaseResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string providerId, AzureLocation location, string resourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _currentQuotaLimitBaseQuotaClientDiagnostics;
        private readonly QuotaRestOperations _currentQuotaLimitBaseQuotaRestClient;
        private readonly CurrentQuotaLimitBaseData _data;

        /// <summary> Initializes a new instance of the <see cref="CurrentQuotaLimitBaseResource"/> class for mocking. </summary>
        protected CurrentQuotaLimitBaseResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CurrentQuotaLimitBaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CurrentQuotaLimitBaseResource(ArmClient client, CurrentQuotaLimitBaseData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CurrentQuotaLimitBaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CurrentQuotaLimitBaseResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _currentQuotaLimitBaseQuotaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Reservations", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string currentQuotaLimitBaseQuotaApiVersion);
            _currentQuotaLimitBaseQuotaRestClient = new QuotaRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, currentQuotaLimitBaseQuotaApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Capacity/resourceProviders/locations/serviceLimits";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CurrentQuotaLimitBaseData Data
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
        /// Get the current quota (service limit) and usage of a resource. You can use the response from the GET operation to submit quota update request.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}
        /// Operation Id: Quota_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CurrentQuotaLimitBaseResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseResource.Get");
            scope.Start();
            try
            {
                var response = await _currentQuotaLimitBaseQuotaRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CurrentQuotaLimitBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the current quota (service limit) and usage of a resource. You can use the response from the GET operation to submit quota update request.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}
        /// Operation Id: Quota_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CurrentQuotaLimitBaseResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseResource.Get");
            scope.Start();
            try
            {
                var response = _currentQuotaLimitBaseQuotaRestClient.Get(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CurrentQuotaLimitBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the quota (service limits) of this resource to the requested value.
        ///   • To get the quota information for specific resource, send a GET request.
        ///   • To increase the quota, update the limit field from the GET response to a new value.
        ///   • To update the quota value, submit the JSON response to the quota request API to update the quota.
        ///   • To update the quota. use the PATCH operation.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}
        /// Operation Id: Quota_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Payload for the quota request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CurrentQuotaLimitBaseResource>> UpdateAsync(WaitUntil waitUntil, CurrentQuotaLimitBaseData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseResource.Update");
            scope.Start();
            try
            {
                var response = await _currentQuotaLimitBaseQuotaRestClient.UpdateAsync(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<CurrentQuotaLimitBaseResource>(new CurrentQuotaLimitBaseOperationSource(Client), _currentQuotaLimitBaseQuotaClientDiagnostics, Pipeline, _currentQuotaLimitBaseQuotaRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Update the quota (service limits) of this resource to the requested value.
        ///   • To get the quota information for specific resource, send a GET request.
        ///   • To increase the quota, update the limit field from the GET response to a new value.
        ///   • To update the quota value, submit the JSON response to the quota request API to update the quota.
        ///   • To update the quota. use the PATCH operation.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}
        /// Operation Id: Quota_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Payload for the quota request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CurrentQuotaLimitBaseResource> Update(WaitUntil waitUntil, CurrentQuotaLimitBaseData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseResource.Update");
            scope.Start();
            try
            {
                var response = _currentQuotaLimitBaseQuotaRestClient.Update(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ReservationsArmOperation<CurrentQuotaLimitBaseResource>(new CurrentQuotaLimitBaseOperationSource(Client), _currentQuotaLimitBaseQuotaClientDiagnostics, Pipeline, _currentQuotaLimitBaseQuotaRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
