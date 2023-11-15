// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The PendingUploadResponseDto. </summary>
    public partial class PendingUploadResponseDto
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PendingUploadResponseDto"/>. </summary>
        internal PendingUploadResponseDto()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PendingUploadResponseDto"/>. </summary>
        /// <param name="blobReferenceForConsumption"> Container level read, write, list SAS. </param>
        /// <param name="pendingUploadId"> ID for this upload request. </param>
        /// <param name="pendingUploadType"> TemporaryBlobReference is the only supported type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PendingUploadResponseDto(BlobReferenceForConsumptionDto blobReferenceForConsumption, string pendingUploadId, PendingUploadType? pendingUploadType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BlobReferenceForConsumption = blobReferenceForConsumption;
            PendingUploadId = pendingUploadId;
            PendingUploadType = pendingUploadType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Container level read, write, list SAS. </summary>
        public BlobReferenceForConsumptionDto BlobReferenceForConsumption { get; }
        /// <summary> ID for this upload request. </summary>
        public string PendingUploadId { get; }
        /// <summary> TemporaryBlobReference is the only supported type. </summary>
        public PendingUploadType? PendingUploadType { get; }
    }
}
