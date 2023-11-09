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

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="MobileNetworkSliceResource" /> and their operations.
    /// Each <see cref="MobileNetworkSliceResource" /> in the collection will belong to the same instance of <see cref="MobileNetworkResource" />.
    /// To get a <see cref="MobileNetworkSliceCollection" /> instance call the GetMobileNetworkSlices method from an instance of <see cref="MobileNetworkResource" />.
    /// </summary>
    public partial class MobileNetworkSliceCollection : ArmCollection, IEnumerable<MobileNetworkSliceResource>, IAsyncEnumerable<MobileNetworkSliceResource>
    {
        private readonly ClientDiagnostics _mobileNetworkSliceSlicesClientDiagnostics;
        private readonly SlicesRestOperations _mobileNetworkSliceSlicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkSliceCollection"/> class for mocking. </summary>
        protected MobileNetworkSliceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkSliceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MobileNetworkSliceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mobileNetworkSliceSlicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", MobileNetworkSliceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MobileNetworkSliceResource.ResourceType, out string mobileNetworkSliceSlicesApiVersion);
            _mobileNetworkSliceSlicesRestClient = new SlicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mobileNetworkSliceSlicesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MobileNetworkResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MobileNetworkResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a network slice. Must be created in the same location as its parent mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/slices/{sliceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Slices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sliceName"> The name of the network slice. </param>
        /// <param name="data"> Parameters supplied to the create or update network slice operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sliceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sliceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MobileNetworkSliceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sliceName, MobileNetworkSliceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sliceName, nameof(sliceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkSliceSlicesClientDiagnostics.CreateScope("MobileNetworkSliceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSliceSlicesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sliceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<MobileNetworkSliceResource>(new MobileNetworkSliceOperationSource(Client), _mobileNetworkSliceSlicesClientDiagnostics, Pipeline, _mobileNetworkSliceSlicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sliceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a network slice. Must be created in the same location as its parent mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/slices/{sliceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Slices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sliceName"> The name of the network slice. </param>
        /// <param name="data"> Parameters supplied to the create or update network slice operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sliceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sliceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MobileNetworkSliceResource> CreateOrUpdate(WaitUntil waitUntil, string sliceName, MobileNetworkSliceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sliceName, nameof(sliceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkSliceSlicesClientDiagnostics.CreateScope("MobileNetworkSliceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mobileNetworkSliceSlicesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sliceName, data, cancellationToken);
                var operation = new MobileNetworkArmOperation<MobileNetworkSliceResource>(new MobileNetworkSliceOperationSource(Client), _mobileNetworkSliceSlicesClientDiagnostics, Pipeline, _mobileNetworkSliceSlicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sliceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified network slice.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/slices/{sliceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Slices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sliceName"> The name of the network slice. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sliceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sliceName"/> is null. </exception>
        public virtual async Task<Response<MobileNetworkSliceResource>> GetAsync(string sliceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sliceName, nameof(sliceName));

            using var scope = _mobileNetworkSliceSlicesClientDiagnostics.CreateScope("MobileNetworkSliceCollection.Get");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSliceSlicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sliceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSliceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified network slice.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/slices/{sliceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Slices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sliceName"> The name of the network slice. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sliceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sliceName"/> is null. </exception>
        public virtual Response<MobileNetworkSliceResource> Get(string sliceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sliceName, nameof(sliceName));

            using var scope = _mobileNetworkSliceSlicesClientDiagnostics.CreateScope("MobileNetworkSliceCollection.Get");
            scope.Start();
            try
            {
                var response = _mobileNetworkSliceSlicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sliceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSliceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all slices in the mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/slices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Slices_ListByMobileNetwork</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MobileNetworkSliceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MobileNetworkSliceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileNetworkSliceSlicesRestClient.CreateListByMobileNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileNetworkSliceSlicesRestClient.CreateListByMobileNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new MobileNetworkSliceResource(Client, MobileNetworkSliceData.DeserializeMobileNetworkSliceData(e)), _mobileNetworkSliceSlicesClientDiagnostics, Pipeline, "MobileNetworkSliceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all slices in the mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/slices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Slices_ListByMobileNetwork</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MobileNetworkSliceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MobileNetworkSliceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileNetworkSliceSlicesRestClient.CreateListByMobileNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileNetworkSliceSlicesRestClient.CreateListByMobileNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new MobileNetworkSliceResource(Client, MobileNetworkSliceData.DeserializeMobileNetworkSliceData(e)), _mobileNetworkSliceSlicesClientDiagnostics, Pipeline, "MobileNetworkSliceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/slices/{sliceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Slices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sliceName"> The name of the network slice. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sliceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sliceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sliceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sliceName, nameof(sliceName));

            using var scope = _mobileNetworkSliceSlicesClientDiagnostics.CreateScope("MobileNetworkSliceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSliceSlicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sliceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/slices/{sliceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Slices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sliceName"> The name of the network slice. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sliceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sliceName"/> is null. </exception>
        public virtual Response<bool> Exists(string sliceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sliceName, nameof(sliceName));

            using var scope = _mobileNetworkSliceSlicesClientDiagnostics.CreateScope("MobileNetworkSliceCollection.Exists");
            scope.Start();
            try
            {
                var response = _mobileNetworkSliceSlicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sliceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/slices/{sliceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Slices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sliceName"> The name of the network slice. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sliceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sliceName"/> is null. </exception>
        public virtual async Task<NullableResponse<MobileNetworkSliceResource>> GetIfExistsAsync(string sliceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sliceName, nameof(sliceName));

            using var scope = _mobileNetworkSliceSlicesClientDiagnostics.CreateScope("MobileNetworkSliceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSliceSlicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sliceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MobileNetworkSliceResource>(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSliceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/slices/{sliceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Slices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sliceName"> The name of the network slice. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sliceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sliceName"/> is null. </exception>
        public virtual NullableResponse<MobileNetworkSliceResource> GetIfExists(string sliceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sliceName, nameof(sliceName));

            using var scope = _mobileNetworkSliceSlicesClientDiagnostics.CreateScope("MobileNetworkSliceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mobileNetworkSliceSlicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sliceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MobileNetworkSliceResource>(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSliceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MobileNetworkSliceResource> IEnumerable<MobileNetworkSliceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MobileNetworkSliceResource> IAsyncEnumerable<MobileNetworkSliceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
