﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using System.Linq;

namespace Azure.AI.FormRecognizer.Models
{
    public class ExtractReceiptOperation : Operation<ExtractedReceipt>
    {
        private Response _response;
        private ExtractedReceipt _value;
        private bool _hasCompleted;

        private readonly AllOperations _operations;

        public override string Id { get; }

        public override ExtractedReceipt Value => OperationHelpers.GetValue(ref _value);

        public override bool HasCompleted => _hasCompleted;

        public override bool HasValue => _value != null;

        /// <inheritdoc/>
        public override Response GetRawResponse() => _response;

        /// <inheritdoc/>
        public override ValueTask<Response<ExtractedReceipt>> WaitForCompletionAsync(CancellationToken cancellationToken = default) =>
            this.DefaultWaitForCompletionAsync(cancellationToken);

        /// <inheritdoc/>
        public override ValueTask<Response<ExtractedReceipt>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) =>
            this.DefaultWaitForCompletionAsync(pollingInterval, cancellationToken);

        internal ExtractReceiptOperation(AllOperations operations, string operationLocation)
        {
            _operations = operations;

            // TODO: Add validation here?
            Id = operationLocation.Split('/').Last();
        }

        /// <inheritdoc/>
        public override Response UpdateStatus(CancellationToken cancellationToken = default) =>
            UpdateStatusAsync(false, cancellationToken).EnsureCompleted();

        /// <inheritdoc/>
        public override async ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) =>
            await UpdateStatusAsync(true, cancellationToken).ConfigureAwait(false);

        private async Task<Response> UpdateStatusAsync(bool async, CancellationToken cancellationToken)
        {
            if (!_hasCompleted)
            {
                Response<AnalyzeOperationResult_internal> update = async
                    ? await _operations.GetAnalyzeReceiptResultAsync(new Guid(Id), cancellationToken).ConfigureAwait(false)
                    : _operations.GetAnalyzeReceiptResult(new Guid(Id), cancellationToken);

                // TODO: check status code?  What if a failure status code is returned?

                if (update.Value.Status == OperationStatus.Succeeded || update.Value.Status == OperationStatus.Failed)
                {
                    _hasCompleted = true;

                    // TODO: When they support extracting more than one receipt, add a pageable method for this.
                    _value = new ExtractedReceipt(update.Value.AnalyzeResult.DocumentResults.First());
                }

                _response = update.GetRawResponse();
            }

            return GetRawResponse();
        }
    }
}
