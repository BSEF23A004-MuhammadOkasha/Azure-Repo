// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the FirewallPolicy data model. </summary>
    public partial class FirewallPolicyData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of FirewallPolicyData. </summary>
        public FirewallPolicyData()
        {
            RuleCollectionGroups = new ChangeTrackingList<WritableSubResource>();
            Firewalls = new ChangeTrackingList<WritableSubResource>();
            ChildPolicies = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of FirewallPolicyData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="eTag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="identity"> The identity of the firewall policy. </param>
        /// <param name="ruleCollectionGroups"> List of references to FirewallPolicyRuleCollectionGroups. </param>
        /// <param name="provisioningState"> The provisioning state of the firewall policy resource. </param>
        /// <param name="basePolicy"> The parent firewall policy from which rules are inherited. </param>
        /// <param name="firewalls"> List of references to Azure Firewalls that this Firewall Policy is associated with. </param>
        /// <param name="childPolicies"> List of references to Child Firewall Policies. </param>
        /// <param name="threatIntelMode"> The operation mode for Threat Intelligence. </param>
        /// <param name="threatIntelWhitelist"> ThreatIntel Whitelist for Firewall Policy. </param>
        /// <param name="insights"> Insights on Firewall Policy. </param>
        /// <param name="snat"> The private IP addresses/IP ranges to which traffic will not be SNAT. </param>
        /// <param name="dnsSettings"> DNS Proxy Settings definition. </param>
        /// <param name="intrusionDetection"> The configuration for Intrusion detection. </param>
        /// <param name="transportSecurity"> TLS Configuration definition. </param>
        /// <param name="sku"> The Firewall Policy SKU. </param>
        internal FirewallPolicyData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? eTag, ManagedServiceIdentity identity, IReadOnlyList<WritableSubResource> ruleCollectionGroups, NetworkProvisioningState? provisioningState, WritableSubResource basePolicy, IReadOnlyList<WritableSubResource> firewalls, IReadOnlyList<WritableSubResource> childPolicies, AzureFirewallThreatIntelMode? threatIntelMode, FirewallPolicyThreatIntelWhitelist threatIntelWhitelist, FirewallPolicyInsights insights, FirewallPolicySnat snat, DnsSettings dnsSettings, FirewallPolicyIntrusionDetection intrusionDetection, FirewallPolicyTransportSecurity transportSecurity, FirewallPolicySku sku) : base(id, name, resourceType, location, tags)
        {
            ETag = eTag;
            Identity = identity;
            RuleCollectionGroups = ruleCollectionGroups;
            ProvisioningState = provisioningState;
            BasePolicy = basePolicy;
            Firewalls = firewalls;
            ChildPolicies = childPolicies;
            ThreatIntelMode = threatIntelMode;
            ThreatIntelWhitelist = threatIntelWhitelist;
            Insights = insights;
            Snat = snat;
            DnsSettings = dnsSettings;
            IntrusionDetection = intrusionDetection;
            TransportSecurity = transportSecurity;
            Sku = sku;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The identity of the firewall policy. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> List of references to FirewallPolicyRuleCollectionGroups. </summary>
        public IReadOnlyList<WritableSubResource> RuleCollectionGroups { get; }
        /// <summary> The provisioning state of the firewall policy resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The parent firewall policy from which rules are inherited. </summary>
        internal WritableSubResource BasePolicy { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier BasePolicyId
        {
            get => BasePolicy is null ? default : BasePolicy.Id;
            set
            {
                if (BasePolicy is null)
                    BasePolicy = new WritableSubResource();
                BasePolicy.Id = value;
            }
        }

        /// <summary> List of references to Azure Firewalls that this Firewall Policy is associated with. </summary>
        public IReadOnlyList<WritableSubResource> Firewalls { get; }
        /// <summary> List of references to Child Firewall Policies. </summary>
        public IReadOnlyList<WritableSubResource> ChildPolicies { get; }
        /// <summary> The operation mode for Threat Intelligence. </summary>
        public AzureFirewallThreatIntelMode? ThreatIntelMode { get; set; }
        /// <summary> ThreatIntel Whitelist for Firewall Policy. </summary>
        public FirewallPolicyThreatIntelWhitelist ThreatIntelWhitelist { get; set; }
        /// <summary> Insights on Firewall Policy. </summary>
        public FirewallPolicyInsights Insights { get; set; }
        /// <summary> The private IP addresses/IP ranges to which traffic will not be SNAT. </summary>
        internal FirewallPolicySnat Snat { get; set; }
        /// <summary> List of private IP addresses/IP address ranges to not be SNAT. </summary>
        public IList<string> SnatPrivateRanges
        {
            get
            {
                if (Snat is null)
                    Snat = new FirewallPolicySnat();
                return Snat.PrivateRanges;
            }
        }

        /// <summary> DNS Proxy Settings definition. </summary>
        public DnsSettings DnsSettings { get; set; }
        /// <summary> The configuration for Intrusion detection. </summary>
        public FirewallPolicyIntrusionDetection IntrusionDetection { get; set; }
        /// <summary> TLS Configuration definition. </summary>
        internal FirewallPolicyTransportSecurity TransportSecurity { get; set; }
        /// <summary> The CA used for intermediate CA generation. </summary>
        public FirewallPolicyCertificateAuthority TransportSecurityCertificateAuthority
        {
            get => TransportSecurity is null ? default : TransportSecurity.CertificateAuthority;
            set
            {
                if (TransportSecurity is null)
                    TransportSecurity = new FirewallPolicyTransportSecurity();
                TransportSecurity.CertificateAuthority = value;
            }
        }

        /// <summary> The Firewall Policy SKU. </summary>
        internal FirewallPolicySku Sku { get; set; }
        /// <summary> Tier of Firewall Policy. </summary>
        public FirewallPolicySkuTier? SkuTier
        {
            get => Sku is null ? default : Sku.Tier;
            set
            {
                if (Sku is null)
                    Sku = new FirewallPolicySku();
                Sku.Tier = value;
            }
        }
    }
}
