// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schedule info of the role assignment schedule
    /// </summary>
    public partial class RoleAssignmentScheduleRequestPropertiesScheduleInfo
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RoleAssignmentScheduleRequestPropertiesScheduleInfo class.
        /// </summary>
        public RoleAssignmentScheduleRequestPropertiesScheduleInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RoleAssignmentScheduleRequestPropertiesScheduleInfo class.
        /// </summary>
        /// <param name="startDateTime">Start DateTime of the role assignment
        /// schedule.</param>
        /// <param name="expiration">Expiration of the role assignment
        /// schedule</param>
        public RoleAssignmentScheduleRequestPropertiesScheduleInfo(System.DateTime? startDateTime = default(System.DateTime?), RoleAssignmentScheduleRequestPropertiesScheduleInfoExpiration expiration = default(RoleAssignmentScheduleRequestPropertiesScheduleInfoExpiration))
        {
            StartDateTime = startDateTime;
            Expiration = expiration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets start DateTime of the role assignment schedule.
        /// </summary>
        [JsonProperty(PropertyName = "startDateTime")]
        public System.DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets expiration of the role assignment schedule
        /// </summary>
        [JsonProperty(PropertyName = "expiration")]
        public RoleAssignmentScheduleRequestPropertiesScheduleInfoExpiration Expiration { get; set; }

    }
}
