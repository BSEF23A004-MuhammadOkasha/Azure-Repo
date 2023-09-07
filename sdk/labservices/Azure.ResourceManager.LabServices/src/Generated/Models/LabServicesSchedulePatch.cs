// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Schedule for automatically turning virtual machines in a lab on and off at specified times. Used for updates. </summary>
    public partial class LabServicesSchedulePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LabServicesSchedulePatch"/>. </summary>
        public LabServicesSchedulePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LabServicesSchedulePatch"/>. </summary>
        /// <param name="startOn"> When lab user virtual machines will be started. Timestamp offsets will be ignored and timeZoneId is used instead. </param>
        /// <param name="stopOn"> When lab user virtual machines will be stopped. Timestamp offsets will be ignored and timeZoneId is used instead. </param>
        /// <param name="recurrencePattern"> The recurrence pattern of the scheduled actions. </param>
        /// <param name="timeZoneId"> The IANA timezone id for the schedule. </param>
        /// <param name="notes"> Notes for this schedule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LabServicesSchedulePatch(DateTimeOffset? startOn, DateTimeOffset? stopOn, LabServicesRecurrencePattern recurrencePattern, string timeZoneId, BinaryData notes, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartOn = startOn;
            StopOn = stopOn;
            RecurrencePattern = recurrencePattern;
            TimeZoneId = timeZoneId;
            Notes = notes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> When lab user virtual machines will be started. Timestamp offsets will be ignored and timeZoneId is used instead. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> When lab user virtual machines will be stopped. Timestamp offsets will be ignored and timeZoneId is used instead. </summary>
        public DateTimeOffset? StopOn { get; set; }
        /// <summary> The recurrence pattern of the scheduled actions. </summary>
        public LabServicesRecurrencePattern RecurrencePattern { get; set; }
        /// <summary> The IANA timezone id for the schedule. </summary>
        public string TimeZoneId { get; set; }
        /// <summary>
        /// Notes for this schedule.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Notes { get; set; }
    }
}
