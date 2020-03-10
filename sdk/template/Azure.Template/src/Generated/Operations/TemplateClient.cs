// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Template.Models;

namespace Azure.Template
{
    public partial class TemplateClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal ServiceRestClient RestClient { get; }
        /// <summary> Initializes a new instance of TemplateClient. </summary>
        internal TemplateClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new ServiceRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <param name="body"> The Model to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Response<Model>> OperationAsync(Model body, CancellationToken cancellationToken = default)
        {
            return await RestClient.OperationAsync(body, cancellationToken).ConfigureAwait(false);
        }
        /// <param name="body"> The Model to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Model> Operation(Model body, CancellationToken cancellationToken = default)
        {
            return RestClient.Operation(body, cancellationToken);
        }
    }
}
