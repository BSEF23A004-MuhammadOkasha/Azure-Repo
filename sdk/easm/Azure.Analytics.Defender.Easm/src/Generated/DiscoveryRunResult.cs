// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The latest run of this disco group with some limited information, null if the group has never been run. </summary>
    public partial class DiscoveryRunResult
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

        /// <summary> Initializes a new instance of <see cref="DiscoveryRunResult"/>. </summary>
        internal DiscoveryRunResult()
        {
            Seeds = new ChangeTrackingList<DiscoverySource>();
            Excludes = new ChangeTrackingList<DiscoverySource>();
            Names = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DiscoveryRunResult"/>. </summary>
        /// <param name="submittedDate"> The date for when the disco run was created in the system. </param>
        /// <param name="startedDate"> The date for when the disco run was actually started by the system. </param>
        /// <param name="completedDate"> The date for when the disco run was completed by the system. </param>
        /// <param name="tier"> The tier which will affect the algorithm used for the disco run. </param>
        /// <param name="state"> The State of the disco run. </param>
        /// <param name="totalAssetsFoundCount"> The total count of assets that were found this disco run. </param>
        /// <param name="seeds"> The list of seeds used for the disco run. </param>
        /// <param name="excludes"> The list of excludes used for the disco run, aka assets to exclude from the discovery algorithm. </param>
        /// <param name="names"> The list of names used for the disco run. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiscoveryRunResult(DateTimeOffset? submittedDate, DateTimeOffset? startedDate, DateTimeOffset? completedDate, string tier, DiscoRunState? state, long? totalAssetsFoundCount, IReadOnlyList<DiscoverySource> seeds, IReadOnlyList<DiscoverySource> excludes, IReadOnlyList<string> names, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubmittedDate = submittedDate;
            StartedDate = startedDate;
            CompletedDate = completedDate;
            Tier = tier;
            State = state;
            TotalAssetsFoundCount = totalAssetsFoundCount;
            Seeds = seeds;
            Excludes = excludes;
            Names = names;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The date for when the disco run was created in the system. </summary>
        public DateTimeOffset? SubmittedDate { get; }
        /// <summary> The date for when the disco run was actually started by the system. </summary>
        public DateTimeOffset? StartedDate { get; }
        /// <summary> The date for when the disco run was completed by the system. </summary>
        public DateTimeOffset? CompletedDate { get; }
        /// <summary> The tier which will affect the algorithm used for the disco run. </summary>
        public string Tier { get; }
        /// <summary> The State of the disco run. </summary>
        public DiscoRunState? State { get; }
        /// <summary> The total count of assets that were found this disco run. </summary>
        public long? TotalAssetsFoundCount { get; }
        /// <summary> The list of seeds used for the disco run. </summary>
        public IReadOnlyList<DiscoverySource> Seeds { get; }
        /// <summary> The list of excludes used for the disco run, aka assets to exclude from the discovery algorithm. </summary>
        public IReadOnlyList<DiscoverySource> Excludes { get; }
        /// <summary> The list of names used for the disco run. </summary>
        public IReadOnlyList<string> Names { get; }
    }
}
