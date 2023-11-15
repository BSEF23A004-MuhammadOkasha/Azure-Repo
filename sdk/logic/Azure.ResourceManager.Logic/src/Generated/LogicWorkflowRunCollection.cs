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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="LogicWorkflowRunResource" /> and their operations.
    /// Each <see cref="LogicWorkflowRunResource" /> in the collection will belong to the same instance of <see cref="LogicWorkflowResource" />.
    /// To get a <see cref="LogicWorkflowRunCollection" /> instance call the GetLogicWorkflowRuns method from an instance of <see cref="LogicWorkflowResource" />.
    /// </summary>
    public partial class LogicWorkflowRunCollection : ArmCollection, IEnumerable<LogicWorkflowRunResource>, IAsyncEnumerable<LogicWorkflowRunResource>
    {
        private readonly ClientDiagnostics _logicWorkflowRunWorkflowRunsClientDiagnostics;
        private readonly WorkflowRunsRestOperations _logicWorkflowRunWorkflowRunsRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunCollection"/> class for mocking. </summary>
        protected LogicWorkflowRunCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LogicWorkflowRunCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowRunWorkflowRunsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", LogicWorkflowRunResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LogicWorkflowRunResource.ResourceType, out string logicWorkflowRunWorkflowRunsApiVersion);
            _logicWorkflowRunWorkflowRunsRestClient = new WorkflowRunsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowRunWorkflowRunsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LogicWorkflowResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LogicWorkflowResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a workflow run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runName"/> is null. </exception>
        public virtual async Task<Response<LogicWorkflowRunResource>> GetAsync(string runName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));

            using var scope = _logicWorkflowRunWorkflowRunsClientDiagnostics.CreateScope("LogicWorkflowRunCollection.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunWorkflowRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workflow run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runName"/> is null. </exception>
        public virtual Response<LogicWorkflowRunResource> Get(string runName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));

            using var scope = _logicWorkflowRunWorkflowRunsClientDiagnostics.CreateScope("LogicWorkflowRunCollection.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunWorkflowRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of workflow runs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRuns_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: Status, StartTime, and ClientTrackingId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogicWorkflowRunResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogicWorkflowRunResource> GetAllAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowRunWorkflowRunsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicWorkflowRunWorkflowRunsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new LogicWorkflowRunResource(Client, LogicWorkflowRunData.DeserializeLogicWorkflowRunData(e)), _logicWorkflowRunWorkflowRunsClientDiagnostics, Pipeline, "LogicWorkflowRunCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of workflow runs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRuns_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: Status, StartTime, and ClientTrackingId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogicWorkflowRunResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogicWorkflowRunResource> GetAll(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowRunWorkflowRunsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicWorkflowRunWorkflowRunsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new LogicWorkflowRunResource(Client, LogicWorkflowRunData.DeserializeLogicWorkflowRunData(e)), _logicWorkflowRunWorkflowRunsClientDiagnostics, Pipeline, "LogicWorkflowRunCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string runName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));

            using var scope = _logicWorkflowRunWorkflowRunsClientDiagnostics.CreateScope("LogicWorkflowRunCollection.Exists");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunWorkflowRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runName"/> is null. </exception>
        public virtual Response<bool> Exists(string runName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));

            using var scope = _logicWorkflowRunWorkflowRunsClientDiagnostics.CreateScope("LogicWorkflowRunCollection.Exists");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunWorkflowRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runName"/> is null. </exception>
        public virtual async Task<NullableResponse<LogicWorkflowRunResource>> GetIfExistsAsync(string runName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));

            using var scope = _logicWorkflowRunWorkflowRunsClientDiagnostics.CreateScope("LogicWorkflowRunCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunWorkflowRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LogicWorkflowRunResource>(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runName"/> is null. </exception>
        public virtual NullableResponse<LogicWorkflowRunResource> GetIfExists(string runName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));

            using var scope = _logicWorkflowRunWorkflowRunsClientDiagnostics.CreateScope("LogicWorkflowRunCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunWorkflowRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LogicWorkflowRunResource>(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LogicWorkflowRunResource> IEnumerable<LogicWorkflowRunResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LogicWorkflowRunResource> IAsyncEnumerable<LogicWorkflowRunResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
