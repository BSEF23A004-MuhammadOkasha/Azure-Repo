// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Request for getting sso details for a user. </summary>
    public partial class DynatraceSsoDetailsContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DynatraceSsoDetailsContent"/>. </summary>
        public DynatraceSsoDetailsContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DynatraceSsoDetailsContent"/>. </summary>
        /// <param name="userPrincipal"> user principal id of the user. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DynatraceSsoDetailsContent(string userPrincipal, Dictionary<string, BinaryData> rawData)
        {
            UserPrincipal = userPrincipal;
            _rawData = rawData;
        }

        /// <summary> user principal id of the user. </summary>
        public string UserPrincipal { get; set; }
    }
}
