// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Enables IIS logs to be collected by this data collection rule. </summary>
    public partial class IisLogsDataSource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IisLogsDataSource"/>. </summary>
        /// <param name="streams"> IIS streams. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="streams"/> is null. </exception>
        public IisLogsDataSource(IEnumerable<string> streams)
        {
            Argument.AssertNotNull(streams, nameof(streams));

            Streams = streams.ToList();
            LogDirectories = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="IisLogsDataSource"/>. </summary>
        /// <param name="streams"> IIS streams. </param>
        /// <param name="logDirectories"> Absolute paths file location. </param>
        /// <param name="name">
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IisLogsDataSource(IList<string> streams, IList<string> logDirectories, string name, Dictionary<string, BinaryData> rawData)
        {
            Streams = streams;
            LogDirectories = logDirectories;
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="IisLogsDataSource"/> for deserialization. </summary>
        internal IisLogsDataSource()
        {
        }

        /// <summary> IIS streams. </summary>
        public IList<string> Streams { get; }
        /// <summary> Absolute paths file location. </summary>
        public IList<string> LogDirectories { get; }
        /// <summary>
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
