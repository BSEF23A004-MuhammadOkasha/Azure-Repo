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

namespace Azure.ResourceManager.Purview
{
    /// <summary>
    /// A Class representing a PurviewPrivateLinkResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PurviewPrivateLinkResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPurviewPrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="PurviewAccountResource" /> using the GetPurviewPrivateLinkResource method.
    /// </summary>
    public partial class PurviewPrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PurviewPrivateLinkResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string groupId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/privateLinkResources/{groupId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _purviewPrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _purviewPrivateLinkResourcePrivateLinkResourcesRestClient;
        private readonly PurviewPrivateLinkResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="PurviewPrivateLinkResource"/> class for mocking. </summary>
        protected PurviewPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PurviewPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PurviewPrivateLinkResource(ArmClient client, PurviewPrivateLinkResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PurviewPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PurviewPrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _purviewPrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Purview", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string purviewPrivateLinkResourcePrivateLinkResourcesApiVersion);
            _purviewPrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, purviewPrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Purview/accounts/privateLinkResources";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PurviewPrivateLinkResourceData Data
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
        /// Gets a privately linkable resources for an account with given group identifier
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/privateLinkResources/{groupId}
        /// Operation Id: PrivateLinkResources_GetByGroupId
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PurviewPrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _purviewPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("PurviewPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _purviewPrivateLinkResourcePrivateLinkResourcesRestClient.GetByGroupIdAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PurviewPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a privately linkable resources for an account with given group identifier
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/privateLinkResources/{groupId}
        /// Operation Id: PrivateLinkResources_GetByGroupId
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PurviewPrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _purviewPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("PurviewPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _purviewPrivateLinkResourcePrivateLinkResourcesRestClient.GetByGroupId(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PurviewPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
