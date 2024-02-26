// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class MachineExtensionUpgrade : IUtf8JsonSerializable, IJsonModel<MachineExtensionUpgrade>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineExtensionUpgrade>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineExtensionUpgrade>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineExtensionUpgrade>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineExtensionUpgrade)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(ExtensionTargets is ChangeTrackingDictionary<string, ExtensionTargetProperties> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("extensionTargets"u8);
                writer.WriteStartObject();
                foreach (var item in ExtensionTargets)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        MachineExtensionUpgrade IJsonModel<MachineExtensionUpgrade>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineExtensionUpgrade>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineExtensionUpgrade)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineExtensionUpgrade(document.RootElement, options);
        }

        internal static MachineExtensionUpgrade DeserializeMachineExtensionUpgrade(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, ExtensionTargetProperties> extensionTargets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extensionTargets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ExtensionTargetProperties> dictionary = new Dictionary<string, ExtensionTargetProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ExtensionTargetProperties.DeserializeExtensionTargetProperties(property0.Value, options));
                    }
                    extensionTargets = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineExtensionUpgrade(extensionTargets ?? new ChangeTrackingDictionary<string, ExtensionTargetProperties>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineExtensionUpgrade>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineExtensionUpgrade>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineExtensionUpgrade)} does not support '{options.Format}' format.");
            }
        }

        MachineExtensionUpgrade IPersistableModel<MachineExtensionUpgrade>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineExtensionUpgrade>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineExtensionUpgrade(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineExtensionUpgrade)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineExtensionUpgrade>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
