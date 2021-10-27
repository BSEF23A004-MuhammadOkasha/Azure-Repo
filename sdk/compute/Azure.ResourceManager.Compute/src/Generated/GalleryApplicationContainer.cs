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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of GalleryApplication and their operations over a Gallery. </summary>
    public partial class GalleryApplicationContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly GalleryApplicationsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryApplicationContainer"/> class for mocking. </summary>
        protected GalleryApplicationContainer()
        {
        }

        /// <summary> Initializes a new instance of GalleryApplicationContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal GalleryApplicationContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new GalleryApplicationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Gallery.ResourceType;

        // Container level operations.

        /// <summary> Create or update a gallery Application Definition. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryApplication"> Parameters supplied to the create or update gallery Application operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> or <paramref name="galleryApplication"/> is null. </exception>
        public virtual GalleryApplicationCreateOrUpdateOperation CreateOrUpdate(string galleryApplicationName, GalleryApplicationData galleryApplication, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplication == null)
            {
                throw new ArgumentNullException(nameof(galleryApplication));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication, cancellationToken);
                var operation = new GalleryApplicationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication).Request, response);
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

        /// <summary> Create or update a gallery Application Definition. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryApplication"> Parameters supplied to the create or update gallery Application operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> or <paramref name="galleryApplication"/> is null. </exception>
        public async virtual Task<GalleryApplicationCreateOrUpdateOperation> CreateOrUpdateAsync(string galleryApplicationName, GalleryApplicationData galleryApplication, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplication == null)
            {
                throw new ArgumentNullException(nameof(galleryApplication));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication, cancellationToken).ConfigureAwait(false);
                var operation = new GalleryApplicationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication).Request, response);
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
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<GalleryApplication> Get(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationContainer.Get");
            scope.Start();
            try
            {
                if (galleryApplicationName == null)
                {
                    throw new ArgumentNullException(nameof(galleryApplicationName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryApplication(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<GalleryApplication>> GetAsync(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationContainer.Get");
            scope.Start();
            try
            {
                if (galleryApplicationName == null)
                {
                    throw new ArgumentNullException(nameof(galleryApplicationName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new GalleryApplication(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<GalleryApplication> GetIfExists(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationContainer.GetIfExists");
            scope.Start();
            try
            {
                if (galleryApplicationName == null)
                {
                    throw new ArgumentNullException(nameof(galleryApplicationName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<GalleryApplication>(null, response.GetRawResponse())
                    : Response.FromValue(new GalleryApplication(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<GalleryApplication>> GetIfExistsAsync(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationContainer.GetIfExists");
            scope.Start();
            try
            {
                if (galleryApplicationName == null)
                {
                    throw new ArgumentNullException(nameof(galleryApplicationName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<GalleryApplication>(null, response.GetRawResponse())
                    : Response.FromValue(new GalleryApplication(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (galleryApplicationName == null)
                {
                    throw new ArgumentNullException(nameof(galleryApplicationName));
                }

                var response = GetIfExists(galleryApplicationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (galleryApplicationName == null)
                {
                    throw new ArgumentNullException(nameof(galleryApplicationName));
                }

                var response = await GetIfExistsAsync(galleryApplicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List gallery Application Definitions in a gallery. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryApplication" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryApplication> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GalleryApplication> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByGallery(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplication(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryApplication> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByGalleryNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplication(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List gallery Application Definitions in a gallery. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryApplication" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryApplication> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GalleryApplication>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByGalleryAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplication(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryApplication>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByGalleryNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplication(Parent, value)), response.Value.NextLink, response.GetRawResponse());
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
        // public ArmBuilder<ResourceIdentifier, GalleryApplication, GalleryApplicationData> Construct() { }
    }
}
