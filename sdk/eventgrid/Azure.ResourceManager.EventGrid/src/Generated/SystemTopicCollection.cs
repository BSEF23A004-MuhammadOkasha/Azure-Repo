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
    /// A class representing a collection of <see cref="SystemTopicResource"/> and their operations.
    /// Each <see cref="SystemTopicResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="SystemTopicCollection"/> instance call the GetSystemTopics method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class SystemTopicCollection : ArmCollection, IEnumerable<SystemTopicResource>, IAsyncEnumerable<SystemTopicResource>
    {
        private readonly ClientDiagnostics _systemTopicClientDiagnostics;
        private readonly SystemTopicsRestOperations _systemTopicRestClient;

        /// <summary> Initializes a new instance of the <see cref="SystemTopicCollection"/> class for mocking. </summary>
        protected SystemTopicCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SystemTopicCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SystemTopicCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _systemTopicClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", SystemTopicResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SystemTopicResource.ResourceType, out string systemTopicApiVersion);
            _systemTopicRestClient = new SystemTopicsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, systemTopicApiVersion);
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
        /// Asynchronously creates a new system topic with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopics_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="systemTopicName"> Name of the system topic. </param>
        /// <param name="data"> System Topic information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="systemTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="systemTopicName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SystemTopicResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string systemTopicName, SystemTopicData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(systemTopicName, nameof(systemTopicName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _systemTopicClientDiagnostics.CreateScope("SystemTopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _systemTopicRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, systemTopicName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<SystemTopicResource>(new SystemTopicOperationSource(Client), _systemTopicClientDiagnostics, Pipeline, _systemTopicRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, systemTopicName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Asynchronously creates a new system topic with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopics_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="systemTopicName"> Name of the system topic. </param>
        /// <param name="data"> System Topic information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="systemTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="systemTopicName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SystemTopicResource> CreateOrUpdate(WaitUntil waitUntil, string systemTopicName, SystemTopicData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(systemTopicName, nameof(systemTopicName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _systemTopicClientDiagnostics.CreateScope("SystemTopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _systemTopicRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, systemTopicName, data, cancellationToken);
                var operation = new EventGridArmOperation<SystemTopicResource>(new SystemTopicOperationSource(Client), _systemTopicClientDiagnostics, Pipeline, _systemTopicRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, systemTopicName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get properties of a system topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="systemTopicName"> Name of the system topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="systemTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="systemTopicName"/> is null. </exception>
        public virtual async Task<Response<SystemTopicResource>> GetAsync(string systemTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(systemTopicName, nameof(systemTopicName));

            using var scope = _systemTopicClientDiagnostics.CreateScope("SystemTopicCollection.Get");
            scope.Start();
            try
            {
                var response = await _systemTopicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, systemTopicName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SystemTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a system topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="systemTopicName"> Name of the system topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="systemTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="systemTopicName"/> is null. </exception>
        public virtual Response<SystemTopicResource> Get(string systemTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(systemTopicName, nameof(systemTopicName));

            using var scope = _systemTopicClientDiagnostics.CreateScope("SystemTopicCollection.Get");
            scope.Start();
            try
            {
                var response = _systemTopicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, systemTopicName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SystemTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the system topics under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopics_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SystemTopicResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SystemTopicResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _systemTopicRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _systemTopicRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SystemTopicResource(Client, SystemTopicData.DeserializeSystemTopicData(e)), _systemTopicClientDiagnostics, Pipeline, "SystemTopicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the system topics under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopics_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SystemTopicResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SystemTopicResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _systemTopicRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _systemTopicRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SystemTopicResource(Client, SystemTopicData.DeserializeSystemTopicData(e)), _systemTopicClientDiagnostics, Pipeline, "SystemTopicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="systemTopicName"> Name of the system topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="systemTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="systemTopicName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string systemTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(systemTopicName, nameof(systemTopicName));

            using var scope = _systemTopicClientDiagnostics.CreateScope("SystemTopicCollection.Exists");
            scope.Start();
            try
            {
                var response = await _systemTopicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, systemTopicName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="systemTopicName"> Name of the system topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="systemTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="systemTopicName"/> is null. </exception>
        public virtual Response<bool> Exists(string systemTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(systemTopicName, nameof(systemTopicName));

            using var scope = _systemTopicClientDiagnostics.CreateScope("SystemTopicCollection.Exists");
            scope.Start();
            try
            {
                var response = _systemTopicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, systemTopicName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="systemTopicName"> Name of the system topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="systemTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="systemTopicName"/> is null. </exception>
        public virtual async Task<NullableResponse<SystemTopicResource>> GetIfExistsAsync(string systemTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(systemTopicName, nameof(systemTopicName));

            using var scope = _systemTopicClientDiagnostics.CreateScope("SystemTopicCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _systemTopicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, systemTopicName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SystemTopicResource>(response.GetRawResponse());
                return Response.FromValue(new SystemTopicResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="systemTopicName"> Name of the system topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="systemTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="systemTopicName"/> is null. </exception>
        public virtual NullableResponse<SystemTopicResource> GetIfExists(string systemTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(systemTopicName, nameof(systemTopicName));

            using var scope = _systemTopicClientDiagnostics.CreateScope("SystemTopicCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _systemTopicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, systemTopicName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SystemTopicResource>(response.GetRawResponse());
                return Response.FromValue(new SystemTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SystemTopicResource> IEnumerable<SystemTopicResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SystemTopicResource> IAsyncEnumerable<SystemTopicResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
