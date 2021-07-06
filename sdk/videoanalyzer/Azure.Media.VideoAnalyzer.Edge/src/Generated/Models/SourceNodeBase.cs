// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Base class for topology source nodes. </summary>
    public partial class SourceNodeBase
    {
        /// <summary> Initializes a new instance of SourceNodeBase. </summary>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public SourceNodeBase(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of SourceNodeBase. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        internal SourceNodeBase(string type, string name)
        {
            Type = type;
            Name = name;
        }

        /// <summary> Type discriminator for the derived types. </summary>
        internal string Type { get; set; }
        /// <summary> Node name. Must be unique within the topology. </summary>
        public string Name { get; set; }
    }
}
