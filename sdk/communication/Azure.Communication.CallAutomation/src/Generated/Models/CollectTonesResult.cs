// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The CollectTonesResult. </summary>
    public partial class CollectTonesResult
    {
        /// <summary> Initializes a new instance of CollectTonesResult. </summary>
        internal CollectTonesResult()
        {
            Tones = new Core.ChangeTrackingList<DtmfTone>();
        }

        /// <summary> Initializes a new instance of CollectTonesResult. </summary>
        /// <param name="tones"></param>
        internal CollectTonesResult(IReadOnlyList<DtmfTone> tones)
        {
            Tones = tones;
        }
    }
}
