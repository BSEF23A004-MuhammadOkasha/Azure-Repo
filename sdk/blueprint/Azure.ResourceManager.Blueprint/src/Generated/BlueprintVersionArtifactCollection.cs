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

namespace Azure.ResourceManager.Blueprint
{
    /// <summary>
    /// A class representing a collection of <see cref="BlueprintVersionArtifactResource" /> and their operations.
    /// Each <see cref="BlueprintVersionArtifactResource" /> in the collection will belong to the same instance of <see cref="PublishedBlueprintResource" />.
    /// To get a <see cref="BlueprintVersionArtifactCollection" /> instance call the GetBlueprintVersionArtifacts method from an instance of <see cref="PublishedBlueprintResource" />.
    /// </summary>
    public partial class BlueprintVersionArtifactCollection : ArmCollection, IEnumerable<BlueprintVersionArtifactResource>, IAsyncEnumerable<BlueprintVersionArtifactResource>
    {
        private readonly ClientDiagnostics _blueprintVersionArtifactPublishedArtifactsClientDiagnostics;
        private readonly PublishedArtifactsRestOperations _blueprintVersionArtifactPublishedArtifactsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BlueprintVersionArtifactCollection"/> class for mocking. </summary>
        protected BlueprintVersionArtifactCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BlueprintVersionArtifactCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BlueprintVersionArtifactCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _blueprintVersionArtifactPublishedArtifactsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Blueprint", BlueprintVersionArtifactResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BlueprintVersionArtifactResource.ResourceType, out string blueprintVersionArtifactPublishedArtifactsApiVersion);
            _blueprintVersionArtifactPublishedArtifactsRestClient = new PublishedArtifactsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, blueprintVersionArtifactPublishedArtifactsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PublishedBlueprintResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PublishedBlueprintResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an artifact for a published blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedArtifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        public virtual async Task<Response<BlueprintVersionArtifactResource>> GetAsync(string artifactName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactName, nameof(artifactName));

            using var scope = _blueprintVersionArtifactPublishedArtifactsClientDiagnostics.CreateScope("BlueprintVersionArtifactCollection.Get");
            scope.Start();
            try
            {
                var response = await _blueprintVersionArtifactPublishedArtifactsRestClient.GetAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, artifactName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlueprintVersionArtifactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an artifact for a published blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedArtifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        public virtual Response<BlueprintVersionArtifactResource> Get(string artifactName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactName, nameof(artifactName));

            using var scope = _blueprintVersionArtifactPublishedArtifactsClientDiagnostics.CreateScope("BlueprintVersionArtifactCollection.Get");
            scope.Start();
            try
            {
                var response = _blueprintVersionArtifactPublishedArtifactsRestClient.Get(Id.Parent.Parent, Id.Parent.Name, Id.Name, artifactName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlueprintVersionArtifactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List artifacts for a version of a published blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}/artifacts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedArtifacts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BlueprintVersionArtifactResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BlueprintVersionArtifactResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _blueprintVersionArtifactPublishedArtifactsRestClient.CreateListRequest(Id.Parent.Parent, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _blueprintVersionArtifactPublishedArtifactsRestClient.CreateListNextPageRequest(nextLink, Id.Parent.Parent, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BlueprintVersionArtifactResource(Client, ArtifactData.DeserializeArtifactData(e)), _blueprintVersionArtifactPublishedArtifactsClientDiagnostics, Pipeline, "BlueprintVersionArtifactCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List artifacts for a version of a published blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}/artifacts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedArtifacts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BlueprintVersionArtifactResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BlueprintVersionArtifactResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _blueprintVersionArtifactPublishedArtifactsRestClient.CreateListRequest(Id.Parent.Parent, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _blueprintVersionArtifactPublishedArtifactsRestClient.CreateListNextPageRequest(nextLink, Id.Parent.Parent, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BlueprintVersionArtifactResource(Client, ArtifactData.DeserializeArtifactData(e)), _blueprintVersionArtifactPublishedArtifactsClientDiagnostics, Pipeline, "BlueprintVersionArtifactCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedArtifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string artifactName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactName, nameof(artifactName));

            using var scope = _blueprintVersionArtifactPublishedArtifactsClientDiagnostics.CreateScope("BlueprintVersionArtifactCollection.Exists");
            scope.Start();
            try
            {
                var response = await _blueprintVersionArtifactPublishedArtifactsRestClient.GetAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, artifactName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedArtifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        public virtual Response<bool> Exists(string artifactName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactName, nameof(artifactName));

            using var scope = _blueprintVersionArtifactPublishedArtifactsClientDiagnostics.CreateScope("BlueprintVersionArtifactCollection.Exists");
            scope.Start();
            try
            {
                var response = _blueprintVersionArtifactPublishedArtifactsRestClient.Get(Id.Parent.Parent, Id.Parent.Name, Id.Name, artifactName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BlueprintVersionArtifactResource> IEnumerable<BlueprintVersionArtifactResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BlueprintVersionArtifactResource> IAsyncEnumerable<BlueprintVersionArtifactResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
