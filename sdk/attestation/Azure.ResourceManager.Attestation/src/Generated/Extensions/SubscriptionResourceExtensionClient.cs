// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Attestation
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _attestationProviderClientDiagnostics;
        private AttestationProvidersRestOperations _attestationProviderRestClient;

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

        private ClientDiagnostics AttestationProviderClientDiagnostics => _attestationProviderClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Attestation", AttestationProviderResource.ResourceType.Namespace, Diagnostics);
        private AttestationProvidersRestOperations AttestationProviderRestClient => _attestationProviderRestClient ??= new AttestationProvidersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AttestationProviderResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Returns a list of attestation providers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/attestationProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AttestationProviderResource> GetAttestationProvidersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AttestationProviderRestClient.CreateListRequest(Id.SubscriptionId);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AttestationProviderResource(Client, AttestationProviderData.DeserializeAttestationProviderData(e)), AttestationProviderClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAttestationProviders", "value", null, cancellationToken);
        }

        /// <summary>
        /// Returns a list of attestation providers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/attestationProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AttestationProviderResource> GetAttestationProviders(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AttestationProviderRestClient.CreateListRequest(Id.SubscriptionId);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, null, e => new AttestationProviderResource(Client, AttestationProviderData.DeserializeAttestationProviderData(e)), AttestationProviderClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAttestationProviders", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the default provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/defaultProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_ListDefault</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AttestationProviderResource> GetAttestationProvidersByDefaultProviderAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AttestationProviderRestClient.CreateListDefaultRequest(Id.SubscriptionId);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AttestationProviderResource(Client, AttestationProviderData.DeserializeAttestationProviderData(e)), AttestationProviderClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAttestationProvidersByDefaultProvider", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the default provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/defaultProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_ListDefault</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AttestationProviderResource> GetAttestationProvidersByDefaultProvider(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AttestationProviderRestClient.CreateListDefaultRequest(Id.SubscriptionId);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, null, e => new AttestationProviderResource(Client, AttestationProviderData.DeserializeAttestationProviderData(e)), AttestationProviderClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAttestationProvidersByDefaultProvider", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the default provider by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/locations/{location}/defaultProvider</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_GetDefaultByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the default provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AttestationProviderResource>> GetDefaultByLocationAttestationProviderAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = AttestationProviderClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDefaultByLocationAttestationProvider");
            scope.Start();
            try
            {
                var response = await AttestationProviderRestClient.GetDefaultByLocationAsync(Id.SubscriptionId, location, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AttestationProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the default provider by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/locations/{location}/defaultProvider</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_GetDefaultByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the default provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AttestationProviderResource> GetDefaultByLocationAttestationProvider(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = AttestationProviderClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDefaultByLocationAttestationProvider");
            scope.Start();
            try
            {
                var response = AttestationProviderRestClient.GetDefaultByLocation(Id.SubscriptionId, location, cancellationToken);
                return Response.FromValue(new AttestationProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
