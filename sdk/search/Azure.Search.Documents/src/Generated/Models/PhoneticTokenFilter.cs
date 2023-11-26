// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Create tokens for phonetic matches. This token filter is implemented using Apache Lucene. </summary>
    public partial class PhoneticTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of <see cref="PhoneticTokenFilter"/>. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PhoneticTokenFilter(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ODataType = "#Microsoft.Azure.Search.PhoneticTokenFilter";
        }

        /// <summary> Initializes a new instance of <see cref="PhoneticTokenFilter"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="encoder"> The phonetic encoder to use. Default is "metaphone". </param>
        /// <param name="replaceOriginalTokens"> A value indicating whether encoded tokens should replace original tokens. If false, encoded tokens are added as synonyms. Default is true. </param>
        internal PhoneticTokenFilter(string oDataType, string name, IDictionary<string, BinaryData> serializedAdditionalRawData, PhoneticEncoder? encoder, bool? replaceOriginalTokens) : base(oDataType, name, serializedAdditionalRawData)
        {
            Encoder = encoder;
            ReplaceOriginalTokens = replaceOriginalTokens;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.PhoneticTokenFilter";
        }

        /// <summary> Initializes a new instance of <see cref="PhoneticTokenFilter"/> for deserialization. </summary>
        internal PhoneticTokenFilter()
        {
        }

        /// <summary> The phonetic encoder to use. Default is "metaphone". </summary>
        public PhoneticEncoder? Encoder { get; set; }
        /// <summary> A value indicating whether encoded tokens should replace original tokens. If false, encoded tokens are added as synonyms. Default is true. </summary>
        public bool? ReplaceOriginalTokens { get; set; }
    }
}
