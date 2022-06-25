// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Template
{
    /// <summary> The Products service client. </summary>
    public partial class ProductsClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://vault.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ProductsClient for mocking. </summary>
        protected ProductsClient()
        {
        }

        /// <summary> Initializes a new instance of ProductsClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public ProductsClient(TokenCredential credential) : this(credential, new Uri(""), new MultiClientServiceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ProductsClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="endpoint"/> is null. </exception>
        public ProductsClient(TokenCredential credential, Uri endpoint, MultiClientServiceClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new MultiClientServiceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <param name="id"> The Integer to use. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Product</c>:
        /// <code>{
        ///   id: number, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetProductAsync(int id, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ProductsClient.GetProduct");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetProductRequest(id, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="id"> The Integer to use. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Product</c>:
        /// <code>{
        ///   id: number, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetProduct(int id, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ProductsClient.GetProduct");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetProductRequest(id, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetProductRequest(int id, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/products/", false);
            uri.AppendPath(id, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
