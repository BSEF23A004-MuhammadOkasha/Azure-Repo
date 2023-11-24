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

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary>
    /// A Class representing a DigitalTwinsPrivateLinkResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DigitalTwinsPrivateLinkResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDigitalTwinsPrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="DigitalTwinsDescriptionResource"/> using the GetDigitalTwinsPrivateLinkResource method.
    /// </summary>
    public partial class DigitalTwinsPrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DigitalTwinsPrivateLinkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="resourceId"> The resourceId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string resourceId)
        {
            var resourceId0 = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/privateLinkResources/{resourceId}";
            return new ResourceIdentifier(resourceId0);
        }

        private readonly ClientDiagnostics _digitalTwinsPrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _digitalTwinsPrivateLinkResourcePrivateLinkResourcesRestClient;
        private readonly DigitalTwinsPrivateLinkResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="DigitalTwinsPrivateLinkResource"/> class for mocking. </summary>
        protected DigitalTwinsPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DigitalTwinsPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DigitalTwinsPrivateLinkResource(ArmClient client, DigitalTwinsPrivateLinkResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DigitalTwinsPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DigitalTwinsPrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _digitalTwinsPrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DigitalTwins", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string digitalTwinsPrivateLinkResourcePrivateLinkResourcesApiVersion);
            _digitalTwinsPrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, digitalTwinsPrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DigitalTwins/digitalTwinsInstances/privateLinkResources";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DigitalTwinsPrivateLinkResourceData Data
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

        /// <summary>
        /// Get the specified private link resource for the given Digital Twin.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/privateLinkResources/{resourceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DigitalTwinsPrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _digitalTwinsPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("DigitalTwinsPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _digitalTwinsPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DigitalTwinsPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified private link resource for the given Digital Twin.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/privateLinkResources/{resourceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DigitalTwinsPrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _digitalTwinsPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("DigitalTwinsPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _digitalTwinsPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DigitalTwinsPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
