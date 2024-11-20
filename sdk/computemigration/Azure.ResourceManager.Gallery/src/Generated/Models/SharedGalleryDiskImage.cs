// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Gallery.Models
{
    /// <summary> This is the disk image base class. </summary>
    public partial class SharedGalleryDiskImage
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SharedGalleryDiskImage"/>. </summary>
        internal SharedGalleryDiskImage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SharedGalleryDiskImage"/>. </summary>
        /// <param name="diskSizeGB"> This property indicates the size of the VHD to be created. </param>
        /// <param name="hostCaching"> The host caching of the disk. Valid values are 'None', 'ReadOnly', and 'ReadWrite'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedGalleryDiskImage(int? diskSizeGB, SharedGalleryHostCaching? hostCaching, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskSizeGB = diskSizeGB;
            HostCaching = hostCaching;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> This property indicates the size of the VHD to be created. </summary>
        public int? DiskSizeGB { get; }
        /// <summary> The host caching of the disk. Valid values are 'None', 'ReadOnly', and 'ReadWrite'. </summary>
        public SharedGalleryHostCaching? HostCaching { get; }
    }
}
