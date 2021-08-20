// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Operation info. </summary>
    public partial class ModelOperationInfo
    {
        /// <summary> Initializes a new instance of ModelOperationInfo. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="createdOn"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> or <paramref name="resourceLocation"/> is null. </exception>
        internal ModelOperationInfo(string operationId, DocumentOperationStatus status, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, string resourceLocation)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (resourceLocation == null)
            {
                throw new ArgumentNullException(nameof(resourceLocation));
            }

            OperationId = operationId;
            Status = status;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            ResourceLocation = resourceLocation;
        }

        /// <summary> Initializes a new instance of ModelOperationInfo. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentCompleted"> Operation progress (0-100). </param>
        /// <param name="createdOn"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="kind"> Type of operation. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        internal ModelOperationInfo(string operationId, DocumentOperationStatus status, int? percentCompleted, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, DocumentOperationKind? kind, string resourceLocation)
        {
            OperationId = operationId;
            Status = status;
            PercentCompleted = percentCompleted;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            Kind = kind;
            ResourceLocation = resourceLocation;
        }

        /// <summary> Operation ID. </summary>
        public string OperationId { get; }
        /// <summary> Operation status. </summary>
        public DocumentOperationStatus Status { get; }
        /// <summary> Operation progress (0-100). </summary>
        public int? PercentCompleted { get; }
        /// <summary> Type of operation. </summary>
        public DocumentOperationKind? Kind { get; }
        /// <summary> URL of the resource targeted by this operation. </summary>
        public string ResourceLocation { get; }
    }
}
