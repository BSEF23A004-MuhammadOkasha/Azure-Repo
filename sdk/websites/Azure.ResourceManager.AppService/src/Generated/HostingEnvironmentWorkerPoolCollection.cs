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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of WorkerPoolResource and their operations over its parent. </summary>
    public partial class HostingEnvironmentWorkerPoolCollection : ArmCollection, IEnumerable<HostingEnvironmentWorkerPool>, IAsyncEnumerable<HostingEnvironmentWorkerPool>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _appServiceEnvironmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentWorkerPoolCollection"/> class for mocking. </summary>
        protected HostingEnvironmentWorkerPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of HostingEnvironmentWorkerPoolCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal HostingEnvironmentWorkerPoolCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => AppServiceEnvironment.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: AppServiceEnvironments_CreateOrUpdateWorkerPool
        /// <summary> Description for Create or update a worker pool. </summary>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="workerPoolEnvelope"> Properties of the worker pool. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> or <paramref name="workerPoolEnvelope"/> is null. </exception>
        public virtual AppServiceEnvironmentCreateOrUpdateWorkerPoolOperation CreateOrUpdate(string workerPoolName, WorkerPoolResourceData workerPoolEnvelope, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (workerPoolName == null)
            {
                throw new ArgumentNullException(nameof(workerPoolName));
            }
            if (workerPoolEnvelope == null)
            {
                throw new ArgumentNullException(nameof(workerPoolEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.CreateOrUpdateWorkerPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, workerPoolEnvelope, cancellationToken);
                var operation = new AppServiceEnvironmentCreateOrUpdateWorkerPoolOperation(Parent, _clientDiagnostics, Pipeline, _appServiceEnvironmentsRestClient.CreateCreateOrUpdateWorkerPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, workerPoolEnvelope).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: AppServiceEnvironments_CreateOrUpdateWorkerPool
        /// <summary> Description for Create or update a worker pool. </summary>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="workerPoolEnvelope"> Properties of the worker pool. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> or <paramref name="workerPoolEnvelope"/> is null. </exception>
        public async virtual Task<AppServiceEnvironmentCreateOrUpdateWorkerPoolOperation> CreateOrUpdateAsync(string workerPoolName, WorkerPoolResourceData workerPoolEnvelope, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (workerPoolName == null)
            {
                throw new ArgumentNullException(nameof(workerPoolName));
            }
            if (workerPoolEnvelope == null)
            {
                throw new ArgumentNullException(nameof(workerPoolEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.CreateOrUpdateWorkerPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, workerPoolEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceEnvironmentCreateOrUpdateWorkerPoolOperation(Parent, _clientDiagnostics, Pipeline, _appServiceEnvironmentsRestClient.CreateCreateOrUpdateWorkerPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, workerPoolEnvelope).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: AppServiceEnvironments_GetWorkerPool
        /// <summary> Description for Get properties of a worker pool. </summary>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> is null. </exception>
        public virtual Response<HostingEnvironmentWorkerPool> Get(string workerPoolName, CancellationToken cancellationToken = default)
        {
            if (workerPoolName == null)
            {
                throw new ArgumentNullException(nameof(workerPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.GetWorkerPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentWorkerPool(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: AppServiceEnvironments_GetWorkerPool
        /// <summary> Description for Get properties of a worker pool. </summary>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> is null. </exception>
        public async virtual Task<Response<HostingEnvironmentWorkerPool>> GetAsync(string workerPoolName, CancellationToken cancellationToken = default)
        {
            if (workerPoolName == null)
            {
                throw new ArgumentNullException(nameof(workerPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.GetWorkerPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HostingEnvironmentWorkerPool(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> is null. </exception>
        public virtual Response<HostingEnvironmentWorkerPool> GetIfExists(string workerPoolName, CancellationToken cancellationToken = default)
        {
            if (workerPoolName == null)
            {
                throw new ArgumentNullException(nameof(workerPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.GetWorkerPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<HostingEnvironmentWorkerPool>(null, response.GetRawResponse())
                    : Response.FromValue(new HostingEnvironmentWorkerPool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> is null. </exception>
        public async virtual Task<Response<HostingEnvironmentWorkerPool>> GetIfExistsAsync(string workerPoolName, CancellationToken cancellationToken = default)
        {
            if (workerPoolName == null)
            {
                throw new ArgumentNullException(nameof(workerPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.GetWorkerPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<HostingEnvironmentWorkerPool>(null, response.GetRawResponse())
                    : Response.FromValue(new HostingEnvironmentWorkerPool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string workerPoolName, CancellationToken cancellationToken = default)
        {
            if (workerPoolName == null)
            {
                throw new ArgumentNullException(nameof(workerPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(workerPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string workerPoolName, CancellationToken cancellationToken = default)
        {
            if (workerPoolName == null)
            {
                throw new ArgumentNullException(nameof(workerPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(workerPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: AppServiceEnvironments_ListWorkerPools
        /// <summary> Description for Get all worker pools of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HostingEnvironmentWorkerPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HostingEnvironmentWorkerPool> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HostingEnvironmentWorkerPool> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListWorkerPools(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HostingEnvironmentWorkerPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HostingEnvironmentWorkerPool> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListWorkerPoolsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HostingEnvironmentWorkerPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: AppServiceEnvironments_ListWorkerPools
        /// <summary> Description for Get all worker pools of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HostingEnvironmentWorkerPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HostingEnvironmentWorkerPool> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HostingEnvironmentWorkerPool>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListWorkerPoolsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HostingEnvironmentWorkerPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HostingEnvironmentWorkerPool>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListWorkerPoolsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HostingEnvironmentWorkerPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<HostingEnvironmentWorkerPool> IEnumerable<HostingEnvironmentWorkerPool>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HostingEnvironmentWorkerPool> IAsyncEnumerable<HostingEnvironmentWorkerPool>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, HostingEnvironmentWorkerPool, WorkerPoolResourceData> Construct() { }
    }
}
