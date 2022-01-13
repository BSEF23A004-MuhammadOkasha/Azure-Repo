// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of FlowLog and their operations over its parent. </summary>
    public partial class FlowLogCollection : ArmCollection, IEnumerable<FlowLog>, IAsyncEnumerable<FlowLog>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FlowLogsRestOperations _flowLogsRestClient;

        /// <summary> Initializes a new instance of the <see cref="FlowLogCollection"/> class for mocking. </summary>
        protected FlowLogCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FlowLogCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FlowLogCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _flowLogsRestClient = new FlowLogsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkWatcher.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkWatcher.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update a flow log for the specified network security group. </summary>
        /// <param name="flowLogName"> The name of the flow log. </param>
        /// <param name="parameters"> Parameters that define the create or update flow log resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FlowLogCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string flowLogName, FlowLogData parameters, CancellationToken cancellationToken = default)
        {
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _flowLogsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, parameters, cancellationToken);
                var operation = new FlowLogCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _flowLogsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a flow log for the specified network security group. </summary>
        /// <param name="flowLogName"> The name of the flow log. </param>
        /// <param name="parameters"> Parameters that define the create or update flow log resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FlowLogCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string flowLogName, FlowLogData parameters, CancellationToken cancellationToken = default)
        {
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _flowLogsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new FlowLogCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _flowLogsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a flow log resource by name. </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual Response<FlowLog> Get(string flowLogName, CancellationToken cancellationToken = default)
        {
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogCollection.Get");
            scope.Start();
            try
            {
                var response = _flowLogsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FlowLog(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a flow log resource by name. </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public async virtual Task<Response<FlowLog>> GetAsync(string flowLogName, CancellationToken cancellationToken = default)
        {
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogCollection.Get");
            scope.Start();
            try
            {
                var response = await _flowLogsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FlowLog(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual Response<FlowLog> GetIfExists(string flowLogName, CancellationToken cancellationToken = default)
        {
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _flowLogsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<FlowLog>(null, response.GetRawResponse());
                return Response.FromValue(new FlowLog(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public async virtual Task<Response<FlowLog>> GetIfExistsAsync(string flowLogName, CancellationToken cancellationToken = default)
        {
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _flowLogsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<FlowLog>(null, response.GetRawResponse());
                return Response.FromValue(new FlowLog(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual Response<bool> Exists(string flowLogName, CancellationToken cancellationToken = default)
        {
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(flowLogName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string flowLogName, CancellationToken cancellationToken = default)
        {
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(flowLogName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all flow log resources for the specified Network Watcher. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FlowLog" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FlowLog> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FlowLog> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FlowLogCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _flowLogsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FlowLog(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FlowLog> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FlowLogCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _flowLogsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FlowLog(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all flow log resources for the specified Network Watcher. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FlowLog" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FlowLog> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FlowLog>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FlowLogCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _flowLogsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FlowLog(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FlowLog>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FlowLogCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _flowLogsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FlowLog(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<FlowLog> IEnumerable<FlowLog>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FlowLog> IAsyncEnumerable<FlowLog>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, FlowLog, FlowLogData> Construct() { }
    }
}
