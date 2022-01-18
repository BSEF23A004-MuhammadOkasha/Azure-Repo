// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.NetworkTraversal
{
    /// <summary> A relay configuration containing the STUN/TURN URLs and credentials. </summary>
    public partial class CommunicationRelayConfiguration
    {
        /// <summary> Initializes a new instance of CommunicationRelayConfiguration. </summary>
        /// <param name="expiresOn"> The date for which the username and credentials are not longer valid. Will be 48 hours from request time. </param>
        /// <param name="iceServers"> An array representing the credentials and the STUN/TURN server URLs for use in ICE negotiations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="iceServers"/> is null. </exception>
        public CommunicationRelayConfiguration(DateTimeOffset? expiresOn, IEnumerable<CommunicationIceServer> iceServers)
        {
            if (iceServers == null)
            {
                throw new ArgumentNullException(nameof(iceServers));
            }

            ExpiresOn = expiresOn;
            IceServers = iceServers.ToList();
        }

        /// <summary> Initializes a new instance of CommunicationRelayConfiguration. </summary>
        /// <param name="expiresOn"> The date for which the username and credentials are not longer valid. Will be 48 hours from request time. </param>
        /// <param name="iceServers"> An array representing the credentials and the STUN/TURN server URLs for use in ICE negotiations. </param>
        internal CommunicationRelayConfiguration(DateTimeOffset? expiresOn, IList<CommunicationIceServer> iceServers)
        {
            ExpiresOn = expiresOn;
            IceServers = iceServers;
        }
        /// <summary> An array representing the credentials and the STUN/TURN server URLs for use in ICE negotiations. </summary>
        public IList<CommunicationIceServer> IceServers { get; }
    }
}
