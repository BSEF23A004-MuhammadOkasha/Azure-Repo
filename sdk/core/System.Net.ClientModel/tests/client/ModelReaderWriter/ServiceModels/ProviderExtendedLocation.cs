// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net.ClientModel.Internal;

namespace System.Net.ClientModel.Tests.Client.Models.ResourceManager.Resources
{
    /// <summary> The provider extended location. </summary>
    public partial class ProviderExtendedLocation
    {
        /// <summary> Initializes a new instance of ProviderExtendedLocation. </summary>
        internal ProviderExtendedLocation()
        {
            ExtendedLocations = new OptionalList<string>();
        }

        /// <summary> Initializes a new instance of ProviderExtendedLocation. </summary>
        /// <param name="location"> The azure location. </param>
        /// <param name="providerExtendedLocationType"> The extended location type. </param>
        /// <param name="extendedLocations"> The extended locations for the azure location. </param>
        internal ProviderExtendedLocation(string location, string providerExtendedLocationType, IReadOnlyList<string> extendedLocations)
        {
            Location = location;
            ProviderExtendedLocationType = providerExtendedLocationType;
            ExtendedLocations = extendedLocations;
        }

        /// <summary> The azure location. </summary>
        public string Location { get; }
        /// <summary> The extended location type. </summary>
        public string ProviderExtendedLocationType { get; }
        /// <summary> The extended locations for the azure location. </summary>
        public IReadOnlyList<string> ExtendedLocations { get; }
    }
}
