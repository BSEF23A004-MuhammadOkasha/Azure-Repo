// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.StorageCache;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> An indication of cache health. Gives more information about health than just that related to provisioning. </summary>
    public partial class StorageCacheHealth
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

        /// <summary> Initializes a new instance of <see cref="StorageCacheHealth"/>. </summary>
        internal StorageCacheHealth()
        {
            Conditions = new ChangeTrackingList<OutstandingCondition>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheHealth"/>. </summary>
        /// <param name="state"> List of cache health states. Down is when the cluster is not responding.  Degraded is when its functioning but has some alerts. Transitioning when it is creating or deleting. Unknown will be returned in old api versions when a new value is added in future versions. WaitingForKey is when the create is waiting for the system assigned identity to be given access to the encryption key in the encryption settings. </param>
        /// <param name="statusDescription"> Describes explanation of state. </param>
        /// <param name="conditions"> Outstanding conditions that need to be investigated and resolved. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCacheHealth(StorageCacheHealthStateType? state, string statusDescription, IReadOnlyList<OutstandingCondition> conditions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            State = state;
            StatusDescription = statusDescription;
            Conditions = conditions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of cache health states. Down is when the cluster is not responding.  Degraded is when its functioning but has some alerts. Transitioning when it is creating or deleting. Unknown will be returned in old api versions when a new value is added in future versions. WaitingForKey is when the create is waiting for the system assigned identity to be given access to the encryption key in the encryption settings. </summary>
        public StorageCacheHealthStateType? State { get; }
        /// <summary> Describes explanation of state. </summary>
        public string StatusDescription { get; }
        /// <summary> Outstanding conditions that need to be investigated and resolved. </summary>
        public IReadOnlyList<OutstandingCondition> Conditions { get; }
    }
}
