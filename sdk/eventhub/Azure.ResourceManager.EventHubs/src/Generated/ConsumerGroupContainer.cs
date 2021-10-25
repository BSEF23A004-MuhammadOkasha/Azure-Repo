// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing collection of ConsumerGroup and their operations over a EventHub. </summary>
    public partial class ConsumerGroupContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ConsumerGroupsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="ConsumerGroupContainer"/> class for mocking. </summary>
        protected ConsumerGroupContainer()
        {
        }

        /// <summary> Initializes a new instance of ConsumerGroupContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ConsumerGroupContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ConsumerGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => EventHub.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates an Event Hubs consumer group as a nested resource within a Namespace. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="parameters"> Parameters supplied to create or update a consumer group resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ConsumerGroupCreateOrUpdateOperation CreateOrUpdate(string consumerGroupName, ConsumerGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (consumerGroupName == null)
            {
                throw new ArgumentNullException(nameof(consumerGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ConsumerGroupContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, parameters, cancellationToken);
                var operation = new ConsumerGroupCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Creates or updates an Event Hubs consumer group as a nested resource within a Namespace. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="parameters"> Parameters supplied to create or update a consumer group resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ConsumerGroupCreateOrUpdateOperation> CreateOrUpdateAsync(string consumerGroupName, ConsumerGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (consumerGroupName == null)
            {
                throw new ArgumentNullException(nameof(consumerGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ConsumerGroupContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ConsumerGroupCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ConsumerGroup> Get(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConsumerGroupContainer.Get");
            scope.Start();
            try
            {
                if (consumerGroupName == null)
                {
                    throw new ArgumentNullException(nameof(consumerGroupName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConsumerGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ConsumerGroup>> GetAsync(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConsumerGroupContainer.Get");
            scope.Start();
            try
            {
                if (consumerGroupName == null)
                {
                    throw new ArgumentNullException(nameof(consumerGroupName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ConsumerGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ConsumerGroup> GetIfExists(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConsumerGroupContainer.GetIfExists");
            scope.Start();
            try
            {
                if (consumerGroupName == null)
                {
                    throw new ArgumentNullException(nameof(consumerGroupName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ConsumerGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new ConsumerGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ConsumerGroup>> GetIfExistsAsync(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConsumerGroupContainer.GetIfExists");
            scope.Start();
            try
            {
                if (consumerGroupName == null)
                {
                    throw new ArgumentNullException(nameof(consumerGroupName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ConsumerGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new ConsumerGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConsumerGroupContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (consumerGroupName == null)
                {
                    throw new ArgumentNullException(nameof(consumerGroupName));
                }

                var response = GetIfExists(consumerGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConsumerGroupContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (consumerGroupName == null)
                {
                    throw new ArgumentNullException(nameof(consumerGroupName));
                }

                var response = await GetIfExistsAsync(consumerGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the consumer groups in a Namespace. An empty feed is returned if no consumer group exists in the Namespace. </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConsumerGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConsumerGroup> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ConsumerGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConsumerGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByEventHub(Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConsumerGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ConsumerGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConsumerGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByEventHubNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConsumerGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the consumer groups in a Namespace. An empty feed is returned if no consumer group exists in the Namespace. </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConsumerGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConsumerGroup> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ConsumerGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConsumerGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByEventHubAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConsumerGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ConsumerGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConsumerGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByEventHubNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConsumerGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, ConsumerGroup, ConsumerGroupData> Construct() { }
    }
}
