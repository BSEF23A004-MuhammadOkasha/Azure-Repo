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

namespace Azure.ResourceManager.ManagedNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedNetworkGroupResource"/> and their operations.
    /// Each <see cref="ManagedNetworkGroupResource"/> in the collection will belong to the same instance of <see cref="ManagedNetworkResource"/>.
    /// To get a <see cref="ManagedNetworkGroupCollection"/> instance call the GetManagedNetworkGroups method from an instance of <see cref="ManagedNetworkResource"/>.
    /// </summary>
    public partial class ManagedNetworkGroupCollection : ArmCollection, IEnumerable<ManagedNetworkGroupResource>, IAsyncEnumerable<ManagedNetworkGroupResource>
    {
        private readonly ClientDiagnostics _managedNetworkGroupClientDiagnostics;
        private readonly ManagedNetworkGroupsRestOperations _managedNetworkGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedNetworkGroupCollection"/> class for mocking. </summary>
        protected ManagedNetworkGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedNetworkGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedNetworkGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedNetworkGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetwork", ManagedNetworkGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedNetworkGroupResource.ResourceType, out string managedNetworkGroupApiVersion);
            _managedNetworkGroupRestClient = new ManagedNetworkGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedNetworkGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedNetworkResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedNetworkResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The Put ManagedNetworkGroups operation creates or updates a Managed Network Group resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkGroups/{managedNetworkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedNetworkGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedNetworkGroupName"> The name of the Managed Network Group. </param>
        /// <param name="data"> Parameters supplied to the create/update a Managed Network Group resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedNetworkGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string managedNetworkGroupName, ManagedNetworkGroupData data, CancellationToken cancellationToken = default)
        {
            if (managedNetworkGroupName == null)
            {
                throw new ArgumentNullException(nameof(managedNetworkGroupName));
            }
            if (managedNetworkGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedNetworkGroupName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _managedNetworkGroupClientDiagnostics.CreateScope("ManagedNetworkGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedNetworkGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkArmOperation<ManagedNetworkGroupResource>(new ManagedNetworkGroupOperationSource(Client), _managedNetworkGroupClientDiagnostics, Pipeline, _managedNetworkGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// The Put ManagedNetworkGroups operation creates or updates a Managed Network Group resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkGroups/{managedNetworkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedNetworkGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedNetworkGroupName"> The name of the Managed Network Group. </param>
        /// <param name="data"> Parameters supplied to the create/update a Managed Network Group resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedNetworkGroupResource> CreateOrUpdate(WaitUntil waitUntil, string managedNetworkGroupName, ManagedNetworkGroupData data, CancellationToken cancellationToken = default)
        {
            if (managedNetworkGroupName == null)
            {
                throw new ArgumentNullException(nameof(managedNetworkGroupName));
            }
            if (managedNetworkGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedNetworkGroupName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _managedNetworkGroupClientDiagnostics.CreateScope("ManagedNetworkGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedNetworkGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkGroupName, data, cancellationToken);
                var operation = new ManagedNetworkArmOperation<ManagedNetworkGroupResource>(new ManagedNetworkGroupOperationSource(Client), _managedNetworkGroupClientDiagnostics, Pipeline, _managedNetworkGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// The Get ManagedNetworkGroups operation gets a Managed Network Group specified by the resource group, Managed Network name, and group name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkGroups/{managedNetworkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedNetworkGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedNetworkGroupName"> The name of the Managed Network Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkGroupName"/> is null. </exception>
        public virtual async Task<Response<ManagedNetworkGroupResource>> GetAsync(string managedNetworkGroupName, CancellationToken cancellationToken = default)
        {
            if (managedNetworkGroupName == null)
            {
                throw new ArgumentNullException(nameof(managedNetworkGroupName));
            }
            if (managedNetworkGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedNetworkGroupName));
            }

            using var scope = _managedNetworkGroupClientDiagnostics.CreateScope("ManagedNetworkGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedNetworkGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedNetworkGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Get ManagedNetworkGroups operation gets a Managed Network Group specified by the resource group, Managed Network name, and group name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkGroups/{managedNetworkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedNetworkGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedNetworkGroupName"> The name of the Managed Network Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkGroupName"/> is null. </exception>
        public virtual Response<ManagedNetworkGroupResource> Get(string managedNetworkGroupName, CancellationToken cancellationToken = default)
        {
            if (managedNetworkGroupName == null)
            {
                throw new ArgumentNullException(nameof(managedNetworkGroupName));
            }
            if (managedNetworkGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedNetworkGroupName));
            }

            using var scope = _managedNetworkGroupClientDiagnostics.CreateScope("ManagedNetworkGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _managedNetworkGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedNetworkGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The ListByManagedNetwork ManagedNetworkGroup operation retrieves all the Managed Network Groups in a specified Managed Networks in a paginated format.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkGroups_ListByManagedNetwork</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedNetworkGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> May be used to limit the number of results in a page for list queries. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedNetworkGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedNetworkGroupResource> GetAllAsync(int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedNetworkGroupRestClient.CreateListByManagedNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedNetworkGroupRestClient.CreateListByManagedNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedNetworkGroupResource(Client, ManagedNetworkGroupData.DeserializeManagedNetworkGroupData(e)), _managedNetworkGroupClientDiagnostics, Pipeline, "ManagedNetworkGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The ListByManagedNetwork ManagedNetworkGroup operation retrieves all the Managed Network Groups in a specified Managed Networks in a paginated format.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkGroups_ListByManagedNetwork</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedNetworkGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> May be used to limit the number of results in a page for list queries. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedNetworkGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedNetworkGroupResource> GetAll(int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedNetworkGroupRestClient.CreateListByManagedNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedNetworkGroupRestClient.CreateListByManagedNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedNetworkGroupResource(Client, ManagedNetworkGroupData.DeserializeManagedNetworkGroupData(e)), _managedNetworkGroupClientDiagnostics, Pipeline, "ManagedNetworkGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkGroups/{managedNetworkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedNetworkGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedNetworkGroupName"> The name of the Managed Network Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string managedNetworkGroupName, CancellationToken cancellationToken = default)
        {
            if (managedNetworkGroupName == null)
            {
                throw new ArgumentNullException(nameof(managedNetworkGroupName));
            }
            if (managedNetworkGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedNetworkGroupName));
            }

            using var scope = _managedNetworkGroupClientDiagnostics.CreateScope("ManagedNetworkGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedNetworkGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkGroups/{managedNetworkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedNetworkGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedNetworkGroupName"> The name of the Managed Network Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string managedNetworkGroupName, CancellationToken cancellationToken = default)
        {
            if (managedNetworkGroupName == null)
            {
                throw new ArgumentNullException(nameof(managedNetworkGroupName));
            }
            if (managedNetworkGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedNetworkGroupName));
            }

            using var scope = _managedNetworkGroupClientDiagnostics.CreateScope("ManagedNetworkGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedNetworkGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkGroups/{managedNetworkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedNetworkGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedNetworkGroupName"> The name of the Managed Network Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<ManagedNetworkGroupResource>> GetIfExistsAsync(string managedNetworkGroupName, CancellationToken cancellationToken = default)
        {
            if (managedNetworkGroupName == null)
            {
                throw new ArgumentNullException(nameof(managedNetworkGroupName));
            }
            if (managedNetworkGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedNetworkGroupName));
            }

            using var scope = _managedNetworkGroupClientDiagnostics.CreateScope("ManagedNetworkGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedNetworkGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ManagedNetworkGroupResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedNetworkGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkGroups/{managedNetworkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedNetworkGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedNetworkGroupName"> The name of the Managed Network Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkGroupName"/> is null. </exception>
        public virtual NullableResponse<ManagedNetworkGroupResource> GetIfExists(string managedNetworkGroupName, CancellationToken cancellationToken = default)
        {
            if (managedNetworkGroupName == null)
            {
                throw new ArgumentNullException(nameof(managedNetworkGroupName));
            }
            if (managedNetworkGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedNetworkGroupName));
            }

            using var scope = _managedNetworkGroupClientDiagnostics.CreateScope("ManagedNetworkGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedNetworkGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ManagedNetworkGroupResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedNetworkGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedNetworkGroupResource> IEnumerable<ManagedNetworkGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedNetworkGroupResource> IAsyncEnumerable<ManagedNetworkGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
