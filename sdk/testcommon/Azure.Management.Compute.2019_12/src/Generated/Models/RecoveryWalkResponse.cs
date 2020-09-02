// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> Response after calling a manual recovery walk. </summary>
    public partial class RecoveryWalkResponse
    {
        /// <summary> Initializes a new instance of RecoveryWalkResponse. </summary>
        internal RecoveryWalkResponse()
        {
        }

        /// <summary> Initializes a new instance of RecoveryWalkResponse. </summary>
        /// <param name="walkPerformed"> Whether the recovery walk was performed. </param>
        /// <param name="nextPlatformUpdateDomain"> The next update domain that needs to be walked. Null means walk spanning all update domains has been completed. </param>
        internal RecoveryWalkResponse(bool? walkPerformed, int? nextPlatformUpdateDomain)
        {
            WalkPerformed = walkPerformed;
            NextPlatformUpdateDomain = nextPlatformUpdateDomain;
        }

        /// <summary> Whether the recovery walk was performed. </summary>
        public bool? WalkPerformed { get; }
        /// <summary> The next update domain that needs to be walked. Null means walk spanning all update domains has been completed. </summary>
        public int? NextPlatformUpdateDomain { get; }
    }
}
