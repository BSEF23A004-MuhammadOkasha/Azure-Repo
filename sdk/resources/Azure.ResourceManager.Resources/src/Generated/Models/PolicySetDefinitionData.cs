// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the PolicySetDefinition data model. </summary>
    public partial class PolicySetDefinitionData : Resource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of PolicySetDefinitionData. </summary>
        public PolicySetDefinitionData()
        {
            Parameters = new ChangeTrackingDictionary<string, ParameterDefinitionsValue>();
            PolicyDefinitions = new ChangeTrackingList<PolicyDefinitionReference>();
            PolicyDefinitionGroups = new ChangeTrackingList<PolicyDefinitionGroup>();
        }

        /// <summary> Initializes a new instance of PolicySetDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="policyType"> The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static. </param>
        /// <param name="displayName"> The display name of the policy set definition. </param>
        /// <param name="description"> The policy set definition description. </param>
        /// <param name="metadata"> The policy set definition metadata.  Metadata is an open ended object and is typically a collection of key value pairs. </param>
        /// <param name="parameters"> The policy set definition parameters that can be used in policy definition references. </param>
        /// <param name="policyDefinitions"> An array of policy definition references. </param>
        /// <param name="policyDefinitionGroups"> The metadata describing groups of policy definition references within the policy set definition. </param>
        internal PolicySetDefinitionData(ResourceGroupResourceIdentifier id, string name, ResourceType type, PolicyType? policyType, string displayName, string description, object metadata, IDictionary<string, ParameterDefinitionsValue> parameters, IList<PolicyDefinitionReference> policyDefinitions, IList<PolicyDefinitionGroup> policyDefinitionGroups) : base(id, name, type)
        {
            PolicyType = policyType;
            DisplayName = displayName;
            Description = description;
            Metadata = metadata;
            Parameters = parameters;
            PolicyDefinitions = policyDefinitions;
            PolicyDefinitionGroups = policyDefinitionGroups;
        }

        /// <summary> The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static. </summary>
        public PolicyType? PolicyType { get; set; }
        /// <summary> The display name of the policy set definition. </summary>
        public string DisplayName { get; set; }
        /// <summary> The policy set definition description. </summary>
        public string Description { get; set; }
        /// <summary> The policy set definition metadata.  Metadata is an open ended object and is typically a collection of key value pairs. </summary>
        public object Metadata { get; set; }
        /// <summary> The policy set definition parameters that can be used in policy definition references. </summary>
        public IDictionary<string, ParameterDefinitionsValue> Parameters { get; }
        /// <summary> An array of policy definition references. </summary>
        public IList<PolicyDefinitionReference> PolicyDefinitions { get; }
        /// <summary> The metadata describing groups of policy definition references within the policy set definition. </summary>
        public IList<PolicyDefinitionGroup> PolicyDefinitionGroups { get; }
    }
}
