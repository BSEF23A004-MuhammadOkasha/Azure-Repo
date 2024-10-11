// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForServersAwsOfferingArcAutoProvisioningConfiguration : IUtf8JsonSerializable, IJsonModel<DefenderForServersAwsOfferingArcAutoProvisioningConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForServersAwsOfferingArcAutoProvisioningConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DefenderForServersAwsOfferingArcAutoProvisioningConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersAwsOfferingArcAutoProvisioningConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForServersAwsOfferingArcAutoProvisioningConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Proxy))
            {
                writer.WritePropertyName("proxy"u8);
                writer.WriteStringValue(Proxy);
            }
            if (Optional.IsDefined(PrivateLinkScope))
            {
                writer.WritePropertyName("privateLinkScope"u8);
                writer.WriteStringValue(PrivateLinkScope);
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
        }

        DefenderForServersAwsOfferingArcAutoProvisioningConfiguration IJsonModel<DefenderForServersAwsOfferingArcAutoProvisioningConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersAwsOfferingArcAutoProvisioningConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForServersAwsOfferingArcAutoProvisioningConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForServersAwsOfferingArcAutoProvisioningConfiguration(document.RootElement, options);
        }

        internal static DefenderForServersAwsOfferingArcAutoProvisioningConfiguration DeserializeDefenderForServersAwsOfferingArcAutoProvisioningConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string proxy = default;
            string privateLinkScope = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("proxy"u8))
                {
                    proxy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateLinkScope"u8))
                {
                    privateLinkScope = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DefenderForServersAwsOfferingArcAutoProvisioningConfiguration(proxy, privateLinkScope, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderForServersAwsOfferingArcAutoProvisioningConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersAwsOfferingArcAutoProvisioningConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderForServersAwsOfferingArcAutoProvisioningConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderForServersAwsOfferingArcAutoProvisioningConfiguration IPersistableModel<DefenderForServersAwsOfferingArcAutoProvisioningConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersAwsOfferingArcAutoProvisioningConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderForServersAwsOfferingArcAutoProvisioningConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForServersAwsOfferingArcAutoProvisioningConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForServersAwsOfferingArcAutoProvisioningConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
