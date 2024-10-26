// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Models
{
    /// <summary> The model for updating storageClass properties. </summary>
    public partial class StorageClassPropertiesUpdate
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

        /// <summary> Initializes a new instance of <see cref="StorageClassPropertiesUpdate"/>. </summary>
        public StorageClassPropertiesUpdate()
        {
            MountOptions = new ChangeTrackingList<string>();
            AccessModes = new ChangeTrackingList<StorageClassAccessMode>();
            Limitations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageClassPropertiesUpdate"/>. </summary>
        /// <param name="allowVolumeExpansion"> Volume can be expanded or not. </param>
        /// <param name="mountOptions"> Additional mount options. </param>
        /// <param name="accessModes"> The access mode: [ReadWriteOnce, ReadWriteMany] or [ReadWriteOnce]. </param>
        /// <param name="dataResilience"> Allow single data node failure. </param>
        /// <param name="failoverSpeed"> Failover speed: NA, Slow, Fast. </param>
        /// <param name="limitations"> Limitations of the storage class. </param>
        /// <param name="performance"> Performance tier. </param>
        /// <param name="priority"> Selection priority when multiple storage classes meet the criteria. 0: Highest, -1: Never use. </param>
        /// <param name="typeProperties"> New storage class type of storageClass. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageClassPropertiesUpdate(VolumeExpansion? allowVolumeExpansion, IList<string> mountOptions, IList<StorageClassAccessMode> accessModes, DataResilienceTier? dataResilience, FailoverTier? failoverSpeed, IList<string> limitations, PerformanceTier? performance, long? priority, StorageClassTypePropertiesUpdate typeProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowVolumeExpansion = allowVolumeExpansion;
            MountOptions = mountOptions;
            AccessModes = accessModes;
            DataResilience = dataResilience;
            FailoverSpeed = failoverSpeed;
            Limitations = limitations;
            Performance = performance;
            Priority = priority;
            TypeProperties = typeProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Volume can be expanded or not. </summary>
        public VolumeExpansion? AllowVolumeExpansion { get; set; }
        /// <summary> Additional mount options. </summary>
        public IList<string> MountOptions { get; }
        /// <summary> The access mode: [ReadWriteOnce, ReadWriteMany] or [ReadWriteOnce]. </summary>
        public IList<StorageClassAccessMode> AccessModes { get; }
        /// <summary> Allow single data node failure. </summary>
        public DataResilienceTier? DataResilience { get; set; }
        /// <summary> Failover speed: NA, Slow, Fast. </summary>
        public FailoverTier? FailoverSpeed { get; set; }
        /// <summary> Limitations of the storage class. </summary>
        public IList<string> Limitations { get; }
        /// <summary> Performance tier. </summary>
        public PerformanceTier? Performance { get; set; }
        /// <summary> Selection priority when multiple storage classes meet the criteria. 0: Highest, -1: Never use. </summary>
        public long? Priority { get; set; }
        /// <summary> New storage class type of storageClass. </summary>
        public StorageClassTypePropertiesUpdate TypeProperties { get; set; }
    }
}
