// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Managed Virtual Network reference type. </summary>
    public partial class ManagedVirtualNetworkReference
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

        /// <summary> Initializes a new instance of <see cref="ManagedVirtualNetworkReference"/>. </summary>
        /// <param name="referenceType"> Managed Virtual Network reference type. </param>
        /// <param name="referenceName"> Reference ManagedVirtualNetwork name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public ManagedVirtualNetworkReference(ManagedVirtualNetworkReferenceType referenceType, string referenceName)
        {
            if (referenceName == null)
            {
                throw new ArgumentNullException(nameof(referenceName));
            }

            ReferenceType = referenceType;
            ReferenceName = referenceName;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedVirtualNetworkReference"/>. </summary>
        /// <param name="referenceType"> Managed Virtual Network reference type. </param>
        /// <param name="referenceName"> Reference ManagedVirtualNetwork name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedVirtualNetworkReference(ManagedVirtualNetworkReferenceType referenceType, string referenceName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReferenceType = referenceType;
            ReferenceName = referenceName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedVirtualNetworkReference"/> for deserialization. </summary>
        internal ManagedVirtualNetworkReference()
        {
        }

        /// <summary> Managed Virtual Network reference type. </summary>
        public ManagedVirtualNetworkReferenceType ReferenceType { get; set; }
        /// <summary> Reference ManagedVirtualNetwork name. </summary>
        public string ReferenceName { get; set; }
    }
}
