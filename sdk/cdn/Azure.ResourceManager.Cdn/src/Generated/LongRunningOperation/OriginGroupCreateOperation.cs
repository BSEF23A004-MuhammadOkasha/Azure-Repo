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
using Azure.ResourceManager.Cdn;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Creates a new origin group within the specified endpoint. </summary>
    public partial class OriginGroupCreateOperation : Operation<OriginGroup>, IOperationSource<OriginGroup>
    {
        private readonly OperationInternals<OriginGroup> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of OriginGroupCreateOperation for mocking. </summary>
        protected OriginGroupCreateOperation()
        {
        }

        internal OriginGroupCreateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<OriginGroup>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "OriginGroupCreateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override OriginGroup Value => _operation.Value;

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
        public override ValueTask<Response<OriginGroup>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<OriginGroup>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        OriginGroup IOperationSource<OriginGroup>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new OriginGroup(_operationBase, OriginGroupData.DeserializeOriginGroupData(document.RootElement));
        }

        async ValueTask<OriginGroup> IOperationSource<OriginGroup>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new OriginGroup(_operationBase, OriginGroupData.DeserializeOriginGroupData(document.RootElement));
        }
    }
}
