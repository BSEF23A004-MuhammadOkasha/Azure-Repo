// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementPolicyEnablementRule : IUtf8JsonSerializable, IJsonModel<RoleManagementPolicyEnablementRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleManagementPolicyEnablementRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoleManagementPolicyEnablementRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyEnablementRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementPolicyEnablementRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(EnablementRules))
            {
                writer.WritePropertyName("enabledRules"u8);
                writer.WriteStartArray();
                foreach (var item in EnablementRules)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType.ToString());
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteObjectValue(Target);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RoleManagementPolicyEnablementRule IJsonModel<RoleManagementPolicyEnablementRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyEnablementRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementPolicyEnablementRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleManagementPolicyEnablementRule(document.RootElement, options);
        }

        internal static RoleManagementPolicyEnablementRule DeserializeRoleManagementPolicyEnablementRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<RoleAssignmentEnablementRuleType>> enabledRules = default;
            Optional<string> id = default;
            RoleManagementPolicyRuleType ruleType = default;
            Optional<RoleManagementPolicyRuleTarget> target = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabledRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoleAssignmentEnablementRuleType> array = new List<RoleAssignmentEnablementRuleType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new RoleAssignmentEnablementRuleType(item.GetString()));
                    }
                    enabledRules = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = new RoleManagementPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = RoleManagementPolicyRuleTarget.DeserializeRoleManagementPolicyRuleTarget(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RoleManagementPolicyEnablementRule(id.Value, ruleType, target.Value, serializedAdditionalRawData, Optional.ToList(enabledRules));
        }

        BinaryData IPersistableModel<RoleManagementPolicyEnablementRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyEnablementRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoleManagementPolicyEnablementRule)} does not support '{options.Format}' format.");
            }
        }

        RoleManagementPolicyEnablementRule IPersistableModel<RoleManagementPolicyEnablementRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyEnablementRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoleManagementPolicyEnablementRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoleManagementPolicyEnablementRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoleManagementPolicyEnablementRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
