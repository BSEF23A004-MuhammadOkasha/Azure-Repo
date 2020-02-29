﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure.AI.FormRecognizer.Models;
using Azure.Core;
using Azure.Core.Pipeline;

// TODO: Rename to FormRecognizer
using Azure.Template.Models;

namespace Azure.AI.FormRecognizer
{
    /// <summary>
    /// The sample client.
    /// </summary>
    public class CustomFormClient
    {
        private readonly ClientDiagnostics _diagnostics;
        private readonly HttpPipeline _pipeline;
        private readonly AllOperations _operations;

        internal const string CustomModelsRoute = "/custom/models";

        /// <summary>
        /// Mocking ctor only.
        /// </summary>
        protected CustomFormClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormClient"/>.
        /// </summary>
#pragma warning disable AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        public CustomFormClient(Uri endpoint, FormRecognizerApiKeyCredential credential) : this(endpoint, credential, new FormRecognizerClientOptions())
#pragma warning restore AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormClient"/>.
        /// </summary>
#pragma warning disable AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        public CustomFormClient(Uri endpoint, FormRecognizerApiKeyCredential credential, FormRecognizerClientOptions options)
#pragma warning restore AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        {
            _diagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new ApiKeyAuthenticationPolicy(credential));
            _operations = new AllOperations(_diagnostics, _pipeline, endpoint.ToString());
        }

        #region Training

        public virtual TrainingOperation StartTraining(string source, TrainingFileFilter filter = default, CancellationToken cancellationToken = default)
        {
            // TODO: do we need to set prefix to an empty string in filter? -- looks like yes.
            //filter ??= new TrainingFileFilter();

            TrainRequest trainRequest = new TrainRequest() { Source = source };

            // TODO: Q1 - if there's a way to default a property value, set filter.Path ="" and set it here in a nicer way.
            if (filter != default)
            {
                trainRequest.SourceFilter = filter;
            }

            // TODO: Make this call an async method instead - i.e. AsyncAsync :-P
            ResponseWithHeaders<TrainCustomModelAsyncHeaders> response = _operations.TrainCustomModelAsync(trainRequest);
            return new TrainingOperation(_operations, response.Headers.Location);
        }

        #endregion Training

        #region Analyze

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ExtractFormOperation StartExtractForm(string modelId, Stream stream, FormContentType contentType, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            // TODO: Make this call an async method instead
            // TODO: automate content-type detection
            ResponseWithHeaders<AnalyzeWithCustomModelHeaders> response = _operations.AnalyzeWithCustomModel(new Guid(modelId), includeTextDetails: includeRawPageExtractions, stream, contentType, cancellationToken);
            return new ExtractFormOperation(_operations, modelId, response.Headers.OperationLocation);
        }

        #endregion Analyze

        #region CRUD Ops

        public virtual Pageable<ModelInfo_internal> GetCustomModels(CancellationToken cancellationToken = default)
        {
            return _operations.GetCustomModelsPageable(GetModelOptions.Full, cancellationToken);
        }

        public virtual AsyncPageable<ModelInfo_internal> GetCustomModelsAsync(CancellationToken cancellationToken = default)
        {
            return _operations.GetCustomModelsPageableAsync(GetModelOptions.Full, cancellationToken);
        }

        /// <summary>
        /// Executes a service call that takes and returns the <see cref="CustomModelCollection"/>.
        /// </summary>
        public virtual Response<CustomModelCollection> GetCustomModelSummary(CancellationToken cancellationToken = default)
        {
            return _operations.GetCustomModels(GetModelOptions.Summary, cancellationToken);
        }

        /// <summary>
        /// Executes a service call that takes and returns the <see cref="CustomModelCollection"/>.
        /// </summary>
        public virtual async Task<Response<CustomModelCollection>> GetCustomModelSummaryAsync(CancellationToken cancellationToken = default)
        {
            return await _operations.GetCustomModelsAsync(GetModelOptions.Summary, cancellationToken).ConfigureAwait(false);
        }

        #endregion CRUD Ops
    }
}
