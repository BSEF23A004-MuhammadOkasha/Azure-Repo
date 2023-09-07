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

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="MediaAssetTrackResource" /> and their operations.
    /// Each <see cref="MediaAssetTrackResource" /> in the collection will belong to the same instance of <see cref="MediaAssetResource" />.
    /// To get a <see cref="MediaAssetTrackCollection" /> instance call the GetMediaAssetTracks method from an instance of <see cref="MediaAssetResource" />.
    /// </summary>
    public partial class MediaAssetTrackCollection : ArmCollection, IEnumerable<MediaAssetTrackResource>, IAsyncEnumerable<MediaAssetTrackResource>
    {
        private readonly ClientDiagnostics _mediaAssetTrackTracksClientDiagnostics;
        private readonly TracksRestOperations _mediaAssetTrackTracksRestClient;

        /// <summary> Initializes a new instance of the <see cref="MediaAssetTrackCollection"/> class for mocking. </summary>
        protected MediaAssetTrackCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MediaAssetTrackCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MediaAssetTrackCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mediaAssetTrackTracksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", MediaAssetTrackResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MediaAssetTrackResource.ResourceType, out string mediaAssetTrackTracksApiVersion);
            _mediaAssetTrackTracksRestClient = new TracksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mediaAssetTrackTracksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MediaAssetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MediaAssetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Track in the asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="trackName"> The Asset Track name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trackName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MediaAssetTrackResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string trackName, MediaAssetTrackData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trackName, nameof(trackName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mediaAssetTrackTracksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, trackName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<MediaAssetTrackResource>(new MediaAssetTrackOperationSource(Client), _mediaAssetTrackTracksClientDiagnostics, Pipeline, _mediaAssetTrackTracksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, trackName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Create or update a Track in the asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="trackName"> The Asset Track name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trackName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MediaAssetTrackResource> CreateOrUpdate(WaitUntil waitUntil, string trackName, MediaAssetTrackData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trackName, nameof(trackName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mediaAssetTrackTracksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, trackName, data, cancellationToken);
                var operation = new MediaArmOperation<MediaAssetTrackResource>(new MediaAssetTrackOperationSource(Client), _mediaAssetTrackTracksClientDiagnostics, Pipeline, _mediaAssetTrackTracksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, trackName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Get the details of a Track in the Asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trackName"> The Asset Track name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trackName"/> is null. </exception>
        public virtual async Task<Response<MediaAssetTrackResource>> GetAsync(string trackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trackName, nameof(trackName));

            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackCollection.Get");
            scope.Start();
            try
            {
                var response = await _mediaAssetTrackTracksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, trackName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaAssetTrackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of a Track in the Asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trackName"> The Asset Track name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trackName"/> is null. </exception>
        public virtual Response<MediaAssetTrackResource> Get(string trackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trackName, nameof(trackName));

            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackCollection.Get");
            scope.Start();
            try
            {
                var response = _mediaAssetTrackTracksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, trackName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaAssetTrackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Tracks in the asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MediaAssetTrackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MediaAssetTrackResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaAssetTrackTracksRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new MediaAssetTrackResource(Client, MediaAssetTrackData.DeserializeMediaAssetTrackData(e)), _mediaAssetTrackTracksClientDiagnostics, Pipeline, "MediaAssetTrackCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the Tracks in the asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MediaAssetTrackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MediaAssetTrackResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaAssetTrackTracksRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new MediaAssetTrackResource(Client, MediaAssetTrackData.DeserializeMediaAssetTrackData(e)), _mediaAssetTrackTracksClientDiagnostics, Pipeline, "MediaAssetTrackCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trackName"> The Asset Track name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trackName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string trackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trackName, nameof(trackName));

            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mediaAssetTrackTracksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, trackName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trackName"> The Asset Track name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trackName"/> is null. </exception>
        public virtual Response<bool> Exists(string trackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trackName, nameof(trackName));

            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackCollection.Exists");
            scope.Start();
            try
            {
                var response = _mediaAssetTrackTracksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, trackName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MediaAssetTrackResource> IEnumerable<MediaAssetTrackResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MediaAssetTrackResource> IAsyncEnumerable<MediaAssetTrackResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
