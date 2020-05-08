// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Models
{
    /// <summary> Construct bigrams for frequently occurring terms while indexing. Single terms are still indexed too, with bigrams overlaid. This token filter is implemented using Apache Lucene. </summary>
    public partial class CommonGramTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of CommonGramTokenFilter. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="commonWords"> The set of common words. </param>
        public CommonGramTokenFilter(string name, IEnumerable<string> commonWords) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (commonWords == null)
            {
                throw new ArgumentNullException(nameof(commonWords));
            }

            CommonWords = commonWords.ToArray();
            ODataType = "#Microsoft.Azure.Search.CommonGramTokenFilter";
        }

        /// <summary> Initializes a new instance of CommonGramTokenFilter. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="commonWords"> The set of common words. </param>
        /// <param name="ignoreCase"> A value indicating whether common words matching will be case insensitive. Default is false. </param>
        /// <param name="useQueryMode"> A value that indicates whether the token filter is in query mode. When in query mode, the token filter generates bigrams and then removes common words and single terms followed by a common word. Default is false. </param>
        internal CommonGramTokenFilter(string oDataType, string name, IList<string> commonWords, bool? ignoreCase, bool? useQueryMode) : base(oDataType, name)
        {
            CommonWords = commonWords;
            IgnoreCase = ignoreCase;
            UseQueryMode = useQueryMode;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.CommonGramTokenFilter";
        }

        /// <summary> The set of common words. </summary>
        public IList<string> CommonWords { get; set; }
        /// <summary> A value indicating whether common words matching will be case insensitive. Default is false. </summary>
        public bool? IgnoreCase { get; set; }
        /// <summary> A value that indicates whether the token filter is in query mode. When in query mode, the token filter generates bigrams and then removes common words and single terms followed by a common word. Default is false. </summary>
        public bool? UseQueryMode { get; set; }
    }
}
