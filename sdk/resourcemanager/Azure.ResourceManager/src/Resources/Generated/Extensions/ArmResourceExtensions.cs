// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class to add extension methods to ArmResource. </summary>
    public static partial class ArmResourceExtensions
    {
        #region PolicyAssignment
        /// <summary> Gets an object representing a PolicyAssignmentCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="PolicyAssignmentCollection" /> object. </returns>
        public static PolicyAssignmentCollection GetPolicyAssignments(this ArmResource armResource)
        {
            return new PolicyAssignmentCollection(armResource);
        }
        #endregion

        #region PolicyExemption
        /// <summary> Gets an object representing a PolicyExemptionCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="PolicyExemptionCollection" /> object. </returns>
        public static PolicyExemptionCollection GetPolicyExemptions(this ArmResource armResource)
        {
            return new PolicyExemptionCollection(armResource);
        }
        #endregion

        #region ManagementLockObject
        /// <summary> Gets an object representing a ManagementLockObjectCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ManagementLockObjectCollection" /> object. </returns>
        public static ManagementLockObjectCollection GetManagementLockObjects(this ArmResource armResource)
        {
            return new ManagementLockObjectCollection(armResource);
        }
        #endregion
    }
}
