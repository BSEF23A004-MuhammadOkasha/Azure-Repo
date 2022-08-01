// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The cluster host information.
    /// Serialized Name: HostInfo
    /// </summary>
    public partial class HDInsightClusterHostInfo
    {
        /// <summary> Initializes a new instance of HDInsightClusterHostInfo. </summary>
        internal HDInsightClusterHostInfo()
        {
        }

        /// <summary> Initializes a new instance of HDInsightClusterHostInfo. </summary>
        /// <param name="name">
        /// The host name
        /// Serialized Name: HostInfo.name
        /// </param>
        /// <param name="fqdn">
        /// The Fully Qualified Domain Name of host
        /// Serialized Name: HostInfo.fqdn
        /// </param>
        /// <param name="effectiveDiskEncryptionKeyUri">
        /// The effective disk encryption key URL used by the host
        /// Serialized Name: HostInfo.effectiveDiskEncryptionKeyUrl
        /// </param>
        internal HDInsightClusterHostInfo(string name, string fqdn, Uri effectiveDiskEncryptionKeyUri)
        {
            Name = name;
            Fqdn = fqdn;
            EffectiveDiskEncryptionKeyUri = effectiveDiskEncryptionKeyUri;
        }

        /// <summary>
        /// The host name
        /// Serialized Name: HostInfo.name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The Fully Qualified Domain Name of host
        /// Serialized Name: HostInfo.fqdn
        /// </summary>
        public string Fqdn { get; }
        /// <summary>
        /// The effective disk encryption key URL used by the host
        /// Serialized Name: HostInfo.effectiveDiskEncryptionKeyUrl
        /// </summary>
        public Uri EffectiveDiskEncryptionKeyUri { get; }
    }
}
