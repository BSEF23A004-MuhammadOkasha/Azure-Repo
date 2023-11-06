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

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A Class representing a SharedGalleryImage along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SharedGalleryImageResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSharedGalleryImageResource method.
    /// Otherwise you can get one from its parent resource <see cref="SharedGalleryResource" /> using the GetSharedGalleryImage method.
    /// </summary>
    public partial class SharedGalleryImageResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SharedGalleryImageResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="location"> The location. </param>
        /// <param name="galleryUniqueName"> The galleryUniqueName. </param>
        /// <param name="galleryImageName"> The galleryImageName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string galleryUniqueName, string galleryImageName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sharedGalleryImageClientDiagnostics;
        private readonly SharedGalleryImagesRestOperations _sharedGalleryImageRestClient;
        private readonly SharedGalleryImageData _data;

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageResource"/> class for mocking. </summary>
        protected SharedGalleryImageResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SharedGalleryImageResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SharedGalleryImageResource(ArmClient client, SharedGalleryImageData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SharedGalleryImageResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sharedGalleryImageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sharedGalleryImageApiVersion);
            _sharedGalleryImageRestClient = new SharedGalleryImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sharedGalleryImageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/locations/sharedGalleries/images";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SharedGalleryImageData Data
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

        /// <summary> Gets a collection of SharedGalleryImageVersionResources in the SharedGalleryImage. </summary>
        /// <returns> An object representing collection of SharedGalleryImageVersionResources and their operations over a SharedGalleryImageVersionResource. </returns>
        public virtual SharedGalleryImageVersionCollection GetSharedGalleryImageVersions()
        {
            return GetCachedClient(client => new SharedGalleryImageVersionCollection(client, Id));
        }

        /// <summary>
        /// Get a shared gallery image version by subscription id or tenant id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SharedGalleryImageVersionResource>> GetSharedGalleryImageVersionAsync(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            return await GetSharedGalleryImageVersions().GetAsync(galleryImageVersionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a shared gallery image version by subscription id or tenant id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SharedGalleryImageVersionResource> GetSharedGalleryImageVersion(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            return GetSharedGalleryImageVersions().Get(galleryImageVersionName, cancellationToken);
        }

        /// <summary>
        /// Get a shared gallery image by subscription id or tenant id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SharedGalleryImageResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageResource.Get");
            scope.Start();
            try
            {
                var response = await _sharedGalleryImageRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name);
                return Response.FromValue(new SharedGalleryImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a shared gallery image by subscription id or tenant id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SharedGalleryImageResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageResource.Get");
            scope.Start();
            try
            {
                var response = _sharedGalleryImageRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name);
                return Response.FromValue(new SharedGalleryImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
