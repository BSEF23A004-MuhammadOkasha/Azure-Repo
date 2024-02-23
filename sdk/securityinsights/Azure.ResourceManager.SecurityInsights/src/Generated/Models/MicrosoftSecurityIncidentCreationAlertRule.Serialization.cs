// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class MicrosoftSecurityIncidentCreationAlertRule : IUtf8JsonSerializable, IJsonModel<MicrosoftSecurityIncidentCreationAlertRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MicrosoftSecurityIncidentCreationAlertRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MicrosoftSecurityIncidentCreationAlertRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftSecurityIncidentCreationAlertRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MicrosoftSecurityIncidentCreationAlertRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (!(DisplayNamesFilter is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("displayNamesFilter"u8);
                writer.WriteStartArray();
                foreach (var item in DisplayNamesFilter)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(DisplayNamesExcludeFilter is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("displayNamesExcludeFilter"u8);
                writer.WriteStartArray();
                foreach (var item in DisplayNamesExcludeFilter)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (ProductFilter.HasValue)
            {
                writer.WritePropertyName("productFilter"u8);
                writer.WriteStringValue(ProductFilter.Value.ToString());
            }
            if (!(SeveritiesFilter is ChangeTrackingList<SecurityInsightsAlertSeverity> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("severitiesFilter"u8);
                writer.WriteStartArray();
                foreach (var item in SeveritiesFilter)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (AlertRuleTemplateName != null)
            {
                writer.WritePropertyName("alertRuleTemplateName"u8);
                writer.WriteStringValue(AlertRuleTemplateName);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (options.Format != "W" && LastModifiedOn.HasValue)
            {
                writer.WritePropertyName("lastModifiedUtc"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            writer.WriteEndObject();
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

        MicrosoftSecurityIncidentCreationAlertRule IJsonModel<MicrosoftSecurityIncidentCreationAlertRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftSecurityIncidentCreationAlertRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MicrosoftSecurityIncidentCreationAlertRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMicrosoftSecurityIncidentCreationAlertRule(document.RootElement, options);
        }

        internal static MicrosoftSecurityIncidentCreationAlertRule DeserializeMicrosoftSecurityIncidentCreationAlertRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AlertRuleKind kind = default;
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            IList<string> displayNamesFilter = default;
            IList<string> displayNamesExcludeFilter = default;
            Optional<MicrosoftSecurityProductName> productFilter = default;
            IList<SecurityInsightsAlertSeverity> severitiesFilter = default;
            Optional<string> alertRuleTemplateName = default;
            Optional<string> description = default;
            Optional<string> displayName = default;
            Optional<bool> enabled = default;
            Optional<DateTimeOffset> lastModifiedUtc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AlertRuleKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayNamesFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            displayNamesFilter = array;
                            continue;
                        }
                        if (property0.NameEquals("displayNamesExcludeFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            displayNamesExcludeFilter = array;
                            continue;
                        }
                        if (property0.NameEquals("productFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            productFilter = new MicrosoftSecurityProductName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("severitiesFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAlertSeverity> array = new List<SecurityInsightsAlertSeverity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityInsightsAlertSeverity(item.GetString()));
                            }
                            severitiesFilter = array;
                            continue;
                        }
                        if (property0.NameEquals("alertRuleTemplateName"u8))
                        {
                            alertRuleTemplateName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MicrosoftSecurityIncidentCreationAlertRule(id, name, type, systemData.Value, kind, Optional.ToNullable(etag), serializedAdditionalRawData, displayNamesFilter ?? new ChangeTrackingList<string>(), displayNamesExcludeFilter ?? new ChangeTrackingList<string>(), Optional.ToNullable(productFilter), severitiesFilter ?? new ChangeTrackingList<SecurityInsightsAlertSeverity>(), alertRuleTemplateName.Value, description.Value, displayName.Value, Optional.ToNullable(enabled), Optional.ToNullable(lastModifiedUtc));
        }

        BinaryData IPersistableModel<MicrosoftSecurityIncidentCreationAlertRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftSecurityIncidentCreationAlertRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MicrosoftSecurityIncidentCreationAlertRule)} does not support '{options.Format}' format.");
            }
        }

        MicrosoftSecurityIncidentCreationAlertRule IPersistableModel<MicrosoftSecurityIncidentCreationAlertRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftSecurityIncidentCreationAlertRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMicrosoftSecurityIncidentCreationAlertRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MicrosoftSecurityIncidentCreationAlertRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MicrosoftSecurityIncidentCreationAlertRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
