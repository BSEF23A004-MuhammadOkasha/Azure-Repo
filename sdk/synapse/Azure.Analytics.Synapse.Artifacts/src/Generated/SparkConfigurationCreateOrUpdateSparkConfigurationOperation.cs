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
    /// <summary> Creates or updates a sparkconfiguration. </summary>
    public partial class SparkConfigurationCreateOrUpdateSparkConfigurationOperation : Operation<SparkConfigurationResource>, IOperationSource<SparkConfigurationResource>
    {
        private readonly OperationInternal<SparkConfigurationResource> _operation;

        /// <summary> Initializes a new instance of SparkConfigurationCreateOrUpdateSparkConfigurationOperation for mocking. </summary>
        protected SparkConfigurationCreateOrUpdateSparkConfigurationOperation()
        {
        }

        internal SparkConfigurationCreateOrUpdateSparkConfigurationOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            IOperation<SparkConfigurationResource> nextLinkOperation = NextLinkOperationImplementation.Create(this, pipeline, request.Method, request.Uri.ToUri(), response, Core.OperationFinalStateVia.Location);
            _operation = new OperationInternal<SparkConfigurationResource>(nextLinkOperation, clientDiagnostics, response, "SparkConfigurationCreateOrUpdateSparkConfigurationOperation");
        }

        /// <inheritdoc />
#pragma warning disable CA1822
        public override string Id => throw new NotImplementedException();
#pragma warning restore CA1822

        /// <inheritdoc />
        public override SparkConfigurationResource Value => _operation.Value;

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
        public override Response<SparkConfigurationResource> WaitForCompletion(CancellationToken cancellationToken = default) => _operation.WaitForCompletion(cancellationToken);

        /// <inheritdoc />
        public override Response<SparkConfigurationResource> WaitForCompletion(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletion(pollingInterval, cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SparkConfigurationResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SparkConfigurationResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SparkConfigurationResource IOperationSource<SparkConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return SparkConfigurationResource.DeserializeSparkConfigurationResource(document.RootElement);
        }

        async ValueTask<SparkConfigurationResource> IOperationSource<SparkConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return SparkConfigurationResource.DeserializeSparkConfigurationResource(document.RootElement);
        }
    }
}
