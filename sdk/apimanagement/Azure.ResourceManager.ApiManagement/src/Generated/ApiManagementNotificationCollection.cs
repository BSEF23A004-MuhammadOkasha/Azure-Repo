// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementNotificationResource" /> and their operations.
    /// Each <see cref="ApiManagementNotificationResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementNotificationCollection" /> instance call the GetApiManagementNotifications method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementNotificationCollection : ArmCollection, IEnumerable<ApiManagementNotificationResource>, IAsyncEnumerable<ApiManagementNotificationResource>
    {
        private readonly ClientDiagnostics _apiManagementNotificationNotificationClientDiagnostics;
        private readonly NotificationRestOperations _apiManagementNotificationNotificationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementNotificationCollection"/> class for mocking. </summary>
        protected ApiManagementNotificationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementNotificationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementNotificationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementNotificationNotificationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementNotificationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementNotificationResource.ResourceType, out string apiManagementNotificationNotificationApiVersion);
            _apiManagementNotificationNotificationRestClient = new NotificationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementNotificationNotificationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update API Management publisher notification.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/notifications/{notificationName}
        /// Operation Id: Notification_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="notificationName"> Notification Name Identifier. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<ApiManagementNotificationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, NotificationName notificationName, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementNotificationNotificationClientDiagnostics.CreateScope("ApiManagementNotificationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementNotificationNotificationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, notificationName, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementNotificationResource>(Response.FromValue(new ApiManagementNotificationResource(Client, response), response.GetRawResponse()));
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
        /// Create or Update API Management publisher notification.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/notifications/{notificationName}
        /// Operation Id: Notification_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="notificationName"> Notification Name Identifier. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<ApiManagementNotificationResource> CreateOrUpdate(WaitUntil waitUntil, NotificationName notificationName, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementNotificationNotificationClientDiagnostics.CreateScope("ApiManagementNotificationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementNotificationNotificationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, notificationName, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementNotificationResource>(Response.FromValue(new ApiManagementNotificationResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the Notification specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/notifications/{notificationName}
        /// Operation Id: Notification_Get
        /// </summary>
        /// <param name="notificationName"> Notification Name Identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementNotificationResource>> GetAsync(NotificationName notificationName, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementNotificationNotificationClientDiagnostics.CreateScope("ApiManagementNotificationCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementNotificationNotificationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, notificationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementNotificationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Notification specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/notifications/{notificationName}
        /// Operation Id: Notification_Get
        /// </summary>
        /// <param name="notificationName"> Notification Name Identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementNotificationResource> Get(NotificationName notificationName, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementNotificationNotificationClientDiagnostics.CreateScope("ApiManagementNotificationCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementNotificationNotificationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, notificationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementNotificationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of properties defined within a service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/notifications
        /// Operation Id: Notification_ListByService
        /// </summary>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementNotificationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementNotificationResource> GetAllAsync(int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ApiManagementNotificationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _apiManagementNotificationNotificationClientDiagnostics.CreateScope("ApiManagementNotificationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _apiManagementNotificationNotificationRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementNotificationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApiManagementNotificationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _apiManagementNotificationNotificationClientDiagnostics.CreateScope("ApiManagementNotificationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _apiManagementNotificationNotificationRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementNotificationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists a collection of properties defined within a service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/notifications
        /// Operation Id: Notification_ListByService
        /// </summary>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementNotificationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementNotificationResource> GetAll(int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            Page<ApiManagementNotificationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _apiManagementNotificationNotificationClientDiagnostics.CreateScope("ApiManagementNotificationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _apiManagementNotificationNotificationRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementNotificationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApiManagementNotificationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _apiManagementNotificationNotificationClientDiagnostics.CreateScope("ApiManagementNotificationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _apiManagementNotificationNotificationRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementNotificationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/notifications/{notificationName}
        /// Operation Id: Notification_Get
        /// </summary>
        /// <param name="notificationName"> Notification Name Identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(NotificationName notificationName, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementNotificationNotificationClientDiagnostics.CreateScope("ApiManagementNotificationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementNotificationNotificationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, notificationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/notifications/{notificationName}
        /// Operation Id: Notification_Get
        /// </summary>
        /// <param name="notificationName"> Notification Name Identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(NotificationName notificationName, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementNotificationNotificationClientDiagnostics.CreateScope("ApiManagementNotificationCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementNotificationNotificationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, notificationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementNotificationResource> IEnumerable<ApiManagementNotificationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementNotificationResource> IAsyncEnumerable<ApiManagementNotificationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
