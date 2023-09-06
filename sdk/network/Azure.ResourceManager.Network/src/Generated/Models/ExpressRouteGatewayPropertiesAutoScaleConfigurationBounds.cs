// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Minimum and maximum number of scale units to deploy. </summary>
    public partial class ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds"/>. </summary>
        public ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds"/>. </summary>
        /// <param name="min"> Minimum number of scale units deployed for ExpressRoute gateway. </param>
        /// <param name="max"> Maximum number of scale units deployed for ExpressRoute gateway. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds(int? min, int? max, Dictionary<string, BinaryData> rawData)
        {
            Min = min;
            Max = max;
            _rawData = rawData;
        }

        /// <summary> Minimum number of scale units deployed for ExpressRoute gateway. </summary>
        public int? Min { get; set; }
        /// <summary> Maximum number of scale units deployed for ExpressRoute gateway. </summary>
        public int? Max { get; set; }
    }
}
