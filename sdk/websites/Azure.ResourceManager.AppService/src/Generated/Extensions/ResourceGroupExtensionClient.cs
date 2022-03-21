// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        private ClientDiagnostics _resourceHealthMetadataClientDiagnostics;
        private ResourceHealthMetadataRestOperations _resourceHealthMetadataRestClient;
        private ClientDiagnostics _defaultClientDiagnostics;
        private WebSiteManagementRestOperations _defaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ResourceHealthMetadataClientDiagnostics => _resourceHealthMetadataClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppService", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ResourceHealthMetadataRestOperations ResourceHealthMetadataRestClient => _resourceHealthMetadataRestClient ??= new ResourceHealthMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppService", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private WebSiteManagementRestOperations DefaultRestClient => _defaultRestClient ??= new WebSiteManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AppServiceCertificateOrders in the AppServiceCertificateOrder. </summary>
        /// <returns> An object representing collection of AppServiceCertificateOrders and their operations over a AppServiceCertificateOrder. </returns>
        public virtual AppServiceCertificateOrderCollection GetAppServiceCertificateOrders()
        {
            return GetCachedClient(Client => new AppServiceCertificateOrderCollection(Client, Id));
        }

        /// <summary> Gets a collection of AppServiceDomains in the AppServiceDomain. </summary>
        /// <returns> An object representing collection of AppServiceDomains and their operations over a AppServiceDomain. </returns>
        public virtual AppServiceDomainCollection GetAppServiceDomains()
        {
            return GetCachedClient(Client => new AppServiceDomainCollection(Client, Id));
        }

        /// <summary> Gets a collection of AppServiceEnvironments in the AppServiceEnvironment. </summary>
        /// <returns> An object representing collection of AppServiceEnvironments and their operations over a AppServiceEnvironment. </returns>
        public virtual AppServiceEnvironmentCollection GetAppServiceEnvironments()
        {
            return GetCachedClient(Client => new AppServiceEnvironmentCollection(Client, Id));
        }

        /// <summary> Gets a collection of AppServicePlans in the AppServicePlan. </summary>
        /// <returns> An object representing collection of AppServicePlans and their operations over a AppServicePlan. </returns>
        public virtual AppServicePlanCollection GetAppServicePlans()
        {
            return GetCachedClient(Client => new AppServicePlanCollection(Client, Id));
        }

        /// <summary> Gets a collection of Certificates in the Certificate. </summary>
        /// <returns> An object representing collection of Certificates and their operations over a Certificate. </returns>
        public virtual CertificateCollection GetCertificates()
        {
            return GetCachedClient(Client => new CertificateCollection(Client, Id));
        }

        /// <summary> Gets a collection of KubeEnvironments in the KubeEnvironment. </summary>
        /// <returns> An object representing collection of KubeEnvironments and their operations over a KubeEnvironment. </returns>
        public virtual KubeEnvironmentCollection GetKubeEnvironments()
        {
            return GetCachedClient(Client => new KubeEnvironmentCollection(Client, Id));
        }

        /// <summary> Gets a collection of StaticSiteARMResources in the StaticSiteARMResource. </summary>
        /// <returns> An object representing collection of StaticSiteARMResources and their operations over a StaticSiteARMResource. </returns>
        public virtual StaticSiteARMResourceCollection GetStaticSiteARMResources()
        {
            return GetCachedClient(Client => new StaticSiteARMResourceCollection(Client, Id));
        }

        /// <summary> Gets a collection of WebSites in the WebSite. </summary>
        /// <returns> An object representing collection of WebSites and their operations over a WebSite. </returns>
        public virtual WebSiteCollection GetWebSites()
        {
            return GetCachedClient(Client => new WebSiteCollection(Client, Id));
        }

        /// <summary>
        /// Description for List all ResourceHealthMetadata for all sites in the resource group in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/resourceHealthMetadata
        /// Operation Id: ResourceHealthMetadata_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteResourceHealthMetadata" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteResourceHealthMetadata> GetAllResourceHealthMetadataAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteResourceHealthMetadata>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceHealthMetadataClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAllResourceHealthMetadata");
                scope.Start();
                try
                {
                    var response = await ResourceHealthMetadataRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteResourceHealthMetadata(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteResourceHealthMetadata>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceHealthMetadataClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAllResourceHealthMetadata");
                scope.Start();
                try
                {
                    var response = await ResourceHealthMetadataRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteResourceHealthMetadata(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Description for List all ResourceHealthMetadata for all sites in the resource group in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/resourceHealthMetadata
        /// Operation Id: ResourceHealthMetadata_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteResourceHealthMetadata" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteResourceHealthMetadata> GetAllResourceHealthMetadata(CancellationToken cancellationToken = default)
        {
            Page<SiteResourceHealthMetadata> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceHealthMetadataClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAllResourceHealthMetadata");
                scope.Start();
                try
                {
                    var response = ResourceHealthMetadataRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteResourceHealthMetadata(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteResourceHealthMetadata> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceHealthMetadataClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAllResourceHealthMetadata");
                scope.Start();
                try
                {
                    var response = ResourceHealthMetadataRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteResourceHealthMetadata(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Description for Move resources between resource groups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/moveResources
        /// Operation Id: Move
        /// </summary>
        /// <param name="moveResourceEnvelope"> Object that represents the resource to move. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> MoveAsync(CsmMoveResourceEnvelope moveResourceEnvelope, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.Move");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.MoveAsync(Id.SubscriptionId, Id.ResourceGroupName, moveResourceEnvelope, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Move resources between resource groups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/moveResources
        /// Operation Id: Move
        /// </summary>
        /// <param name="moveResourceEnvelope"> Object that represents the resource to move. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Move(CsmMoveResourceEnvelope moveResourceEnvelope, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.Move");
            scope.Start();
            try
            {
                var response = DefaultRestClient.Move(Id.SubscriptionId, Id.ResourceGroupName, moveResourceEnvelope, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Validate if a resource can be created.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/validate
        /// Operation Id: Validate
        /// </summary>
        /// <param name="validateRequest"> Request with the resources to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ValidateResponse>> ValidateAsync(ValidateRequest validateRequest, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.Validate");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.ValidateAsync(Id.SubscriptionId, Id.ResourceGroupName, validateRequest, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Validate if a resource can be created.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/validate
        /// Operation Id: Validate
        /// </summary>
        /// <param name="validateRequest"> Request with the resources to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ValidateResponse> Validate(ValidateRequest validateRequest, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.Validate");
            scope.Start();
            try
            {
                var response = DefaultRestClient.Validate(Id.SubscriptionId, Id.ResourceGroupName, validateRequest, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Validate whether a resource can be moved.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/validateMoveResources
        /// Operation Id: ValidateMove
        /// </summary>
        /// <param name="moveResourceEnvelope"> Object that represents the resource to move. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ValidateMoveAsync(CsmMoveResourceEnvelope moveResourceEnvelope, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.ValidateMove");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.ValidateMoveAsync(Id.SubscriptionId, Id.ResourceGroupName, moveResourceEnvelope, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Validate whether a resource can be moved.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/validateMoveResources
        /// Operation Id: ValidateMove
        /// </summary>
        /// <param name="moveResourceEnvelope"> Object that represents the resource to move. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ValidateMove(CsmMoveResourceEnvelope moveResourceEnvelope, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.ValidateMove");
            scope.Start();
            try
            {
                var response = DefaultRestClient.ValidateMove(Id.SubscriptionId, Id.ResourceGroupName, moveResourceEnvelope, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
