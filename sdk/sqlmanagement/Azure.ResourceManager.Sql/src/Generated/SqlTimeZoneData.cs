// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the SqlTimeZone data model. </summary>
    public partial class SqlTimeZoneData : Resource
    {
        /// <summary> Initializes a new instance of SqlTimeZoneData. </summary>
        public SqlTimeZoneData()
        {
        }

        /// <summary> Initializes a new instance of SqlTimeZoneData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="timeZoneId"> The time zone id. </param>
        /// <param name="displayName"> The time zone display name. </param>
        internal SqlTimeZoneData(ResourceIdentifier id, string name, ResourceType type, string timeZoneId, string displayName) : base(id, name, type)
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
