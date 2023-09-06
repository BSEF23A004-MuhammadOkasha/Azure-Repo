// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Server gtid set parameters. </summary>
    public partial class MySqlFlexibleServerGtidSetContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerGtidSetContent"/>. </summary>
        public MySqlFlexibleServerGtidSetContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerGtidSetContent"/>. </summary>
        /// <param name="gtidSet"> The gtid set of server. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerGtidSetContent(string gtidSet, Dictionary<string, BinaryData> rawData)
        {
            GtidSet = gtidSet;
            _rawData = rawData;
        }

        /// <summary> The gtid set of server. </summary>
        public string GtidSet { get; set; }
    }
}
