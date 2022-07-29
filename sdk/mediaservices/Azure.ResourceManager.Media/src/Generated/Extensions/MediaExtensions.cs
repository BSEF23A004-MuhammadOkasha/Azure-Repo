// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Media
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Media. </summary>
    public static partial class MediaExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of MediaServiceOperationResultResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of MediaServiceOperationResultResources and their operations over a MediaServiceOperationResultResource. </returns>
        public static MediaServiceOperationResultCollection GetMediaServiceOperationResults(this SubscriptionResource subscriptionResource)
        {
            return GetExtensionClient(subscriptionResource).GetMediaServiceOperationResults();
        }

        /// <summary>
        /// Get media service operation result.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/mediaServicesOperationResults/{operationId}
        /// Operation Id: MediaServicesOperationResults_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> Location name. </param>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="operationId"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<MediaServiceOperationResultResource>> GetMediaServiceOperationResultAsync(this SubscriptionResource subscriptionResource, string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetMediaServiceOperationResults().GetAsync(locationName, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get media service operation result.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/mediaServicesOperationResults/{operationId}
        /// Operation Id: MediaServicesOperationResults_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> Location name. </param>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="operationId"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<MediaServiceOperationResultResource> GetMediaServiceOperationResult(this SubscriptionResource subscriptionResource, string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetMediaServiceOperationResults().Get(locationName, operationId, cancellationToken);
        }

        /// <summary>
        /// List Media Services accounts in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/mediaservices
        /// Operation Id: Mediaservices_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MediaServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<MediaServiceResource> GetMediaServicesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetMediaServicesAsync(cancellationToken);
        }

        /// <summary>
        /// List Media Services accounts in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/mediaservices
        /// Operation Id: Mediaservices_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MediaServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<MediaServiceResource> GetMediaServices(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetMediaServices(cancellationToken);
        }

        /// <summary>
        /// Checks whether the Media Service resource name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/checkNameAvailability
        /// Operation Id: Locations_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> Location name. </param>
        /// <param name="content"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<MediaNameAvailabilityResult>> CheckMediaNameAvailabilityAsync(this SubscriptionResource subscriptionResource, string locationName, MediaNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckMediaNameAvailabilityAsync(locationName, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks whether the Media Service resource name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/checkNameAvailability
        /// Operation Id: Locations_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> Location name. </param>
        /// <param name="content"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="content"/> is null. </exception>
        public static Response<MediaNameAvailabilityResult> CheckMediaNameAvailability(this SubscriptionResource subscriptionResource, string locationName, MediaNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckMediaNameAvailability(locationName, content, cancellationToken);
        }

        /// <summary>
        /// Get media service operation status.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/mediaServicesOperationStatuses/{operationId}
        /// Operation Id: MediaServicesOperationStatuses_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> Location name. </param>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="operationId"/> is null. </exception>
        public static async Task<Response<MediaServiceOperationStatus>> GetMediaServicesOperationStatusAsync(this SubscriptionResource subscriptionResource, string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return await GetExtensionClient(subscriptionResource).GetMediaServicesOperationStatusAsync(locationName, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get media service operation status.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/mediaServicesOperationStatuses/{operationId}
        /// Operation Id: MediaServicesOperationStatuses_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> Location name. </param>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="operationId"/> is null. </exception>
        public static Response<MediaServiceOperationStatus> GetMediaServicesOperationStatus(this SubscriptionResource subscriptionResource, string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(subscriptionResource).GetMediaServicesOperationStatus(locationName, operationId, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of MediaServiceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of MediaServiceResources and their operations over a MediaServiceResource. </returns>
        public static MediaServiceCollection GetMediaServices(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetMediaServices();
        }

        /// <summary>
        /// Get the details of a Media Services account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}
        /// Operation Id: Mediaservices_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<MediaServiceResource>> GetMediaServiceAsync(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetMediaServices().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the details of a Media Services account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}
        /// Operation Id: Mediaservices_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<MediaServiceResource> GetMediaService(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetMediaServices().Get(accountName, cancellationToken);
        }

        #region AccountFilterResource
        /// <summary>
        /// Gets an object representing an <see cref="AccountFilterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AccountFilterResource.CreateResourceIdentifier" /> to create an <see cref="AccountFilterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AccountFilterResource" /> object. </returns>
        public static AccountFilterResource GetAccountFilterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AccountFilterResource.ValidateResourceId(id);
                return new AccountFilterResource(client, id);
            }
            );
        }
        #endregion

        #region MediaServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="MediaServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MediaServiceResource.CreateResourceIdentifier" /> to create a <see cref="MediaServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MediaServiceResource" /> object. </returns>
        public static MediaServiceResource GetMediaServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MediaServiceResource.ValidateResourceId(id);
                return new MediaServiceResource(client, id);
            }
            );
        }
        #endregion

        #region MediaServiceOperationResultResource
        /// <summary>
        /// Gets an object representing a <see cref="MediaServiceOperationResultResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MediaServiceOperationResultResource.CreateResourceIdentifier" /> to create a <see cref="MediaServiceOperationResultResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MediaServiceOperationResultResource" /> object. </returns>
        public static MediaServiceOperationResultResource GetMediaServiceOperationResultResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MediaServiceOperationResultResource.ValidateResourceId(id);
                return new MediaServiceOperationResultResource(client, id);
            }
            );
        }
        #endregion

        #region MediaPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="MediaPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MediaPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="MediaPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MediaPrivateLinkResource" /> object. </returns>
        public static MediaPrivateLinkResource GetMediaPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MediaPrivateLinkResource.ValidateResourceId(id);
                return new MediaPrivateLinkResource(client, id);
            }
            );
        }
        #endregion

        #region MediaPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="MediaPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MediaPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="MediaPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MediaPrivateEndpointConnectionResource" /> object. </returns>
        public static MediaPrivateEndpointConnectionResource GetMediaPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MediaPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new MediaPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region MediaAssetResource
        /// <summary>
        /// Gets an object representing a <see cref="MediaAssetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MediaAssetResource.CreateResourceIdentifier" /> to create a <see cref="MediaAssetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MediaAssetResource" /> object. </returns>
        public static MediaAssetResource GetMediaAssetResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MediaAssetResource.ValidateResourceId(id);
                return new MediaAssetResource(client, id);
            }
            );
        }
        #endregion

        #region AssetFilterResource
        /// <summary>
        /// Gets an object representing an <see cref="AssetFilterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AssetFilterResource.CreateResourceIdentifier" /> to create an <see cref="AssetFilterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AssetFilterResource" /> object. </returns>
        public static AssetFilterResource GetAssetFilterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AssetFilterResource.ValidateResourceId(id);
                return new AssetFilterResource(client, id);
            }
            );
        }
        #endregion

        #region MediaAssetTrackResource
        /// <summary>
        /// Gets an object representing a <see cref="MediaAssetTrackResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MediaAssetTrackResource.CreateResourceIdentifier" /> to create a <see cref="MediaAssetTrackResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MediaAssetTrackResource" /> object. </returns>
        public static MediaAssetTrackResource GetMediaAssetTrackResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MediaAssetTrackResource.ValidateResourceId(id);
                return new MediaAssetTrackResource(client, id);
            }
            );
        }
        #endregion

        #region MediaAssetTrackOperationResultResource
        /// <summary>
        /// Gets an object representing a <see cref="MediaAssetTrackOperationResultResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MediaAssetTrackOperationResultResource.CreateResourceIdentifier" /> to create a <see cref="MediaAssetTrackOperationResultResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MediaAssetTrackOperationResultResource" /> object. </returns>
        public static MediaAssetTrackOperationResultResource GetMediaAssetTrackOperationResultResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MediaAssetTrackOperationResultResource.ValidateResourceId(id);
                return new MediaAssetTrackOperationResultResource(client, id);
            }
            );
        }
        #endregion

        #region ContentKeyPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="ContentKeyPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContentKeyPolicyResource.CreateResourceIdentifier" /> to create a <see cref="ContentKeyPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContentKeyPolicyResource" /> object. </returns>
        public static ContentKeyPolicyResource GetContentKeyPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ContentKeyPolicyResource.ValidateResourceId(id);
                return new ContentKeyPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region MediaTransformResource
        /// <summary>
        /// Gets an object representing a <see cref="MediaTransformResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MediaTransformResource.CreateResourceIdentifier" /> to create a <see cref="MediaTransformResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MediaTransformResource" /> object. </returns>
        public static MediaTransformResource GetMediaTransformResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MediaTransformResource.ValidateResourceId(id);
                return new MediaTransformResource(client, id);
            }
            );
        }
        #endregion

        #region MediaTransformJobResource
        /// <summary>
        /// Gets an object representing a <see cref="MediaTransformJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MediaTransformJobResource.CreateResourceIdentifier" /> to create a <see cref="MediaTransformJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MediaTransformJobResource" /> object. </returns>
        public static MediaTransformJobResource GetMediaTransformJobResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MediaTransformJobResource.ValidateResourceId(id);
                return new MediaTransformJobResource(client, id);
            }
            );
        }
        #endregion

        #region StreamingPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="StreamingPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StreamingPolicyResource.CreateResourceIdentifier" /> to create a <see cref="StreamingPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StreamingPolicyResource" /> object. </returns>
        public static StreamingPolicyResource GetStreamingPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StreamingPolicyResource.ValidateResourceId(id);
                return new StreamingPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region StreamingLocatorResource
        /// <summary>
        /// Gets an object representing a <see cref="StreamingLocatorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StreamingLocatorResource.CreateResourceIdentifier" /> to create a <see cref="StreamingLocatorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StreamingLocatorResource" /> object. </returns>
        public static StreamingLocatorResource GetStreamingLocatorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StreamingLocatorResource.ValidateResourceId(id);
                return new StreamingLocatorResource(client, id);
            }
            );
        }
        #endregion

        #region LiveEventResource
        /// <summary>
        /// Gets an object representing a <see cref="LiveEventResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LiveEventResource.CreateResourceIdentifier" /> to create a <see cref="LiveEventResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LiveEventResource" /> object. </returns>
        public static LiveEventResource GetLiveEventResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                LiveEventResource.ValidateResourceId(id);
                return new LiveEventResource(client, id);
            }
            );
        }
        #endregion

        #region LiveOutputResource
        /// <summary>
        /// Gets an object representing a <see cref="LiveOutputResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LiveOutputResource.CreateResourceIdentifier" /> to create a <see cref="LiveOutputResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LiveOutputResource" /> object. </returns>
        public static LiveOutputResource GetLiveOutputResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                LiveOutputResource.ValidateResourceId(id);
                return new LiveOutputResource(client, id);
            }
            );
        }
        #endregion

        #region StreamingEndpointResource
        /// <summary>
        /// Gets an object representing a <see cref="StreamingEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StreamingEndpointResource.CreateResourceIdentifier" /> to create a <see cref="StreamingEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StreamingEndpointResource" /> object. </returns>
        public static StreamingEndpointResource GetStreamingEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StreamingEndpointResource.ValidateResourceId(id);
                return new StreamingEndpointResource(client, id);
            }
            );
        }
        #endregion
    }
}
