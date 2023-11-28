// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> A class that describes the PATCH request parameters of a Domains resource. </summary>
    public partial class CommunicationDomainResourcePatch : CommunicationAcceptTags
    {
        /// <summary> Initializes a new instance of <see cref="CommunicationDomainResourcePatch"/>. </summary>
        public CommunicationDomainResourcePatch()
        {
        }

        /// <summary> Describes whether user engagement tracking is enabled or disabled. </summary>
        public UserEngagementTracking? UserEngagementTracking { get; set; }
    }
}
