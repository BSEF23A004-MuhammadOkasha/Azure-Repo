// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(EncryptionDetailsConverter))]
    public partial class EncryptionDetails : IUtf8JsonSerializable, IJsonModel<EncryptionDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EncryptionDetails>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<EncryptionDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<EncryptionDetails>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<EncryptionDetails>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DoubleEncryptionEnabled))
                {
                    writer.WritePropertyName("doubleEncryptionEnabled"u8);
                    writer.WriteBooleanValue(DoubleEncryptionEnabled.Value);
                }
            }
            if (Optional.IsDefined(Cmk))
            {
                writer.WritePropertyName("cmk"u8);
                writer.WriteObjectValue(Cmk);
            }
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

        EncryptionDetails IJsonModel<EncryptionDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EncryptionDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEncryptionDetails(document.RootElement, options);
        }

        internal static EncryptionDetails DeserializeEncryptionDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> doubleEncryptionEnabled = default;
            Optional<CustomerManagedKeyDetails> cmk = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("doubleEncryptionEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    doubleEncryptionEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cmk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cmk = CustomerManagedKeyDetails.DeserializeCustomerManagedKeyDetails(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EncryptionDetails(Optional.ToNullable(doubleEncryptionEnabled), cmk.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EncryptionDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EncryptionDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        EncryptionDetails IPersistableModel<EncryptionDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EncryptionDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeEncryptionDetails(document.RootElement, options);
        }

        string IPersistableModel<EncryptionDetails>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class EncryptionDetailsConverter : JsonConverter<EncryptionDetails>
        {
            public override void Write(Utf8JsonWriter writer, EncryptionDetails model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EncryptionDetails Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEncryptionDetails(document.RootElement);
            }
        }
    }
}
