// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of the last installed patch summary. </summary>
    public partial class LastPatchInstallationSummary
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LastPatchInstallationSummary"/>. </summary>
        internal LastPatchInstallationSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LastPatchInstallationSummary"/>. </summary>
        /// <param name="status"> The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that point it will become "Unknown", "Failed", "Succeeded", or "CompletedWithWarnings.". </param>
        /// <param name="installationActivityId"> The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs. </param>
        /// <param name="maintenanceWindowExceeded"> Describes whether the operation ran out of time before it completed all its intended actions. </param>
        /// <param name="notSelectedPatchCount"> The number of all available patches but not going to be installed because it didn't match a classification or inclusion list entry. </param>
        /// <param name="excludedPatchCount"> The number of all available patches but excluded explicitly by a customer-specified exclusion list match. </param>
        /// <param name="pendingPatchCount"> The number of all available patches expected to be installed over the course of the patch installation operation. </param>
        /// <param name="installedPatchCount"> The count of patches that successfully installed. </param>
        /// <param name="failedPatchCount"> The count of patches that failed installation. </param>
        /// <param name="startOn"> The UTC timestamp when the operation began. </param>
        /// <param name="lastModifiedOn"> The UTC timestamp when the operation began. </param>
        /// <param name="error"> The errors that were encountered during execution of the operation. The details array contains the list of them. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LastPatchInstallationSummary(PatchOperationStatus? status, string installationActivityId, bool? maintenanceWindowExceeded, int? notSelectedPatchCount, int? excludedPatchCount, int? pendingPatchCount, int? installedPatchCount, int? failedPatchCount, DateTimeOffset? startOn, DateTimeOffset? lastModifiedOn, ComputeApiError error, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            InstallationActivityId = installationActivityId;
            MaintenanceWindowExceeded = maintenanceWindowExceeded;
            NotSelectedPatchCount = notSelectedPatchCount;
            ExcludedPatchCount = excludedPatchCount;
            PendingPatchCount = pendingPatchCount;
            InstalledPatchCount = installedPatchCount;
            FailedPatchCount = failedPatchCount;
            StartOn = startOn;
            LastModifiedOn = lastModifiedOn;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that point it will become "Unknown", "Failed", "Succeeded", or "CompletedWithWarnings.". </summary>
        public PatchOperationStatus? Status { get; }
        /// <summary> The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs. </summary>
        public string InstallationActivityId { get; }
        /// <summary> Describes whether the operation ran out of time before it completed all its intended actions. </summary>
        public bool? MaintenanceWindowExceeded { get; }
        /// <summary> The number of all available patches but not going to be installed because it didn't match a classification or inclusion list entry. </summary>
        public int? NotSelectedPatchCount { get; }
        /// <summary> The number of all available patches but excluded explicitly by a customer-specified exclusion list match. </summary>
        public int? ExcludedPatchCount { get; }
        /// <summary> The number of all available patches expected to be installed over the course of the patch installation operation. </summary>
        public int? PendingPatchCount { get; }
        /// <summary> The count of patches that successfully installed. </summary>
        public int? InstalledPatchCount { get; }
        /// <summary> The count of patches that failed installation. </summary>
        public int? FailedPatchCount { get; }
        /// <summary> The UTC timestamp when the operation began. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The UTC timestamp when the operation began. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The errors that were encountered during execution of the operation. The details array contains the list of them. </summary>
        public ComputeApiError Error { get; }
    }
}
