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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A class representing a collection of <see cref="NestedResourceTypeThirdSkuResource"/> and their operations.
    /// Each <see cref="NestedResourceTypeThirdSkuResource"/> in the collection will belong to the same instance of <see cref="ResourceTypeRegistrationResource"/>.
    /// To get a <see cref="NestedResourceTypeThirdSkuCollection"/> instance call the GetNestedResourceTypeThirdSkus method from an instance of <see cref="ResourceTypeRegistrationResource"/>.
    /// </summary>
    public partial class NestedResourceTypeThirdSkuCollection : ArmCollection, IEnumerable<NestedResourceTypeThirdSkuResource>, IAsyncEnumerable<NestedResourceTypeThirdSkuResource>
    {
        private readonly ClientDiagnostics _nestedResourceTypeThirdSkuSkusClientDiagnostics;
        private readonly SkusRestOperations _nestedResourceTypeThirdSkuSkusRestClient;
        private readonly string _nestedResourceTypeFirst;
        private readonly string _nestedResourceTypeSecond;
        private readonly string _nestedResourceTypeThird;

        /// <summary> Initializes a new instance of the <see cref="NestedResourceTypeThirdSkuCollection"/> class for mocking. </summary>
        protected NestedResourceTypeThirdSkuCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NestedResourceTypeThirdSkuCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <param name="nestedResourceTypeSecond"> The second child resource type. </param>
        /// <param name="nestedResourceTypeThird"> The third child resource type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/> or <paramref name="nestedResourceTypeThird"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/> or <paramref name="nestedResourceTypeThird"/> is an empty string, and was expected to be non-empty. </exception>
        internal NestedResourceTypeThirdSkuCollection(ArmClient client, ResourceIdentifier id, string nestedResourceTypeFirst, string nestedResourceTypeSecond, string nestedResourceTypeThird) : base(client, id)
        {
            _nestedResourceTypeFirst = nestedResourceTypeFirst;
            _nestedResourceTypeSecond = nestedResourceTypeSecond;
            _nestedResourceTypeThird = nestedResourceTypeThird;
            _nestedResourceTypeThirdSkuSkusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", NestedResourceTypeThirdSkuResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NestedResourceTypeThirdSkuResource.ResourceType, out string nestedResourceTypeThirdSkuSkusApiVersion);
            _nestedResourceTypeThirdSkuSkusRestClient = new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, nestedResourceTypeThirdSkuSkusApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceTypeRegistrationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceTypeRegistrationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the resource type skus in the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_CreateOrUpdateNestedResourceTypeThird</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeThirdSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NestedResourceTypeThirdSkuResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sku, ResourceTypeSkuData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _nestedResourceTypeThirdSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeThirdSkuCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _nestedResourceTypeThirdSkuSkusRestClient.CreateOrUpdateNestedResourceTypeThirdAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, data, cancellationToken).ConfigureAwait(false);
                var uri = _nestedResourceTypeThirdSkuSkusRestClient.CreateCreateOrUpdateNestedResourceTypeThirdRequestUri(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new ProviderHubArmOperation<NestedResourceTypeThirdSkuResource>(Response.FromValue(new NestedResourceTypeThirdSkuResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Creates or updates the resource type skus in the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_CreateOrUpdateNestedResourceTypeThird</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeThirdSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NestedResourceTypeThirdSkuResource> CreateOrUpdate(WaitUntil waitUntil, string sku, ResourceTypeSkuData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _nestedResourceTypeThirdSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeThirdSkuCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _nestedResourceTypeThirdSkuSkusRestClient.CreateOrUpdateNestedResourceTypeThird(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, data, cancellationToken);
                var uri = _nestedResourceTypeThirdSkuSkusRestClient.CreateCreateOrUpdateNestedResourceTypeThirdRequestUri(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new ProviderHubArmOperation<NestedResourceTypeThirdSkuResource>(Response.FromValue(new NestedResourceTypeThirdSkuResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeThird</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeThirdSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<Response<NestedResourceTypeThirdSkuResource>> GetAsync(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _nestedResourceTypeThirdSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeThirdSkuCollection.Get");
            scope.Start();
            try
            {
                var response = await _nestedResourceTypeThirdSkuSkusRestClient.GetNestedResourceTypeThirdAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NestedResourceTypeThirdSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeThird</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeThirdSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual Response<NestedResourceTypeThirdSkuResource> Get(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _nestedResourceTypeThirdSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeThirdSkuCollection.Get");
            scope.Start();
            try
            {
                var response = _nestedResourceTypeThirdSkuSkusRestClient.GetNestedResourceTypeThird(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NestedResourceTypeThirdSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_ListByResourceTypeRegistrationsNestedResourceTypeThird</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeThirdSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NestedResourceTypeThirdSkuResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NestedResourceTypeThirdSkuResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _nestedResourceTypeThirdSkuSkusRestClient.CreateListByResourceTypeRegistrationsNestedResourceTypeThirdRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _nestedResourceTypeThirdSkuSkusRestClient.CreateListByResourceTypeRegistrationsNestedResourceTypeThirdNextPageRequest(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NestedResourceTypeThirdSkuResource(Client, ResourceTypeSkuData.DeserializeResourceTypeSkuData(e)), _nestedResourceTypeThirdSkuSkusClientDiagnostics, Pipeline, "NestedResourceTypeThirdSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_ListByResourceTypeRegistrationsNestedResourceTypeThird</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeThirdSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NestedResourceTypeThirdSkuResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NestedResourceTypeThirdSkuResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _nestedResourceTypeThirdSkuSkusRestClient.CreateListByResourceTypeRegistrationsNestedResourceTypeThirdRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _nestedResourceTypeThirdSkuSkusRestClient.CreateListByResourceTypeRegistrationsNestedResourceTypeThirdNextPageRequest(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NestedResourceTypeThirdSkuResource(Client, ResourceTypeSkuData.DeserializeResourceTypeSkuData(e)), _nestedResourceTypeThirdSkuSkusClientDiagnostics, Pipeline, "NestedResourceTypeThirdSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeThird</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeThirdSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _nestedResourceTypeThirdSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeThirdSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = await _nestedResourceTypeThirdSkuSkusRestClient.GetNestedResourceTypeThirdAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeThird</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeThirdSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual Response<bool> Exists(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _nestedResourceTypeThirdSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeThirdSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = _nestedResourceTypeThirdSkuSkusRestClient.GetNestedResourceTypeThird(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeThird</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeThirdSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<NullableResponse<NestedResourceTypeThirdSkuResource>> GetIfExistsAsync(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _nestedResourceTypeThirdSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeThirdSkuCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _nestedResourceTypeThirdSkuSkusRestClient.GetNestedResourceTypeThirdAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NestedResourceTypeThirdSkuResource>(response.GetRawResponse());
                return Response.FromValue(new NestedResourceTypeThirdSkuResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeThird</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeThirdSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual NullableResponse<NestedResourceTypeThirdSkuResource> GetIfExists(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _nestedResourceTypeThirdSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeThirdSkuCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _nestedResourceTypeThirdSkuSkusRestClient.GetNestedResourceTypeThird(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NestedResourceTypeThirdSkuResource>(response.GetRawResponse());
                return Response.FromValue(new NestedResourceTypeThirdSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NestedResourceTypeThirdSkuResource> IEnumerable<NestedResourceTypeThirdSkuResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NestedResourceTypeThirdSkuResource> IAsyncEnumerable<NestedResourceTypeThirdSkuResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
