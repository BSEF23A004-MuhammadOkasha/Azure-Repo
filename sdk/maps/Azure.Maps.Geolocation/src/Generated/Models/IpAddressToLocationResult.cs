// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Geolocation.Models
{
    /// <summary> This object is returned from a successful call to IP Address to country/region API. </summary>
    public partial class IpAddressToLocationResult
    {
        /// <summary> Initializes a new instance of IpAddressToLocationResult. </summary>
        internal IpAddressToLocationResult()
        {
        }

        /// <summary> Initializes a new instance of IpAddressToLocationResult. </summary>
        /// <param name="countryRegion"> The object containing the country/region information. </param>
        /// <param name="ipAddress"> The IP Address of the request. </param>
        internal IpAddressToLocationResult(CountryRegion countryRegion, string ipAddress)
        {
            CountryRegion = countryRegion;
            IpAddress = ipAddress;
        }

        /// <summary> The object containing the country/region information. </summary>
        public CountryRegion CountryRegion { get; }
        /// <summary> The IP Address of the request. </summary>
        public string IpAddress { get; }
    }
}
