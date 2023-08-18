// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> Creates a data flow debug session. </summary>
    public partial class DataFlowDebugSessionCreateDataFlowDebugSessionOperation : Operation<CreateDataFlowDebugSessionResponse>, Core.IOperationSource<CreateDataFlowDebugSessionResponse>
    {
        private readonly OperationInternal<CreateDataFlowDebugSessionResponse> _operation;

        /// <summary> Initializes a new instance of DataFlowDebugSessionCreateDataFlowDebugSessionOperation for mocking. </summary>
        protected DataFlowDebugSessionCreateDataFlowDebugSessionOperation()
        {
        }

        internal DataFlowDebugSessionCreateDataFlowDebugSessionOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            IOperation<CreateDataFlowDebugSessionResponse> nextLinkOperation = Core.NextLinkOperationImplementation.Create(this, pipeline, request.Method, request.Uri.ToUri(), response, Core.OperationFinalStateVia.Location);
            _operation = new OperationInternal<CreateDataFlowDebugSessionResponse>(nextLinkOperation, clientDiagnostics, response, "DataFlowDebugSessionCreateDataFlowDebugSessionOperation");
        }

        /// <inheritdoc />
#pragma warning disable CA1822
        public override string Id => throw new NotImplementedException();
#pragma warning restore CA1822

        /// <inheritdoc />
        public override CreateDataFlowDebugSessionResponse Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.RawResponse;

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override Response<CreateDataFlowDebugSessionResponse> WaitForCompletion(CancellationToken cancellationToken = default) => _operation.WaitForCompletion(cancellationToken);

        /// <inheritdoc />
        public override Response<CreateDataFlowDebugSessionResponse> WaitForCompletion(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletion(pollingInterval, cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<CreateDataFlowDebugSessionResponse>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<CreateDataFlowDebugSessionResponse>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        CreateDataFlowDebugSessionResponse Core.IOperationSource<CreateDataFlowDebugSessionResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return CreateDataFlowDebugSessionResponse.DeserializeCreateDataFlowDebugSessionResponse(document.RootElement);
        }

        async ValueTask<CreateDataFlowDebugSessionResponse> Core.IOperationSource<CreateDataFlowDebugSessionResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return CreateDataFlowDebugSessionResponse.DeserializeCreateDataFlowDebugSessionResponse(document.RootElement);
        }
    }
}
