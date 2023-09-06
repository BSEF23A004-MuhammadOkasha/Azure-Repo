// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Explicit Proxy Settings in Firewall Policy. </summary>
    public partial class FirewallPolicyExplicitProxy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyExplicitProxy"/>. </summary>
        public FirewallPolicyExplicitProxy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyExplicitProxy"/>. </summary>
        /// <param name="enableExplicitProxy"> When set to true, explicit proxy mode is enabled. </param>
        /// <param name="httpPort"> Port number for explicit proxy http protocol, cannot be greater than 64000. </param>
        /// <param name="httpsPort"> Port number for explicit proxy https protocol, cannot be greater than 64000. </param>
        /// <param name="enablePacFile"> When set to true, pac file port and url needs to be provided. </param>
        /// <param name="pacFilePort"> Port number for firewall to serve PAC file. </param>
        /// <param name="pacFile"> SAS URL for PAC file. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallPolicyExplicitProxy(bool? enableExplicitProxy, int? httpPort, int? httpsPort, bool? enablePacFile, int? pacFilePort, string pacFile, Dictionary<string, BinaryData> rawData)
        {
            EnableExplicitProxy = enableExplicitProxy;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            EnablePacFile = enablePacFile;
            PacFilePort = pacFilePort;
            PacFile = pacFile;
            _rawData = rawData;
        }

        /// <summary> When set to true, explicit proxy mode is enabled. </summary>
        public bool? EnableExplicitProxy { get; set; }
        /// <summary> Port number for explicit proxy http protocol, cannot be greater than 64000. </summary>
        public int? HttpPort { get; set; }
        /// <summary> Port number for explicit proxy https protocol, cannot be greater than 64000. </summary>
        public int? HttpsPort { get; set; }
        /// <summary> When set to true, pac file port and url needs to be provided. </summary>
        public bool? EnablePacFile { get; set; }
        /// <summary> Port number for firewall to serve PAC file. </summary>
        public int? PacFilePort { get; set; }
        /// <summary> SAS URL for PAC file. </summary>
        public string PacFile { get; set; }
    }
}
