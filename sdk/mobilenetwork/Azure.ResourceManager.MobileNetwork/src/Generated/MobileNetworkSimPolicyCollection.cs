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
    /// A class representing a collection of <see cref="MobileNetworkSimPolicyResource"/> and their operations.
    /// Each <see cref="MobileNetworkSimPolicyResource"/> in the collection will belong to the same instance of <see cref="MobileNetworkResource"/>.
    /// To get a <see cref="MobileNetworkSimPolicyCollection"/> instance call the GetMobileNetworkSimPolicies method from an instance of <see cref="MobileNetworkResource"/>.
    /// </summary>
    public partial class MobileNetworkSimPolicyCollection : ArmCollection, IEnumerable<MobileNetworkSimPolicyResource>, IAsyncEnumerable<MobileNetworkSimPolicyResource>
    {
        private readonly ClientDiagnostics _mobileNetworkSimPolicySimPoliciesClientDiagnostics;
        private readonly SimPoliciesRestOperations _mobileNetworkSimPolicySimPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkSimPolicyCollection"/> class for mocking. </summary>
        protected MobileNetworkSimPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkSimPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MobileNetworkSimPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mobileNetworkSimPolicySimPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", MobileNetworkSimPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MobileNetworkSimPolicyResource.ResourceType, out string mobileNetworkSimPolicySimPoliciesApiVersion);
            _mobileNetworkSimPolicySimPoliciesRestClient = new SimPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mobileNetworkSimPolicySimPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MobileNetworkResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MobileNetworkResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a SIM policy. Must be created in the same location as its parent mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/simPolicies/{simPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="data"> Parameters supplied to the create or update SIM policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MobileNetworkSimPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string simPolicyName, MobileNetworkSimPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkSimPolicySimPoliciesClientDiagnostics.CreateScope("MobileNetworkSimPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSimPolicySimPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<MobileNetworkSimPolicyResource>(new MobileNetworkSimPolicyOperationSource(Client), _mobileNetworkSimPolicySimPoliciesClientDiagnostics, Pipeline, _mobileNetworkSimPolicySimPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a SIM policy. Must be created in the same location as its parent mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/simPolicies/{simPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="data"> Parameters supplied to the create or update SIM policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MobileNetworkSimPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string simPolicyName, MobileNetworkSimPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkSimPolicySimPoliciesClientDiagnostics.CreateScope("MobileNetworkSimPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mobileNetworkSimPolicySimPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simPolicyName, data, cancellationToken);
                var operation = new MobileNetworkArmOperation<MobileNetworkSimPolicyResource>(new MobileNetworkSimPolicyOperationSource(Client), _mobileNetworkSimPolicySimPoliciesClientDiagnostics, Pipeline, _mobileNetworkSimPolicySimPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified SIM policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/simPolicies/{simPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simPolicyName"/> is null. </exception>
        public virtual async Task<Response<MobileNetworkSimPolicyResource>> GetAsync(string simPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));

            using var scope = _mobileNetworkSimPolicySimPoliciesClientDiagnostics.CreateScope("MobileNetworkSimPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSimPolicySimPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSimPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified SIM policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/simPolicies/{simPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simPolicyName"/> is null. </exception>
        public virtual Response<MobileNetworkSimPolicyResource> Get(string simPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));

            using var scope = _mobileNetworkSimPolicySimPoliciesClientDiagnostics.CreateScope("MobileNetworkSimPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _mobileNetworkSimPolicySimPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSimPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the SIM policies in a mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/simPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimPolicies_ListByMobileNetwork</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MobileNetworkSimPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MobileNetworkSimPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileNetworkSimPolicySimPoliciesRestClient.CreateListByMobileNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileNetworkSimPolicySimPoliciesRestClient.CreateListByMobileNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MobileNetworkSimPolicyResource(Client, MobileNetworkSimPolicyData.DeserializeMobileNetworkSimPolicyData(e)), _mobileNetworkSimPolicySimPoliciesClientDiagnostics, Pipeline, "MobileNetworkSimPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the SIM policies in a mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/simPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimPolicies_ListByMobileNetwork</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MobileNetworkSimPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MobileNetworkSimPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileNetworkSimPolicySimPoliciesRestClient.CreateListByMobileNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileNetworkSimPolicySimPoliciesRestClient.CreateListByMobileNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MobileNetworkSimPolicyResource(Client, MobileNetworkSimPolicyData.DeserializeMobileNetworkSimPolicyData(e)), _mobileNetworkSimPolicySimPoliciesClientDiagnostics, Pipeline, "MobileNetworkSimPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/simPolicies/{simPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string simPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));

            using var scope = _mobileNetworkSimPolicySimPoliciesClientDiagnostics.CreateScope("MobileNetworkSimPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSimPolicySimPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/simPolicies/{simPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string simPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));

            using var scope = _mobileNetworkSimPolicySimPoliciesClientDiagnostics.CreateScope("MobileNetworkSimPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _mobileNetworkSimPolicySimPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simPolicyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/simPolicies/{simPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simPolicyName"/> is null. </exception>
        public virtual async Task<NullableResponse<MobileNetworkSimPolicyResource>> GetIfExistsAsync(string simPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));

            using var scope = _mobileNetworkSimPolicySimPoliciesClientDiagnostics.CreateScope("MobileNetworkSimPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSimPolicySimPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MobileNetworkSimPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSimPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/simPolicies/{simPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simPolicyName"/> is null. </exception>
        public virtual NullableResponse<MobileNetworkSimPolicyResource> GetIfExists(string simPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));

            using var scope = _mobileNetworkSimPolicySimPoliciesClientDiagnostics.CreateScope("MobileNetworkSimPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mobileNetworkSimPolicySimPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, simPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MobileNetworkSimPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSimPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MobileNetworkSimPolicyResource> IEnumerable<MobileNetworkSimPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MobileNetworkSimPolicyResource> IAsyncEnumerable<MobileNetworkSimPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
