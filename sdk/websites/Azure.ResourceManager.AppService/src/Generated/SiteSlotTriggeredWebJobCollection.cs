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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of TriggeredWebJob and their operations over its parent. </summary>
    public partial class SiteSlotTriggeredWebJobCollection : ArmCollection, IEnumerable<SiteSlotTriggeredWebJob>, IAsyncEnumerable<SiteSlotTriggeredWebJob>
    {
        private readonly ClientDiagnostics _siteSlotTriggeredWebJobWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotTriggeredWebJobWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotTriggeredWebJobCollection"/> class for mocking. </summary>
        protected SiteSlotTriggeredWebJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotTriggeredWebJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotTriggeredWebJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotTriggeredWebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotTriggeredWebJob.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SiteSlotTriggeredWebJob.ResourceType, out string siteSlotTriggeredWebJobWebAppsApiVersion);
            _siteSlotTriggeredWebJobWebAppsRestClient = new WebAppsRestOperations(_siteSlotTriggeredWebJobWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotTriggeredWebJobWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetTriggeredWebJob
        /// <summary> Description for Gets a triggered web job by its ID for an app, or a deployment slot. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotTriggeredWebJob>> GetAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _siteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotTriggeredWebJobWebAppsRestClient.GetTriggeredWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotTriggeredWebJob(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetTriggeredWebJob
        /// <summary> Description for Gets a triggered web job by its ID for an app, or a deployment slot. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<SiteSlotTriggeredWebJob> Get(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _siteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotTriggeredWebJobWebAppsRestClient.GetTriggeredWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken);
                if (response.Value == null)
                    throw _siteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotTriggeredWebJob(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListTriggeredWebJobs
        /// <summary> Description for List triggered web jobs for an app, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotTriggeredWebJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotTriggeredWebJob> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotTriggeredWebJob>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotTriggeredWebJobWebAppsRestClient.ListTriggeredWebJobsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotTriggeredWebJob(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotTriggeredWebJob>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotTriggeredWebJobWebAppsRestClient.ListTriggeredWebJobsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotTriggeredWebJob(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListTriggeredWebJobs
        /// <summary> Description for List triggered web jobs for an app, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotTriggeredWebJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotTriggeredWebJob> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotTriggeredWebJob> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotTriggeredWebJobWebAppsRestClient.ListTriggeredWebJobs(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotTriggeredWebJob(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotTriggeredWebJob> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotTriggeredWebJobWebAppsRestClient.ListTriggeredWebJobsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotTriggeredWebJob(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetTriggeredWebJob
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _siteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetTriggeredWebJob
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<bool> Exists(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _siteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(webJobName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetTriggeredWebJob
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotTriggeredWebJob>> GetIfExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _siteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotTriggeredWebJobWebAppsRestClient.GetTriggeredWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotTriggeredWebJob>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotTriggeredWebJob(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetTriggeredWebJob
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<SiteSlotTriggeredWebJob> GetIfExists(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _siteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotTriggeredWebJobWebAppsRestClient.GetTriggeredWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotTriggeredWebJob>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotTriggeredWebJob(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotTriggeredWebJob> IEnumerable<SiteSlotTriggeredWebJob>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotTriggeredWebJob> IAsyncEnumerable<SiteSlotTriggeredWebJob>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
