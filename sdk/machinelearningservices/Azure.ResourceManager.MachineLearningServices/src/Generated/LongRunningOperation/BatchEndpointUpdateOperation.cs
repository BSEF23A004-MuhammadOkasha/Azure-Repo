// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Update a batch inference endpoint (asynchronous). </summary>
    public partial class BatchEndpointUpdateOperation : Operation<BatchEndpointTrackedResource>, IOperationSource<BatchEndpointTrackedResource>
    {
        private readonly OperationInternals<BatchEndpointTrackedResource> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of BatchEndpointUpdateOperation for mocking. </summary>
        protected BatchEndpointUpdateOperation()
        {
        }

        internal BatchEndpointUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<BatchEndpointTrackedResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "BatchEndpointUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override BatchEndpointTrackedResource Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<BatchEndpointTrackedResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<BatchEndpointTrackedResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        BatchEndpointTrackedResource IOperationSource<BatchEndpointTrackedResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new BatchEndpointTrackedResource(_operationBase, BatchEndpointTrackedResourceData.DeserializeBatchEndpointTrackedResourceData(document.RootElement));
        }

        async ValueTask<BatchEndpointTrackedResource> IOperationSource<BatchEndpointTrackedResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new BatchEndpointTrackedResource(_operationBase, BatchEndpointTrackedResourceData.DeserializeBatchEndpointTrackedResourceData(document.RootElement));
        }
    }
}
