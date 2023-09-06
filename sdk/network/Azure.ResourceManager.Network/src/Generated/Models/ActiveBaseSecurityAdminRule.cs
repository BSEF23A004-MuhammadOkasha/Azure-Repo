// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary>
    /// Network base admin rule.
    /// Please note <see cref="ActiveBaseSecurityAdminRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ActiveSecurityAdminRule"/> and <see cref="ActiveDefaultSecurityAdminRule"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownActiveBaseSecurityAdminRule))]
    public abstract partial class ActiveBaseSecurityAdminRule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ActiveBaseSecurityAdminRule"/>. </summary>
        protected ActiveBaseSecurityAdminRule()
        {
            RuleCollectionAppliesToGroups = new ChangeTrackingList<NetworkManagerSecurityGroupItem>();
            RuleGroups = new ChangeTrackingList<NetworkConfigurationGroup>();
        }

        /// <summary> Initializes a new instance of <see cref="ActiveBaseSecurityAdminRule"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="commitOn"> Deployment time string. </param>
        /// <param name="region"> Deployment region. </param>
        /// <param name="configurationDescription"> A description of the security admin configuration. </param>
        /// <param name="ruleCollectionDescription"> A description of the rule collection. </param>
        /// <param name="ruleCollectionAppliesToGroups"> Groups for rule collection. </param>
        /// <param name="ruleGroups"> Effective configuration groups. </param>
        /// <param name="kind"> Whether the rule is custom or default. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ActiveBaseSecurityAdminRule(string id, DateTimeOffset? commitOn, string region, string configurationDescription, string ruleCollectionDescription, IReadOnlyList<NetworkManagerSecurityGroupItem> ruleCollectionAppliesToGroups, IReadOnlyList<NetworkConfigurationGroup> ruleGroups, EffectiveAdminRuleKind kind, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            CommitOn = commitOn;
            Region = region;
            ConfigurationDescription = configurationDescription;
            RuleCollectionDescription = ruleCollectionDescription;
            RuleCollectionAppliesToGroups = ruleCollectionAppliesToGroups;
            RuleGroups = ruleGroups;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> Resource ID. </summary>
        public string Id { get; }
        /// <summary> Deployment time string. </summary>
        public DateTimeOffset? CommitOn { get; }
        /// <summary> Deployment region. </summary>
        public string Region { get; }
        /// <summary> A description of the security admin configuration. </summary>
        public string ConfigurationDescription { get; }
        /// <summary> A description of the rule collection. </summary>
        public string RuleCollectionDescription { get; }
        /// <summary> Groups for rule collection. </summary>
        public IReadOnlyList<NetworkManagerSecurityGroupItem> RuleCollectionAppliesToGroups { get; }
        /// <summary> Effective configuration groups. </summary>
        public IReadOnlyList<NetworkConfigurationGroup> RuleGroups { get; }
        /// <summary> Whether the rule is custom or default. </summary>
        internal EffectiveAdminRuleKind Kind { get; set; }
    }
}
