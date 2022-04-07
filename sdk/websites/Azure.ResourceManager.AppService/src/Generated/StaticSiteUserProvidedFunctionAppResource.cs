// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a StaticSiteUserProvidedFunctionApp along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StaticSiteUserProvidedFunctionAppResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStaticSiteUserProvidedFunctionAppResource method.
    /// Otherwise you can get one from its parent resource <see cref="StaticSiteARMResource" /> using the GetStaticSiteUserProvidedFunctionApp method.
    /// </summary>
    public partial class StaticSiteUserProvidedFunctionAppResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StaticSiteUserProvidedFunctionAppResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string functionAppName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteUserProvidedFunctionAppStaticSitesRestClient;
        private readonly StaticSiteUserProvidedFunctionAppARMResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteUserProvidedFunctionAppResource"/> class for mocking. </summary>
        protected StaticSiteUserProvidedFunctionAppResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StaticSiteUserProvidedFunctionAppResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StaticSiteUserProvidedFunctionAppResource(ArmClient client, StaticSiteUserProvidedFunctionAppARMResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteUserProvidedFunctionAppResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StaticSiteUserProvidedFunctionAppResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string staticSiteUserProvidedFunctionAppStaticSitesApiVersion);
            _staticSiteUserProvidedFunctionAppStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteUserProvidedFunctionAppStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/staticSites/userProvidedFunctionApps";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StaticSiteUserProvidedFunctionAppARMResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets the details of the user provided function app registered with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSite
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StaticSiteUserProvidedFunctionAppResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppResource.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteUserProvidedFunctionAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of the user provided function app registered with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSite
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StaticSiteUserProvidedFunctionAppResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppResource.Get");
            scope.Start();
            try
            {
                var response = _staticSiteUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteUserProvidedFunctionAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Detach the user provided function app from the static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_DetachUserProvidedFunctionAppFromStaticSite
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppResource.Delete");
            scope.Start();
            try
            {
                var response = await _staticSiteUserProvidedFunctionAppStaticSitesRestClient.DetachUserProvidedFunctionAppFromStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Detach the user provided function app from the static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_DetachUserProvidedFunctionAppFromStaticSite
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppResource.Delete");
            scope.Start();
            try
            {
                var response = _staticSiteUserProvidedFunctionAppStaticSitesRestClient.DetachUserProvidedFunctionAppFromStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
