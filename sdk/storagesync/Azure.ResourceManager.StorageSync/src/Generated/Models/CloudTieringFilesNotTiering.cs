// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Server endpoint cloud tiering status object. </summary>
    public partial class CloudTieringFilesNotTiering
    {
        /// <summary> Initializes a new instance of CloudTieringFilesNotTiering. </summary>
        internal CloudTieringFilesNotTiering()
        {
            Errors = new Core.ChangeTrackingList<FilesNotTieringError>();
        }

        /// <summary> Initializes a new instance of CloudTieringFilesNotTiering. </summary>
        /// <param name="lastUpdatedOn"> Last updated timestamp. </param>
        /// <param name="totalFileCount"> Last cloud tiering result (HResult). </param>
        /// <param name="errors"> Array of tiering errors. </param>
        internal CloudTieringFilesNotTiering(DateTimeOffset? lastUpdatedOn, long? totalFileCount, IReadOnlyList<FilesNotTieringError> errors)
        {
            LastUpdatedOn = lastUpdatedOn;
            TotalFileCount = totalFileCount;
            Errors = errors;
        }

        /// <summary> Last updated timestamp. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> Last cloud tiering result (HResult). </summary>
        public long? TotalFileCount { get; }
        /// <summary> Array of tiering errors. </summary>
        public IReadOnlyList<FilesNotTieringError> Errors { get; }
    }
}
