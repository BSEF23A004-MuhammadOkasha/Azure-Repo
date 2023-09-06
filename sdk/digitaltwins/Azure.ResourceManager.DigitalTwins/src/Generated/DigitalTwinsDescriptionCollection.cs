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

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary>
    /// A class representing a collection of <see cref="DigitalTwinsDescriptionResource" /> and their operations.
    /// Each <see cref="DigitalTwinsDescriptionResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DigitalTwinsDescriptionCollection" /> instance call the GetDigitalTwinsDescriptions method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DigitalTwinsDescriptionCollection : ArmCollection, IEnumerable<DigitalTwinsDescriptionResource>, IAsyncEnumerable<DigitalTwinsDescriptionResource>
    {
        private readonly ClientDiagnostics _digitalTwinsDescriptionDigitalTwinsClientDiagnostics;
        private readonly DigitalTwinsRestOperations _digitalTwinsDescriptionDigitalTwinsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DigitalTwinsDescriptionCollection"/> class for mocking. </summary>
        protected DigitalTwinsDescriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DigitalTwinsDescriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DigitalTwinsDescriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _digitalTwinsDescriptionDigitalTwinsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DigitalTwins", DigitalTwinsDescriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DigitalTwinsDescriptionResource.ResourceType, out string digitalTwinsDescriptionDigitalTwinsApiVersion);
            _digitalTwinsDescriptionDigitalTwinsRestClient = new DigitalTwinsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, digitalTwinsDescriptionDigitalTwinsApiVersion);
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
        /// Create or update the metadata of a DigitalTwinsInstance. The usual pattern to modify a property is to retrieve the DigitalTwinsInstance and security metadata, and then combine them with the modified values in a new body to update the DigitalTwinsInstance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="data"> The DigitalTwinsInstance and security metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DigitalTwinsDescriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceName, DigitalTwinsDescriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _digitalTwinsDescriptionDigitalTwinsClientDiagnostics.CreateScope("DigitalTwinsDescriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _digitalTwinsDescriptionDigitalTwinsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DigitalTwinsArmOperation<DigitalTwinsDescriptionResource>(new DigitalTwinsDescriptionOperationSource(Client), _digitalTwinsDescriptionDigitalTwinsClientDiagnostics, Pipeline, _digitalTwinsDescriptionDigitalTwinsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update the metadata of a DigitalTwinsInstance. The usual pattern to modify a property is to retrieve the DigitalTwinsInstance and security metadata, and then combine them with the modified values in a new body to update the DigitalTwinsInstance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="data"> The DigitalTwinsInstance and security metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DigitalTwinsDescriptionResource> CreateOrUpdate(WaitUntil waitUntil, string resourceName, DigitalTwinsDescriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _digitalTwinsDescriptionDigitalTwinsClientDiagnostics.CreateScope("DigitalTwinsDescriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _digitalTwinsDescriptionDigitalTwinsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, cancellationToken);
                var operation = new DigitalTwinsArmOperation<DigitalTwinsDescriptionResource>(new DigitalTwinsDescriptionOperationSource(Client), _digitalTwinsDescriptionDigitalTwinsClientDiagnostics, Pipeline, _digitalTwinsDescriptionDigitalTwinsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get DigitalTwinsInstances resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<DigitalTwinsDescriptionResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _digitalTwinsDescriptionDigitalTwinsClientDiagnostics.CreateScope("DigitalTwinsDescriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _digitalTwinsDescriptionDigitalTwinsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DigitalTwinsDescriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get DigitalTwinsInstances resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<DigitalTwinsDescriptionResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _digitalTwinsDescriptionDigitalTwinsClientDiagnostics.CreateScope("DigitalTwinsDescriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _digitalTwinsDescriptionDigitalTwinsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DigitalTwinsDescriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all the DigitalTwinsInstances in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DigitalTwinsDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DigitalTwinsDescriptionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _digitalTwinsDescriptionDigitalTwinsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _digitalTwinsDescriptionDigitalTwinsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DigitalTwinsDescriptionResource(Client, DigitalTwinsDescriptionData.DeserializeDigitalTwinsDescriptionData(e)), _digitalTwinsDescriptionDigitalTwinsClientDiagnostics, Pipeline, "DigitalTwinsDescriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the DigitalTwinsInstances in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DigitalTwinsDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DigitalTwinsDescriptionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _digitalTwinsDescriptionDigitalTwinsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _digitalTwinsDescriptionDigitalTwinsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DigitalTwinsDescriptionResource(Client, DigitalTwinsDescriptionData.DeserializeDigitalTwinsDescriptionData(e)), _digitalTwinsDescriptionDigitalTwinsClientDiagnostics, Pipeline, "DigitalTwinsDescriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _digitalTwinsDescriptionDigitalTwinsClientDiagnostics.CreateScope("DigitalTwinsDescriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _digitalTwinsDescriptionDigitalTwinsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _digitalTwinsDescriptionDigitalTwinsClientDiagnostics.CreateScope("DigitalTwinsDescriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _digitalTwinsDescriptionDigitalTwinsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DigitalTwinsDescriptionResource> IEnumerable<DigitalTwinsDescriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DigitalTwinsDescriptionResource> IAsyncEnumerable<DigitalTwinsDescriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
