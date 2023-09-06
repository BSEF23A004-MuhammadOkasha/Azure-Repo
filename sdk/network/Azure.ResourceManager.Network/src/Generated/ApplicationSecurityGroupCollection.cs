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
    /// A class representing a collection of <see cref="ApplicationSecurityGroupResource" /> and their operations.
    /// Each <see cref="ApplicationSecurityGroupResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="ApplicationSecurityGroupCollection" /> instance call the GetApplicationSecurityGroups method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ApplicationSecurityGroupCollection : ArmCollection, IEnumerable<ApplicationSecurityGroupResource>, IAsyncEnumerable<ApplicationSecurityGroupResource>
    {
        private readonly ClientDiagnostics _applicationSecurityGroupClientDiagnostics;
        private readonly ApplicationSecurityGroupsRestOperations _applicationSecurityGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApplicationSecurityGroupCollection"/> class for mocking. </summary>
        protected ApplicationSecurityGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationSecurityGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApplicationSecurityGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _applicationSecurityGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ApplicationSecurityGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApplicationSecurityGroupResource.ResourceType, out string applicationSecurityGroupApiVersion);
            _applicationSecurityGroupRestClient = new ApplicationSecurityGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, applicationSecurityGroupApiVersion);
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
        /// Creates or updates an application security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups/{applicationSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationSecurityGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="data"> Parameters supplied to the create or update ApplicationSecurityGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApplicationSecurityGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationSecurityGroupName, ApplicationSecurityGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _applicationSecurityGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ApplicationSecurityGroupResource>(new ApplicationSecurityGroupOperationSource(Client), _applicationSecurityGroupClientDiagnostics, Pipeline, _applicationSecurityGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an application security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups/{applicationSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationSecurityGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="data"> Parameters supplied to the create or update ApplicationSecurityGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApplicationSecurityGroupResource> CreateOrUpdate(WaitUntil waitUntil, string applicationSecurityGroupName, ApplicationSecurityGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _applicationSecurityGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, data, cancellationToken);
                var operation = new NetworkArmOperation<ApplicationSecurityGroupResource>(new ApplicationSecurityGroupOperationSource(Client), _applicationSecurityGroupClientDiagnostics, Pipeline, _applicationSecurityGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified application security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups/{applicationSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public virtual async Task<Response<ApplicationSecurityGroupResource>> GetAsync(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _applicationSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationSecurityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified application security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups/{applicationSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public virtual Response<ApplicationSecurityGroupResource> Get(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _applicationSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationSecurityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the application security groups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationSecurityGroups_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationSecurityGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplicationSecurityGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _applicationSecurityGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _applicationSecurityGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ApplicationSecurityGroupResource(Client, ApplicationSecurityGroupData.DeserializeApplicationSecurityGroupData(e)), _applicationSecurityGroupClientDiagnostics, Pipeline, "ApplicationSecurityGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the application security groups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationSecurityGroups_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationSecurityGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplicationSecurityGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _applicationSecurityGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _applicationSecurityGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ApplicationSecurityGroupResource(Client, ApplicationSecurityGroupData.DeserializeApplicationSecurityGroupData(e)), _applicationSecurityGroupClientDiagnostics, Pipeline, "ApplicationSecurityGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups/{applicationSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _applicationSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups/{applicationSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _applicationSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApplicationSecurityGroupResource> IEnumerable<ApplicationSecurityGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApplicationSecurityGroupResource> IAsyncEnumerable<ApplicationSecurityGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
