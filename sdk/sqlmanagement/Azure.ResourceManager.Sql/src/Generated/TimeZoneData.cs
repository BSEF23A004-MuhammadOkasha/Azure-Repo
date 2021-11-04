// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the TimeZone data model. </summary>
    public partial class TimeZoneData : Resource
    {
        /// <summary> Initializes a new instance of TimeZoneData. </summary>
        public TimeZoneData()
        {
        }

        /// <summary> Initializes a new instance of TimeZoneData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="timeZoneId"> The time zone id. </param>
        /// <param name="displayName"> The time zone display name. </param>
        internal TimeZoneData(ResourceIdentifier id, string name, ResourceType type, string timeZoneId, string displayName) : base(id, name, type)
        {
            TimeZoneId = timeZoneId;
            DisplayName = displayName;
        }

        /// <summary> The time zone id. </summary>
        public string TimeZoneId { get; }
        /// <summary> The time zone display name. </summary>
        public string DisplayName { get; }
    }
}
