// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ManagedDatabaseRestoreDetailsResult data model. </summary>
    public partial class ManagedDatabaseRestoreDetailsResultData : Resource
    {
        /// <summary> Initializes a new instance of ManagedDatabaseRestoreDetailsResultData. </summary>
        public ManagedDatabaseRestoreDetailsResultData()
        {
            UnrestorableFiles = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ManagedDatabaseRestoreDetailsResultData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> Restore status. </param>
        /// <param name="currentRestoringFileName"> Current restoring file name. </param>
        /// <param name="lastRestoredFileName"> Last restored file name. </param>
        /// <param name="lastRestoredFileTime"> Last restored file time. </param>
        /// <param name="percentCompleted"> Percent completed. </param>
        /// <param name="unrestorableFiles"> List of unrestorable files. </param>
        /// <param name="numberOfFilesDetected"> Number of files detected. </param>
        /// <param name="lastUploadedFileName"> Last uploaded file name. </param>
        /// <param name="lastUploadedFileTime"> Last uploaded file time. </param>
        /// <param name="blockReason"> The reason why restore is in Blocked state. </param>
        internal ManagedDatabaseRestoreDetailsResultData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string status, string currentRestoringFileName, string lastRestoredFileName, DateTimeOffset? lastRestoredFileTime, double? percentCompleted, IReadOnlyList<string> unrestorableFiles, long? numberOfFilesDetected, string lastUploadedFileName, DateTimeOffset? lastUploadedFileTime, string blockReason) : base(id, name, type, systemData)
        {
            Status = status;
            CurrentRestoringFileName = currentRestoringFileName;
            LastRestoredFileName = lastRestoredFileName;
            LastRestoredFileTime = lastRestoredFileTime;
            PercentCompleted = percentCompleted;
            UnrestorableFiles = unrestorableFiles;
            NumberOfFilesDetected = numberOfFilesDetected;
            LastUploadedFileName = lastUploadedFileName;
            LastUploadedFileTime = lastUploadedFileTime;
            BlockReason = blockReason;
        }

        /// <summary> Restore status. </summary>
        public string Status { get; }
        /// <summary> Current restoring file name. </summary>
        public string CurrentRestoringFileName { get; }
        /// <summary> Last restored file name. </summary>
        public string LastRestoredFileName { get; }
        /// <summary> Last restored file time. </summary>
        public DateTimeOffset? LastRestoredFileTime { get; }
        /// <summary> Percent completed. </summary>
        public double? PercentCompleted { get; }
        /// <summary> List of unrestorable files. </summary>
        public IReadOnlyList<string> UnrestorableFiles { get; }
        /// <summary> Number of files detected. </summary>
        public long? NumberOfFilesDetected { get; }
        /// <summary> Last uploaded file name. </summary>
        public string LastUploadedFileName { get; }
        /// <summary> Last uploaded file time. </summary>
        public DateTimeOffset? LastUploadedFileTime { get; }
        /// <summary> The reason why restore is in Blocked state. </summary>
        public string BlockReason { get; }
    }
}
