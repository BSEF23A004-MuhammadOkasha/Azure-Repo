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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.EdgeOrder.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary> A class representing collection of OrderItemResource and their operations over its parent. </summary>
    public partial class OrderItemResourceCollection : ArmCollection, IEnumerable<OrderItemResource>, IAsyncEnumerable<OrderItemResource>
    {
        private readonly ClientDiagnostics _orderItemResourceClientDiagnostics;
        private readonly EdgeOrderManagementRestOperations _orderItemResourceRestClient;

        /// <summary> Initializes a new instance of the <see cref="OrderItemResourceCollection"/> class for mocking. </summary>
        protected OrderItemResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OrderItemResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OrderItemResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _orderItemResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", OrderItemResource.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(OrderItemResource.ResourceType, out string orderItemResourceApiVersion);
            _orderItemResourceRestClient = new EdgeOrderManagementRestOperations(_orderItemResourceClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, orderItemResourceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CreateOrderItem
        /// <summary> Creates an order item. Existing order item cannot be updated with this api and should instead be updated with the Update order item API. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="orderItemResource"> Order item details from request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> or <paramref name="orderItemResource"/> is null. </exception>
        public async virtual Task<OrderItemResourceCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string orderItemName, OrderItemResourceData orderItemResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));
            if (orderItemResource == null)
            {
                throw new ArgumentNullException(nameof(orderItemResource));
            }

            using var scope = _orderItemResourceClientDiagnostics.CreateScope("OrderItemResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _orderItemResourceRestClient.CreateOrderItemAsync(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, orderItemResource, cancellationToken).ConfigureAwait(false);
                var operation = new OrderItemResourceCreateOrUpdateOperation(Client, _orderItemResourceClientDiagnostics, Pipeline, _orderItemResourceRestClient.CreateCreateOrderItemRequest(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, orderItemResource).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CreateOrderItem
        /// <summary> Creates an order item. Existing order item cannot be updated with this api and should instead be updated with the Update order item API. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="orderItemResource"> Order item details from request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> or <paramref name="orderItemResource"/> is null. </exception>
        public virtual OrderItemResourceCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string orderItemName, OrderItemResourceData orderItemResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));
            if (orderItemResource == null)
            {
                throw new ArgumentNullException(nameof(orderItemResource));
            }

            using var scope = _orderItemResourceClientDiagnostics.CreateScope("OrderItemResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _orderItemResourceRestClient.CreateOrderItem(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, orderItemResource, cancellationToken);
                var operation = new OrderItemResourceCreateOrUpdateOperation(Client, _orderItemResourceClientDiagnostics, Pipeline, _orderItemResourceRestClient.CreateCreateOrderItemRequest(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, orderItemResource).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: GetOrderItemByName
        /// <summary> Gets an order item. </summary>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        public async virtual Task<Response<OrderItemResource>> GetAsync(string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));

            using var scope = _orderItemResourceClientDiagnostics.CreateScope("OrderItemResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _orderItemResourceRestClient.GetOrderItemByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _orderItemResourceClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new OrderItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: GetOrderItemByName
        /// <summary> Gets an order item. </summary>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        public virtual Response<OrderItemResource> Get(string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));

            using var scope = _orderItemResourceClientDiagnostics.CreateScope("OrderItemResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _orderItemResourceRestClient.GetOrderItemByName(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, expand, cancellationToken);
                if (response.Value == null)
                    throw _orderItemResourceClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OrderItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ListOrderItemsAtResourceGroupLevel
        /// <summary> Lists order item at resource group level. </summary>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OrderItemResource> GetAllAsync(string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<OrderItemResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _orderItemResourceClientDiagnostics.CreateScope("OrderItemResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _orderItemResourceRestClient.ListOrderItemsAtResourceGroupLevelAsync(Id.SubscriptionId, Id.ResourceGroupName, filter, expand, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OrderItemResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _orderItemResourceClientDiagnostics.CreateScope("OrderItemResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _orderItemResourceRestClient.ListOrderItemsAtResourceGroupLevelNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, expand, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ListOrderItemsAtResourceGroupLevel
        /// <summary> Lists order item at resource group level. </summary>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OrderItemResource> GetAll(string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<OrderItemResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _orderItemResourceClientDiagnostics.CreateScope("OrderItemResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _orderItemResourceRestClient.ListOrderItemsAtResourceGroupLevel(Id.SubscriptionId, Id.ResourceGroupName, filter, expand, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OrderItemResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _orderItemResourceClientDiagnostics.CreateScope("OrderItemResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _orderItemResourceRestClient.ListOrderItemsAtResourceGroupLevelNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, expand, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: GetOrderItemByName
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));

            using var scope = _orderItemResourceClientDiagnostics.CreateScope("OrderItemResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(orderItemName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: GetOrderItemByName
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        public virtual Response<bool> Exists(string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));

            using var scope = _orderItemResourceClientDiagnostics.CreateScope("OrderItemResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(orderItemName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: GetOrderItemByName
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        public async virtual Task<Response<OrderItemResource>> GetIfExistsAsync(string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));

            using var scope = _orderItemResourceClientDiagnostics.CreateScope("OrderItemResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _orderItemResourceRestClient.GetOrderItemByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<OrderItemResource>(null, response.GetRawResponse());
                return Response.FromValue(new OrderItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: GetOrderItemByName
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        public virtual Response<OrderItemResource> GetIfExists(string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderItemName, nameof(orderItemName));

            using var scope = _orderItemResourceClientDiagnostics.CreateScope("OrderItemResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _orderItemResourceRestClient.GetOrderItemByName(Id.SubscriptionId, Id.ResourceGroupName, orderItemName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<OrderItemResource>(null, response.GetRawResponse());
                return Response.FromValue(new OrderItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OrderItemResource> IEnumerable<OrderItemResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OrderItemResource> IAsyncEnumerable<OrderItemResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
