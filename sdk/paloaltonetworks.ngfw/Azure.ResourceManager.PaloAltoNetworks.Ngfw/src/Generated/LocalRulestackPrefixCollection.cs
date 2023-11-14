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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing a collection of <see cref="LocalRulestackPrefixResource" /> and their operations.
    /// Each <see cref="LocalRulestackPrefixResource" /> in the collection will belong to the same instance of <see cref="LocalRulestackResource" />.
    /// To get a <see cref="LocalRulestackPrefixCollection" /> instance call the GetLocalRulestackPrefixes method from an instance of <see cref="LocalRulestackResource" />.
    /// </summary>
    public partial class LocalRulestackPrefixCollection : ArmCollection, IEnumerable<LocalRulestackPrefixResource>, IAsyncEnumerable<LocalRulestackPrefixResource>
    {
        private readonly ClientDiagnostics _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics;
        private readonly PrefixListLocalRulestackRestOperations _localRulestackPrefixPrefixListLocalRulestackRestClient;

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackPrefixCollection"/> class for mocking. </summary>
        protected LocalRulestackPrefixCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackPrefixCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LocalRulestackPrefixCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", LocalRulestackPrefixResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LocalRulestackPrefixResource.ResourceType, out string localRulestackPrefixPrefixListLocalRulestackApiVersion);
            _localRulestackPrefixPrefixListLocalRulestackRestClient = new PrefixListLocalRulestackRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, localRulestackPrefixPrefixListLocalRulestackApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LocalRulestackResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LocalRulestackResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a PrefixListResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListLocalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LocalRulestackPrefixResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, LocalRulestackPrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _localRulestackPrefixPrefixListLocalRulestackRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<LocalRulestackPrefixResource>(new LocalRulestackPrefixOperationSource(Client), _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics, Pipeline, _localRulestackPrefixPrefixListLocalRulestackRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a PrefixListResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListLocalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LocalRulestackPrefixResource> CreateOrUpdate(WaitUntil waitUntil, string name, LocalRulestackPrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _localRulestackPrefixPrefixListLocalRulestackRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new NgfwArmOperation<LocalRulestackPrefixResource>(new LocalRulestackPrefixOperationSource(Client), _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics, Pipeline, _localRulestackPrefixPrefixListLocalRulestackRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a PrefixListResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<LocalRulestackPrefixResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = await _localRulestackPrefixPrefixListLocalRulestackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a PrefixListResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<LocalRulestackPrefixResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = _localRulestackPrefixPrefixListLocalRulestackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List PrefixListResource resources by LocalRulestacks
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/prefixlists</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListLocalRulestack_ListByLocalRulestacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LocalRulestackPrefixResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LocalRulestackPrefixResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _localRulestackPrefixPrefixListLocalRulestackRestClient.CreateListByLocalRulestacksRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _localRulestackPrefixPrefixListLocalRulestackRestClient.CreateListByLocalRulestacksNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new LocalRulestackPrefixResource(Client, LocalRulestackPrefixData.DeserializeLocalRulestackPrefixData(e)), _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics, Pipeline, "LocalRulestackPrefixCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List PrefixListResource resources by LocalRulestacks
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/prefixlists</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListLocalRulestack_ListByLocalRulestacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LocalRulestackPrefixResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LocalRulestackPrefixResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _localRulestackPrefixPrefixListLocalRulestackRestClient.CreateListByLocalRulestacksRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _localRulestackPrefixPrefixListLocalRulestackRestClient.CreateListByLocalRulestacksNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new LocalRulestackPrefixResource(Client, LocalRulestackPrefixData.DeserializeLocalRulestackPrefixData(e)), _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics, Pipeline, "LocalRulestackPrefixCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackPrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = await _localRulestackPrefixPrefixListLocalRulestackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackPrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = _localRulestackPrefixPrefixListLocalRulestackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<LocalRulestackPrefixResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackPrefixCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _localRulestackPrefixPrefixListLocalRulestackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LocalRulestackPrefixResource>(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackPrefixResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<LocalRulestackPrefixResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackPrefixPrefixListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackPrefixCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _localRulestackPrefixPrefixListLocalRulestackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LocalRulestackPrefixResource>(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LocalRulestackPrefixResource> IEnumerable<LocalRulestackPrefixResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LocalRulestackPrefixResource> IAsyncEnumerable<LocalRulestackPrefixResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
