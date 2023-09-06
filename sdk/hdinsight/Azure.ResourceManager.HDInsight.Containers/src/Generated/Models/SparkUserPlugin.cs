// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Spark user plugin. </summary>
    public partial class SparkUserPlugin
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SparkUserPlugin"/>. </summary>
        /// <param name="path"> Fully qualified path to the folder containing the plugins. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> is null. </exception>
        public SparkUserPlugin(string path)
        {
            Argument.AssertNotNull(path, nameof(path));

            Path = path;
        }

        /// <summary> Initializes a new instance of <see cref="SparkUserPlugin"/>. </summary>
        /// <param name="path"> Fully qualified path to the folder containing the plugins. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SparkUserPlugin(string path, Dictionary<string, BinaryData> rawData)
        {
            Path = path;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SparkUserPlugin"/> for deserialization. </summary>
        internal SparkUserPlugin()
        {
        }

        /// <summary> Fully qualified path to the folder containing the plugins. </summary>
        public string Path { get; set; }
    }
}
