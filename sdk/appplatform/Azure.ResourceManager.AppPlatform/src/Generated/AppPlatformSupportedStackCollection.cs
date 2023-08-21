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
    /// A class representing a collection of <see cref="AppPlatformSupportedStackResource" /> and their operations.
    /// Each <see cref="AppPlatformSupportedStackResource" /> in the collection will belong to the same instance of <see cref="AppPlatformBuildServiceResource" />.
    /// To get an <see cref="AppPlatformSupportedStackCollection" /> instance call the GetAppPlatformSupportedStacks method from an instance of <see cref="AppPlatformBuildServiceResource" />.
    /// </summary>
    public partial class AppPlatformSupportedStackCollection : ArmCollection, IEnumerable<AppPlatformSupportedStackResource>, IAsyncEnumerable<AppPlatformSupportedStackResource>
    {
        private readonly ClientDiagnostics _appPlatformSupportedStackBuildServiceClientDiagnostics;
        private readonly BuildServiceRestOperations _appPlatformSupportedStackBuildServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformSupportedStackCollection"/> class for mocking. </summary>
        protected AppPlatformSupportedStackCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformSupportedStackCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformSupportedStackCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformSupportedStackBuildServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformSupportedStackResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformSupportedStackResource.ResourceType, out string appPlatformSupportedStackBuildServiceApiVersion);
            _appPlatformSupportedStackBuildServiceRestClient = new BuildServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformSupportedStackBuildServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformBuildServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformBuildServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the supported stack resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedStack</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stackName"> The name of the stack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stackName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformSupportedStackResource>> GetAsync(string stackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stackName, nameof(stackName));

            using var scope = _appPlatformSupportedStackBuildServiceClientDiagnostics.CreateScope("AppPlatformSupportedStackCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformSupportedStackBuildServiceRestClient.GetSupportedStackAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, stackName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformSupportedStackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the supported stack resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedStack</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stackName"> The name of the stack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stackName"/> is null. </exception>
        public virtual Response<AppPlatformSupportedStackResource> Get(string stackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stackName, nameof(stackName));

            using var scope = _appPlatformSupportedStackBuildServiceClientDiagnostics.CreateScope("AppPlatformSupportedStackCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformSupportedStackBuildServiceRestClient.GetSupportedStack(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, stackName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformSupportedStackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all supported stacks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_ListSupportedStacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformSupportedStackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformSupportedStackResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformSupportedStackBuildServiceRestClient.CreateListSupportedStacksRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AppPlatformSupportedStackResource(Client, AppPlatformSupportedStackData.DeserializeAppPlatformSupportedStackData(e)), _appPlatformSupportedStackBuildServiceClientDiagnostics, Pipeline, "AppPlatformSupportedStackCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get all supported stacks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_ListSupportedStacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformSupportedStackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformSupportedStackResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformSupportedStackBuildServiceRestClient.CreateListSupportedStacksRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new AppPlatformSupportedStackResource(Client, AppPlatformSupportedStackData.DeserializeAppPlatformSupportedStackData(e)), _appPlatformSupportedStackBuildServiceClientDiagnostics, Pipeline, "AppPlatformSupportedStackCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedStack</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stackName"> The name of the stack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stackName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string stackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stackName, nameof(stackName));

            using var scope = _appPlatformSupportedStackBuildServiceClientDiagnostics.CreateScope("AppPlatformSupportedStackCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformSupportedStackBuildServiceRestClient.GetSupportedStackAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, stackName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedStack</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stackName"> The name of the stack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stackName"/> is null. </exception>
        public virtual Response<bool> Exists(string stackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stackName, nameof(stackName));

            using var scope = _appPlatformSupportedStackBuildServiceClientDiagnostics.CreateScope("AppPlatformSupportedStackCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformSupportedStackBuildServiceRestClient.GetSupportedStack(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, stackName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformSupportedStackResource> IEnumerable<AppPlatformSupportedStackResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformSupportedStackResource> IAsyncEnumerable<AppPlatformSupportedStackResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
