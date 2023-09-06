// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary>
    /// Get Operation response object.
    /// Please note <see cref="OperationDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DocumentClassifierBuildOperationDetails"/>, <see cref="DocumentModelBuildOperationDetails"/>, <see cref="DocumentModelComposeOperationDetails"/> and <see cref="DocumentModelCopyToOperationDetails"/>.
    /// </summary>
    public partial class OperationDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OperationDetails"/>. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="createdOn"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> or <paramref name="resourceLocation"/> is null. </exception>
        internal OperationDetails(string operationId, DocumentOperationStatus status, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, Uri resourceLocation)
        {
            Argument.AssertNotNull(operationId, nameof(operationId));
            Argument.AssertNotNull(resourceLocation, nameof(resourceLocation));

            OperationId = operationId;
            Status = status;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            ResourceLocation = resourceLocation;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationDetails"/>. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentCompleted"> Operation progress (0-100). </param>
        /// <param name="createdOn"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="kind"> Type of operation. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <param name="serviceVersion"> API version used to create this operation. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document model. </param>
        /// <param name="jsonError"> Encountered error. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationDetails(string operationId, DocumentOperationStatus status, int? percentCompleted, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, DocumentOperationKind kind, Uri resourceLocation, string serviceVersion, IReadOnlyDictionary<string, string> tags, JsonElement jsonError, Dictionary<string, BinaryData> rawData)
        {
            OperationId = operationId;
            Status = status;
            PercentCompleted = percentCompleted;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            Kind = kind;
            ResourceLocation = resourceLocation;
            ServiceVersion = serviceVersion;
            Tags = tags;
            JsonError = jsonError;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="OperationDetails"/> for deserialization. </summary>
        internal OperationDetails()
        {
        }

        /// <summary> Operation ID. </summary>
        public string OperationId { get; }
        /// <summary> Operation status. </summary>
        public DocumentOperationStatus Status { get; }
        /// <summary> Operation progress (0-100). </summary>
        public int? PercentCompleted { get; }
        /// <summary> List of key-value tag attributes associated with the document model. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
