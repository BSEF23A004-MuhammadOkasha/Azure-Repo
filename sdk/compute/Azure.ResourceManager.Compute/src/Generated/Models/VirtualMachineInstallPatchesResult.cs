// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The result summary of an installation operation. </summary>
    public partial class VirtualMachineInstallPatchesResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineInstallPatchesResult"/>. </summary>
        internal VirtualMachineInstallPatchesResult()
        {
            Patches = new ChangeTrackingList<PatchInstallationDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineInstallPatchesResult"/>. </summary>
        /// <param name="status"> The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that point it will become "Failed", "Succeeded", "Unknown" or "CompletedWithWarnings.". </param>
        /// <param name="installationActivityId"> The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs. </param>
        /// <param name="rebootStatus"> The reboot state of the VM following completion of the operation. </param>
        /// <param name="maintenanceWindowExceeded"> Whether the operation ran out of time before it completed all its intended actions. </param>
        /// <param name="excludedPatchCount"> The number of patches that were not installed due to the user blocking their installation. </param>
        /// <param name="notSelectedPatchCount"> The number of patches that were detected as available for install, but did not meet the operation's criteria. </param>
        /// <param name="pendingPatchCount"> The number of patches that were identified as meeting the installation criteria, but were not able to be installed. Typically this happens when maintenanceWindowExceeded == true. </param>
        /// <param name="installedPatchCount"> The number of patches successfully installed. </param>
        /// <param name="failedPatchCount"> The number of patches that could not be installed due to some issue. See errors for details. </param>
        /// <param name="patches"> The patches that were installed during the operation. </param>
        /// <param name="startOn"> The UTC timestamp when the operation began. </param>
        /// <param name="error"> The errors that were encountered during execution of the operation. The details array contains the list of them. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineInstallPatchesResult(PatchOperationStatus? status, string installationActivityId, VmGuestPatchRebootStatus? rebootStatus, bool? maintenanceWindowExceeded, int? excludedPatchCount, int? notSelectedPatchCount, int? pendingPatchCount, int? installedPatchCount, int? failedPatchCount, IReadOnlyList<PatchInstallationDetail> patches, DateTimeOffset? startOn, ComputeApiError error, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            InstallationActivityId = installationActivityId;
            RebootStatus = rebootStatus;
            MaintenanceWindowExceeded = maintenanceWindowExceeded;
            ExcludedPatchCount = excludedPatchCount;
            NotSelectedPatchCount = notSelectedPatchCount;
            PendingPatchCount = pendingPatchCount;
            InstalledPatchCount = installedPatchCount;
            FailedPatchCount = failedPatchCount;
            Patches = patches;
            StartOn = startOn;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that point it will become "Failed", "Succeeded", "Unknown" or "CompletedWithWarnings.". </summary>
        public PatchOperationStatus? Status { get; }
        /// <summary> The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs. </summary>
        public string InstallationActivityId { get; }
        /// <summary> The reboot state of the VM following completion of the operation. </summary>
        public VmGuestPatchRebootStatus? RebootStatus { get; }
        /// <summary> Whether the operation ran out of time before it completed all its intended actions. </summary>
        public bool? MaintenanceWindowExceeded { get; }
        /// <summary> The number of patches that were not installed due to the user blocking their installation. </summary>
        public int? ExcludedPatchCount { get; }
        /// <summary> The number of patches that were detected as available for install, but did not meet the operation's criteria. </summary>
        public int? NotSelectedPatchCount { get; }
        /// <summary> The number of patches that were identified as meeting the installation criteria, but were not able to be installed. Typically this happens when maintenanceWindowExceeded == true. </summary>
        public int? PendingPatchCount { get; }
        /// <summary> The number of patches successfully installed. </summary>
        public int? InstalledPatchCount { get; }
        /// <summary> The number of patches that could not be installed due to some issue. See errors for details. </summary>
        public int? FailedPatchCount { get; }
        /// <summary> The patches that were installed during the operation. </summary>
        public IReadOnlyList<PatchInstallationDetail> Patches { get; }
        /// <summary> The UTC timestamp when the operation began. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The errors that were encountered during execution of the operation. The details array contains the list of them. </summary>
        public ComputeApiError Error { get; }
    }
}
