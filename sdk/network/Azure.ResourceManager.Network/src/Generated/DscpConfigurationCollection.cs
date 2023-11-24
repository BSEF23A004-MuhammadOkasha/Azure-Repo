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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="DscpConfigurationResource"/> and their operations.
    /// Each <see cref="DscpConfigurationResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DscpConfigurationCollection"/> instance call the GetDscpConfigurations method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DscpConfigurationCollection : ArmCollection, IEnumerable<DscpConfigurationResource>, IAsyncEnumerable<DscpConfigurationResource>
    {
        private readonly ClientDiagnostics _dscpConfigurationClientDiagnostics;
        private readonly DscpConfigurationRestOperations _dscpConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="DscpConfigurationCollection"/> class for mocking. </summary>
        protected DscpConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DscpConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DscpConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dscpConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", DscpConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DscpConfigurationResource.ResourceType, out string dscpConfigurationApiVersion);
            _dscpConfigurationRestClient = new DscpConfigurationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dscpConfigurationApiVersion);
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
        /// Creates or updates a DSCP Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dscpConfigurations/{dscpConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscpConfiguration_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="data"> Parameters supplied to the create or update dscp configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dscpConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DscpConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dscpConfigurationName, DscpConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dscpConfigurationName, nameof(dscpConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dscpConfigurationClientDiagnostics.CreateScope("DscpConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dscpConfigurationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, dscpConfigurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<DscpConfigurationResource>(new DscpConfigurationOperationSource(Client), _dscpConfigurationClientDiagnostics, Pipeline, _dscpConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, dscpConfigurationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a DSCP Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dscpConfigurations/{dscpConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscpConfiguration_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="data"> Parameters supplied to the create or update dscp configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dscpConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DscpConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string dscpConfigurationName, DscpConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dscpConfigurationName, nameof(dscpConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dscpConfigurationClientDiagnostics.CreateScope("DscpConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dscpConfigurationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, dscpConfigurationName, data, cancellationToken);
                var operation = new NetworkArmOperation<DscpConfigurationResource>(new DscpConfigurationOperationSource(Client), _dscpConfigurationClientDiagnostics, Pipeline, _dscpConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, dscpConfigurationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a DSCP Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dscpConfigurations/{dscpConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscpConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dscpConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> is null. </exception>
        public virtual async Task<Response<DscpConfigurationResource>> GetAsync(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dscpConfigurationName, nameof(dscpConfigurationName));

            using var scope = _dscpConfigurationClientDiagnostics.CreateScope("DscpConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _dscpConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dscpConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DscpConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a DSCP Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dscpConfigurations/{dscpConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscpConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dscpConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> is null. </exception>
        public virtual Response<DscpConfigurationResource> Get(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dscpConfigurationName, nameof(dscpConfigurationName));

            using var scope = _dscpConfigurationClientDiagnostics.CreateScope("DscpConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _dscpConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dscpConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DscpConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a DSCP Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dscpConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscpConfiguration_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DscpConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DscpConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dscpConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dscpConfigurationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DscpConfigurationResource(Client, DscpConfigurationData.DeserializeDscpConfigurationData(e)), _dscpConfigurationClientDiagnostics, Pipeline, "DscpConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a DSCP Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dscpConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscpConfiguration_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DscpConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DscpConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dscpConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dscpConfigurationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DscpConfigurationResource(Client, DscpConfigurationData.DeserializeDscpConfigurationData(e)), _dscpConfigurationClientDiagnostics, Pipeline, "DscpConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dscpConfigurations/{dscpConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscpConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dscpConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dscpConfigurationName, nameof(dscpConfigurationName));

            using var scope = _dscpConfigurationClientDiagnostics.CreateScope("DscpConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dscpConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dscpConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dscpConfigurations/{dscpConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscpConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dscpConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dscpConfigurationName, nameof(dscpConfigurationName));

            using var scope = _dscpConfigurationClientDiagnostics.CreateScope("DscpConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _dscpConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dscpConfigurationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dscpConfigurations/{dscpConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscpConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dscpConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<DscpConfigurationResource>> GetIfExistsAsync(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dscpConfigurationName, nameof(dscpConfigurationName));

            using var scope = _dscpConfigurationClientDiagnostics.CreateScope("DscpConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dscpConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dscpConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DscpConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new DscpConfigurationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dscpConfigurations/{dscpConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscpConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dscpConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> is null. </exception>
        public virtual NullableResponse<DscpConfigurationResource> GetIfExists(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dscpConfigurationName, nameof(dscpConfigurationName));

            using var scope = _dscpConfigurationClientDiagnostics.CreateScope("DscpConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dscpConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dscpConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DscpConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new DscpConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DscpConfigurationResource> IEnumerable<DscpConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DscpConfigurationResource> IAsyncEnumerable<DscpConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
