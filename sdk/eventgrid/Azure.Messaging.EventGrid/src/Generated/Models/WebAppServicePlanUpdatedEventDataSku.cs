// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> sku of app service plan. </summary>
    public partial class WebAppServicePlanUpdatedEventDataSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebAppServicePlanUpdatedEventDataSku"/>. </summary>
        internal WebAppServicePlanUpdatedEventDataSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WebAppServicePlanUpdatedEventDataSku"/>. </summary>
        /// <param name="name"> name of app service plan sku. </param>
        /// <param name="tier"> tier of app service plan sku. </param>
        /// <param name="size"> size of app service plan sku. </param>
        /// <param name="family"> family of app service plan sku. </param>
        /// <param name="capacity"> capacity of app service plan sku. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAppServicePlanUpdatedEventDataSku(string name, string tier, string size, string family, string capacity, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
            _rawData = rawData;
        }

        /// <summary> name of app service plan sku. </summary>
        public string Name { get; }
        /// <summary> tier of app service plan sku. </summary>
        public string Tier { get; }
        /// <summary> size of app service plan sku. </summary>
        public string Size { get; }
        /// <summary> family of app service plan sku. </summary>
        public string Family { get; }
        /// <summary> capacity of app service plan sku. </summary>
        public string Capacity { get; }
    }
}
