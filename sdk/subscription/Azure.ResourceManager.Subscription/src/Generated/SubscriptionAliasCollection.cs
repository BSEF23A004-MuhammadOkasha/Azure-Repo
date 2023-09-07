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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Subscription.Models;

namespace Azure.ResourceManager.Subscription
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionAliasResource" /> and their operations.
    /// Each <see cref="SubscriptionAliasResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="SubscriptionAliasCollection" /> instance call the GetSubscriptionAliases method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class SubscriptionAliasCollection : ArmCollection, IEnumerable<SubscriptionAliasResource>, IAsyncEnumerable<SubscriptionAliasResource>
    {
        private readonly ClientDiagnostics _subscriptionAliasAliasClientDiagnostics;
        private readonly AliasRestOperations _subscriptionAliasAliasRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionAliasCollection"/> class for mocking. </summary>
        protected SubscriptionAliasCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionAliasCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubscriptionAliasCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionAliasAliasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Subscription", SubscriptionAliasResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionAliasResource.ResourceType, out string subscriptionAliasAliasApiVersion);
            _subscriptionAliasAliasRestClient = new AliasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionAliasAliasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Alias Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="aliasName"> AliasName is the name for the subscription creation request. Note that this is not the same as subscription name and this doesn’t have any other lifecycle need beyond the request for subscription creation. </param>
        /// <param name="content"> The SubscriptionAliasCreateOrUpdateContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionAliasResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string aliasName, SubscriptionAliasCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _subscriptionAliasAliasClientDiagnostics.CreateScope("SubscriptionAliasCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subscriptionAliasAliasRestClient.CreateAsync(aliasName, content, cancellationToken).ConfigureAwait(false);
                var operation = new SubscriptionArmOperation<SubscriptionAliasResource>(new SubscriptionAliasOperationSource(Client), _subscriptionAliasAliasClientDiagnostics, Pipeline, _subscriptionAliasAliasRestClient.CreateCreateRequest(aliasName, content).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Create Alias Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="aliasName"> AliasName is the name for the subscription creation request. Note that this is not the same as subscription name and this doesn’t have any other lifecycle need beyond the request for subscription creation. </param>
        /// <param name="content"> The SubscriptionAliasCreateOrUpdateContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SubscriptionAliasResource> CreateOrUpdate(WaitUntil waitUntil, string aliasName, SubscriptionAliasCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _subscriptionAliasAliasClientDiagnostics.CreateScope("SubscriptionAliasCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subscriptionAliasAliasRestClient.Create(aliasName, content, cancellationToken);
                var operation = new SubscriptionArmOperation<SubscriptionAliasResource>(new SubscriptionAliasOperationSource(Client), _subscriptionAliasAliasClientDiagnostics, Pipeline, _subscriptionAliasAliasRestClient.CreateCreateRequest(aliasName, content).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Get Alias Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aliasName"> AliasName is the name for the subscription creation request. Note that this is not the same as subscription name and this doesn’t have any other lifecycle need beyond the request for subscription creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> is null. </exception>
        public virtual async Task<Response<SubscriptionAliasResource>> GetAsync(string aliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));

            using var scope = _subscriptionAliasAliasClientDiagnostics.CreateScope("SubscriptionAliasCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionAliasAliasRestClient.GetAsync(aliasName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Alias Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aliasName"> AliasName is the name for the subscription creation request. Note that this is not the same as subscription name and this doesn’t have any other lifecycle need beyond the request for subscription creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> is null. </exception>
        public virtual Response<SubscriptionAliasResource> Get(string aliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));

            using var scope = _subscriptionAliasAliasClientDiagnostics.CreateScope("SubscriptionAliasCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionAliasAliasRestClient.Get(aliasName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Alias Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionAliasResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionAliasResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionAliasAliasRestClient.CreateListRequest();
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new SubscriptionAliasResource(Client, SubscriptionAliasData.DeserializeSubscriptionAliasData(e)), _subscriptionAliasAliasClientDiagnostics, Pipeline, "SubscriptionAliasCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List Alias Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionAliasResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionAliasResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionAliasAliasRestClient.CreateListRequest();
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new SubscriptionAliasResource(Client, SubscriptionAliasData.DeserializeSubscriptionAliasData(e)), _subscriptionAliasAliasClientDiagnostics, Pipeline, "SubscriptionAliasCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aliasName"> AliasName is the name for the subscription creation request. Note that this is not the same as subscription name and this doesn’t have any other lifecycle need beyond the request for subscription creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string aliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));

            using var scope = _subscriptionAliasAliasClientDiagnostics.CreateScope("SubscriptionAliasCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionAliasAliasRestClient.GetAsync(aliasName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aliasName"> AliasName is the name for the subscription creation request. Note that this is not the same as subscription name and this doesn’t have any other lifecycle need beyond the request for subscription creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> is null. </exception>
        public virtual Response<bool> Exists(string aliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));

            using var scope = _subscriptionAliasAliasClientDiagnostics.CreateScope("SubscriptionAliasCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionAliasAliasRestClient.Get(aliasName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionAliasResource> IEnumerable<SubscriptionAliasResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionAliasResource> IAsyncEnumerable<SubscriptionAliasResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
