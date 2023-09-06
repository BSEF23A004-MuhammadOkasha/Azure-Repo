// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The thumbprint is a unique value for the x509 certificate, commonly used to find a particular certificate in a certificate store. The thumbprint is dynamically generated using the SHA1 algorithm, and does not physically exist in the certificate. </summary>
    public partial class DeviceTwinInfoX509Thumbprint
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeviceTwinInfoX509Thumbprint"/>. </summary>
        internal DeviceTwinInfoX509Thumbprint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceTwinInfoX509Thumbprint"/>. </summary>
        /// <param name="primaryThumbprint"> Primary thumbprint for the x509 certificate. </param>
        /// <param name="secondaryThumbprint"> Secondary thumbprint for the x509 certificate. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceTwinInfoX509Thumbprint(string primaryThumbprint, string secondaryThumbprint, Dictionary<string, BinaryData> rawData)
        {
            PrimaryThumbprint = primaryThumbprint;
            SecondaryThumbprint = secondaryThumbprint;
            _rawData = rawData;
        }

        /// <summary> Primary thumbprint for the x509 certificate. </summary>
        public string PrimaryThumbprint { get; }
        /// <summary> Secondary thumbprint for the x509 certificate. </summary>
        public string SecondaryThumbprint { get; }
    }
}
