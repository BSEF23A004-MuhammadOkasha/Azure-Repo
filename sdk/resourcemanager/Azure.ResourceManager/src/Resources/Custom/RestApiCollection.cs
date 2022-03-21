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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class which represents the RestApis for a given azure namespace.
    /// </summary>
    public partial class RestApiCollection : ArmCollection, IEnumerable<RestApi>, IAsyncEnumerable<RestApi>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly string _nameSpace;
        private readonly ResourceProviderCollection _providerCollection;

        /// <summary> Represents the REST operations. </summary>
        private RestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="RestApiCollection"/> class for mocking. </summary>
        protected RestApiCollection()
        {
        }

        /// <summary> Initializes a new instance of RestApiCollection class. </summary>
        /// <param name="operation"> The resource representing the parent resource. </param>
        /// <param name="nameSpace"> The namespace for the rest apis. </param>
        internal RestApiCollection(ArmResource operation, string nameSpace)
            : base(operation.Client, operation.Id)
        {
            _clientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", nameSpace, DiagnosticOptions);
            _nameSpace = nameSpace;
            _providerCollection = new ResourceProviderCollection(Client.GetSubscription(Id));
        }


        private RestOperations GetRestClient(CancellationToken cancellationToken = default)
        {
            return _restClient ??= new RestOperations(
                _nameSpace,
                _providerCollection.GetApiVersionForNamespace(_nameSpace, cancellationToken),
                _clientDiagnostics,
                Pipeline,
                DiagnosticOptions.ApplicationId,
                BaseUri);
        }

        private async Task<RestOperations> GetRestClientAsync(CancellationToken cancellationToken = default)
        {
            return _restClient ??= new RestOperations(
                _nameSpace,
                await _providerCollection.GetApiVersionForNamespaceAsync(_nameSpace, cancellationToken).ConfigureAwait(false),
                _clientDiagnostics,
                Pipeline,
                DiagnosticOptions.ApplicationId,
                BaseUri);
        }

        /// <summary> Gets a list of operations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestApi" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestApi> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RestApi> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestApiCollection.GetAll");
                scope.Start();
                try
                {
                    var response = GetRestClient().List(cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets a list of operations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestApi" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestApi> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestApi>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestApiCollection.GetAll");
                scope.Start();
                try
                {
                    var restClient = await GetRestClientAsync().ConfigureAwait(false);
                    var response = await restClient.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<RestApi> IEnumerable<RestApi>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestApi> IAsyncEnumerable<RestApi>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
