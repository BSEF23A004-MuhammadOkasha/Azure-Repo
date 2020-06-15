// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Uses Java regexes to emit multiple tokens - one for each capture group in one or more patterns. This token filter is implemented using Apache Lucene. </summary>
    public partial class PatternCaptureTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of PatternCaptureTokenFilter. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="patterns"> A list of patterns to match against each token. </param>
        public PatternCaptureTokenFilter(string name, IEnumerable<string> patterns) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (patterns == null)
            {
                throw new ArgumentNullException(nameof(patterns));
            }

            Patterns = patterns.ToArray();
            ODataType = "#Microsoft.Azure.Search.PatternCaptureTokenFilter";
        }

        /// <summary> Initializes a new instance of PatternCaptureTokenFilter. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="patterns"> A list of patterns to match against each token. </param>
        /// <param name="preserveOriginal"> A value indicating whether to return the original token even if one of the patterns matches. Default is true. </param>
        internal PatternCaptureTokenFilter(string oDataType, string name, IList<string> patterns, bool? preserveOriginal) : base(oDataType, name)
        {
            Patterns = patterns ?? new List<string>();
            PreserveOriginal = preserveOriginal;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.PatternCaptureTokenFilter";
        }
        /// <summary> A value indicating whether to return the original token even if one of the patterns matches. Default is true. </summary>
        public bool? PreserveOriginal { get; set; }
    }
}
