// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Media.Models;

namespace Azure.ResourceManager.Media
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _mediaServicesAccountMediaservicesClientDiagnostics;
        private MediaservicesRestOperations _mediaServicesAccountMediaservicesRestClient;
        private ClientDiagnostics _locationsClientDiagnostics;
        private LocationsRestOperations _locationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics MediaServicesAccountMediaservicesClientDiagnostics => _mediaServicesAccountMediaservicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Media", MediaServicesAccountResource.ResourceType.Namespace, Diagnostics);
        private MediaservicesRestOperations MediaServicesAccountMediaservicesRestClient => _mediaServicesAccountMediaservicesRestClient ??= new MediaservicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(MediaServicesAccountResource.ResourceType));
        private ClientDiagnostics LocationsClientDiagnostics => _locationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Media", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationsRestOperations LocationsRestClient => _locationsRestClient ??= new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List Media Services accounts in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Media/mediaservices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Mediaservices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MediaServicesAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MediaServicesAccountResource> GetMediaServicesAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MediaServicesAccountMediaservicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MediaServicesAccountMediaservicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new MediaServicesAccountResource(Client, MediaServicesAccountData.DeserializeMediaServicesAccountData(e)), MediaServicesAccountMediaservicesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetMediaServicesAccounts", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// List Media Services accounts in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Media/mediaservices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Mediaservices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MediaServicesAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MediaServicesAccountResource> GetMediaServicesAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MediaServicesAccountMediaservicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MediaServicesAccountMediaservicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new MediaServicesAccountResource(Client, MediaServicesAccountData.DeserializeMediaServicesAccountData(e)), MediaServicesAccountMediaservicesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetMediaServicesAccounts", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks whether the Media Service resource name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> Location name. </param>
        /// <param name="content"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MediaServicesNameAvailabilityResult>> CheckMediaServicesNameAvailabilityAsync(AzureLocation locationName, MediaServicesNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMediaServicesNameAvailability");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, locationName, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks whether the Media Service resource name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> Location name. </param>
        /// <param name="content"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MediaServicesNameAvailabilityResult> CheckMediaServicesNameAvailability(AzureLocation locationName, MediaServicesNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMediaServicesNameAvailability");
            scope.Start();
            try
            {
                var response = LocationsRestClient.CheckNameAvailability(Id.SubscriptionId, locationName, content, cancellationToken);
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
