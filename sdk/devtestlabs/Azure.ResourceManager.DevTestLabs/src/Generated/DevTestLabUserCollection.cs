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

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing a collection of <see cref="DevTestLabUserResource"/> and their operations.
    /// Each <see cref="DevTestLabUserResource"/> in the collection will belong to the same instance of <see cref="DevTestLabResource"/>.
    /// To get a <see cref="DevTestLabUserCollection"/> instance call the GetDevTestLabUsers method from an instance of <see cref="DevTestLabResource"/>.
    /// </summary>
    public partial class DevTestLabUserCollection : ArmCollection, IEnumerable<DevTestLabUserResource>, IAsyncEnumerable<DevTestLabUserResource>
    {
        private readonly ClientDiagnostics _devTestLabUserUsersClientDiagnostics;
        private readonly UsersRestOperations _devTestLabUserUsersRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevTestLabUserCollection"/> class for mocking. </summary>
        protected DevTestLabUserCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevTestLabUserCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevTestLabUserCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devTestLabUserUsersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", DevTestLabUserResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevTestLabUserResource.ResourceType, out string devTestLabUserUsersApiVersion);
            _devTestLabUserUsersRestClient = new UsersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devTestLabUserUsersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevTestLabResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevTestLabResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or replace an existing user profile. This operation can take a while to complete.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the user profile. </param>
        /// <param name="data"> Profile of a lab user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevTestLabUserResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DevTestLabUserData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabUserUsersClientDiagnostics.CreateScope("DevTestLabUserCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devTestLabUserUsersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation<DevTestLabUserResource>(new DevTestLabUserOperationSource(Client), _devTestLabUserUsersClientDiagnostics, Pipeline, _devTestLabUserUsersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or replace an existing user profile. This operation can take a while to complete.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the user profile. </param>
        /// <param name="data"> Profile of a lab user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevTestLabUserResource> CreateOrUpdate(WaitUntil waitUntil, string name, DevTestLabUserData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabUserUsersClientDiagnostics.CreateScope("DevTestLabUserCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devTestLabUserUsersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new DevTestLabsArmOperation<DevTestLabUserResource>(new DevTestLabUserOperationSource(Client), _devTestLabUserUsersClientDiagnostics, Pipeline, _devTestLabUserUsersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get user profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the user profile. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=identity)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DevTestLabUserResource>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabUserUsersClientDiagnostics.CreateScope("DevTestLabUserCollection.Get");
            scope.Start();
            try
            {
                var response = await _devTestLabUserUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get user profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the user profile. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=identity)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DevTestLabUserResource> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabUserUsersClientDiagnostics.CreateScope("DevTestLabUserCollection.Get");
            scope.Start();
            try
            {
                var response = _devTestLabUserUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List user profiles in a given lab.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=identity)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevTestLabUserResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevTestLabUserResource> GetAllAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabUserUsersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabUserUsersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DevTestLabUserResource(Client, DevTestLabUserData.DeserializeDevTestLabUserData(e)), _devTestLabUserUsersClientDiagnostics, Pipeline, "DevTestLabUserCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List user profiles in a given lab.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=identity)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevTestLabUserResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevTestLabUserResource> GetAll(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabUserUsersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabUserUsersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DevTestLabUserResource(Client, DevTestLabUserData.DeserializeDevTestLabUserData(e)), _devTestLabUserUsersClientDiagnostics, Pipeline, "DevTestLabUserCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the user profile. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=identity)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabUserUsersClientDiagnostics.CreateScope("DevTestLabUserCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devTestLabUserUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the user profile. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=identity)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabUserUsersClientDiagnostics.CreateScope("DevTestLabUserCollection.Exists");
            scope.Start();
            try
            {
                var response = _devTestLabUserUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the user profile. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=identity)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<DevTestLabUserResource>> GetIfExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabUserUsersClientDiagnostics.CreateScope("DevTestLabUserCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _devTestLabUserUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DevTestLabUserResource>(response.GetRawResponse());
                return Response.FromValue(new DevTestLabUserResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the user profile. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=identity)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<DevTestLabUserResource> GetIfExists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabUserUsersClientDiagnostics.CreateScope("DevTestLabUserCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _devTestLabUserUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DevTestLabUserResource>(response.GetRawResponse());
                return Response.FromValue(new DevTestLabUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevTestLabUserResource> IEnumerable<DevTestLabUserResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevTestLabUserResource> IAsyncEnumerable<DevTestLabUserResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
