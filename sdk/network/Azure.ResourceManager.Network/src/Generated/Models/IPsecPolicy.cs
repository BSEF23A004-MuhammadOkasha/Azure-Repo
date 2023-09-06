// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> An IPSec Policy configuration for a virtual network gateway connection. </summary>
    public partial class IPsecPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IPsecPolicy"/>. </summary>
        /// <param name="saLifeTimeSeconds"> The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for a site to site VPN tunnel. </param>
        /// <param name="saDataSizeKilobytes"> The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for a site to site VPN tunnel. </param>
        /// <param name="ipsecEncryption"> The IPSec encryption algorithm (IKE phase 1). </param>
        /// <param name="ipsecIntegrity"> The IPSec integrity algorithm (IKE phase 1). </param>
        /// <param name="ikeEncryption"> The IKE encryption algorithm (IKE phase 2). </param>
        /// <param name="ikeIntegrity"> The IKE integrity algorithm (IKE phase 2). </param>
        /// <param name="dhGroup"> The DH Group used in IKE Phase 1 for initial SA. </param>
        /// <param name="pfsGroup"> The Pfs Group used in IKE Phase 2 for new child SA. </param>
        public IPsecPolicy(int saLifeTimeSeconds, int saDataSizeKilobytes, IPsecEncryption ipsecEncryption, IPsecIntegrity ipsecIntegrity, IkeEncryption ikeEncryption, IkeIntegrity ikeIntegrity, DHGroup dhGroup, PfsGroup pfsGroup)
        {
            SaLifeTimeSeconds = saLifeTimeSeconds;
            SaDataSizeKilobytes = saDataSizeKilobytes;
            IPsecEncryption = ipsecEncryption;
            IPsecIntegrity = ipsecIntegrity;
            IkeEncryption = ikeEncryption;
            IkeIntegrity = ikeIntegrity;
            DhGroup = dhGroup;
            PfsGroup = pfsGroup;
        }

        /// <summary> Initializes a new instance of <see cref="IPsecPolicy"/>. </summary>
        /// <param name="saLifeTimeSeconds"> The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for a site to site VPN tunnel. </param>
        /// <param name="saDataSizeKilobytes"> The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for a site to site VPN tunnel. </param>
        /// <param name="ipsecEncryption"> The IPSec encryption algorithm (IKE phase 1). </param>
        /// <param name="ipsecIntegrity"> The IPSec integrity algorithm (IKE phase 1). </param>
        /// <param name="ikeEncryption"> The IKE encryption algorithm (IKE phase 2). </param>
        /// <param name="ikeIntegrity"> The IKE integrity algorithm (IKE phase 2). </param>
        /// <param name="dhGroup"> The DH Group used in IKE Phase 1 for initial SA. </param>
        /// <param name="pfsGroup"> The Pfs Group used in IKE Phase 2 for new child SA. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IPsecPolicy(int saLifeTimeSeconds, int saDataSizeKilobytes, IPsecEncryption ipsecEncryption, IPsecIntegrity ipsecIntegrity, IkeEncryption ikeEncryption, IkeIntegrity ikeIntegrity, DHGroup dhGroup, PfsGroup pfsGroup, Dictionary<string, BinaryData> rawData)
        {
            SaLifeTimeSeconds = saLifeTimeSeconds;
            SaDataSizeKilobytes = saDataSizeKilobytes;
            IPsecEncryption = ipsecEncryption;
            IPsecIntegrity = ipsecIntegrity;
            IkeEncryption = ikeEncryption;
            IkeIntegrity = ikeIntegrity;
            DhGroup = dhGroup;
            PfsGroup = pfsGroup;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="IPsecPolicy"/> for deserialization. </summary>
        internal IPsecPolicy()
        {
        }

        /// <summary> The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for a site to site VPN tunnel. </summary>
        public int SaLifeTimeSeconds { get; set; }
        /// <summary> The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for a site to site VPN tunnel. </summary>
        public int SaDataSizeKilobytes { get; set; }
        /// <summary> The IPSec encryption algorithm (IKE phase 1). </summary>
        public IPsecEncryption IPsecEncryption { get; set; }
        /// <summary> The IPSec integrity algorithm (IKE phase 1). </summary>
        public IPsecIntegrity IPsecIntegrity { get; set; }
        /// <summary> The IKE encryption algorithm (IKE phase 2). </summary>
        public IkeEncryption IkeEncryption { get; set; }
        /// <summary> The IKE integrity algorithm (IKE phase 2). </summary>
        public IkeIntegrity IkeIntegrity { get; set; }
        /// <summary> The DH Group used in IKE Phase 1 for initial SA. </summary>
        public DHGroup DhGroup { get; set; }
        /// <summary> The Pfs Group used in IKE Phase 2 for new child SA. </summary>
        public PfsGroup PfsGroup { get; set; }
    }
}
