// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevOpsInfrastructure.Models
{
    /// <summary> Details of the ResourceDetailsObject. </summary>
    public partial class DevOpsResourceDetailsProperties
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

        /// <summary> Initializes a new instance of <see cref="DevOpsResourceDetailsProperties"/>. </summary>
        /// <param name="status"> The status of the resource. </param>
        /// <param name="image"> The image name of the resource. </param>
        /// <param name="imageVersion"> The version of the image running on the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="image"/> or <paramref name="imageVersion"/> is null. </exception>
        internal DevOpsResourceDetailsProperties(DevOpsResourceStatus status, string image, string imageVersion)
        {
            Argument.AssertNotNull(image, nameof(image));
            Argument.AssertNotNull(imageVersion, nameof(imageVersion));

            Status = status;
            Image = image;
            ImageVersion = imageVersion;
        }

        /// <summary> Initializes a new instance of <see cref="DevOpsResourceDetailsProperties"/>. </summary>
        /// <param name="status"> The status of the resource. </param>
        /// <param name="image"> The image name of the resource. </param>
        /// <param name="imageVersion"> The version of the image running on the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevOpsResourceDetailsProperties(DevOpsResourceStatus status, string image, string imageVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Image = image;
            ImageVersion = imageVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DevOpsResourceDetailsProperties"/> for deserialization. </summary>
        internal DevOpsResourceDetailsProperties()
        {
        }

        /// <summary> The status of the resource. </summary>
        public DevOpsResourceStatus Status { get; }
        /// <summary> The image name of the resource. </summary>
        public string Image { get; }
        /// <summary> The version of the image running on the resource. </summary>
        public string ImageVersion { get; }
    }
}
