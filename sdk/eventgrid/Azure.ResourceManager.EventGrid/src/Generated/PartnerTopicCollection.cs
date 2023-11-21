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

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="PartnerTopicResource"/> and their operations.
    /// Each <see cref="PartnerTopicResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="PartnerTopicCollection"/> instance call the GetPartnerTopics method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class PartnerTopicCollection : ArmCollection, IEnumerable<PartnerTopicResource>, IAsyncEnumerable<PartnerTopicResource>
    {
        private readonly ClientDiagnostics _partnerTopicClientDiagnostics;
        private readonly PartnerTopicsRestOperations _partnerTopicRestClient;

        /// <summary> Initializes a new instance of the <see cref="PartnerTopicCollection"/> class for mocking. </summary>
        protected PartnerTopicCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PartnerTopicCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PartnerTopicCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _partnerTopicClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", PartnerTopicResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PartnerTopicResource.ResourceType, out string partnerTopicApiVersion);
            _partnerTopicRestClient = new PartnerTopicsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, partnerTopicApiVersion);
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
        /// Asynchronously creates a new partner topic with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerTopics_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="partnerTopicName"> Name of the partner topic. </param>
        /// <param name="data"> Partner Topic information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerTopicName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PartnerTopicResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string partnerTopicName, PartnerTopicData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerTopicName, nameof(partnerTopicName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _partnerTopicClientDiagnostics.CreateScope("PartnerTopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _partnerTopicRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, partnerTopicName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<PartnerTopicResource>(Response.FromValue(new PartnerTopicResource(Client, response), response.GetRawResponse()));
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
        /// Asynchronously creates a new partner topic with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerTopics_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="partnerTopicName"> Name of the partner topic. </param>
        /// <param name="data"> Partner Topic information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerTopicName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PartnerTopicResource> CreateOrUpdate(WaitUntil waitUntil, string partnerTopicName, PartnerTopicData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerTopicName, nameof(partnerTopicName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _partnerTopicClientDiagnostics.CreateScope("PartnerTopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _partnerTopicRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, partnerTopicName, data, cancellationToken);
                var operation = new EventGridArmOperation<PartnerTopicResource>(Response.FromValue(new PartnerTopicResource(Client, response), response.GetRawResponse()));
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
        /// Get properties of a partner topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerTopicName"> Name of the partner topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerTopicName"/> is null. </exception>
        public virtual async Task<Response<PartnerTopicResource>> GetAsync(string partnerTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerTopicName, nameof(partnerTopicName));

            using var scope = _partnerTopicClientDiagnostics.CreateScope("PartnerTopicCollection.Get");
            scope.Start();
            try
            {
                var response = await _partnerTopicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, partnerTopicName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PartnerTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a partner topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerTopicName"> Name of the partner topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerTopicName"/> is null. </exception>
        public virtual Response<PartnerTopicResource> Get(string partnerTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerTopicName, nameof(partnerTopicName));

            using var scope = _partnerTopicClientDiagnostics.CreateScope("PartnerTopicCollection.Get");
            scope.Start();
            try
            {
                var response = _partnerTopicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, partnerTopicName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PartnerTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the partner topics under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerTopics_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PartnerTopicResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PartnerTopicResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _partnerTopicRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _partnerTopicRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new PartnerTopicResource(Client, PartnerTopicData.DeserializePartnerTopicData(e)), _partnerTopicClientDiagnostics, Pipeline, "PartnerTopicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the partner topics under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerTopics_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PartnerTopicResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PartnerTopicResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _partnerTopicRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _partnerTopicRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new PartnerTopicResource(Client, PartnerTopicData.DeserializePartnerTopicData(e)), _partnerTopicClientDiagnostics, Pipeline, "PartnerTopicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerTopicName"> Name of the partner topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerTopicName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string partnerTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerTopicName, nameof(partnerTopicName));

            using var scope = _partnerTopicClientDiagnostics.CreateScope("PartnerTopicCollection.Exists");
            scope.Start();
            try
            {
                var response = await _partnerTopicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, partnerTopicName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerTopicName"> Name of the partner topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerTopicName"/> is null. </exception>
        public virtual Response<bool> Exists(string partnerTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerTopicName, nameof(partnerTopicName));

            using var scope = _partnerTopicClientDiagnostics.CreateScope("PartnerTopicCollection.Exists");
            scope.Start();
            try
            {
                var response = _partnerTopicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, partnerTopicName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerTopicName"> Name of the partner topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerTopicName"/> is null. </exception>
        public virtual async Task<NullableResponse<PartnerTopicResource>> GetIfExistsAsync(string partnerTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerTopicName, nameof(partnerTopicName));

            using var scope = _partnerTopicClientDiagnostics.CreateScope("PartnerTopicCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _partnerTopicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, partnerTopicName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PartnerTopicResource>(response.GetRawResponse());
                return Response.FromValue(new PartnerTopicResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerTopicName"> Name of the partner topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerTopicName"/> is null. </exception>
        public virtual NullableResponse<PartnerTopicResource> GetIfExists(string partnerTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerTopicName, nameof(partnerTopicName));

            using var scope = _partnerTopicClientDiagnostics.CreateScope("PartnerTopicCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _partnerTopicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, partnerTopicName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PartnerTopicResource>(response.GetRawResponse());
                return Response.FromValue(new PartnerTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PartnerTopicResource> IEnumerable<PartnerTopicResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PartnerTopicResource> IAsyncEnumerable<PartnerTopicResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
