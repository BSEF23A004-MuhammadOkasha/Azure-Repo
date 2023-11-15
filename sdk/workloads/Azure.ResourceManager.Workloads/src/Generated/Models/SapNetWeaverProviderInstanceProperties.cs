// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the provider properties. </summary>
    public partial class SapNetWeaverProviderInstanceProperties : ProviderSpecificProperties
    {
        /// <summary> Initializes a new instance of <see cref="SapNetWeaverProviderInstanceProperties"/>. </summary>
        public SapNetWeaverProviderInstanceProperties()
        {
            SapHostFileEntries = new ChangeTrackingList<string>();
            ProviderType = "SapNetWeaver";
        }

        /// <summary> Initializes a new instance of <see cref="SapNetWeaverProviderInstanceProperties"/>. </summary>
        /// <param name="providerType"> The provider type. For example, the value can be SapHana. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sapSid"> Gets or sets the SAP System Identifier. </param>
        /// <param name="sapHostname"> Gets or sets the target virtual machine IP Address/FQDN. </param>
        /// <param name="sapInstanceNr"> Gets or sets the instance number of SAP NetWeaver. </param>
        /// <param name="sapHostFileEntries"> Gets or sets the list of HostFile Entries. </param>
        /// <param name="sapUsername"> Gets or sets the SAP user name. </param>
        /// <param name="sapPassword"> Sets the SAP password. </param>
        /// <param name="sapPasswordUri"> Gets or sets the key vault URI to secret with the SAP password. </param>
        /// <param name="sapClientId"> Gets or sets the SAP Client ID. </param>
        /// <param name="sapPortNumber"> Gets or sets the SAP HTTP port number. </param>
        /// <param name="sslCertificateUri"> Gets or sets the blob URI to SSL certificate for the SAP system. </param>
        /// <param name="sslPreference"> Gets or sets certificate preference if secure communication is enabled. </param>
        internal SapNetWeaverProviderInstanceProperties(string providerType, IDictionary<string, BinaryData> serializedAdditionalRawData, string sapSid, string sapHostname, string sapInstanceNr, IList<string> sapHostFileEntries, string sapUsername, string sapPassword, Uri sapPasswordUri, string sapClientId, string sapPortNumber, Uri sslCertificateUri, SapSslPreference? sslPreference) : base(providerType, serializedAdditionalRawData)
        {
            SapSid = sapSid;
            SapHostname = sapHostname;
            SapInstanceNr = sapInstanceNr;
            SapHostFileEntries = sapHostFileEntries;
            SapUsername = sapUsername;
            SapPassword = sapPassword;
            SapPasswordUri = sapPasswordUri;
            SapClientId = sapClientId;
            SapPortNumber = sapPortNumber;
            SslCertificateUri = sslCertificateUri;
            SslPreference = sslPreference;
            ProviderType = providerType ?? "SapNetWeaver";
        }

        /// <summary> Gets or sets the SAP System Identifier. </summary>
        public string SapSid { get; set; }
        /// <summary> Gets or sets the target virtual machine IP Address/FQDN. </summary>
        public string SapHostname { get; set; }
        /// <summary> Gets or sets the instance number of SAP NetWeaver. </summary>
        public string SapInstanceNr { get; set; }
        /// <summary> Gets or sets the list of HostFile Entries. </summary>
        public IList<string> SapHostFileEntries { get; }
        /// <summary> Gets or sets the SAP user name. </summary>
        public string SapUsername { get; set; }
        /// <summary> Sets the SAP password. </summary>
        public string SapPassword { get; set; }
        /// <summary> Gets or sets the key vault URI to secret with the SAP password. </summary>
        public Uri SapPasswordUri { get; set; }
        /// <summary> Gets or sets the SAP Client ID. </summary>
        public string SapClientId { get; set; }
        /// <summary> Gets or sets the SAP HTTP port number. </summary>
        public string SapPortNumber { get; set; }
        /// <summary> Gets or sets the blob URI to SSL certificate for the SAP system. </summary>
        public Uri SslCertificateUri { get; set; }
        /// <summary> Gets or sets certificate preference if secure communication is enabled. </summary>
        public SapSslPreference? SslPreference { get; set; }
    }
}
