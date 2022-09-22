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

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A Class representing a StorageSyncWorkflow along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StorageSyncWorkflowResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStorageSyncWorkflowResource method.
    /// Otherwise you can get one from its parent resource <see cref="StorageSyncServiceResource" /> using the GetStorageSyncWorkflow method.
    /// </summary>
    public partial class StorageSyncWorkflowResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StorageSyncWorkflowResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string storageSyncServiceName, string workflowId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/workflows/{workflowId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _storageSyncWorkflowWorkflowsClientDiagnostics;
        private readonly WorkflowsRestOperations _storageSyncWorkflowWorkflowsRestClient;
        private readonly StorageSyncWorkflowData _data;

        /// <summary> Initializes a new instance of the <see cref="StorageSyncWorkflowResource"/> class for mocking. </summary>
        protected StorageSyncWorkflowResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StorageSyncWorkflowResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StorageSyncWorkflowResource(ArmClient client, StorageSyncWorkflowData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StorageSyncWorkflowResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StorageSyncWorkflowResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageSyncWorkflowWorkflowsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageSync", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string storageSyncWorkflowWorkflowsApiVersion);
            _storageSyncWorkflowWorkflowsRestClient = new WorkflowsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageSyncWorkflowWorkflowsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StorageSync/storageSyncServices/workflows";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StorageSyncWorkflowData Data
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
        /// Get Workflows resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/workflows/{workflowId}
        /// Operation Id: Workflows_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageSyncWorkflowResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncWorkflowWorkflowsClientDiagnostics.CreateScope("StorageSyncWorkflowResource.Get");
            scope.Start();
            try
            {
                var response = await _storageSyncWorkflowWorkflowsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncWorkflowResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Workflows resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/workflows/{workflowId}
        /// Operation Id: Workflows_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageSyncWorkflowResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncWorkflowWorkflowsClientDiagnostics.CreateScope("StorageSyncWorkflowResource.Get");
            scope.Start();
            try
            {
                var response = _storageSyncWorkflowWorkflowsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncWorkflowResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Abort the given workflow.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/workflows/{workflowId}/abort
        /// Operation Id: Workflows_Abort
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AbortAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncWorkflowWorkflowsClientDiagnostics.CreateScope("StorageSyncWorkflowResource.Abort");
            scope.Start();
            try
            {
                var response = await _storageSyncWorkflowWorkflowsRestClient.AbortAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Abort the given workflow.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/workflows/{workflowId}/abort
        /// Operation Id: Workflows_Abort
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Abort(CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncWorkflowWorkflowsClientDiagnostics.CreateScope("StorageSyncWorkflowResource.Abort");
            scope.Start();
            try
            {
                var response = _storageSyncWorkflowWorkflowsRestClient.Abort(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
