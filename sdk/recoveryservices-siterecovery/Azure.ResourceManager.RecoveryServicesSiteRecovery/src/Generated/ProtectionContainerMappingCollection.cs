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
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="ProtectionContainerMappingResource"/> and their operations.
    /// Each <see cref="ProtectionContainerMappingResource"/> in the collection will belong to the same instance of <see cref="SiteRecoveryProtectionContainerResource"/>.
    /// To get a <see cref="ProtectionContainerMappingCollection"/> instance call the GetProtectionContainerMappings method from an instance of <see cref="SiteRecoveryProtectionContainerResource"/>.
    /// </summary>
    public partial class ProtectionContainerMappingCollection : ArmCollection, IEnumerable<ProtectionContainerMappingResource>, IAsyncEnumerable<ProtectionContainerMappingResource>
    {
        private readonly ClientDiagnostics _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics;
        private readonly ReplicationProtectionContainerMappingsRestOperations _protectionContainerMappingReplicationProtectionContainerMappingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProtectionContainerMappingCollection"/> class for mocking. </summary>
        protected ProtectionContainerMappingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProtectionContainerMappingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ProtectionContainerMappingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", ProtectionContainerMappingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ProtectionContainerMappingResource.ResourceType, out string protectionContainerMappingReplicationProtectionContainerMappingsApiVersion);
            _protectionContainerMappingReplicationProtectionContainerMappingsRestClient = new ReplicationProtectionContainerMappingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, protectionContainerMappingReplicationProtectionContainerMappingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteRecoveryProtectionContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteRecoveryProtectionContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create a protection container mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectionContainerMappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainerMappings_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProtectionContainerMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mappingName"> Protection container mapping name. </param>
        /// <param name="content"> Mapping creation input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ProtectionContainerMappingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string mappingName, ProtectionContainerMappingCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics.CreateScope("ProtectionContainerMappingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, mappingName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<ProtectionContainerMappingResource>(new ProtectionContainerMappingOperationSource(Client), _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics, Pipeline, _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, mappingName, content).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create a protection container mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectionContainerMappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainerMappings_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProtectionContainerMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mappingName"> Protection container mapping name. </param>
        /// <param name="content"> Mapping creation input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ProtectionContainerMappingResource> CreateOrUpdate(WaitUntil waitUntil, string mappingName, ProtectionContainerMappingCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics.CreateScope("ProtectionContainerMappingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, mappingName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<ProtectionContainerMappingResource>(new ProtectionContainerMappingOperationSource(Client), _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics, Pipeline, _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, mappingName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of a protection container mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectionContainerMappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainerMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProtectionContainerMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mappingName"> Protection Container mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> is null. </exception>
        public virtual async Task<Response<ProtectionContainerMappingResource>> GetAsync(string mappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));

            using var scope = _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics.CreateScope("ProtectionContainerMappingCollection.Get");
            scope.Start();
            try
            {
                var response = await _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, mappingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProtectionContainerMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of a protection container mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectionContainerMappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainerMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProtectionContainerMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mappingName"> Protection Container mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> is null. </exception>
        public virtual Response<ProtectionContainerMappingResource> Get(string mappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));

            using var scope = _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics.CreateScope("ProtectionContainerMappingCollection.Get");
            scope.Start();
            try
            {
                var response = _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, mappingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProtectionContainerMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the protection container mappings for a protection container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectionContainerMappings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainerMappings_ListByReplicationProtectionContainers</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProtectionContainerMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProtectionContainerMappingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProtectionContainerMappingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.CreateListByReplicationProtectionContainersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.CreateListByReplicationProtectionContainersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ProtectionContainerMappingResource(Client, ProtectionContainerMappingData.DeserializeProtectionContainerMappingData(e)), _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics, Pipeline, "ProtectionContainerMappingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the protection container mappings for a protection container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectionContainerMappings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainerMappings_ListByReplicationProtectionContainers</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProtectionContainerMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProtectionContainerMappingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProtectionContainerMappingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.CreateListByReplicationProtectionContainersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.CreateListByReplicationProtectionContainersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ProtectionContainerMappingResource(Client, ProtectionContainerMappingData.DeserializeProtectionContainerMappingData(e)), _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics, Pipeline, "ProtectionContainerMappingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectionContainerMappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainerMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProtectionContainerMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mappingName"> Protection Container mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string mappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));

            using var scope = _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics.CreateScope("ProtectionContainerMappingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, mappingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectionContainerMappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainerMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProtectionContainerMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mappingName"> Protection Container mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> is null. </exception>
        public virtual Response<bool> Exists(string mappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));

            using var scope = _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics.CreateScope("ProtectionContainerMappingCollection.Exists");
            scope.Start();
            try
            {
                var response = _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, mappingName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectionContainerMappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainerMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProtectionContainerMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mappingName"> Protection Container mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> is null. </exception>
        public virtual async Task<NullableResponse<ProtectionContainerMappingResource>> GetIfExistsAsync(string mappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));

            using var scope = _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics.CreateScope("ProtectionContainerMappingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, mappingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ProtectionContainerMappingResource>(response.GetRawResponse());
                return Response.FromValue(new ProtectionContainerMappingResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectionContainerMappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainerMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProtectionContainerMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mappingName"> Protection Container mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> is null. </exception>
        public virtual NullableResponse<ProtectionContainerMappingResource> GetIfExists(string mappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));

            using var scope = _protectionContainerMappingReplicationProtectionContainerMappingsClientDiagnostics.CreateScope("ProtectionContainerMappingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _protectionContainerMappingReplicationProtectionContainerMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, mappingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ProtectionContainerMappingResource>(response.GetRawResponse());
                return Response.FromValue(new ProtectionContainerMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ProtectionContainerMappingResource> IEnumerable<ProtectionContainerMappingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ProtectionContainerMappingResource> IAsyncEnumerable<ProtectionContainerMappingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
