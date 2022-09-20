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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Attestation/attestationProviders
        /// Operation Id: AttestationProviders_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AttestationProviderResource> GetAttestationProvidersAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AttestationProviderResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AttestationProviderClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAttestationProviders");
                scope.Start();
                try
                {
                    var response = await AttestationProviderRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AttestationProviderResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Returns a list of attestation providers in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Attestation/attestationProviders
        /// Operation Id: AttestationProviders_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AttestationProviderResource> GetAttestationProviders(CancellationToken cancellationToken = default)
        {
            Page<AttestationProviderResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AttestationProviderClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAttestationProviders");
                scope.Start();
                try
                {
                    var response = AttestationProviderRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AttestationProviderResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get the default provider
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Attestation/defaultProviders
        /// Operation Id: AttestationProviders_ListDefault
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AttestationProviderResource> GetAttestationProvidersByDefaultProviderAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AttestationProviderResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AttestationProviderClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAttestationProvidersByDefaultProvider");
                scope.Start();
                try
                {
                    var response = await AttestationProviderRestClient.ListDefaultAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AttestationProviderResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get the default provider
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Attestation/defaultProviders
        /// Operation Id: AttestationProviders_ListDefault
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AttestationProviderResource> GetAttestationProvidersByDefaultProvider(CancellationToken cancellationToken = default)
        {
            Page<AttestationProviderResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AttestationProviderClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAttestationProvidersByDefaultProvider");
                scope.Start();
                try
                {
                    var response = AttestationProviderRestClient.ListDefault(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AttestationProviderResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get the default provider by location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Attestation/locations/{location}/defaultProvider
        /// Operation Id: AttestationProviders_GetDefaultByLocation
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Attestation/locations/{location}/defaultProvider
        /// Operation Id: AttestationProviders_GetDefaultByLocation
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
