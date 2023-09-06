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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="HubIPConfigurationResource" /> and their operations.
    /// Each <see cref="HubIPConfigurationResource" /> in the collection will belong to the same instance of <see cref="VirtualHubResource" />.
    /// To get a <see cref="HubIPConfigurationCollection" /> instance call the GetHubIPConfigurations method from an instance of <see cref="VirtualHubResource" />.
    /// </summary>
    public partial class HubIPConfigurationCollection : ArmCollection, IEnumerable<HubIPConfigurationResource>, IAsyncEnumerable<HubIPConfigurationResource>
    {
        private readonly ClientDiagnostics _hubIPConfigurationVirtualHubIPConfigurationClientDiagnostics;
        private readonly VirtualHubIpConfigurationRestOperations _hubIPConfigurationVirtualHubIPConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="HubIPConfigurationCollection"/> class for mocking. </summary>
        protected HubIPConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HubIPConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HubIPConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hubIPConfigurationVirtualHubIPConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", HubIPConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HubIPConfigurationResource.ResourceType, out string hubIPConfigurationVirtualHubIPConfigurationApiVersion);
            _hubIPConfigurationVirtualHubIPConfigurationRestClient = new VirtualHubIpConfigurationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hubIPConfigurationVirtualHubIPConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualHubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualHubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a VirtualHubIpConfiguration resource if it doesn't exist else updates the existing VirtualHubIpConfiguration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubIpConfiguration_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="data"> Hub Ip Configuration parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HubIPConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ipConfigName, HubIPConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hubIPConfigurationVirtualHubIPConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hubIPConfigurationVirtualHubIPConfigurationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<HubIPConfigurationResource>(new HubIPConfigurationOperationSource(Client), _hubIPConfigurationVirtualHubIPConfigurationClientDiagnostics, Pipeline, _hubIPConfigurationVirtualHubIPConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a VirtualHubIpConfiguration resource if it doesn't exist else updates the existing VirtualHubIpConfiguration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubIpConfiguration_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="data"> Hub Ip Configuration parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HubIPConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string ipConfigName, HubIPConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hubIPConfigurationVirtualHubIPConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hubIPConfigurationVirtualHubIPConfigurationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, data, cancellationToken);
                var operation = new NetworkArmOperation<HubIPConfigurationResource>(new HubIPConfigurationOperationSource(Client), _hubIPConfigurationVirtualHubIPConfigurationClientDiagnostics, Pipeline, _hubIPConfigurationVirtualHubIPConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a Virtual Hub Ip configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubIpConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> is null. </exception>
        public virtual async Task<Response<HubIPConfigurationResource>> GetAsync(string ipConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));

            using var scope = _hubIPConfigurationVirtualHubIPConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _hubIPConfigurationVirtualHubIPConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubIPConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a Virtual Hub Ip configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubIpConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> is null. </exception>
        public virtual Response<HubIPConfigurationResource> Get(string ipConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));

            using var scope = _hubIPConfigurationVirtualHubIPConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _hubIPConfigurationVirtualHubIPConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubIPConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of all VirtualHubIpConfigurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubIpConfiguration_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HubIPConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HubIPConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hubIPConfigurationVirtualHubIPConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hubIPConfigurationVirtualHubIPConfigurationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new HubIPConfigurationResource(Client, HubIPConfigurationData.DeserializeHubIPConfigurationData(e)), _hubIPConfigurationVirtualHubIPConfigurationClientDiagnostics, Pipeline, "HubIPConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of all VirtualHubIpConfigurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubIpConfiguration_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HubIPConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HubIPConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hubIPConfigurationVirtualHubIPConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hubIPConfigurationVirtualHubIPConfigurationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new HubIPConfigurationResource(Client, HubIPConfigurationData.DeserializeHubIPConfigurationData(e)), _hubIPConfigurationVirtualHubIPConfigurationClientDiagnostics, Pipeline, "HubIPConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubIpConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ipConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));

            using var scope = _hubIPConfigurationVirtualHubIPConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hubIPConfigurationVirtualHubIPConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubIpConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> is null. </exception>
        public virtual Response<bool> Exists(string ipConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));

            using var scope = _hubIPConfigurationVirtualHubIPConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _hubIPConfigurationVirtualHubIPConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HubIPConfigurationResource> IEnumerable<HubIPConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HubIPConfigurationResource> IAsyncEnumerable<HubIPConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
