// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Catalog
{
    /// <summary> The PurviewCatalog service client. </summary>
    public partial class PurviewCatalogClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of PurviewCatalogClient for mocking. </summary>
        protected PurviewCatalogClient()
        {
        }

        /// <summary> Initializes a new instance of PurviewCatalogClient. </summary>
        /// <param name="endpoint"> The catalog endpoint of your Purview account. Example: https://{accountName}.purview.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public PurviewCatalogClient(Uri endpoint, TokenCredential credential, PurviewCatalogClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PurviewCatalogClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            var authPolicy = new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Gets data using search. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>keywords</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The keywords applied to all searchable fields.</term>
        ///   </item>
        ///   <item>
        ///     <term>offset</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The offset. The default value is 0.</term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The limit of the number of the search result. default value is 50; maximum value is 1000.</term>
        ///   </item>
        ///   <item>
        ///     <term>filter</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term>The filter for the search. See examples for the usage of supported filters.</term>
        ///   </item>
        ///   <item>
        ///     <term>facets</term>
        ///     <term>SearchFacetItem[]</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        ///   <item>
        ///     <term>taxonomySetting</term>
        ///     <term>SearchRequestTaxonomySetting</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        /// </list>
        /// Schema for <c>SearchRequestTaxonomySetting</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>assetTypes</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        ///   <item>
        ///     <term>facet</term>
        ///     <term>SearchFacetItem</term>
        ///     <term></term>
        ///     <term>The content of a search facet result item.</term>
        ///   </item>
        /// </list>
        /// Schema for <c>SearchFacetItem</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>count</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The count of the facet item.</term>
        ///   </item>
        ///   <item>
        ///     <term>facet</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The name of the facet item.</term>
        ///   </item>
        ///   <item>
        ///     <term>sort</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term>Any object</term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> SearchAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateSearchRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.Search");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets data using search. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>keywords</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The keywords applied to all searchable fields.</term>
        ///   </item>
        ///   <item>
        ///     <term>offset</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The offset. The default value is 0.</term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The limit of the number of the search result. default value is 50; maximum value is 1000.</term>
        ///   </item>
        ///   <item>
        ///     <term>filter</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term>The filter for the search. See examples for the usage of supported filters.</term>
        ///   </item>
        ///   <item>
        ///     <term>facets</term>
        ///     <term>SearchFacetItem[]</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        ///   <item>
        ///     <term>taxonomySetting</term>
        ///     <term>SearchRequestTaxonomySetting</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        /// </list>
        /// Schema for <c>SearchRequestTaxonomySetting</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>assetTypes</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        ///   <item>
        ///     <term>facet</term>
        ///     <term>SearchFacetItem</term>
        ///     <term></term>
        ///     <term>The content of a search facet result item.</term>
        ///   </item>
        /// </list>
        /// Schema for <c>SearchFacetItem</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>count</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The count of the facet item.</term>
        ///   </item>
        ///   <item>
        ///     <term>facet</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The name of the facet item.</term>
        ///   </item>
        ///   <item>
        ///     <term>sort</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term>Any object</term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Search(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateSearchRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.Search");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="Search"/> and <see cref="SearchAsync"/> operations. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateSearchRequest(RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/search/query", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Get search suggestions by query criteria. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>keywords</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The keywords applied to all fields that support suggest operation. It must be at least 1 character, and no more than 100 characters. In the index schema we defined a default suggester which lists all the supported fields and specifies a search mode.</term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The number of suggestions we hope to return. The default value is 5. The value must be a number between 1 and 100.</term>
        ///   </item>
        ///   <item>
        ///     <term>filter</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term>The filter for the search.</term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> SuggestAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateSuggestRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.Suggest");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get search suggestions by query criteria. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>keywords</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The keywords applied to all fields that support suggest operation. It must be at least 1 character, and no more than 100 characters. In the index schema we defined a default suggester which lists all the supported fields and specifies a search mode.</term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The number of suggestions we hope to return. The default value is 5. The value must be a number between 1 and 100.</term>
        ///   </item>
        ///   <item>
        ///     <term>filter</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term>The filter for the search.</term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Suggest(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateSuggestRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.Suggest");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="Suggest"/> and <see cref="SuggestAsync"/> operations. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateSuggestRequest(RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/search/suggest", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Browse entities by path or entity type. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>entityType</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The entity type to browse as the root level entry point.</term>
        ///   </item>
        ///   <item>
        ///     <term>path</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The path to browse the next level child entities.</term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The number of browse items we hope to return.</term>
        ///   </item>
        ///   <item>
        ///     <term>offset</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The offset. The default value is 0.</term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> BrowseAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateBrowseRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.Browse");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Browse entities by path or entity type. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>entityType</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The entity type to browse as the root level entry point.</term>
        ///   </item>
        ///   <item>
        ///     <term>path</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The path to browse the next level child entities.</term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The number of browse items we hope to return.</term>
        ///   </item>
        ///   <item>
        ///     <term>offset</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The offset. The default value is 0.</term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Browse(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateBrowseRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.Browse");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="Browse"/> and <see cref="BrowseAsync"/> operations. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateBrowseRequest(RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/browse", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Get auto complete options. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>keywords</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The keywords applied to all fields that support autocomplete operation. It must be at least 1 character, and no more than 100 characters.</term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The number of autocomplete results we hope to return. The default value is 50. The value must be a number between 1 and 100.</term>
        ///   </item>
        ///   <item>
        ///     <term>filter</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term>The filter for the autocomplete request.</term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> AutoCompleteAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateAutoCompleteRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.AutoComplete");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get auto complete options. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>keywords</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The keywords applied to all fields that support autocomplete operation. It must be at least 1 character, and no more than 100 characters.</term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term>The number of autocomplete results we hope to return. The default value is 50. The value must be a number between 1 and 100.</term>
        ///   </item>
        ///   <item>
        ///     <term>filter</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term>The filter for the autocomplete request.</term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response AutoComplete(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateAutoCompleteRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.AutoComplete");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="AutoComplete"/> and <see cref="AutoCompleteAsync"/> operations. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateAutoCompleteRequest(RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/search/autocomplete", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }
    }
}
