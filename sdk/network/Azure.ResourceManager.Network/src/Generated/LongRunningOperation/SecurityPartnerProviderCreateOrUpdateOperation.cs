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
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Creates or updates the specified Security Partner Provider. </summary>
    public partial class SecurityPartnerProviderCreateOrUpdateOperation : Operation<SecurityPartnerProvider>, IOperationSource<SecurityPartnerProvider>
    {
        private readonly OperationInternals<SecurityPartnerProvider> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of SecurityPartnerProviderCreateOrUpdateOperation for mocking. </summary>
        protected SecurityPartnerProviderCreateOrUpdateOperation()
        {
        }

        internal SecurityPartnerProviderCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SecurityPartnerProvider>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "SecurityPartnerProviderCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SecurityPartnerProvider Value => _operation.Value;

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
        public override ValueTask<Response<SecurityPartnerProvider>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SecurityPartnerProvider>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SecurityPartnerProvider IOperationSource<SecurityPartnerProvider>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SecurityPartnerProviderData.DeserializeSecurityPartnerProviderData(document.RootElement);
            return new SecurityPartnerProvider(_armClient, data);
        }

        async ValueTask<SecurityPartnerProvider> IOperationSource<SecurityPartnerProvider>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SecurityPartnerProviderData.DeserializeSecurityPartnerProviderData(document.RootElement);
            return new SecurityPartnerProvider(_armClient, data);
        }
    }
}
