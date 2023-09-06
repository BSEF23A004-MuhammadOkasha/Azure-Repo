// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Uri or local path to source data. </summary>
    internal partial class SourcePath
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SourcePath"/>. </summary>
        public SourcePath()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SourcePath"/>. </summary>
        /// <param name="source"> File source path. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SourcePath(string source, Dictionary<string, BinaryData> rawData)
        {
            Source = source;
            _rawData = rawData;
        }

        /// <summary> File source path. </summary>
        public string Source { get; set; }
    }
}
