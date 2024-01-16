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

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary>
    /// A class representing a collection of <see cref="VMwareDatastoreResource"/> and their operations.
    /// Each <see cref="VMwareDatastoreResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="VMwareDatastoreCollection"/> instance call the GetVMwareDatastores method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class VMwareDatastoreCollection : ArmCollection, IEnumerable<VMwareDatastoreResource>, IAsyncEnumerable<VMwareDatastoreResource>
    {
        private readonly ClientDiagnostics _vMwareDatastoreDatastoresClientDiagnostics;
        private readonly DatastoresRestOperations _vMwareDatastoreDatastoresRestClient;

        /// <summary> Initializes a new instance of the <see cref="VMwareDatastoreCollection"/> class for mocking. </summary>
        protected VMwareDatastoreCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VMwareDatastoreCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VMwareDatastoreCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vMwareDatastoreDatastoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VMwareDatastoreResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VMwareDatastoreResource.ResourceType, out string vMwareDatastoreDatastoresApiVersion);
            _vMwareDatastoreDatastoresRestClient = new DatastoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vMwareDatastoreDatastoresApiVersion);
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
        /// Create Or Update datastore.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VMwareDatastoreResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string datastoreName, VMwareDatastoreData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vMwareDatastoreDatastoresRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<VMwareDatastoreResource>(new VMwareDatastoreOperationSource(Client), _vMwareDatastoreDatastoresClientDiagnostics, Pipeline, _vMwareDatastoreDatastoresRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Or Update datastore.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VMwareDatastoreResource> CreateOrUpdate(WaitUntil waitUntil, string datastoreName, VMwareDatastoreData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vMwareDatastoreDatastoresRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, data, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<VMwareDatastoreResource>(new VMwareDatastoreOperationSource(Client), _vMwareDatastoreDatastoresClientDiagnostics, Pipeline, _vMwareDatastoreDatastoresRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements datastore GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual async Task<Response<VMwareDatastoreResource>> GetAsync(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.Get");
            scope.Start();
            try
            {
                var response = await _vMwareDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareDatastoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements datastore GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual Response<VMwareDatastoreResource> Get(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.Get");
            scope.Start();
            try
            {
                var response = _vMwareDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareDatastoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of datastores in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VMwareDatastoreResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VMwareDatastoreResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vMwareDatastoreDatastoresRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vMwareDatastoreDatastoresRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VMwareDatastoreResource(Client, VMwareDatastoreData.DeserializeVMwareDatastoreData(e)), _vMwareDatastoreDatastoresClientDiagnostics, Pipeline, "VMwareDatastoreCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of datastores in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VMwareDatastoreResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VMwareDatastoreResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vMwareDatastoreDatastoresRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vMwareDatastoreDatastoresRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VMwareDatastoreResource(Client, VMwareDatastoreData.DeserializeVMwareDatastoreData(e)), _vMwareDatastoreDatastoresClientDiagnostics, Pipeline, "VMwareDatastoreCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vMwareDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual Response<bool> Exists(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.Exists");
            scope.Start();
            try
            {
                var response = _vMwareDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual async Task<NullableResponse<VMwareDatastoreResource>> GetIfExistsAsync(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vMwareDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VMwareDatastoreResource>(response.GetRawResponse());
                return Response.FromValue(new VMwareDatastoreResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareDatastoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual NullableResponse<VMwareDatastoreResource> GetIfExists(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vMwareDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VMwareDatastoreResource>(response.GetRawResponse());
                return Response.FromValue(new VMwareDatastoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VMwareDatastoreResource> IEnumerable<VMwareDatastoreResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VMwareDatastoreResource> IAsyncEnumerable<VMwareDatastoreResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
