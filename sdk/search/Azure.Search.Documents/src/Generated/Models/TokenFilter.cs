// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    /// <summary> Base type for token filters. </summary>
    public partial class TokenFilter
    {
        /// <summary> Initializes a new instance of TokenFilter. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        public TokenFilter(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            ODataType = null;
        }

        /// <summary> Initializes a new instance of TokenFilter. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal TokenFilter(string oDataType, string name)
        {
            ODataType = oDataType;
            Name = name;
        }

        /// <summary> Identifies the concrete type of the token filter. </summary>
        internal string ODataType { get; set; }
        /// <summary> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </summary>
        public string Name { get; }
    }
}
