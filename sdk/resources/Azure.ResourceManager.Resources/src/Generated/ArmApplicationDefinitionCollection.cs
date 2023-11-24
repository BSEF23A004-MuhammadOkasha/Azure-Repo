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

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="ArmApplicationDefinitionResource"/> and their operations.
    /// Each <see cref="ArmApplicationDefinitionResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="ArmApplicationDefinitionCollection"/> instance call the GetArmApplicationDefinitions method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ArmApplicationDefinitionCollection : ArmCollection, IEnumerable<ArmApplicationDefinitionResource>, IAsyncEnumerable<ArmApplicationDefinitionResource>
    {
        private readonly ClientDiagnostics _armApplicationDefinitionApplicationDefinitionsClientDiagnostics;
        private readonly ApplicationDefinitionsRestOperations _armApplicationDefinitionApplicationDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ArmApplicationDefinitionCollection"/> class for mocking. </summary>
        protected ArmApplicationDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArmApplicationDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ArmApplicationDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _armApplicationDefinitionApplicationDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ArmApplicationDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ArmApplicationDefinitionResource.ResourceType, out string armApplicationDefinitionApplicationDefinitionsApiVersion);
            _armApplicationDefinitionApplicationDefinitionsRestClient = new ApplicationDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, armApplicationDefinitionApplicationDefinitionsApiVersion);
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
        /// Creates a new managed application definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applicationDefinitions/{applicationDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationDefinitions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="data"> Parameters supplied to the create or update an managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationDefinitionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ArmApplicationDefinitionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationDefinitionName, ArmApplicationDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationDefinitionName, nameof(applicationDefinitionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _armApplicationDefinitionApplicationDefinitionsClientDiagnostics.CreateScope("ArmApplicationDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _armApplicationDefinitionApplicationDefinitionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationDefinitionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<ArmApplicationDefinitionResource>(new ArmApplicationDefinitionOperationSource(Client), _armApplicationDefinitionApplicationDefinitionsClientDiagnostics, Pipeline, _armApplicationDefinitionApplicationDefinitionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, applicationDefinitionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new managed application definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applicationDefinitions/{applicationDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationDefinitions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="data"> Parameters supplied to the create or update an managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationDefinitionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ArmApplicationDefinitionResource> CreateOrUpdate(WaitUntil waitUntil, string applicationDefinitionName, ArmApplicationDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationDefinitionName, nameof(applicationDefinitionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _armApplicationDefinitionApplicationDefinitionsClientDiagnostics.CreateScope("ArmApplicationDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _armApplicationDefinitionApplicationDefinitionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, applicationDefinitionName, data, cancellationToken);
                var operation = new ResourcesArmOperation<ArmApplicationDefinitionResource>(new ArmApplicationDefinitionOperationSource(Client), _armApplicationDefinitionApplicationDefinitionsClientDiagnostics, Pipeline, _armApplicationDefinitionApplicationDefinitionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, applicationDefinitionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the managed application definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applicationDefinitions/{applicationDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationDefinitionName"/> is null. </exception>
        public virtual async Task<Response<ArmApplicationDefinitionResource>> GetAsync(string applicationDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationDefinitionName, nameof(applicationDefinitionName));

            using var scope = _armApplicationDefinitionApplicationDefinitionsClientDiagnostics.CreateScope("ArmApplicationDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _armApplicationDefinitionApplicationDefinitionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArmApplicationDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the managed application definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applicationDefinitions/{applicationDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationDefinitionName"/> is null. </exception>
        public virtual Response<ArmApplicationDefinitionResource> Get(string applicationDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationDefinitionName, nameof(applicationDefinitionName));

            using var scope = _armApplicationDefinitionApplicationDefinitionsClientDiagnostics.CreateScope("ArmApplicationDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _armApplicationDefinitionApplicationDefinitionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArmApplicationDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the managed application definitions in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applicationDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationDefinitions_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ArmApplicationDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ArmApplicationDefinitionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _armApplicationDefinitionApplicationDefinitionsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _armApplicationDefinitionApplicationDefinitionsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ArmApplicationDefinitionResource(Client, ArmApplicationDefinitionData.DeserializeArmApplicationDefinitionData(e)), _armApplicationDefinitionApplicationDefinitionsClientDiagnostics, Pipeline, "ArmApplicationDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the managed application definitions in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applicationDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationDefinitions_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ArmApplicationDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ArmApplicationDefinitionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _armApplicationDefinitionApplicationDefinitionsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _armApplicationDefinitionApplicationDefinitionsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ArmApplicationDefinitionResource(Client, ArmApplicationDefinitionData.DeserializeArmApplicationDefinitionData(e)), _armApplicationDefinitionApplicationDefinitionsClientDiagnostics, Pipeline, "ArmApplicationDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applicationDefinitions/{applicationDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationDefinitionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationDefinitionName, nameof(applicationDefinitionName));

            using var scope = _armApplicationDefinitionApplicationDefinitionsClientDiagnostics.CreateScope("ArmApplicationDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _armApplicationDefinitionApplicationDefinitionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applicationDefinitions/{applicationDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationDefinitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationDefinitionName, nameof(applicationDefinitionName));

            using var scope = _armApplicationDefinitionApplicationDefinitionsClientDiagnostics.CreateScope("ArmApplicationDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _armApplicationDefinitionApplicationDefinitionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationDefinitionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applicationDefinitions/{applicationDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationDefinitionName"/> is null. </exception>
        public virtual async Task<NullableResponse<ArmApplicationDefinitionResource>> GetIfExistsAsync(string applicationDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationDefinitionName, nameof(applicationDefinitionName));

            using var scope = _armApplicationDefinitionApplicationDefinitionsClientDiagnostics.CreateScope("ArmApplicationDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _armApplicationDefinitionApplicationDefinitionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ArmApplicationDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new ArmApplicationDefinitionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applicationDefinitions/{applicationDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationDefinitionName"/> is null. </exception>
        public virtual NullableResponse<ArmApplicationDefinitionResource> GetIfExists(string applicationDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationDefinitionName, nameof(applicationDefinitionName));

            using var scope = _armApplicationDefinitionApplicationDefinitionsClientDiagnostics.CreateScope("ArmApplicationDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _armApplicationDefinitionApplicationDefinitionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationDefinitionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ArmApplicationDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new ArmApplicationDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ArmApplicationDefinitionResource> IEnumerable<ArmApplicationDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ArmApplicationDefinitionResource> IAsyncEnumerable<ArmApplicationDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
