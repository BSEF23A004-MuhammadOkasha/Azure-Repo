// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    /// <summary> Generates n-grams of the given size(s). This token filter is implemented using Apache Lucene. </summary>
    public partial class NGramTokenFilterV2 : TokenFilter
    {
        /// <summary> Initializes a new instance of NGramTokenFilterV2. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        public NGramTokenFilterV2(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            ODataType = "#Microsoft.Azure.Search.NGramTokenFilterV2";
        }

        /// <summary> Initializes a new instance of NGramTokenFilterV2. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="minGram"> The minimum n-gram length. Default is 1. Maximum is 300. Must be less than the value of maxGram. </param>
        /// <param name="maxGram"> The maximum n-gram length. Default is 2. Maximum is 300. </param>
        internal NGramTokenFilterV2(string oDataType, string name, int? minGram, int? maxGram) : base(oDataType, name)
        {
            MinGram = minGram;
            MaxGram = maxGram;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.NGramTokenFilterV2";
        }

        /// <summary> The minimum n-gram length. Default is 1. Maximum is 300. Must be less than the value of maxGram. </summary>
        public int? MinGram { get; set; }
        /// <summary> The maximum n-gram length. Default is 2. Maximum is 300. </summary>
        public int? MaxGram { get; set; }
    }
}
