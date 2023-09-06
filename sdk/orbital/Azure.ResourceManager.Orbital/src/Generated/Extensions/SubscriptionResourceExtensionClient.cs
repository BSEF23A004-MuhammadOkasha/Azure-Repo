// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Orbital
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _orbitalSpacecraftSpacecraftsClientDiagnostics;
        private SpacecraftsRestOperations _orbitalSpacecraftSpacecraftsRestClient;
        private ClientDiagnostics _orbitalContactProfileContactProfilesClientDiagnostics;
        private ContactProfilesRestOperations _orbitalContactProfileContactProfilesRestClient;

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

        private ClientDiagnostics OrbitalSpacecraftSpacecraftsClientDiagnostics => _orbitalSpacecraftSpacecraftsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Orbital", OrbitalSpacecraftResource.ResourceType.Namespace, Diagnostics);
        private SpacecraftsRestOperations OrbitalSpacecraftSpacecraftsRestClient => _orbitalSpacecraftSpacecraftsRestClient ??= new SpacecraftsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(OrbitalSpacecraftResource.ResourceType));
        private ClientDiagnostics OrbitalContactProfileContactProfilesClientDiagnostics => _orbitalContactProfileContactProfilesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Orbital", OrbitalContactProfileResource.ResourceType.Namespace, Diagnostics);
        private ContactProfilesRestOperations OrbitalContactProfileContactProfilesRestClient => _orbitalContactProfileContactProfilesRestClient ??= new ContactProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(OrbitalContactProfileResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AvailableGroundStationResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of AvailableGroundStationResources and their operations over a AvailableGroundStationResource. </returns>
        public virtual AvailableGroundStationCollection GetAvailableGroundStations()
        {
            return GetCachedClient(Client => new AvailableGroundStationCollection(Client, Id));
        }

        /// <summary>
        /// Returns list of spacecrafts by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/spacecrafts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrbitalSpacecraftResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OrbitalSpacecraftResource> GetOrbitalSpacecraftsAsync(string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OrbitalSpacecraftSpacecraftsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OrbitalSpacecraftSpacecraftsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new OrbitalSpacecraftResource(Client, OrbitalSpacecraftData.DeserializeOrbitalSpacecraftData(e)), OrbitalSpacecraftSpacecraftsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetOrbitalSpacecrafts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of spacecrafts by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/spacecrafts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrbitalSpacecraftResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OrbitalSpacecraftResource> GetOrbitalSpacecrafts(string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OrbitalSpacecraftSpacecraftsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OrbitalSpacecraftSpacecraftsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new OrbitalSpacecraftResource(Client, OrbitalSpacecraftData.DeserializeOrbitalSpacecraftData(e)), OrbitalSpacecraftSpacecraftsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetOrbitalSpacecrafts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of contact profiles by Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/contactProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContactProfiles_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrbitalContactProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OrbitalContactProfileResource> GetOrbitalContactProfilesAsync(string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OrbitalContactProfileContactProfilesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OrbitalContactProfileContactProfilesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new OrbitalContactProfileResource(Client, OrbitalContactProfileData.DeserializeOrbitalContactProfileData(e)), OrbitalContactProfileContactProfilesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetOrbitalContactProfiles", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of contact profiles by Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/contactProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContactProfiles_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrbitalContactProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OrbitalContactProfileResource> GetOrbitalContactProfiles(string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OrbitalContactProfileContactProfilesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OrbitalContactProfileContactProfilesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new OrbitalContactProfileResource(Client, OrbitalContactProfileData.DeserializeOrbitalContactProfileData(e)), OrbitalContactProfileContactProfilesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetOrbitalContactProfiles", "value", "nextLink", cancellationToken);
        }
    }
}
