// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseManagedVirtualNetworkSettings : IUtf8JsonSerializable, IJsonModel<SynapseManagedVirtualNetworkSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseManagedVirtualNetworkSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseManagedVirtualNetworkSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedVirtualNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseManagedVirtualNetworkSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PreventDataExfiltration.HasValue)
            {
                writer.WritePropertyName("preventDataExfiltration"u8);
                writer.WriteBooleanValue(PreventDataExfiltration.Value);
            }
            if (EnableLinkedAccessCheckOnTargetResource.HasValue)
            {
                writer.WritePropertyName("linkedAccessCheckOnTargetResource"u8);
                writer.WriteBooleanValue(EnableLinkedAccessCheckOnTargetResource.Value);
            }
            if (!(AllowedAadTenantIdsForLinking is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allowedAadTenantIdsForLinking"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedAadTenantIdsForLinking)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        SynapseManagedVirtualNetworkSettings IJsonModel<SynapseManagedVirtualNetworkSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedVirtualNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseManagedVirtualNetworkSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseManagedVirtualNetworkSettings(document.RootElement, options);
        }

        internal static SynapseManagedVirtualNetworkSettings DeserializeSynapseManagedVirtualNetworkSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? preventDataExfiltration = default;
            bool? linkedAccessCheckOnTargetResource = default;
            IList<string> allowedAadTenantIdsForLinking = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preventDataExfiltration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preventDataExfiltration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("linkedAccessCheckOnTargetResource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedAccessCheckOnTargetResource = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedAadTenantIdsForLinking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedAadTenantIdsForLinking = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseManagedVirtualNetworkSettings(preventDataExfiltration, linkedAccessCheckOnTargetResource, allowedAadTenantIdsForLinking ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseManagedVirtualNetworkSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedVirtualNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseManagedVirtualNetworkSettings)} does not support '{options.Format}' format.");
            }
        }

        SynapseManagedVirtualNetworkSettings IPersistableModel<SynapseManagedVirtualNetworkSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedVirtualNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseManagedVirtualNetworkSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseManagedVirtualNetworkSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseManagedVirtualNetworkSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
