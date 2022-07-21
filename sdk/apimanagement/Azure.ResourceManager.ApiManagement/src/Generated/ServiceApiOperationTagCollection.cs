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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceApiOperationTagResource" /> and their operations.
    /// Each <see cref="ServiceApiOperationTagResource" /> in the collection will belong to the same instance of <see cref="ApiOperationResource" />.
    /// To get a <see cref="ServiceApiOperationTagCollection" /> instance call the GetServiceApiOperationTags method from an instance of <see cref="ApiOperationResource" />.
    /// </summary>
    public partial class ServiceApiOperationTagCollection : ArmCollection, IEnumerable<ServiceApiOperationTagResource>, IAsyncEnumerable<ServiceApiOperationTagResource>
    {
        private readonly ClientDiagnostics _serviceApiOperationTagTagClientDiagnostics;
        private readonly TagRestOperations _serviceApiOperationTagTagRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceApiOperationTagCollection"/> class for mocking. </summary>
        protected ServiceApiOperationTagCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceApiOperationTagCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceApiOperationTagCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceApiOperationTagTagClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceApiOperationTagResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceApiOperationTagResource.ResourceType, out string serviceApiOperationTagTagApiVersion);
            _serviceApiOperationTagTagRestClient = new TagRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceApiOperationTagTagApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiOperationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiOperationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Assign tag to the Operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}
        /// Operation Id: Tag_AssignToOperation
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceApiOperationTagResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _serviceApiOperationTagTagClientDiagnostics.CreateScope("ServiceApiOperationTagCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceApiOperationTagTagRestClient.AssignToOperationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ServiceApiOperationTagResource>(Response.FromValue(new ServiceApiOperationTagResource(Client, response), response.GetRawResponse()));
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
        /// Assign tag to the Operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}
        /// Operation Id: Tag_AssignToOperation
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual ArmOperation<ServiceApiOperationTagResource> CreateOrUpdate(WaitUntil waitUntil, string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _serviceApiOperationTagTagClientDiagnostics.CreateScope("ServiceApiOperationTagCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceApiOperationTagTagRestClient.AssignToOperation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken);
                var operation = new ApiManagementArmOperation<ServiceApiOperationTagResource>(Response.FromValue(new ServiceApiOperationTagResource(Client, response), response.GetRawResponse()));
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
        /// Get tag associated with the Operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}
        /// Operation Id: Tag_GetByOperation
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<Response<ServiceApiOperationTagResource>> GetAsync(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _serviceApiOperationTagTagClientDiagnostics.CreateScope("ServiceApiOperationTagCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceApiOperationTagTagRestClient.GetByOperationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceApiOperationTagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get tag associated with the Operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}
        /// Operation Id: Tag_GetByOperation
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual Response<ServiceApiOperationTagResource> Get(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _serviceApiOperationTagTagClientDiagnostics.CreateScope("ServiceApiOperationTagCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceApiOperationTagTagRestClient.GetByOperation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceApiOperationTagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Tags associated with the Operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags
        /// Operation Id: Tag_ListByOperation
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceApiOperationTagResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceApiOperationTagResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceApiOperationTagResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceApiOperationTagTagClientDiagnostics.CreateScope("ServiceApiOperationTagCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceApiOperationTagTagRestClient.ListByOperationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceApiOperationTagResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceApiOperationTagResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceApiOperationTagTagClientDiagnostics.CreateScope("ServiceApiOperationTagCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceApiOperationTagTagRestClient.ListByOperationNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceApiOperationTagResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all Tags associated with the Operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags
        /// Operation Id: Tag_ListByOperation
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceApiOperationTagResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceApiOperationTagResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            Page<ServiceApiOperationTagResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceApiOperationTagTagClientDiagnostics.CreateScope("ServiceApiOperationTagCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceApiOperationTagTagRestClient.ListByOperation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceApiOperationTagResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServiceApiOperationTagResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceApiOperationTagTagClientDiagnostics.CreateScope("ServiceApiOperationTagCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceApiOperationTagTagRestClient.ListByOperationNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceApiOperationTagResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}
        /// Operation Id: Tag_GetByOperation
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _serviceApiOperationTagTagClientDiagnostics.CreateScope("ServiceApiOperationTagCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceApiOperationTagTagRestClient.GetByOperationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}
        /// Operation Id: Tag_GetByOperation
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual Response<bool> Exists(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _serviceApiOperationTagTagClientDiagnostics.CreateScope("ServiceApiOperationTagCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceApiOperationTagTagRestClient.GetByOperation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceApiOperationTagResource> IEnumerable<ServiceApiOperationTagResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceApiOperationTagResource> IAsyncEnumerable<ServiceApiOperationTagResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
