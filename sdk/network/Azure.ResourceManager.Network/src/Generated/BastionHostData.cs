// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the BastionHost data model.
    /// Bastion Host resource.
    /// </summary>
    public partial class BastionHostData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="BastionHostData"/>. </summary>
        public BastionHostData()
        {
            IPConfigurations = new ChangeTrackingList<BastionHostIPConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="BastionHostData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="sku"> The sku of this Bastion Host. </param>
        /// <param name="ipConfigurations"> IP configuration of the Bastion Host resource. </param>
        /// <param name="dnsName"> FQDN for the endpoint on which bastion host is accessible. </param>
        /// <param name="provisioningState"> The provisioning state of the bastion host resource. </param>
        /// <param name="scaleUnits"> The scale units for the Bastion Host resource. </param>
        /// <param name="disableCopyPaste"> Enable/Disable Copy/Paste feature of the Bastion Host resource. </param>
        /// <param name="enableFileCopy"> Enable/Disable File Copy feature of the Bastion Host resource. </param>
        /// <param name="enableIPConnect"> Enable/Disable IP Connect feature of the Bastion Host resource. </param>
        /// <param name="enableShareableLink"> Enable/Disable Shareable Link of the Bastion Host resource. </param>
        /// <param name="enableTunneling"> Enable/Disable Tunneling feature of the Bastion Host resource. </param>
        /// <param name="enableKerberos"> Enable/Disable Kerberos feature of the Bastion Host resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BastionHostData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? etag, NetworkSku sku, IList<BastionHostIPConfiguration> ipConfigurations, string dnsName, NetworkProvisioningState? provisioningState, int? scaleUnits, bool? disableCopyPaste, bool? enableFileCopy, bool? enableIPConnect, bool? enableShareableLink, bool? enableTunneling, bool? enableKerberos, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, location, tags, rawData)
        {
            ETag = etag;
            Sku = sku;
            IPConfigurations = ipConfigurations;
            DnsName = dnsName;
            ProvisioningState = provisioningState;
            ScaleUnits = scaleUnits;
            DisableCopyPaste = disableCopyPaste;
            EnableFileCopy = enableFileCopy;
            EnableIPConnect = enableIPConnect;
            EnableShareableLink = enableShareableLink;
            EnableTunneling = enableTunneling;
            EnableKerberos = enableKerberos;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The sku of this Bastion Host. </summary>
        internal NetworkSku Sku { get; set; }
        /// <summary> The name of this Bastion Host. </summary>
        public BastionHostSkuName? SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new NetworkSku();
                Sku.Name = value;
            }
        }

        /// <summary> IP configuration of the Bastion Host resource. </summary>
        public IList<BastionHostIPConfiguration> IPConfigurations { get; }
        /// <summary> FQDN for the endpoint on which bastion host is accessible. </summary>
        public string DnsName { get; set; }
        /// <summary> The provisioning state of the bastion host resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The scale units for the Bastion Host resource. </summary>
        public int? ScaleUnits { get; set; }
        /// <summary> Enable/Disable Copy/Paste feature of the Bastion Host resource. </summary>
        public bool? DisableCopyPaste { get; set; }
        /// <summary> Enable/Disable File Copy feature of the Bastion Host resource. </summary>
        public bool? EnableFileCopy { get; set; }
        /// <summary> Enable/Disable IP Connect feature of the Bastion Host resource. </summary>
        public bool? EnableIPConnect { get; set; }
        /// <summary> Enable/Disable Shareable Link of the Bastion Host resource. </summary>
        public bool? EnableShareableLink { get; set; }
        /// <summary> Enable/Disable Tunneling feature of the Bastion Host resource. </summary>
        public bool? EnableTunneling { get; set; }
        /// <summary> Enable/Disable Kerberos feature of the Bastion Host resource. </summary>
        public bool? EnableKerberos { get; set; }
    }
}
