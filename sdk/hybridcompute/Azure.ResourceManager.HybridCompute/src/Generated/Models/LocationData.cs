// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Metadata pertaining to the geographic location of the resource. </summary>
    public partial class LocationData
    {
        /// <summary> Initializes a new instance of LocationData. </summary>
        /// <param name="name"> A canonical name for the geographic or physical location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public LocationData(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of LocationData. </summary>
        /// <param name="name"> A canonical name for the geographic or physical location. </param>
        /// <param name="city"> The city or locality where the resource is located. </param>
        /// <param name="district"> The district, state, or province where the resource is located. </param>
        /// <param name="countryOrRegion"> The country or region where the resource is located. </param>
        internal LocationData(string name, string city, string district, string countryOrRegion)
        {
            Name = name;
            City = city;
            District = district;
            CountryOrRegion = countryOrRegion;
        }

        /// <summary> A canonical name for the geographic or physical location. </summary>
        public string Name { get; set; }
        /// <summary> The city or locality where the resource is located. </summary>
        public string City { get; set; }
        /// <summary> The district, state, or province where the resource is located. </summary>
        public string District { get; set; }
        /// <summary> The country or region where the resource is located. </summary>
        public string CountryOrRegion { get; set; }
    }
}
