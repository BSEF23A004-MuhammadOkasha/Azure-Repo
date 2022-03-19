// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The AliasPathMetadata. </summary>
    internal partial class AliasPathMetadata
    {
        /// <summary> Initializes a new instance of AliasPathMetadata. </summary>
        internal AliasPathMetadata()
        {
        }

        /// <summary> Initializes a new instance of AliasPathMetadata. </summary>
        /// <param name="aliasPathTokenType"> The type of the token that the alias path is referring to. </param>
        /// <param name="attributes"> The attributes of the token that the alias path is referring to. </param>
        internal AliasPathMetadata(AliasPathTokenType? aliasPathTokenType, AliasPathAttributes? attributes)
        {
            AliasPathTokenType = aliasPathTokenType;
            Attributes = attributes;
        }

        /// <summary> The type of the token that the alias path is referring to. </summary>
        public AliasPathTokenType? AliasPathTokenType { get; }
        /// <summary> The attributes of the token that the alias path is referring to. </summary>
        public AliasPathAttributes? Attributes { get; }
    }
}
