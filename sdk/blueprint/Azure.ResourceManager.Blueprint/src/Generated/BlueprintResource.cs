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

namespace Azure.ResourceManager.Blueprint
{
    /// <summary>
    /// A Class representing a Blueprint along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="BlueprintResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetBlueprintResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetBlueprint method.
    /// </summary>
    public partial class BlueprintResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BlueprintResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceScope, string blueprintName)
        {
            var resourceId = $"{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _blueprintClientDiagnostics;
        private readonly BlueprintsRestOperations _blueprintRestClient;
        private readonly ClientDiagnostics _publishedBlueprintClientDiagnostics;
        private readonly PublishedBlueprintsRestOperations _publishedBlueprintRestClient;
        private readonly BlueprintData _data;

        /// <summary> Initializes a new instance of the <see cref="BlueprintResource"/> class for mocking. </summary>
        protected BlueprintResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BlueprintResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BlueprintResource(ArmClient client, BlueprintData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BlueprintResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BlueprintResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _blueprintClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Blueprint", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string blueprintApiVersion);
            _blueprintRestClient = new BlueprintsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, blueprintApiVersion);
            _publishedBlueprintClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Blueprint", PublishedBlueprintResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PublishedBlueprintResource.ResourceType, out string publishedBlueprintApiVersion);
            _publishedBlueprintRestClient = new PublishedBlueprintsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, publishedBlueprintApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Blueprint/blueprints";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BlueprintData Data
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

        /// <summary> Gets a collection of BlueprintArtifactResources in the Blueprint. </summary>
        /// <returns> An object representing collection of BlueprintArtifactResources and their operations over a BlueprintArtifactResource. </returns>
        public virtual BlueprintArtifactCollection GetBlueprintArtifacts()
        {
            return GetCachedClient(Client => new BlueprintArtifactCollection(Client, Id));
        }

        /// <summary>
        /// Get a blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BlueprintArtifactResource>> GetBlueprintArtifactAsync(string artifactName, CancellationToken cancellationToken = default)
        {
            return await GetBlueprintArtifacts().GetAsync(artifactName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<BlueprintArtifactResource> GetBlueprintArtifact(string artifactName, CancellationToken cancellationToken = default)
        {
            return GetBlueprintArtifacts().Get(artifactName, cancellationToken);
        }

        /// <summary> Gets a collection of PublishedBlueprintResources in the Blueprint. </summary>
        /// <returns> An object representing collection of PublishedBlueprintResources and their operations over a PublishedBlueprintResource. </returns>
        public virtual PublishedBlueprintCollection GetPublishedBlueprints()
        {
            return GetCachedClient(Client => new PublishedBlueprintCollection(Client, Id));
        }

        /// <summary>
        /// Get a published version of a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PublishedBlueprintResource>> GetPublishedBlueprintAsync(string versionId, CancellationToken cancellationToken = default)
        {
            return await GetPublishedBlueprints().GetAsync(versionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a published version of a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<PublishedBlueprintResource> GetPublishedBlueprint(string versionId, CancellationToken cancellationToken = default)
        {
            return GetPublishedBlueprints().Get(versionId, cancellationToken);
        }

        /// <summary>
        /// Get a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BlueprintResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _blueprintClientDiagnostics.CreateScope("BlueprintResource.Get");
            scope.Start();
            try
            {
                var response = await _blueprintRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlueprintResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BlueprintResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _blueprintClientDiagnostics.CreateScope("BlueprintResource.Get");
            scope.Start();
            try
            {
                var response = _blueprintRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlueprintResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<BlueprintResource>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _blueprintClientDiagnostics.CreateScope("BlueprintResource.Delete");
            scope.Start();
            try
            {
                var response = await _blueprintRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new BlueprintArmOperation<BlueprintResource>(Response.FromValue(new BlueprintResource(Client, response), response.GetRawResponse()));
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
        /// Delete a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<BlueprintResource> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _blueprintClientDiagnostics.CreateScope("BlueprintResource.Delete");
            scope.Start();
            try
            {
                var response = _blueprintRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new BlueprintArmOperation<BlueprintResource>(Response.FromValue(new BlueprintResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BlueprintResource>> UpdateAsync(WaitUntil waitUntil, BlueprintData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _blueprintClientDiagnostics.CreateScope("BlueprintResource.Update");
            scope.Start();
            try
            {
                var response = await _blueprintRestClient.CreateOrUpdateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new BlueprintArmOperation<BlueprintResource>(Response.FromValue(new BlueprintResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BlueprintResource> Update(WaitUntil waitUntil, BlueprintData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _blueprintClientDiagnostics.CreateScope("BlueprintResource.Update");
            scope.Start();
            try
            {
                var response = _blueprintRestClient.CreateOrUpdate(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new BlueprintArmOperation<BlueprintResource>(Response.FromValue(new BlueprintResource(Client, response), response.GetRawResponse()));
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
        /// List published versions of given blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PublishedBlueprintResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PublishedBlueprintResource> GetPublishedBlueprintsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _publishedBlueprintRestClient.CreateListRequest(Id.Parent, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publishedBlueprintRestClient.CreateListNextPageRequest(nextLink, Id.Parent, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PublishedBlueprintResource(Client, PublishedBlueprintData.DeserializePublishedBlueprintData(e)), _publishedBlueprintClientDiagnostics, Pipeline, "BlueprintResource.GetPublishedBlueprints", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List published versions of given blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PublishedBlueprintResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PublishedBlueprintResource> GetPublishedBlueprints(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _publishedBlueprintRestClient.CreateListRequest(Id.Parent, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publishedBlueprintRestClient.CreateListNextPageRequest(nextLink, Id.Parent, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PublishedBlueprintResource(Client, PublishedBlueprintData.DeserializePublishedBlueprintData(e)), _publishedBlueprintClientDiagnostics, Pipeline, "BlueprintResource.GetPublishedBlueprints", "value", "nextLink", cancellationToken);
        }
    }
}
