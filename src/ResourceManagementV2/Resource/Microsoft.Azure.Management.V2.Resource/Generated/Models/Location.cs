// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System.Linq;

    /// <summary>
    /// Location information.
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        public Location() { }

        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        /// <param name="id">Gets or sets the ID of the resource
        /// (/subscriptions/SubscriptionId).</param>
        /// <param name="subscriptionId">Gets or sets the subscription
        /// Id.</param>
        /// <param name="name">Gets or sets the location name</param>
        /// <param name="displayName">Gets or sets the display name of the
        /// location</param>
        /// <param name="latitude">Gets or sets the latitude of the
        /// location</param>
        /// <param name="longitude">Gets or sets the longitude of the
        /// location</param>
        public Location(string id = default(string), string subscriptionId = default(string), string name = default(string), string displayName = default(string), string latitude = default(string), string longitude = default(string))
        {
            Id = id;
            SubscriptionId = subscriptionId;
            Name = name;
            DisplayName = displayName;
            Latitude = latitude;
            Longitude = longitude;
        }

        /// <summary>
        /// Gets or sets the ID of the resource
        /// (/subscriptions/SubscriptionId).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the subscription Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the location name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name of the location
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the latitude of the location
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude of the location
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; set; }

    }
}
