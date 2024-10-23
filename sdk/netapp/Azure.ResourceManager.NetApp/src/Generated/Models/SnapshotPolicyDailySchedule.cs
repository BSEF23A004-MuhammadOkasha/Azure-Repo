// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// Daily Schedule properties
    /// Serialized Name: DailySchedule
    /// </summary>
    public partial class SnapshotPolicyDailySchedule
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyDailySchedule"/>. </summary>
        public SnapshotPolicyDailySchedule()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyDailySchedule"/>. </summary>
        /// <param name="snapshotsToKeep">
        /// Daily snapshot count to keep
        /// Serialized Name: DailySchedule.snapshotsToKeep
        /// </param>
        /// <param name="hour">
        /// Indicates which hour in UTC timezone a snapshot should be taken
        /// Serialized Name: DailySchedule.hour
        /// </param>
        /// <param name="minute">
        /// Indicates which minute snapshot should be taken
        /// Serialized Name: DailySchedule.minute
        /// </param>
        /// <param name="usedBytes">
        /// Resource size in bytes, current storage usage for the volume in bytes
        /// Serialized Name: DailySchedule.usedBytes
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotPolicyDailySchedule(int? snapshotsToKeep, int? hour, int? minute, long? usedBytes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SnapshotsToKeep = snapshotsToKeep;
            Hour = hour;
            Minute = minute;
            UsedBytes = usedBytes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Daily snapshot count to keep
        /// Serialized Name: DailySchedule.snapshotsToKeep
        /// </summary>
        public int? SnapshotsToKeep { get; set; }
        /// <summary>
        /// Indicates which hour in UTC timezone a snapshot should be taken
        /// Serialized Name: DailySchedule.hour
        /// </summary>
        public int? Hour { get; set; }
        /// <summary>
        /// Indicates which minute snapshot should be taken
        /// Serialized Name: DailySchedule.minute
        /// </summary>
        public int? Minute { get; set; }
        /// <summary>
        /// Resource size in bytes, current storage usage for the volume in bytes
        /// Serialized Name: DailySchedule.usedBytes
        /// </summary>
        public long? UsedBytes { get; set; }
    }
}
