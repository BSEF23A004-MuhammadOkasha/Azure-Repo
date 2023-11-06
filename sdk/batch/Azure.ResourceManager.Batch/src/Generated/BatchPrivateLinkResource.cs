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

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A Class representing a BatchPrivateLinkResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="BatchPrivateLinkResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetBatchPrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="BatchAccountResource" /> using the GetBatchPrivateLinkResource method.
    /// </summary>
    public partial class BatchPrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BatchPrivateLinkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="privateLinkResourceName"> The privateLinkResourceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string privateLinkResourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/privateLinkResources/{privateLinkResourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _batchPrivateLinkResourcePrivateLinkResourceClientDiagnostics;
        private readonly PrivateLinkResourceRestOperations _batchPrivateLinkResourcePrivateLinkResourceRestClient;
        private readonly BatchPrivateLinkResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="BatchPrivateLinkResource"/> class for mocking. </summary>
        protected BatchPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BatchPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BatchPrivateLinkResource(ArmClient client, BatchPrivateLinkResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BatchPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BatchPrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _batchPrivateLinkResourcePrivateLinkResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Batch", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string batchPrivateLinkResourcePrivateLinkResourceApiVersion);
            _batchPrivateLinkResourcePrivateLinkResourceRestClient = new PrivateLinkResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, batchPrivateLinkResourcePrivateLinkResourceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Batch/batchAccounts/privateLinkResources";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BatchPrivateLinkResourceData Data
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
        /// Gets information about the specified private link resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResource_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BatchPrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _batchPrivateLinkResourcePrivateLinkResourceClientDiagnostics.CreateScope("BatchPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _batchPrivateLinkResourcePrivateLinkResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified private link resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResource_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BatchPrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _batchPrivateLinkResourcePrivateLinkResourceClientDiagnostics.CreateScope("BatchPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _batchPrivateLinkResourcePrivateLinkResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
