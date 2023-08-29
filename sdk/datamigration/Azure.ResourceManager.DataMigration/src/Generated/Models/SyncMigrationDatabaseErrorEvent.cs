// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Database migration errors for online migration. </summary>
    public partial class SyncMigrationDatabaseErrorEvent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SyncMigrationDatabaseErrorEvent"/>. </summary>
        internal SyncMigrationDatabaseErrorEvent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SyncMigrationDatabaseErrorEvent"/>. </summary>
        /// <param name="timestampString"> String value of timestamp. </param>
        /// <param name="eventTypeString"> Event type. </param>
        /// <param name="eventText"> Event text. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SyncMigrationDatabaseErrorEvent(string timestampString, string eventTypeString, string eventText, Dictionary<string, BinaryData> rawData)
        {
            TimestampString = timestampString;
            EventTypeString = eventTypeString;
            EventText = eventText;
            _rawData = rawData;
        }

        /// <summary> String value of timestamp. </summary>
        public string TimestampString { get; }
        /// <summary> Event type. </summary>
        public string EventTypeString { get; }
        /// <summary> Event text. </summary>
        public string EventText { get; }
    }
}
