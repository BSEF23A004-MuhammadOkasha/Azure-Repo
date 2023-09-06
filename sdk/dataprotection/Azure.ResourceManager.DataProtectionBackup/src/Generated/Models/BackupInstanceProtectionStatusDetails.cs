// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Protection status details. </summary>
    public partial class BackupInstanceProtectionStatusDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BackupInstanceProtectionStatusDetails"/>. </summary>
        internal BackupInstanceProtectionStatusDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupInstanceProtectionStatusDetails"/>. </summary>
        /// <param name="errorDetails"> Specifies the protection status error of the resource. </param>
        /// <param name="status"> Specifies the protection status of the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupInstanceProtectionStatusDetails(ResponseError errorDetails, BackupInstanceProtectionStatus? status, Dictionary<string, BinaryData> rawData)
        {
            ErrorDetails = errorDetails;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> Specifies the protection status error of the resource. </summary>
        public ResponseError ErrorDetails { get; }
        /// <summary> Specifies the protection status of the resource. </summary>
        public BackupInstanceProtectionStatus? Status { get; }
    }
}
