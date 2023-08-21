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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppPlatformBindingResource" /> and their operations.
    /// Each <see cref="AppPlatformBindingResource" /> in the collection will belong to the same instance of <see cref="AppPlatformAppResource" />.
    /// To get an <see cref="AppPlatformBindingCollection" /> instance call the GetAppPlatformBindings method from an instance of <see cref="AppPlatformAppResource" />.
    /// </summary>
    public partial class AppPlatformBindingCollection : ArmCollection, IEnumerable<AppPlatformBindingResource>, IAsyncEnumerable<AppPlatformBindingResource>
    {
        private readonly ClientDiagnostics _appPlatformBindingBindingsClientDiagnostics;
        private readonly BindingsRestOperations _appPlatformBindingBindingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBindingCollection"/> class for mocking. </summary>
        protected AppPlatformBindingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBindingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformBindingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformBindingBindingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformBindingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformBindingResource.ResourceType, out string appPlatformBindingBindingsApiVersion);
            _appPlatformBindingBindingsRestClient = new BindingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformBindingBindingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformAppResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformAppResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new Binding or update an exiting Binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bindings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformBindingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string bindingName, AppPlatformBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bindingName, nameof(bindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformBindingBindingsClientDiagnostics.CreateScope("AppPlatformBindingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformBindingBindingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformBindingResource>(new AppPlatformBindingOperationSource(Client), _appPlatformBindingBindingsClientDiagnostics, Pipeline, _appPlatformBindingBindingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Create a new Binding or update an exiting Binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bindings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformBindingResource> CreateOrUpdate(WaitUntil waitUntil, string bindingName, AppPlatformBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bindingName, nameof(bindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformBindingBindingsClientDiagnostics.CreateScope("AppPlatformBindingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformBindingBindingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformBindingResource>(new AppPlatformBindingOperationSource(Client), _appPlatformBindingBindingsClientDiagnostics, Pipeline, _appPlatformBindingBindingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Get a Binding and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bindings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformBindingResource>> GetAsync(string bindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bindingName, nameof(bindingName));

            using var scope = _appPlatformBindingBindingsClientDiagnostics.CreateScope("AppPlatformBindingCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformBindingBindingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Binding and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bindings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> is null. </exception>
        public virtual Response<AppPlatformBindingResource> Get(string bindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bindingName, nameof(bindingName));

            using var scope = _appPlatformBindingBindingsClientDiagnostics.CreateScope("AppPlatformBindingCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformBindingBindingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in an App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bindings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformBindingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformBindingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformBindingBindingsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformBindingBindingsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppPlatformBindingResource(Client, AppPlatformBindingData.DeserializeAppPlatformBindingData(e)), _appPlatformBindingBindingsClientDiagnostics, Pipeline, "AppPlatformBindingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in an App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bindings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformBindingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformBindingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformBindingBindingsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformBindingBindingsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppPlatformBindingResource(Client, AppPlatformBindingData.DeserializeAppPlatformBindingData(e)), _appPlatformBindingBindingsClientDiagnostics, Pipeline, "AppPlatformBindingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bindings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string bindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bindingName, nameof(bindingName));

            using var scope = _appPlatformBindingBindingsClientDiagnostics.CreateScope("AppPlatformBindingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformBindingBindingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bindings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> is null. </exception>
        public virtual Response<bool> Exists(string bindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bindingName, nameof(bindingName));

            using var scope = _appPlatformBindingBindingsClientDiagnostics.CreateScope("AppPlatformBindingCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformBindingBindingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformBindingResource> IEnumerable<AppPlatformBindingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformBindingResource> IAsyncEnumerable<AppPlatformBindingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
