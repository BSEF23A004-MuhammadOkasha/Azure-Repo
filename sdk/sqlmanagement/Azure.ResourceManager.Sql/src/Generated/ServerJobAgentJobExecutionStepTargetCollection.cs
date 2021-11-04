// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of JobExecution and their operations over its parent. </summary>
    public partial class ServerJobAgentJobExecutionStepTargetCollection : ArmCollection, IEnumerable<ServerJobAgentJobExecutionStepTarget>, IAsyncEnumerable<ServerJobAgentJobExecutionStepTarget>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly JobTargetExecutionsRestOperations _jobTargetExecutionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerJobAgentJobExecutionStepTargetCollection"/> class for mocking. </summary>
        protected ServerJobAgentJobExecutionStepTargetCollection()
        {
        }

        /// <summary> Initializes a new instance of ServerJobAgentJobExecutionStepTargetCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerJobAgentJobExecutionStepTargetCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _jobTargetExecutionsRestClient = new JobTargetExecutionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ServerJobAgentJobExecutionStep.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}
        /// OperationId: JobTargetExecutions_Get
        /// <summary> Gets a target execution. </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerJobAgentJobExecutionStepTarget> Get(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.Get");
            scope.Start();
            try
            {
                var response = _jobTargetExecutionsRestClient.Get(Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, targetId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobExecutionStepTarget(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}
        /// OperationId: JobTargetExecutions_Get
        /// <summary> Gets a target execution. </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerJobAgentJobExecutionStepTarget>> GetAsync(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobTargetExecutionsRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, targetId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerJobAgentJobExecutionStepTarget(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerJobAgentJobExecutionStepTarget> GetIfExists(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobTargetExecutionsRestClient.Get(Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, targetId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServerJobAgentJobExecutionStepTarget>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerJobAgentJobExecutionStepTarget(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerJobAgentJobExecutionStepTarget>> GetIfExistsAsync(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _jobTargetExecutionsRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, targetId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServerJobAgentJobExecutionStepTarget>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerJobAgentJobExecutionStepTarget(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> CheckIfExists(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(targetId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(targetId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}
        /// OperationId: JobTargetExecutions_ListByStep
        /// <summary> Lists the target executions of a job step execution. </summary>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerJobAgentJobExecutionStepTarget" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerJobAgentJobExecutionStepTarget> GetAll(DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ServerJobAgentJobExecutionStepTarget> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobTargetExecutionsRestClient.ListByStep(Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStepTarget(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerJobAgentJobExecutionStepTarget> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobTargetExecutionsRestClient.ListByStepNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStepTarget(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}
        /// OperationId: JobTargetExecutions_ListByStep
        /// <summary> Lists the target executions of a job step execution. </summary>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerJobAgentJobExecutionStepTarget" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerJobAgentJobExecutionStepTarget> GetAllAsync(DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerJobAgentJobExecutionStepTarget>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobTargetExecutionsRestClient.ListByStepAsync(Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStepTarget(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerJobAgentJobExecutionStepTarget>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobTargetExecutionsRestClient.ListByStepNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStepTarget(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ServerJobAgentJobExecutionStepTarget> IEnumerable<ServerJobAgentJobExecutionStepTarget>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerJobAgentJobExecutionStepTarget> IAsyncEnumerable<ServerJobAgentJobExecutionStepTarget>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ServerJobAgentJobExecutionStepTarget, JobExecutionData> Construct() { }
    }
}
