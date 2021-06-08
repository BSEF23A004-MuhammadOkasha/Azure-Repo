// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    public partial class PolicySetDefinitionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicyType))
            {
                writer.WritePropertyName("policyType");
                writer.WriteStringValue(PolicyType.Value.ToString());
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteObjectValue(Metadata);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(PolicyDefinitions))
            {
                writer.WritePropertyName("policyDefinitions");
                writer.WriteStartArray();
                foreach (var item in PolicyDefinitions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PolicyDefinitionGroups))
            {
                writer.WritePropertyName("policyDefinitionGroups");
                writer.WriteStartArray();
                foreach (var item in PolicyDefinitionGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PolicySetDefinitionData DeserializePolicySetDefinitionData(JsonElement element)
        {
            ResourceGroupResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<PolicyType> policyType = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<object> metadata = default;
            Optional<IDictionary<string, ParameterDefinitionsValue>> parameters = default;
            Optional<IList<PolicyDefinitionReference>> policyDefinitions = default;
            Optional<IList<PolicyDefinitionGroup>> policyDefinitionGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("policyType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            policyType = new PolicyType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            metadata = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("parameters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, ParameterDefinitionsValue> dictionary = new Dictionary<string, ParameterDefinitionsValue>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ParameterDefinitionsValue.DeserializeParameterDefinitionsValue(property1.Value));
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PolicyDefinitionReference> array = new List<PolicyDefinitionReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PolicyDefinitionReference.DeserializePolicyDefinitionReference(item));
                            }
                            policyDefinitions = array;
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitionGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PolicyDefinitionGroup> array = new List<PolicyDefinitionGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PolicyDefinitionGroup.DeserializePolicyDefinitionGroup(item));
                            }
                            policyDefinitionGroups = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PolicySetDefinitionData(id, name, type, Optional.ToNullable(policyType), displayName.Value, description.Value, metadata.Value, Optional.ToDictionary(parameters), Optional.ToList(policyDefinitions), Optional.ToList(policyDefinitionGroups));
        }
    }
}
