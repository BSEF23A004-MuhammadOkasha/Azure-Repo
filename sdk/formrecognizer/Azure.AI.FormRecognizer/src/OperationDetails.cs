﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary>
    /// The response object of a <see cref="DocumentModelAdministrationClient.GetOperation"/> request. Supported
    /// operations are:
    /// <list type="bullet">
    ///     <item><description><see cref="DocumentModelBuildOperationDetails"/></description></item>
    ///     <item><description><see cref="DocumentModelComposeOperationDetails"/></description></item>
    ///     <item><description><see cref="DocumentModelCopyToOperationDetails"/></description></item>
    /// </list>
    /// </summary>
    [CodeGenModel("OperationDetails")]
    public partial class OperationDetails
    {
        /// <summary>
        /// Initializes a new instance of DocumentModelOperationDetails. Used by the <see cref="DocumentAnalysisModelFactory"/>
        /// for mocking.
        /// </summary>
        internal OperationDetails(string operationId, DocumentOperationStatus status, int? percentCompleted, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, DocumentOperationKind kind, Uri resourceLocation, string apiVersion, IReadOnlyDictionary<string, string> tags, ResponseError error)
        {
            OperationId = operationId;
            Status = status;
            PercentCompleted = percentCompleted;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            Kind = kind;
            ResourceLocation = resourceLocation;
            ApiVersion = apiVersion;
            Tags = tags;
            Error = error;
        }

        /// <summary>
        /// Date and time (UTC) when the operation was created.
        /// </summary>
        [CodeGenMember("CreatedDateTime")]
        public DateTimeOffset CreatedOn { get; }

        /// <summary>
        /// Date and time (UTC) when the operation was last updated.
        /// </summary>
        [CodeGenMember("LastUpdatedDateTime")]
        public DateTimeOffset LastUpdatedOn { get; }

        /// <summary>
        /// Type of operation.
        /// </summary>
        [CodeGenMember("Kind")]
        public DocumentOperationKind Kind { get; internal set; }

        /// <summary>
        /// URI of the resource targeted by this operation.
        /// </summary>
        public Uri ResourceLocation { get; }

        /// <summary>
        /// Gets the error that occurred during the operation. The value is <c>null</c> if the operation succeeds.
        /// </summary>
        public ResponseError Error { get; private set; }

        // The service returns a custom DocumentAnalysis.Error object but we want to expose
        // Core's ResponseError instead. To accomplish this, we keep the returned error as a
        // JsonElement and manually serialize it to ResponseError.
        [CodeGenMember("Error")]
        internal JsonElement JsonError
        {
            get => throw new InvalidOperationException();
            private set
            {
                Error = value.ValueKind == JsonValueKind.Undefined
                    ? null
                    : JsonSerializer.Deserialize<ResponseError>(value.GetRawText());
            }
        }

        internal string ApiVersion { get; }
    }
}
