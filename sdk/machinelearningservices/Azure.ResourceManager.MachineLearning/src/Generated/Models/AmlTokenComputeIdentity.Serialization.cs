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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AmlTokenComputeIdentity : IUtf8JsonSerializable, IJsonModel<AmlTokenComputeIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmlTokenComputeIdentity>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AmlTokenComputeIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AmlTokenComputeIdentity>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AmlTokenComputeIdentity>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("computeIdentityType"u8);
            writer.WriteStringValue(ComputeIdentityType.ToString());
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

        AmlTokenComputeIdentity IJsonModel<AmlTokenComputeIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AmlTokenComputeIdentity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlTokenComputeIdentity(document.RootElement, options);
        }

        internal static AmlTokenComputeIdentity DeserializeAmlTokenComputeIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitorComputeIdentityType computeIdentityType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeIdentityType"u8))
                {
                    computeIdentityType = new MonitorComputeIdentityType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AmlTokenComputeIdentity(computeIdentityType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AmlTokenComputeIdentity>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AmlTokenComputeIdentity)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AmlTokenComputeIdentity IPersistableModel<AmlTokenComputeIdentity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AmlTokenComputeIdentity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAmlTokenComputeIdentity(document.RootElement, options);
        }

        string IPersistableModel<AmlTokenComputeIdentity>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
