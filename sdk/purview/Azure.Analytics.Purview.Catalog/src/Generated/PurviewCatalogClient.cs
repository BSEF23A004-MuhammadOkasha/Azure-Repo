// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Catalog
{
    /// <summary> The PurviewCatalog service client. </summary>
    public partial class PurviewCatalogClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PurviewCatalogClient for mocking. </summary>
        protected PurviewCatalogClient()
        {
        }

        /// <summary> Initializes a new instance of PurviewCatalogClient. </summary>
        /// <param name="endpoint"> The catalog endpoint of your Purview account. Example: https://{accountName}.purview.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public PurviewCatalogClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new PurviewCatalogClientOptions())
        {
        }

        /// <summary> Initializes a new instance of PurviewCatalogClient. </summary>
        /// <param name="endpoint"> The catalog endpoint of your Purview account. Example: https://{accountName}.purview.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public PurviewCatalogClient(Uri endpoint, TokenCredential credential, PurviewCatalogClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new PurviewCatalogClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Gets data using search. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Task{Response}"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   keywords: string,
        ///   offset: number,
        ///   limit: number,
        ///   filter: AnyObject,
        ///   facets: [
        ///     {
        ///       count: number,
        ///       facet: string,
        ///       sort: AnyObject
        ///     }
        ///   ],
        ///   taxonomySetting: {
        ///     assetTypes: [string],
        ///     facet: SearchFacetItem
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   @search.count: number,
        ///   @search.facets: {
        ///     assetType: [
        ///       {
        ///         count: number,
        ///         value: string
        ///       }
        ///     ],
        ///     classification: [SearchFacetItemValue],
        ///     classificationCategory: [SearchFacetItemValue],
        ///     contactId: [SearchFacetItemValue],
        ///     fileExtension: [SearchFacetItemValue],
        ///     label: [SearchFacetItemValue],
        ///     term: [SearchFacetItemValue]
        ///   },
        ///   value: [SearchResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> SearchAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.Search");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSearchRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets data using search. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Response"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   keywords: string,
        ///   offset: number,
        ///   limit: number,
        ///   filter: AnyObject,
        ///   facets: [
        ///     {
        ///       count: number,
        ///       facet: string,
        ///       sort: AnyObject
        ///     }
        ///   ],
        ///   taxonomySetting: {
        ///     assetTypes: [string],
        ///     facet: SearchFacetItem
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   @search.count: number,
        ///   @search.facets: {
        ///     assetType: [
        ///       {
        ///         count: number,
        ///         value: string
        ///       }
        ///     ],
        ///     classification: [SearchFacetItemValue],
        ///     classificationCategory: [SearchFacetItemValue],
        ///     contactId: [SearchFacetItemValue],
        ///     fileExtension: [SearchFacetItemValue],
        ///     label: [SearchFacetItemValue],
        ///     term: [SearchFacetItemValue]
        ///   },
        ///   value: [SearchResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response Search(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.Search");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSearchRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get search suggestions by query criteria. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Task{Response}"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   keywords: string,
        ///   limit: number,
        ///   filter: AnyObject
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [SuggestResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> SuggestAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.Suggest");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSuggestRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get search suggestions by query criteria. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Response"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   keywords: string,
        ///   limit: number,
        ///   filter: AnyObject
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [SuggestResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response Suggest(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.Suggest");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSuggestRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Browse entities by path or entity type. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Task{Response}"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   entityType: string,
        ///   path: string,
        ///   limit: number,
        ///   offset: number
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   @search.count: number,
        ///   value: [BrowseResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> BrowseAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.Browse");
            scope.Start();
            try
            {
                using HttpMessage message = CreateBrowseRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Browse entities by path or entity type. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Response"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   entityType: string,
        ///   path: string,
        ///   limit: number,
        ///   offset: number
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   @search.count: number,
        ///   value: [BrowseResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response Browse(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.Browse");
            scope.Start();
            try
            {
                using HttpMessage message = CreateBrowseRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get auto complete options. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Task{Response}"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   keywords: string,
        ///   limit: number,
        ///   filter: AnyObject
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [AutoCompleteResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> AutoCompleteAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.AutoComplete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAutoCompleteRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get auto complete options. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Response"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   keywords: string,
        ///   limit: number,
        ///   filter: AnyObject
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [AutoCompleteResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response AutoComplete(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.AutoComplete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAutoCompleteRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private PurviewEntities _cachedPurviewEntities;
        private PurviewGlossaries _cachedPurviewGlossaries;
        private PurviewLineages _cachedPurviewLineages;
        private PurviewRelationships _cachedPurviewRelationships;
        private PurviewTypes _cachedPurviewTypes;
        private PurviewCollections _cachedPurviewCollections;

        /// <summary> Initializes a new instance of PurviewEntities. </summary>
        public virtual PurviewEntities GetPurviewEntitiesClient()
        {
            return Volatile.Read(ref _cachedPurviewEntities) ?? Interlocked.CompareExchange(ref _cachedPurviewEntities, new PurviewEntities(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint), null) ?? _cachedPurviewEntities;
        }

        /// <summary> Initializes a new instance of PurviewGlossaries. </summary>
        public virtual PurviewGlossaries GetPurviewGlossariesClient()
        {
            return Volatile.Read(ref _cachedPurviewGlossaries) ?? Interlocked.CompareExchange(ref _cachedPurviewGlossaries, new PurviewGlossaries(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedPurviewGlossaries;
        }

        /// <summary> Initializes a new instance of PurviewLineages. </summary>
        public virtual PurviewLineages GetPurviewLineagesClient()
        {
            return Volatile.Read(ref _cachedPurviewLineages) ?? Interlocked.CompareExchange(ref _cachedPurviewLineages, new PurviewLineages(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedPurviewLineages;
        }

        /// <summary> Initializes a new instance of PurviewRelationships. </summary>
        public virtual PurviewRelationships GetPurviewRelationshipsClient()
        {
            return Volatile.Read(ref _cachedPurviewRelationships) ?? Interlocked.CompareExchange(ref _cachedPurviewRelationships, new PurviewRelationships(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint), null) ?? _cachedPurviewRelationships;
        }

        /// <summary> Initializes a new instance of PurviewTypes. </summary>
        public virtual PurviewTypes GetPurviewTypesClient()
        {
            return Volatile.Read(ref _cachedPurviewTypes) ?? Interlocked.CompareExchange(ref _cachedPurviewTypes, new PurviewTypes(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedPurviewTypes;
        }

        /// <summary> Initializes a new instance of PurviewCollections. </summary>
        public virtual PurviewCollections GetPurviewCollectionsClient()
        {
            return Volatile.Read(ref _cachedPurviewCollections) ?? Interlocked.CompareExchange(ref _cachedPurviewCollections, new PurviewCollections(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedPurviewCollections;
        }

        internal HttpMessage CreateSearchRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/search/query", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateSuggestRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/search/suggest", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateBrowseRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/browse", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateAutoCompleteRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/search/autocomplete", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
