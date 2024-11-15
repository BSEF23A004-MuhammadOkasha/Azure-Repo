// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> The structure, containing the list of vector storage configurations i.e. the list of azure asset IDs. </summary>
    public partial class VectorStoreConfigurations
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

        /// <summary> Initializes a new instance of <see cref="VectorStoreConfigurations"/>. </summary>
        /// <param name="storeName"> Name. </param>
        /// <param name="storeConfiguration"> Configurations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storeName"/> or <paramref name="storeConfiguration"/> is null. </exception>
        public VectorStoreConfigurations(string storeName, VectorStoreConfiguration storeConfiguration)
        {
            Argument.AssertNotNull(storeName, nameof(storeName));
            Argument.AssertNotNull(storeConfiguration, nameof(storeConfiguration));

            StoreName = storeName;
            StoreConfiguration = storeConfiguration;
        }

        /// <summary> Initializes a new instance of <see cref="VectorStoreConfigurations"/>. </summary>
        /// <param name="storeName"> Name. </param>
        /// <param name="storeConfiguration"> Configurations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VectorStoreConfigurations(string storeName, VectorStoreConfiguration storeConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StoreName = storeName;
            StoreConfiguration = storeConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VectorStoreConfigurations"/> for deserialization. </summary>
        internal VectorStoreConfigurations()
        {
        }

        /// <summary> Name. </summary>
        public string StoreName { get; set; }
        /// <summary> Configurations. </summary>
        public VectorStoreConfiguration StoreConfiguration { get; set; }
    }
}
