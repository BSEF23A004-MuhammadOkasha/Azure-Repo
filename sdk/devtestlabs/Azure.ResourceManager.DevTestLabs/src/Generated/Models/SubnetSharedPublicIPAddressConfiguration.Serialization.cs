// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    internal partial class SubnetSharedPublicIPAddressConfiguration : IUtf8JsonSerializable, IJsonModel<SubnetSharedPublicIPAddressConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubnetSharedPublicIPAddressConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SubnetSharedPublicIPAddressConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubnetSharedPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubnetSharedPublicIPAddressConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedPorts))
            {
                writer.WritePropertyName("allowedPorts"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedPorts)
                {
                    writer.WriteObjectValue(item);
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

        SubnetSharedPublicIPAddressConfiguration IJsonModel<SubnetSharedPublicIPAddressConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubnetSharedPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubnetSharedPublicIPAddressConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubnetSharedPublicIPAddressConfiguration(document.RootElement, options);
        }

        internal static SubnetSharedPublicIPAddressConfiguration DeserializeSubnetSharedPublicIPAddressConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DevTestLabPort> allowedPorts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevTestLabPort> array = new List<DevTestLabPort>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabPort.DeserializeDevTestLabPort(item, options));
                    }
                    allowedPorts = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SubnetSharedPublicIPAddressConfiguration(allowedPorts ?? new ChangeTrackingList<DevTestLabPort>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubnetSharedPublicIPAddressConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubnetSharedPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SubnetSharedPublicIPAddressConfiguration)} does not support '{options.Format}' format.");
            }
        }

        SubnetSharedPublicIPAddressConfiguration IPersistableModel<SubnetSharedPublicIPAddressConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubnetSharedPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSubnetSharedPublicIPAddressConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubnetSharedPublicIPAddressConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubnetSharedPublicIPAddressConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
