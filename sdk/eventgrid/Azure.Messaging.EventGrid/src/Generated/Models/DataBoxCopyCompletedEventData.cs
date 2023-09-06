// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.DataBox.CopyCompleted event. </summary>
    public partial class DataBoxCopyCompletedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxCopyCompletedEventData"/>. </summary>
        internal DataBoxCopyCompletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxCopyCompletedEventData"/>. </summary>
        /// <param name="serialNumber"> Serial Number of the device associated with the event. The list is comma separated if more than one serial number is associated. </param>
        /// <param name="stageName"> Name of the current Stage. </param>
        /// <param name="stageTime"> The time at which the stage happened. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxCopyCompletedEventData(string serialNumber, DataBoxStageName? stageName, DateTimeOffset? stageTime, Dictionary<string, BinaryData> rawData)
        {
            SerialNumber = serialNumber;
            StageName = stageName;
            StageTime = stageTime;
            _rawData = rawData;
        }

        /// <summary> Serial Number of the device associated with the event. The list is comma separated if more than one serial number is associated. </summary>
        public string SerialNumber { get; }
        /// <summary> Name of the current Stage. </summary>
        public DataBoxStageName? StageName { get; }
        /// <summary> The time at which the stage happened. </summary>
        public DateTimeOffset? StageTime { get; }
    }
}
