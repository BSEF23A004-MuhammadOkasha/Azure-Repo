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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing a collection of <see cref="LocalRulestackResource" /> and their operations.
    /// Each <see cref="LocalRulestackResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="LocalRulestackCollection" /> instance call the GetLocalRulestacks method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class LocalRulestackCollection : ArmCollection, IEnumerable<LocalRulestackResource>, IAsyncEnumerable<LocalRulestackResource>
    {
        private readonly ClientDiagnostics _localRulestackClientDiagnostics;
        private readonly LocalRulestacksRestOperations _localRulestackRestClient;

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackCollection"/> class for mocking. </summary>
        protected LocalRulestackCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LocalRulestackCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _localRulestackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", LocalRulestackResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LocalRulestackResource.ResourceType, out string localRulestackApiVersion);
            _localRulestackRestClient = new LocalRulestacksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, localRulestackApiVersion);
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
        /// Create a LocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="localRulestackName"> LocalRulestack resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localRulestackName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LocalRulestackResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string localRulestackName, LocalRulestackData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localRulestackName, nameof(localRulestackName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localRulestackClientDiagnostics.CreateScope("LocalRulestackCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _localRulestackRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, localRulestackName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<LocalRulestackResource>(new LocalRulestackOperationSource(Client), _localRulestackClientDiagnostics, Pipeline, _localRulestackRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, localRulestackName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a LocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="localRulestackName"> LocalRulestack resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localRulestackName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LocalRulestackResource> CreateOrUpdate(WaitUntil waitUntil, string localRulestackName, LocalRulestackData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localRulestackName, nameof(localRulestackName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localRulestackClientDiagnostics.CreateScope("LocalRulestackCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _localRulestackRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, localRulestackName, data, cancellationToken);
                var operation = new NgfwArmOperation<LocalRulestackResource>(new LocalRulestackOperationSource(Client), _localRulestackClientDiagnostics, Pipeline, _localRulestackRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, localRulestackName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a LocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="localRulestackName"> LocalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localRulestackName"/> is null. </exception>
        public virtual async Task<Response<LocalRulestackResource>> GetAsync(string localRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localRulestackName, nameof(localRulestackName));

            using var scope = _localRulestackClientDiagnostics.CreateScope("LocalRulestackCollection.Get");
            scope.Start();
            try
            {
                var response = await _localRulestackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, localRulestackName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a LocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="localRulestackName"> LocalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localRulestackName"/> is null. </exception>
        public virtual Response<LocalRulestackResource> Get(string localRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localRulestackName, nameof(localRulestackName));

            using var scope = _localRulestackClientDiagnostics.CreateScope("LocalRulestackCollection.Get");
            scope.Start();
            try
            {
                var response = _localRulestackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, localRulestackName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List LocalRulestackResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LocalRulestackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LocalRulestackResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _localRulestackRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _localRulestackRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new LocalRulestackResource(Client, LocalRulestackData.DeserializeLocalRulestackData(e)), _localRulestackClientDiagnostics, Pipeline, "LocalRulestackCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List LocalRulestackResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LocalRulestackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LocalRulestackResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _localRulestackRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _localRulestackRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new LocalRulestackResource(Client, LocalRulestackData.DeserializeLocalRulestackData(e)), _localRulestackClientDiagnostics, Pipeline, "LocalRulestackCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="localRulestackName"> LocalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localRulestackName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string localRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localRulestackName, nameof(localRulestackName));

            using var scope = _localRulestackClientDiagnostics.CreateScope("LocalRulestackCollection.Exists");
            scope.Start();
            try
            {
                var response = await _localRulestackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, localRulestackName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="localRulestackName"> LocalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localRulestackName"/> is null. </exception>
        public virtual Response<bool> Exists(string localRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localRulestackName, nameof(localRulestackName));

            using var scope = _localRulestackClientDiagnostics.CreateScope("LocalRulestackCollection.Exists");
            scope.Start();
            try
            {
                var response = _localRulestackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, localRulestackName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="localRulestackName"> LocalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localRulestackName"/> is null. </exception>
        public virtual async Task<NullableResponse<LocalRulestackResource>> GetIfExistsAsync(string localRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localRulestackName, nameof(localRulestackName));

            using var scope = _localRulestackClientDiagnostics.CreateScope("LocalRulestackCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _localRulestackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, localRulestackName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LocalRulestackResource>(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="localRulestackName"> LocalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localRulestackName"/> is null. </exception>
        public virtual NullableResponse<LocalRulestackResource> GetIfExists(string localRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localRulestackName, nameof(localRulestackName));

            using var scope = _localRulestackClientDiagnostics.CreateScope("LocalRulestackCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _localRulestackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, localRulestackName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LocalRulestackResource>(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LocalRulestackResource> IEnumerable<LocalRulestackResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LocalRulestackResource> IAsyncEnumerable<LocalRulestackResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
