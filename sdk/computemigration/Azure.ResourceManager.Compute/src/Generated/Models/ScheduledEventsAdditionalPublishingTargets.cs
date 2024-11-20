// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The ScheduledEventsAdditionalPublishingTargets. </summary>
    internal partial class ScheduledEventsAdditionalPublishingTargets
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

        /// <summary> Initializes a new instance of <see cref="ScheduledEventsAdditionalPublishingTargets"/>. </summary>
        public ScheduledEventsAdditionalPublishingTargets()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScheduledEventsAdditionalPublishingTargets"/>. </summary>
        /// <param name="eventGridAndResourceGraph"> The configuration parameters used while creating eventGridAndResourceGraph Scheduled Event setting. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScheduledEventsAdditionalPublishingTargets(EventGridAndResourceGraph eventGridAndResourceGraph, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EventGridAndResourceGraph = eventGridAndResourceGraph;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The configuration parameters used while creating eventGridAndResourceGraph Scheduled Event setting. </summary>
        internal EventGridAndResourceGraph EventGridAndResourceGraph { get; set; }
        /// <summary> Specifies if event grid and resource graph is enabled for Scheduled event related configurations. </summary>
        public bool? Enable
        {
            get => EventGridAndResourceGraph is null ? default : EventGridAndResourceGraph.Enable;
            set
            {
                if (EventGridAndResourceGraph is null)
                    EventGridAndResourceGraph = new EventGridAndResourceGraph();
                EventGridAndResourceGraph.Enable = value;
            }
        }
    }
}
