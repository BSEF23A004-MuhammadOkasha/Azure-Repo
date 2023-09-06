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

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="MobileNetworkSimResource" /> and their operations.
    /// Each <see cref="MobileNetworkSimResource" /> in the collection will belong to the same instance of <see cref="MobileNetworkSimGroupResource" />.
    /// To get a <see cref="MobileNetworkSimCollection" /> instance call the GetMobileNetworkSims method from an instance of <see cref="MobileNetworkSimGroupResource" />.
    /// </summary>
    public partial class MobileNetworkSimCollection : ArmCollection, IEnumerable<MobileNetworkSimResource>, IAsyncEnumerable<MobileNetworkSimResource>
    {
        private readonly ClientDiagnostics _mobileNetworkSimSimsClientDiagnostics;
        private readonly SimsRestOperations _mobileNetworkSimSimsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkSimCollection"/> class for mocking. </summary>
        protected MobileNetworkSimCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkSimCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MobileNetworkSimCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mobileNetworkSimSimsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", MobileNetworkSimResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MobileNetworkSimResource.ResourceType, out string mobileNetworkSimSimsApiVersion);
            _mobileNetworkSimSimsRestClient = new SimsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mobileNetworkSimSimsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MobileNetworkSimGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MobileNetworkSimGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a SIM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}/sims/{simName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sims_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="simName"> The name of the SIM. </param>
        /// <param name="data"> Parameters supplied to the create or update SIM operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MobileNetworkSimResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string simName, MobileNetworkSimData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simName, nameof(simName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkSimSimsClientDiagnostics.CreateScope("MobileNetworkSimCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSimSimsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<MobileNetworkSimResource>(new MobileNetworkSimOperationSource(Client), _mobileNetworkSimSimsClientDiagnostics, Pipeline, _mobileNetworkSimSimsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a SIM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}/sims/{simName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sims_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="simName"> The name of the SIM. </param>
        /// <param name="data"> Parameters supplied to the create or update SIM operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MobileNetworkSimResource> CreateOrUpdate(WaitUntil waitUntil, string simName, MobileNetworkSimData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simName, nameof(simName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkSimSimsClientDiagnostics.CreateScope("MobileNetworkSimCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mobileNetworkSimSimsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simName, data, cancellationToken);
                var operation = new MobileNetworkArmOperation<MobileNetworkSimResource>(new MobileNetworkSimOperationSource(Client), _mobileNetworkSimSimsClientDiagnostics, Pipeline, _mobileNetworkSimSimsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified SIM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}/sims/{simName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sims_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simName"> The name of the SIM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simName"/> is null. </exception>
        public virtual async Task<Response<MobileNetworkSimResource>> GetAsync(string simName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simName, nameof(simName));

            using var scope = _mobileNetworkSimSimsClientDiagnostics.CreateScope("MobileNetworkSimCollection.Get");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSimSimsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSimResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified SIM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}/sims/{simName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sims_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simName"> The name of the SIM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simName"/> is null. </exception>
        public virtual Response<MobileNetworkSimResource> Get(string simName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simName, nameof(simName));

            using var scope = _mobileNetworkSimSimsClientDiagnostics.CreateScope("MobileNetworkSimCollection.Get");
            scope.Start();
            try
            {
                var response = _mobileNetworkSimSimsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSimResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the SIMs in a SIM group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}/sims</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sims_ListByGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MobileNetworkSimResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MobileNetworkSimResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileNetworkSimSimsRestClient.CreateListByGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileNetworkSimSimsRestClient.CreateListByGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new MobileNetworkSimResource(Client, MobileNetworkSimData.DeserializeMobileNetworkSimData(e)), _mobileNetworkSimSimsClientDiagnostics, Pipeline, "MobileNetworkSimCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the SIMs in a SIM group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}/sims</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sims_ListByGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MobileNetworkSimResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MobileNetworkSimResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileNetworkSimSimsRestClient.CreateListByGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileNetworkSimSimsRestClient.CreateListByGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new MobileNetworkSimResource(Client, MobileNetworkSimData.DeserializeMobileNetworkSimData(e)), _mobileNetworkSimSimsClientDiagnostics, Pipeline, "MobileNetworkSimCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}/sims/{simName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sims_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simName"> The name of the SIM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string simName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simName, nameof(simName));

            using var scope = _mobileNetworkSimSimsClientDiagnostics.CreateScope("MobileNetworkSimCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSimSimsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}/sims/{simName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sims_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simName"> The name of the SIM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simName"/> is null. </exception>
        public virtual Response<bool> Exists(string simName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simName, nameof(simName));

            using var scope = _mobileNetworkSimSimsClientDiagnostics.CreateScope("MobileNetworkSimCollection.Exists");
            scope.Start();
            try
            {
                var response = _mobileNetworkSimSimsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MobileNetworkSimResource> IEnumerable<MobileNetworkSimResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MobileNetworkSimResource> IAsyncEnumerable<MobileNetworkSimResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
