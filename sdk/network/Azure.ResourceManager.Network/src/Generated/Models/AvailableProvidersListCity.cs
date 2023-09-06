// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> City or town details. </summary>
    public partial class AvailableProvidersListCity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AvailableProvidersListCity"/>. </summary>
        internal AvailableProvidersListCity()
        {
            Providers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableProvidersListCity"/>. </summary>
        /// <param name="cityName"> The city or town name. </param>
        /// <param name="providers"> A list of Internet service providers. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableProvidersListCity(string cityName, IReadOnlyList<string> providers, Dictionary<string, BinaryData> rawData)
        {
            CityName = cityName;
            Providers = providers;
            _rawData = rawData;
        }

        /// <summary> The city or town name. </summary>
        public string CityName { get; }
        /// <summary> A list of Internet service providers. </summary>
        public IReadOnlyList<string> Providers { get; }
    }
}
