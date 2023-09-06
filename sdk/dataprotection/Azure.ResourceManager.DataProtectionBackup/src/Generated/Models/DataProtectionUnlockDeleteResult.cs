// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Response of Unlock Delete API. </summary>
    public partial class DataProtectionUnlockDeleteResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataProtectionUnlockDeleteResult"/>. </summary>
        internal DataProtectionUnlockDeleteResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataProtectionUnlockDeleteResult"/>. </summary>
        /// <param name="unlockDeleteExpiryTime"> This is the time when unlock delete privileges will get expired. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataProtectionUnlockDeleteResult(string unlockDeleteExpiryTime, Dictionary<string, BinaryData> rawData)
        {
            UnlockDeleteExpiryTime = unlockDeleteExpiryTime;
            _rawData = rawData;
        }

        /// <summary> This is the time when unlock delete privileges will get expired. </summary>
        public string UnlockDeleteExpiryTime { get; }
    }
}
