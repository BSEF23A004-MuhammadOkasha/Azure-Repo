// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather
{
    /// <summary> The resource management error additional info. </summary>
    internal partial class ErrorAdditionalInfo
    {
        /// <summary> Initializes a new instance of <see cref="ErrorAdditionalInfo"/>. </summary>
        internal ErrorAdditionalInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ErrorAdditionalInfo"/>. </summary>
        /// <param name="type"> The additional info type. </param>
        /// <param name="info"> The additional info. </param>
        internal ErrorAdditionalInfo(string type, object info)
        {
            Type = type;
            Info = info;
        }

        /// <summary> The additional info type. </summary>
        public string Type { get; }
        /// <summary> The additional info. </summary>
        public object Info { get; }
    }
}
