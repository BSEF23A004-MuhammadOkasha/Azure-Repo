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
using Azure.ResourceManager.Logic.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A Class representing a LogicWorkflowRunActionRepetition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="LogicWorkflowRunActionRepetitionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetLogicWorkflowRunActionRepetitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="LogicWorkflowRunActionResource" /> using the GetLogicWorkflowRunActionRepetition method.
    /// </summary>
    public partial class LogicWorkflowRunActionRepetitionResource : LogicWorkflowRunActionRepetitionDefinitionResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LogicWorkflowRunActionRepetitionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string repetitionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsClientDiagnostics;
        private readonly WorkflowRunActionRepetitionsRestOperations _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionRepetitionResource"/> class for mocking. </summary>
        protected LogicWorkflowRunActionRepetitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LogicWorkflowRunActionRepetitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LogicWorkflowRunActionRepetitionResource(ArmClient client, LogicWorkflowRunActionRepetitionDefinitionData data) : base(client, data)
        {
            _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsApiVersion);
            _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsRestClient = new WorkflowRunActionRepetitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionRepetitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LogicWorkflowRunActionRepetitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsApiVersion);
            _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsRestClient = new WorkflowRunActionRepetitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Logic/workflows/runs/actions/repetitions";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of LogicWorkflowRunActionRepetitionRequestHistoryResources in the LogicWorkflowRunActionRepetition. </summary>
        /// <returns> An object representing collection of LogicWorkflowRunActionRepetitionRequestHistoryResources and their operations over a LogicWorkflowRunActionRepetitionRequestHistoryResource. </returns>
        public virtual LogicWorkflowRunActionRepetitionRequestHistoryCollection GetLogicWorkflowRunActionRepetitionRequestHistories()
        {
            return GetCachedClient(Client => new LogicWorkflowRunActionRepetitionRequestHistoryCollection(Client, Id));
        }

        /// <summary>
        /// Gets a workflow run repetition request history.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories/{requestHistoryName}
        /// Operation Id: WorkflowRunActionRepetitionsRequestHistories_Get
        /// </summary>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestHistoryName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LogicWorkflowRunActionRepetitionRequestHistoryResource>> GetLogicWorkflowRunActionRepetitionRequestHistoryAsync(string requestHistoryName, CancellationToken cancellationToken = default)
        {
            return await GetLogicWorkflowRunActionRepetitionRequestHistories().GetAsync(requestHistoryName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a workflow run repetition request history.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories/{requestHistoryName}
        /// Operation Id: WorkflowRunActionRepetitionsRequestHistories_Get
        /// </summary>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestHistoryName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<LogicWorkflowRunActionRepetitionRequestHistoryResource> GetLogicWorkflowRunActionRepetitionRequestHistory(string requestHistoryName, CancellationToken cancellationToken = default)
        {
            return GetLogicWorkflowRunActionRepetitionRequestHistories().Get(requestHistoryName, cancellationToken);
        }

        /// <summary>
        /// Get a workflow run action repetition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}
        /// Operation Id: WorkflowRunActionRepetitions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<LogicWorkflowRunActionRepetitionDefinitionResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsClientDiagnostics.CreateScope("LogicWorkflowRunActionRepetitionResource.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workflow run action repetition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}
        /// Operation Id: WorkflowRunActionRepetitions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual new async Task<Response<LogicWorkflowRunActionRepetitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((LogicWorkflowRunActionRepetitionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Get a workflow run action repetition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}
        /// Operation Id: WorkflowRunActionRepetitions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<LogicWorkflowRunActionRepetitionDefinitionResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsClientDiagnostics.CreateScope("LogicWorkflowRunActionRepetitionResource.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workflow run action repetition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}
        /// Operation Id: WorkflowRunActionRepetitions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual new Response<LogicWorkflowRunActionRepetitionResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((LogicWorkflowRunActionRepetitionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Lists a workflow run expression trace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/listExpressionTraces
        /// Operation Id: WorkflowRunActionRepetitions_ListExpressionTraces
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogicExpressionRoot" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogicExpressionRoot> GetExpressionTracesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LogicExpressionRoot>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsClientDiagnostics.CreateScope("LogicWorkflowRunActionRepetitionResource.GetExpressionTraces");
                scope.Start();
                try
                {
                    var response = await _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsRestClient.ListExpressionTracesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Inputs, null, response.GetRawResponse());
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
        /// Lists a workflow run expression trace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/listExpressionTraces
        /// Operation Id: WorkflowRunActionRepetitions_ListExpressionTraces
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogicExpressionRoot" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogicExpressionRoot> GetExpressionTraces(CancellationToken cancellationToken = default)
        {
            Page<LogicExpressionRoot> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsClientDiagnostics.CreateScope("LogicWorkflowRunActionRepetitionResource.GetExpressionTraces");
                scope.Start();
                try
                {
                    var response = _logicWorkflowRunActionRepetitionWorkflowRunActionRepetitionsRestClient.ListExpressionTraces(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Inputs, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
