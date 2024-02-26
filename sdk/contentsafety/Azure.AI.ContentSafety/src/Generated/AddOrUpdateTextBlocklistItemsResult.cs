// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.ContentSafety
{
    /// <summary> The response of adding blocklistItems to the text blocklist. </summary>
    public partial class AddOrUpdateTextBlocklistItemsResult
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

        /// <summary> Initializes a new instance of <see cref="AddOrUpdateTextBlocklistItemsResult"/>. </summary>
        /// <param name="blocklistItems"> Array of blocklistItems have been added. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blocklistItems"/> is null. </exception>
        internal AddOrUpdateTextBlocklistItemsResult(IEnumerable<TextBlocklistItem> blocklistItems)
        {
            if (blocklistItems == null)
            {
                throw new ArgumentNullException(nameof(blocklistItems));
            }

            BlocklistItems = blocklistItems.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AddOrUpdateTextBlocklistItemsResult"/>. </summary>
        /// <param name="blocklistItems"> Array of blocklistItems have been added. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AddOrUpdateTextBlocklistItemsResult(IReadOnlyList<TextBlocklistItem> blocklistItems, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BlocklistItems = blocklistItems;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AddOrUpdateTextBlocklistItemsResult"/> for deserialization. </summary>
        internal AddOrUpdateTextBlocklistItemsResult()
        {
        }

        /// <summary> Array of blocklistItems have been added. </summary>
        public IReadOnlyList<TextBlocklistItem> BlocklistItems { get; }
    }
}
