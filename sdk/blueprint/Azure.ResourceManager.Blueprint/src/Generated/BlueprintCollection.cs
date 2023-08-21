// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Blueprint
{
    /// <summary>
    /// A class representing a collection of <see cref="BlueprintResource" /> and their operations.
    /// Each <see cref="BlueprintResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="BlueprintCollection" /> instance call the GetBlueprints method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class BlueprintCollection : ArmCollection, IEnumerable<BlueprintResource>, IAsyncEnumerable<BlueprintResource>
    {
        private readonly ClientDiagnostics _blueprintClientDiagnostics;
        private readonly BlueprintsRestOperations _blueprintRestClient;

        /// <summary> Initializes a new instance of the <see cref="BlueprintCollection"/> class for mocking. </summary>
        protected BlueprintCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BlueprintCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BlueprintCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _blueprintClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Blueprint", BlueprintResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BlueprintResource.ResourceType, out string blueprintApiVersion);
            _blueprintRestClient = new BlueprintsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, blueprintApiVersion);
        }

        /// <summary>
        /// Create or update a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="data"> Blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="blueprintName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BlueprintResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string blueprintName, BlueprintData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _blueprintClientDiagnostics.CreateScope("BlueprintCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _blueprintRestClient.CreateOrUpdateAsync(Id, blueprintName, data, cancellationToken).ConfigureAwait(false);
                var operation = new BlueprintArmOperation<BlueprintResource>(Response.FromValue(new BlueprintResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="data"> Blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="blueprintName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BlueprintResource> CreateOrUpdate(WaitUntil waitUntil, string blueprintName, BlueprintData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _blueprintClientDiagnostics.CreateScope("BlueprintCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _blueprintRestClient.CreateOrUpdate(Id, blueprintName, data, cancellationToken);
                var operation = new BlueprintArmOperation<BlueprintResource>(Response.FromValue(new BlueprintResource(Client, response), response.GetRawResponse()));
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
        /// Get a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="blueprintName"/> is null. </exception>
        public virtual async Task<Response<BlueprintResource>> GetAsync(string blueprintName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));

            using var scope = _blueprintClientDiagnostics.CreateScope("BlueprintCollection.Get");
            scope.Start();
            try
            {
                var response = await _blueprintRestClient.GetAsync(Id, blueprintName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlueprintResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="blueprintName"/> is null. </exception>
        public virtual Response<BlueprintResource> Get(string blueprintName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));

            using var scope = _blueprintClientDiagnostics.CreateScope("BlueprintCollection.Get");
            scope.Start();
            try
            {
                var response = _blueprintRestClient.Get(Id, blueprintName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlueprintResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List blueprint definitions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BlueprintResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BlueprintResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _blueprintRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _blueprintRestClient.CreateListNextPageRequest(nextLink, Id);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BlueprintResource(Client, BlueprintData.DeserializeBlueprintData(e)), _blueprintClientDiagnostics, Pipeline, "BlueprintCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List blueprint definitions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BlueprintResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BlueprintResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _blueprintRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _blueprintRestClient.CreateListNextPageRequest(nextLink, Id);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BlueprintResource(Client, BlueprintData.DeserializeBlueprintData(e)), _blueprintClientDiagnostics, Pipeline, "BlueprintCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="blueprintName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string blueprintName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));

            using var scope = _blueprintClientDiagnostics.CreateScope("BlueprintCollection.Exists");
            scope.Start();
            try
            {
                var response = await _blueprintRestClient.GetAsync(Id, blueprintName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="blueprintName"/> is null. </exception>
        public virtual Response<bool> Exists(string blueprintName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));

            using var scope = _blueprintClientDiagnostics.CreateScope("BlueprintCollection.Exists");
            scope.Start();
            try
            {
                var response = _blueprintRestClient.Get(Id, blueprintName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BlueprintResource> IEnumerable<BlueprintResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BlueprintResource> IAsyncEnumerable<BlueprintResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
