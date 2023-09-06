// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing the LocalRulestackCertificateObject data model.
    /// LocalRulestack Certificate Object
    /// </summary>
    public partial class LocalRulestackCertificateObjectData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LocalRulestackCertificateObjectData"/>. </summary>
        /// <param name="certificateSelfSigned"> use certificate self signed. </param>
        public LocalRulestackCertificateObjectData(FirewallBooleanType certificateSelfSigned)
        {
            CertificateSelfSigned = certificateSelfSigned;
        }

        /// <summary> Initializes a new instance of <see cref="LocalRulestackCertificateObjectData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="certificateSignerResourceId"> Resource Id of certificate signer, to be populated only when certificateSelfSigned is false. </param>
        /// <param name="certificateSelfSigned"> use certificate self signed. </param>
        /// <param name="auditComment"> comment for this object. </param>
        /// <param name="description"> user description for this object. </param>
        /// <param name="etag"> read only string representing last create or update. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LocalRulestackCertificateObjectData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string certificateSignerResourceId, FirewallBooleanType certificateSelfSigned, string auditComment, string description, ETag? etag, FirewallProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            CertificateSignerResourceId = certificateSignerResourceId;
            CertificateSelfSigned = certificateSelfSigned;
            AuditComment = auditComment;
            Description = description;
            ETag = etag;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="LocalRulestackCertificateObjectData"/> for deserialization. </summary>
        internal LocalRulestackCertificateObjectData()
        {
        }

        /// <summary> Resource Id of certificate signer, to be populated only when certificateSelfSigned is false. </summary>
        public string CertificateSignerResourceId { get; set; }
        /// <summary> use certificate self signed. </summary>
        public FirewallBooleanType CertificateSelfSigned { get; set; }
        /// <summary> comment for this object. </summary>
        public string AuditComment { get; set; }
        /// <summary> user description for this object. </summary>
        public string Description { get; set; }
        /// <summary> read only string representing last create or update. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public FirewallProvisioningState? ProvisioningState { get; }
    }
}
