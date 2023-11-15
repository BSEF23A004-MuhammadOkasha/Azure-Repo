// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class StreamingPolicyFairPlayConfiguration : IUtf8JsonSerializable, IJsonModel<StreamingPolicyFairPlayConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingPolicyFairPlayConfiguration>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<StreamingPolicyFairPlayConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<StreamingPolicyFairPlayConfiguration>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<StreamingPolicyFairPlayConfiguration>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CustomLicenseAcquisitionUriTemplate))
            {
                writer.WritePropertyName("customLicenseAcquisitionUrlTemplate"u8);
                writer.WriteStringValue(CustomLicenseAcquisitionUriTemplate);
            }
            writer.WritePropertyName("allowPersistentLicense"u8);
            writer.WriteBooleanValue(AllowPersistentLicense);
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        StreamingPolicyFairPlayConfiguration IJsonModel<StreamingPolicyFairPlayConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StreamingPolicyFairPlayConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingPolicyFairPlayConfiguration(document.RootElement, options);
        }

        internal static StreamingPolicyFairPlayConfiguration DeserializeStreamingPolicyFairPlayConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> customLicenseAcquisitionUriTemplate = default;
            bool allowPersistentLicense = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customLicenseAcquisitionUrlTemplate"u8))
                {
                    customLicenseAcquisitionUriTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowPersistentLicense"u8))
                {
                    allowPersistentLicense = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamingPolicyFairPlayConfiguration(customLicenseAcquisitionUriTemplate.Value, allowPersistentLicense, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingPolicyFairPlayConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StreamingPolicyFairPlayConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        StreamingPolicyFairPlayConfiguration IPersistableModel<StreamingPolicyFairPlayConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StreamingPolicyFairPlayConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeStreamingPolicyFairPlayConfiguration(document.RootElement, options);
        }

        string IPersistableModel<StreamingPolicyFairPlayConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
