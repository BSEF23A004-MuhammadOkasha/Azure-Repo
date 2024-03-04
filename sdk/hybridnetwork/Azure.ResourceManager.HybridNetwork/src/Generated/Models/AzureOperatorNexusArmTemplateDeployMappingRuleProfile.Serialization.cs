// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureOperatorNexusArmTemplateDeployMappingRuleProfile : IUtf8JsonSerializable, IJsonModel<AzureOperatorNexusArmTemplateDeployMappingRuleProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureOperatorNexusArmTemplateDeployMappingRuleProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureOperatorNexusArmTemplateDeployMappingRuleProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusArmTemplateDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusArmTemplateDeployMappingRuleProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TemplateMappingRuleProfile))
            {
                writer.WritePropertyName("templateMappingRuleProfile"u8);
                writer.WriteObjectValue(TemplateMappingRuleProfile);
            }
            if (Optional.IsDefined(ApplicationEnablement))
            {
                writer.WritePropertyName("applicationEnablement"u8);
                writer.WriteStringValue(ApplicationEnablement.Value.ToString());
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

        AzureOperatorNexusArmTemplateDeployMappingRuleProfile IJsonModel<AzureOperatorNexusArmTemplateDeployMappingRuleProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusArmTemplateDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusArmTemplateDeployMappingRuleProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureOperatorNexusArmTemplateDeployMappingRuleProfile(document.RootElement, options);
        }

        internal static AzureOperatorNexusArmTemplateDeployMappingRuleProfile DeserializeAzureOperatorNexusArmTemplateDeployMappingRuleProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ArmTemplateMappingRuleProfile templateMappingRuleProfile = default;
            ApplicationEnablement? applicationEnablement = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateMappingRuleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateMappingRuleProfile = ArmTemplateMappingRuleProfile.DeserializeArmTemplateMappingRuleProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("applicationEnablement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationEnablement = new ApplicationEnablement(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureOperatorNexusArmTemplateDeployMappingRuleProfile(applicationEnablement, serializedAdditionalRawData, templateMappingRuleProfile);
        }

        BinaryData IPersistableModel<AzureOperatorNexusArmTemplateDeployMappingRuleProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusArmTemplateDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusArmTemplateDeployMappingRuleProfile)} does not support '{options.Format}' format.");
            }
        }

        AzureOperatorNexusArmTemplateDeployMappingRuleProfile IPersistableModel<AzureOperatorNexusArmTemplateDeployMappingRuleProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusArmTemplateDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureOperatorNexusArmTemplateDeployMappingRuleProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusArmTemplateDeployMappingRuleProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureOperatorNexusArmTemplateDeployMappingRuleProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
