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
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing collection of CodeVersionResource and their operations over a CodeContainerResource. </summary>
    public partial class CodeVersionResourceContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CodeVersionsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="CodeVersionResourceContainer"/> class for mocking. </summary>
        protected CodeVersionResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of CodeVersionResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CodeVersionResourceContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new CodeVersionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => CodeContainerResource.ResourceType;

        // Container level operations.

        /// <summary> Create or update version. </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="properties"/> is null. </exception>
        public virtual CodeVersionCreateOrUpdateOperation CreateOrUpdate(string version, CodeVersion properties, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("CodeVersionResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, properties, cancellationToken);
                var operation = new CodeVersionCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Create or update version. </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="properties"/> is null. </exception>
        public async virtual Task<CodeVersionCreateOrUpdateOperation> CreateOrUpdateAsync(string version, CodeVersion properties, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("CodeVersionResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, properties, cancellationToken).ConfigureAwait(false);
                var operation = new CodeVersionCreateOrUpdateOperation(Parent, response);
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
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<CodeVersionResource> Get(string version, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CodeVersionResourceContainer.Get");
            scope.Start();
            try
            {
                if (version == null)
                {
                    throw new ArgumentNullException(nameof(version));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CodeVersionResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<CodeVersionResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CodeVersionResourceContainer.Get");
            scope.Start();
            try
            {
                if (version == null)
                {
                    throw new ArgumentNullException(nameof(version));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CodeVersionResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<CodeVersionResource> GetIfExists(string version, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CodeVersionResourceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (version == null)
                {
                    throw new ArgumentNullException(nameof(version));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<CodeVersionResource>(null, response.GetRawResponse())
                    : Response.FromValue(new CodeVersionResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<CodeVersionResource>> GetIfExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CodeVersionResourceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (version == null)
                {
                    throw new ArgumentNullException(nameof(version));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<CodeVersionResource>(null, response.GetRawResponse())
                    : Response.FromValue(new CodeVersionResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string version, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CodeVersionResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (version == null)
                {
                    throw new ArgumentNullException(nameof(version));
                }

                var response = GetIfExists(version, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CodeVersionResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (version == null)
                {
                    throw new ArgumentNullException(nameof(version));
                }

                var response = await GetIfExistsAsync(version, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List versions. </summary>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Maximum number of records to return. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CodeVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CodeVersionResource> GetAll(string orderBy = null, int? top = null, string skip = null, CancellationToken cancellationToken = default)
        {
            Page<CodeVersionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CodeVersionResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CodeVersionResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CodeVersionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CodeVersionResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CodeVersionResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List versions. </summary>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Maximum number of records to return. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CodeVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CodeVersionResource> GetAllAsync(string orderBy = null, int? top = null, string skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<CodeVersionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CodeVersionResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CodeVersionResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CodeVersionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CodeVersionResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CodeVersionResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
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
        // public ArmBuilder<ResourceIdentifier, CodeVersionResource, CodeVersionResourceData> Construct() { }
    }
}
