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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Updates an existing encryption protector. </summary>
    public partial class EncryptionProtectorCreateOrUpdateOperation : Operation<EncryptionProtector>, IOperationSource<EncryptionProtector>
    {
        private readonly OperationInternals<EncryptionProtector> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of EncryptionProtectorCreateOrUpdateOperation for mocking. </summary>
        protected EncryptionProtectorCreateOrUpdateOperation()
        {
        }

        internal EncryptionProtectorCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<EncryptionProtector>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "EncryptionProtectorCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override EncryptionProtector Value => _operation.Value;

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
        public override ValueTask<Response<EncryptionProtector>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<EncryptionProtector>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        EncryptionProtector IOperationSource<EncryptionProtector>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = EncryptionProtectorData.DeserializeEncryptionProtectorData(document.RootElement);
            return new EncryptionProtector(_operationBase, data);
        }

        async ValueTask<EncryptionProtector> IOperationSource<EncryptionProtector>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = EncryptionProtectorData.DeserializeEncryptionProtectorData(document.RootElement);
            return new EncryptionProtector(_operationBase, data);
        }
    }
}
