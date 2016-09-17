// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Models
{
    using System.Linq;

    /// <summary>
    /// Request parameters for GetMemberGroups API call
    /// </summary>
    public partial class GroupGetMemberGroupsParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GroupGetMemberGroupsParametersInner class.
        /// </summary>
        public GroupGetMemberGroupsParametersInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// GroupGetMemberGroupsParametersInner class.
        /// </summary>
        /// <param name="securityEnabledOnly">If true only membership in
        /// security enabled groups should be checked. Otherwise membership
        /// in all groups should be checked </param>
        public GroupGetMemberGroupsParametersInner(bool securityEnabledOnly)
        {
            SecurityEnabledOnly = securityEnabledOnly;
        }

        /// <summary>
        /// Gets or sets if true only membership in security enabled groups
        /// should be checked. Otherwise membership in all groups should be
        /// checked
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "securityEnabledOnly")]
        public bool SecurityEnabledOnly { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
