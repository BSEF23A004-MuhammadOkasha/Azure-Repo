// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Break file locks request. </summary>
    public partial class NetAppVolumeBreakFileLocksContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBreakFileLocksContent"/>. </summary>
        public NetAppVolumeBreakFileLocksContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBreakFileLocksContent"/>. </summary>
        /// <param name="clientIP"> To clear file locks on a volume for a particular client. </param>
        /// <param name="confirmRunningDisruptiveOperation"> Break File locks could be a disruptive operation for application as locks on the volume will be broken, if want to process, set to true. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeBreakFileLocksContent(IPAddress clientIP, bool? confirmRunningDisruptiveOperation, Dictionary<string, BinaryData> rawData)
        {
            ClientIP = clientIP;
            ConfirmRunningDisruptiveOperation = confirmRunningDisruptiveOperation;
            _rawData = rawData;
        }

        /// <summary> To clear file locks on a volume for a particular client. </summary>
        public IPAddress ClientIP { get; set; }
        /// <summary> Break File locks could be a disruptive operation for application as locks on the volume will be broken, if want to process, set to true. </summary>
        public bool? ConfirmRunningDisruptiveOperation { get; set; }
    }
}
