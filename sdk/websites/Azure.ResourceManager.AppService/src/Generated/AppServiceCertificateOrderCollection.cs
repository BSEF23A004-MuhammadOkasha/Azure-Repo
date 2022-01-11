// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of AppServiceCertificateOrder and their operations over its parent. </summary>
    public partial class AppServiceCertificateOrderCollection : ArmCollection, IEnumerable<AppServiceCertificateOrder>, IAsyncEnumerable<AppServiceCertificateOrder>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AppServiceCertificateOrdersRestOperations _appServiceCertificateOrdersRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServiceCertificateOrderCollection"/> class for mocking. </summary>
        protected AppServiceCertificateOrderCollection()
        {
        }

        /// <summary> Initializes a new instance of AppServiceCertificateOrderCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AppServiceCertificateOrderCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServiceCertificateOrdersRestClient = new AppServiceCertificateOrdersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AppServiceCertificateOrders_CreateOrUpdate
        /// <summary> Description for Create or update a certificate purchase order. </summary>
        /// <param name="certificateOrderName"> Name of the certificate order. </param>
        /// <param name="certificateDistinguishedName"> Distinguished name to use for the certificate order. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> or <paramref name="certificateDistinguishedName"/> is null. </exception>
        public virtual AppServiceCertificateOrderCreateOrUpdateOperation CreateOrUpdate(string certificateOrderName, AppServiceCertificateOrderData certificateDistinguishedName, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }
            if (certificateDistinguishedName == null)
            {
                throw new ArgumentNullException(nameof(certificateDistinguishedName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceCertificateOrdersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, certificateDistinguishedName, cancellationToken);
                var operation = new AppServiceCertificateOrderCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _appServiceCertificateOrdersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, certificateDistinguishedName).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AppServiceCertificateOrders_CreateOrUpdate
        /// <summary> Description for Create or update a certificate purchase order. </summary>
        /// <param name="certificateOrderName"> Name of the certificate order. </param>
        /// <param name="certificateDistinguishedName"> Distinguished name to use for the certificate order. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> or <paramref name="certificateDistinguishedName"/> is null. </exception>
        public async virtual Task<AppServiceCertificateOrderCreateOrUpdateOperation> CreateOrUpdateAsync(string certificateOrderName, AppServiceCertificateOrderData certificateDistinguishedName, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }
            if (certificateDistinguishedName == null)
            {
                throw new ArgumentNullException(nameof(certificateDistinguishedName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateOrdersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, certificateDistinguishedName, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceCertificateOrderCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _appServiceCertificateOrdersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, certificateDistinguishedName).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AppServiceCertificateOrders_Get
        /// <summary> Description for Get a certificate order. </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual Response<AppServiceCertificateOrder> Get(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceCertificateOrdersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceCertificateOrder(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AppServiceCertificateOrders_Get
        /// <summary> Description for Get a certificate order. </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public async virtual Task<Response<AppServiceCertificateOrder>> GetAsync(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateOrdersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AppServiceCertificateOrder(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual Response<AppServiceCertificateOrder> GetIfExists(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServiceCertificateOrdersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AppServiceCertificateOrder>(null, response.GetRawResponse())
                    : Response.FromValue(new AppServiceCertificateOrder(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public async virtual Task<Response<AppServiceCertificateOrder>> GetIfExistsAsync(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateOrdersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AppServiceCertificateOrder>(null, response.GetRawResponse())
                    : Response.FromValue(new AppServiceCertificateOrder(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(certificateOrderName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(certificateOrderName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AppServiceCertificateOrders_ListByResourceGroup
        /// <summary> Description for Get certificate orders in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceCertificateOrder" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceCertificateOrder> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AppServiceCertificateOrder> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceCertificateOrdersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceCertificateOrder(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AppServiceCertificateOrder> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceCertificateOrdersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceCertificateOrder(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AppServiceCertificateOrders_ListByResourceGroup
        /// <summary> Description for Get certificate orders in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceCertificateOrder" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceCertificateOrder> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AppServiceCertificateOrder>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceCertificateOrdersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceCertificateOrder(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AppServiceCertificateOrder>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceCertificateOrdersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceCertificateOrder(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="AppServiceCertificateOrder" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AppServiceCertificateOrder.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="AppServiceCertificateOrder" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AppServiceCertificateOrder.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppServiceCertificateOrder> IEnumerable<AppServiceCertificateOrder>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServiceCertificateOrder> IAsyncEnumerable<AppServiceCertificateOrder>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, AppServiceCertificateOrder, AppServiceCertificateOrderData> Construct() { }
    }
}
