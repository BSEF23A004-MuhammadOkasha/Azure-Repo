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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ExpressRoutePort and their operations over its parent. </summary>
    public partial class ExpressRoutePortCollection : ArmCollection, IEnumerable<ExpressRoutePort>, IAsyncEnumerable<ExpressRoutePort>
    {
        private readonly ClientDiagnostics _expressRoutePortClientDiagnostics;
        private readonly ExpressRoutePortsRestOperations _expressRoutePortRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortCollection"/> class for mocking. </summary>
        protected ExpressRoutePortCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRoutePortCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRoutePortClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRoutePort.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ExpressRoutePort.ResourceType, out string expressRoutePortApiVersion);
            _expressRoutePortRestClient = new ExpressRoutePortsRestOperations(_expressRoutePortClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, expressRoutePortApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates the specified ExpressRoutePort resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="parameters"> Parameters supplied to the create ExpressRoutePort operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ExpressRoutePortCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string expressRoutePortName, ExpressRoutePortData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRoutePortRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ExpressRoutePortCreateOrUpdateOperation(Client, _expressRoutePortClientDiagnostics, Pipeline, _expressRoutePortRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, parameters).Request, response);
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

        /// <summary> Creates or updates the specified ExpressRoutePort resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="parameters"> Parameters supplied to the create ExpressRoutePort operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ExpressRoutePortCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string expressRoutePortName, ExpressRoutePortData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRoutePortRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, parameters, cancellationToken);
                var operation = new ExpressRoutePortCreateOrUpdateOperation(Client, _expressRoutePortClientDiagnostics, Pipeline, _expressRoutePortRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, parameters).Request, response);
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

        /// <summary> Retrieves the requested ExpressRoutePort resource. </summary>
        /// <param name="expressRoutePortName"> The name of ExpressRoutePort. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> is null. </exception>
        public async virtual Task<Response<ExpressRoutePort>> GetAsync(string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRoutePortRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _expressRoutePortClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRoutePort(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the requested ExpressRoutePort resource. </summary>
        /// <param name="expressRoutePortName"> The name of ExpressRoutePort. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> is null. </exception>
        public virtual Response<ExpressRoutePort> Get(string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRoutePortRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, cancellationToken);
                if (response.Value == null)
                    throw _expressRoutePortClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePort(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all the ExpressRoutePort resources in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRoutePort" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRoutePort> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRoutePort>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRoutePortRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRoutePort(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRoutePort>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRoutePortRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRoutePort(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List all the ExpressRoutePort resources in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRoutePort" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRoutePort> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRoutePort> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRoutePortRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRoutePort(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRoutePort> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRoutePortRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRoutePort(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="expressRoutePortName"> The name of ExpressRoutePort. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(expressRoutePortName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="expressRoutePortName"> The name of ExpressRoutePort. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> is null. </exception>
        public virtual Response<bool> Exists(string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(expressRoutePortName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="expressRoutePortName"> The name of ExpressRoutePort. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> is null. </exception>
        public async virtual Task<Response<ExpressRoutePort>> GetIfExistsAsync(string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRoutePortRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ExpressRoutePort>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePort(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="expressRoutePortName"> The name of ExpressRoutePort. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> is null. </exception>
        public virtual Response<ExpressRoutePort> GetIfExists(string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRoutePortRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ExpressRoutePort>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePort(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRoutePort> IEnumerable<ExpressRoutePort>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRoutePort> IAsyncEnumerable<ExpressRoutePort>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
