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
    /// <summary> Updates an existing origin group within a profile. </summary>
    public partial class AFDOriginGroupUpdateOperation : Operation<AfdOriginGroup>, IOperationSource<AfdOriginGroup>
    {
        private readonly OperationInternals<AfdOriginGroup> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of AFDOriginGroupUpdateOperation for mocking. </summary>
        protected AFDOriginGroupUpdateOperation()
        {
        }

        internal AFDOriginGroupUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<AfdOriginGroup>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.OriginalUri, "AFDOriginGroupUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AfdOriginGroup Value => _operation.Value;

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
        public override ValueTask<Response<AfdOriginGroup>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AfdOriginGroup>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        AfdOriginGroup IOperationSource<AfdOriginGroup>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new AfdOriginGroup(_operationBase, AfdOriginGroupData.DeserializeAfdOriginGroupData(document.RootElement));
        }

        async ValueTask<AfdOriginGroup> IOperationSource<AfdOriginGroup>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new AfdOriginGroup(_operationBase, AfdOriginGroupData.DeserializeAfdOriginGroupData(document.RootElement));
        }
    }
}
