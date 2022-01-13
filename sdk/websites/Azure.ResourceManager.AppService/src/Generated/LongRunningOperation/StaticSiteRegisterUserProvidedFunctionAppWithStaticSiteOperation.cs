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
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Register a user provided function app with a static site. </summary>
    public partial class StaticSiteRegisterUserProvidedFunctionAppWithStaticSiteOperation : Operation<AppService.StaticSiteUserProvidedFunctionApp>, IOperationSource<AppService.StaticSiteUserProvidedFunctionApp>
    {
        private readonly OperationInternals<AppService.StaticSiteUserProvidedFunctionApp> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of StaticSiteRegisterUserProvidedFunctionAppWithStaticSiteOperation for mocking. </summary>
        protected StaticSiteRegisterUserProvidedFunctionAppWithStaticSiteOperation()
        {
        }

        internal StaticSiteRegisterUserProvidedFunctionAppWithStaticSiteOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<AppService.StaticSiteUserProvidedFunctionApp>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "StaticSiteRegisterUserProvidedFunctionAppWithStaticSiteOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AppService.StaticSiteUserProvidedFunctionApp Value => _operation.Value;

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
        public override ValueTask<Response<AppService.StaticSiteUserProvidedFunctionApp>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AppService.StaticSiteUserProvidedFunctionApp>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        AppService.StaticSiteUserProvidedFunctionApp IOperationSource<AppService.StaticSiteUserProvidedFunctionApp>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StaticSiteUserProvidedFunctionAppARMResourceData.DeserializeStaticSiteUserProvidedFunctionAppARMResourceData(document.RootElement);
            return new AppService.StaticSiteUserProvidedFunctionApp(_operationBase, data);
        }

        async ValueTask<AppService.StaticSiteUserProvidedFunctionApp> IOperationSource<AppService.StaticSiteUserProvidedFunctionApp>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StaticSiteUserProvidedFunctionAppARMResourceData.DeserializeStaticSiteUserProvidedFunctionAppARMResourceData(document.RootElement);
            return new AppService.StaticSiteUserProvidedFunctionApp(_operationBase, data);
        }
    }
}
