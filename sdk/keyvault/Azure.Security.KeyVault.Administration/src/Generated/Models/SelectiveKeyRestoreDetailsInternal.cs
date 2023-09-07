// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> Selective Key Restore operation. </summary>
    internal partial class SelectiveKeyRestoreDetailsInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SelectiveKeyRestoreDetailsInternal"/>. </summary>
        internal SelectiveKeyRestoreDetailsInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SelectiveKeyRestoreDetailsInternal"/>. </summary>
        /// <param name="status"> Status of the restore operation. </param>
        /// <param name="statusDetails"> The status details of restore operation. </param>
        /// <param name="error"> Error encountered, if any, during the selective key restore operation. </param>
        /// <param name="jobId"> Identifier for the selective key restore operation. </param>
        /// <param name="startTime"> The start time of the restore operation. </param>
        /// <param name="endTime"> The end time of the restore operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SelectiveKeyRestoreDetailsInternal(string status, string statusDetails, KeyVaultServiceError error, string jobId, DateTimeOffset? startTime, DateTimeOffset? endTime, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            StatusDetails = statusDetails;
            Error = error;
            JobId = jobId;
            StartTime = startTime;
            EndTime = endTime;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Status of the restore operation. </summary>
        public string Status { get; }
        /// <summary> The status details of restore operation. </summary>
        public string StatusDetails { get; }
        /// <summary> Error encountered, if any, during the selective key restore operation. </summary>
        public KeyVaultServiceError Error { get; }
        /// <summary> Identifier for the selective key restore operation. </summary>
        public string JobId { get; }
        /// <summary> The start time of the restore operation. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The end time of the restore operation. </summary>
        public DateTimeOffset? EndTime { get; }
    }
}
