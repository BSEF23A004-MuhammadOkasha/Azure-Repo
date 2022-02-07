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
using Azure.ResourceManager;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Updates a database&apos;s short term retention policy. </summary>
    public partial class BackupShortTermRetentionPolicyUpdateOperation : Operation<BackupShortTermRetentionPolicy>, IOperationSource<BackupShortTermRetentionPolicy>
    {
        private readonly OperationInternals<BackupShortTermRetentionPolicy> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of BackupShortTermRetentionPolicyUpdateOperation for mocking. </summary>
        protected BackupShortTermRetentionPolicyUpdateOperation()
        {
        }

        internal BackupShortTermRetentionPolicyUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<BackupShortTermRetentionPolicy>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "BackupShortTermRetentionPolicyUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override BackupShortTermRetentionPolicy Value => _operation.Value;

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
        public override ValueTask<Response<BackupShortTermRetentionPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<BackupShortTermRetentionPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        BackupShortTermRetentionPolicy IOperationSource<BackupShortTermRetentionPolicy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BackupShortTermRetentionPolicyData.DeserializeBackupShortTermRetentionPolicyData(document.RootElement);
            return new BackupShortTermRetentionPolicy(_armClient, data);
        }

        async ValueTask<BackupShortTermRetentionPolicy> IOperationSource<BackupShortTermRetentionPolicy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BackupShortTermRetentionPolicyData.DeserializeBackupShortTermRetentionPolicyData(document.RootElement);
            return new BackupShortTermRetentionPolicy(_armClient, data);
        }
    }
}
