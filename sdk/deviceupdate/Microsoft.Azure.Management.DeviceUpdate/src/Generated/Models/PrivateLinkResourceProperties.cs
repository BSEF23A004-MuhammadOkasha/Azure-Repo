// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeviceUpdate.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of a private link resource.
    /// </summary>
    public partial class PrivateLinkResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkResourceProperties
        /// class.
        /// </summary>
        public PrivateLinkResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkResourceProperties
        /// class.
        /// </summary>
        /// <param name="groupId">The private link resource group id.</param>
        /// <param name="requiredMembers">The private link resource required
        /// member names.</param>
        /// <param name="requiredZoneNames">The private link resource Private
        /// link DNS zone name.</param>
        public PrivateLinkResourceProperties(string groupId = default(string), IList<string> requiredMembers = default(IList<string>), IList<string> requiredZoneNames = default(IList<string>))
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the private link resource group id.
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; private set; }

        /// <summary>
        /// Gets the private link resource required member names.
        /// </summary>
        [JsonProperty(PropertyName = "requiredMembers")]
        public IList<string> RequiredMembers { get; private set; }

        /// <summary>
        /// Gets or sets the private link resource Private link DNS zone name.
        /// </summary>
        [JsonProperty(PropertyName = "requiredZoneNames")]
        public IList<string> RequiredZoneNames { get; set; }

    }
}
