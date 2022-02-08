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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a HostingEnvironmentMultiRolePool along with the instance operations that can be performed on it. </summary>
    public partial class HostingEnvironmentMultiRolePool : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HostingEnvironmentMultiRolePool"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient;
        private readonly WorkerPoolResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentMultiRolePool"/> class for mocking. </summary>
        protected HostingEnvironmentMultiRolePool()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HostingEnvironmentMultiRolePool"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HostingEnvironmentMultiRolePool(ArmClient client, WorkerPoolResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentMultiRolePool"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HostingEnvironmentMultiRolePool(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string hostingEnvironmentMultiRolePoolAppServiceEnvironmentsApiVersion);
            _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(_hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, hostingEnvironmentMultiRolePoolAppServiceEnvironmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/hostingEnvironments/multiRolePools";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WorkerPoolResourceData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_GetMultiRolePool
        /// <summary> Description for Get properties of a multi-role pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<HostingEnvironmentMultiRolePool>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.Get");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.GetMultiRolePoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HostingEnvironmentMultiRolePool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_GetMultiRolePool
        /// <summary> Description for Get properties of a multi-role pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HostingEnvironmentMultiRolePool> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.Get");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.GetMultiRolePool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentMultiRolePool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_UpdateMultiRolePool
        /// <summary> Description for Create or update a multi-role pool. </summary>
        /// <param name="multiRolePoolEnvelope"> Properties of the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="multiRolePoolEnvelope"/> is null. </exception>
        public async virtual Task<Response<HostingEnvironmentMultiRolePool>> UpdateAsync(WorkerPoolResourceData multiRolePoolEnvelope, CancellationToken cancellationToken = default)
        {
            if (multiRolePoolEnvelope == null)
            {
                throw new ArgumentNullException(nameof(multiRolePoolEnvelope));
            }

            using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.Update");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.UpdateMultiRolePoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, multiRolePoolEnvelope, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new HostingEnvironmentMultiRolePool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_UpdateMultiRolePool
        /// <summary> Description for Create or update a multi-role pool. </summary>
        /// <param name="multiRolePoolEnvelope"> Properties of the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="multiRolePoolEnvelope"/> is null. </exception>
        public virtual Response<HostingEnvironmentMultiRolePool> Update(WorkerPoolResourceData multiRolePoolEnvelope, CancellationToken cancellationToken = default)
        {
            if (multiRolePoolEnvelope == null)
            {
                throw new ArgumentNullException(nameof(multiRolePoolEnvelope));
            }

            using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.Update");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.UpdateMultiRolePool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, multiRolePoolEnvelope, cancellationToken);
                return Response.FromValue(new HostingEnvironmentMultiRolePool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_CreateOrUpdateMultiRolePool
        /// <summary> Description for Create or update a multi-role pool. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="multiRolePoolEnvelope"> Properties of the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="multiRolePoolEnvelope"/> is null. </exception>
        public async virtual Task<ArmOperation<HostingEnvironmentMultiRolePool>> CreateOrUpdateAsync(bool waitForCompletion, WorkerPoolResourceData multiRolePoolEnvelope, CancellationToken cancellationToken = default)
        {
            if (multiRolePoolEnvelope == null)
            {
                throw new ArgumentNullException(nameof(multiRolePoolEnvelope));
            }

            using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateOrUpdateMultiRolePoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, multiRolePoolEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<HostingEnvironmentMultiRolePool>(new HostingEnvironmentMultiRolePoolOperationSource(Client), _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateCreateOrUpdateMultiRolePoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, multiRolePoolEnvelope).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_CreateOrUpdateMultiRolePool
        /// <summary> Description for Create or update a multi-role pool. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="multiRolePoolEnvelope"> Properties of the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="multiRolePoolEnvelope"/> is null. </exception>
        public virtual ArmOperation<HostingEnvironmentMultiRolePool> CreateOrUpdate(bool waitForCompletion, WorkerPoolResourceData multiRolePoolEnvelope, CancellationToken cancellationToken = default)
        {
            if (multiRolePoolEnvelope == null)
            {
                throw new ArgumentNullException(nameof(multiRolePoolEnvelope));
            }

            using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateOrUpdateMultiRolePool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, multiRolePoolEnvelope, cancellationToken);
                var operation = new AppServiceArmOperation<HostingEnvironmentMultiRolePool>(new HostingEnvironmentMultiRolePoolOperationSource(Client), _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateCreateOrUpdateMultiRolePoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, multiRolePoolEnvelope).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/instances/{instance}/metricdefinitions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRolePoolInstanceMetricDefinitions
        /// <summary> Description for Get metric definitions for a specific instance of a multi-role pool of an App Service Environment. </summary>
        /// <param name="instance"> Name of the instance in the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instance"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instance"/> is null. </exception>
        /// <returns> An async collection of <see cref="ResourceMetricDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceMetricDefinition> GetMultiRolePoolInstanceMetricDefinitionsAsync(string instance, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instance, nameof(instance));

            async Task<Page<ResourceMetricDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolInstanceMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRolePoolInstanceMetricDefinitionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, instance, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceMetricDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolInstanceMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRolePoolInstanceMetricDefinitionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, instance, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/instances/{instance}/metricdefinitions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRolePoolInstanceMetricDefinitions
        /// <summary> Description for Get metric definitions for a specific instance of a multi-role pool of an App Service Environment. </summary>
        /// <param name="instance"> Name of the instance in the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instance"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instance"/> is null. </exception>
        /// <returns> A collection of <see cref="ResourceMetricDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceMetricDefinition> GetMultiRolePoolInstanceMetricDefinitions(string instance, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instance, nameof(instance));

            Page<ResourceMetricDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolInstanceMetricDefinitions");
                scope.Start();
                try
                {
                    var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRolePoolInstanceMetricDefinitions(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, instance, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceMetricDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolInstanceMetricDefinitions");
                scope.Start();
                try
                {
                    var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRolePoolInstanceMetricDefinitionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, instance, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/metricdefinitions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRoleMetricDefinitions
        /// <summary> Description for Get metric definitions for a multi-role pool of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceMetricDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceMetricDefinition> GetMultiRoleMetricDefinitionsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceMetricDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRoleMetricDefinitionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceMetricDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRoleMetricDefinitionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/metricdefinitions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRoleMetricDefinitions
        /// <summary> Description for Get metric definitions for a multi-role pool of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceMetricDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceMetricDefinition> GetMultiRoleMetricDefinitions(CancellationToken cancellationToken = default)
        {
            Page<ResourceMetricDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleMetricDefinitions");
                scope.Start();
                try
                {
                    var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRoleMetricDefinitions(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceMetricDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleMetricDefinitions");
                scope.Start();
                try
                {
                    var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRoleMetricDefinitionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/skus
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRolePoolSkus
        /// <summary> Description for Get available SKUs for scaling a multi-role pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SkuInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SkuInfo> GetMultiRolePoolSkusAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SkuInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolSkus");
                scope.Start();
                try
                {
                    var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRolePoolSkusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SkuInfo>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolSkus");
                scope.Start();
                try
                {
                    var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRolePoolSkusNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/skus
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRolePoolSkus
        /// <summary> Description for Get available SKUs for scaling a multi-role pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SkuInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SkuInfo> GetMultiRolePoolSkus(CancellationToken cancellationToken = default)
        {
            Page<SkuInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolSkus");
                scope.Start();
                try
                {
                    var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRolePoolSkus(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SkuInfo> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolSkus");
                scope.Start();
                try
                {
                    var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRolePoolSkusNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/usages
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRoleUsages
        /// <summary> Description for Get usage metrics for a multi-role pool of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Usage> GetMultiRoleUsagesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Usage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleUsages");
                scope.Start();
                try
                {
                    var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRoleUsagesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Usage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleUsages");
                scope.Start();
                try
                {
                    var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRoleUsagesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/usages
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRoleUsages
        /// <summary> Description for Get usage metrics for a multi-role pool of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Usage> GetMultiRoleUsages(CancellationToken cancellationToken = default)
        {
            Page<Usage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleUsages");
                scope.Start();
                try
                {
                    var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRoleUsages(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Usage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleUsages");
                scope.Start();
                try
                {
                    var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.ListMultiRoleUsagesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
