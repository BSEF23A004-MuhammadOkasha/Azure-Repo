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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="DiskImageResource"/> and their operations.
    /// Each <see cref="DiskImageResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DiskImageCollection"/> instance call the GetDiskImages method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DiskImageCollection : ArmCollection, IEnumerable<DiskImageResource>, IAsyncEnumerable<DiskImageResource>
    {
        private readonly ClientDiagnostics _diskImageImagesClientDiagnostics;
        private readonly ImagesRestOperations _diskImageImagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiskImageCollection"/> class for mocking. </summary>
        protected DiskImageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiskImageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiskImageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diskImageImagesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", DiskImageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DiskImageResource.ResourceType, out string diskImageImagesApiVersion);
            _diskImageImagesRestClient = new ImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diskImageImagesApiVersion);
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
        /// Create or update an image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="data"> Parameters supplied to the Create Image operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DiskImageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string imageName, DiskImageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diskImageImagesClientDiagnostics.CreateScope("DiskImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diskImageImagesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, imageName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<DiskImageResource>(new DiskImageOperationSource(Client), _diskImageImagesClientDiagnostics, Pipeline, _diskImageImagesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, imageName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="data"> Parameters supplied to the Create Image operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DiskImageResource> CreateOrUpdate(WaitUntil waitUntil, string imageName, DiskImageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diskImageImagesClientDiagnostics.CreateScope("DiskImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diskImageImagesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, imageName, data, cancellationToken);
                var operation = new ComputeArmOperation<DiskImageResource>(new DiskImageOperationSource(Client), _diskImageImagesClientDiagnostics, Pipeline, _diskImageImagesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, imageName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual async Task<Response<DiskImageResource>> GetAsync(string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _diskImageImagesClientDiagnostics.CreateScope("DiskImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _diskImageImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, imageName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual Response<DiskImageResource> Get(string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _diskImageImagesClientDiagnostics.CreateScope("DiskImageCollection.Get");
            scope.Start();
            try
            {
                var response = _diskImageImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, imageName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of images under a resource group. Use nextLink property in the response to get the next page of Images. Do this till nextLink is null to fetch all the Images.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskImageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diskImageImagesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _diskImageImagesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DiskImageResource(Client, DiskImageData.DeserializeDiskImageData(e)), _diskImageImagesClientDiagnostics, Pipeline, "DiskImageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of images under a resource group. Use nextLink property in the response to get the next page of Images. Do this till nextLink is null to fetch all the Images.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskImageResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diskImageImagesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _diskImageImagesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DiskImageResource(Client, DiskImageData.DeserializeDiskImageData(e)), _diskImageImagesClientDiagnostics, Pipeline, "DiskImageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _diskImageImagesClientDiagnostics.CreateScope("DiskImageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _diskImageImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, imageName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual Response<bool> Exists(string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _diskImageImagesClientDiagnostics.CreateScope("DiskImageCollection.Exists");
            scope.Start();
            try
            {
                var response = _diskImageImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, imageName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual async Task<NullableResponse<DiskImageResource>> GetIfExistsAsync(string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _diskImageImagesClientDiagnostics.CreateScope("DiskImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diskImageImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, imageName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DiskImageResource>(response.GetRawResponse());
                return Response.FromValue(new DiskImageResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual NullableResponse<DiskImageResource> GetIfExists(string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _diskImageImagesClientDiagnostics.CreateScope("DiskImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diskImageImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, imageName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DiskImageResource>(response.GetRawResponse());
                return Response.FromValue(new DiskImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiskImageResource> IEnumerable<DiskImageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiskImageResource> IAsyncEnumerable<DiskImageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
