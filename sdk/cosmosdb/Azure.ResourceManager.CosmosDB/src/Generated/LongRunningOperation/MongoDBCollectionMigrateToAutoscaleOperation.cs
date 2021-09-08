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

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Migrate an Azure Cosmos DB MongoDB collection from manual throughput to autoscale. </summary>
    public partial class MongoDBCollectionMigrateToAutoscaleOperation : Operation<ThroughputSettings>, IOperationSource<ThroughputSettings>
    {
        private readonly OperationInternals<ThroughputSettings> _operation;

        /// <summary> Initializes a new instance of MongoDBCollectionMigrateToAutoscaleOperation for mocking. </summary>
        protected MongoDBCollectionMigrateToAutoscaleOperation()
        {
        }

        internal MongoDBCollectionMigrateToAutoscaleOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ThroughputSettings>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "MongoDBCollectionMigrateToAutoscaleOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ThroughputSettings Value => _operation.Value;

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
        public override ValueTask<Response<ThroughputSettings>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ThroughputSettings>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ThroughputSettings IOperationSource<ThroughputSettings>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ThroughputSettings.DeserializeThroughputSettings(document.RootElement);
        }

        async ValueTask<ThroughputSettings> IOperationSource<ThroughputSettings>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ThroughputSettings.DeserializeThroughputSettings(document.RootElement);
        }
    }
}
