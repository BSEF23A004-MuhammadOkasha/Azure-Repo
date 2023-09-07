// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.Maps.Geolocation
{
    /// <summary> This object is returned from a successful call to IP Address to country/region API. </summary>
    public partial class CountryRegionResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CountryRegionResult"/>. </summary>
        /// <param name="countryRegion"> The object containing the country/region information. </param>
        /// <param name="ipAddress"> The IP Address of the request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CountryRegionResult(CountryRegion countryRegion, IPAddress ipAddress, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CountryRegion = countryRegion;
            IpAddress = ipAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
