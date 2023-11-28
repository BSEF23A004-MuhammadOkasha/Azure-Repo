// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Policy Info in backupInstance. </summary>
    public partial class BackupInstancePolicyInfo
    {
        /// <summary> Initializes a new instance of <see cref="BackupInstancePolicyInfo"/>. </summary>
        /// <param name="policyId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyId"/> is null. </exception>
        public BackupInstancePolicyInfo(ResourceIdentifier policyId)
        {
            Argument.AssertNotNull(policyId, nameof(policyId));

            PolicyId = policyId;
        }

        /// <summary> Initializes a new instance of <see cref="BackupInstancePolicyInfo"/>. </summary>
        /// <param name="policyId"></param>
        /// <param name="policyVersion"></param>
        /// <param name="policyParameters"> Policy parameters for the backup instance. </param>
        internal BackupInstancePolicyInfo(ResourceIdentifier policyId, string policyVersion, BackupInstancePolicySettings policyParameters)
        {
            PolicyId = policyId;
            PolicyVersion = policyVersion;
            PolicyParameters = policyParameters;
        }

        /// <summary> Gets or sets the policy id. </summary>
        public ResourceIdentifier PolicyId { get; set; }
        /// <summary> Gets the policy version. </summary>
        public string PolicyVersion { get; }
        /// <summary> Policy parameters for the backup instance. </summary>
        public BackupInstancePolicySettings PolicyParameters { get; set; }
    }
}
