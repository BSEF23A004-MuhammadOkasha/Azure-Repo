// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.DigitalTwins.Core
{
    /// <summary> Parameter group. </summary>
    internal partial class GetDigitalTwinsEventRouteOptions
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GetDigitalTwinsEventRouteOptions"/>. </summary>
        public GetDigitalTwinsEventRouteOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GetDigitalTwinsEventRouteOptions"/>. </summary>
        /// <param name="traceParent"> Identifies the request in a distributed tracing system. </param>
        /// <param name="traceState"> Provides vendor-specific trace identification information and is a companion to traceparent. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GetDigitalTwinsEventRouteOptions(string traceParent, string traceState, Dictionary<string, BinaryData> rawData)
        {
            TraceParent = traceParent;
            TraceState = traceState;
            _rawData = rawData;
        }
    }
}
