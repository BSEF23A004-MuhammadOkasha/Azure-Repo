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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkQosPolicy : IUtf8JsonSerializable, IJsonModel<MobileNetworkQosPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkQosPolicy>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MobileNetworkQosPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FiveQi))
            {
                writer.WritePropertyName("5qi"u8);
                writer.WriteNumberValue(FiveQi.Value);
            }
            if (Optional.IsDefined(AllocationAndRetentionPriorityLevel))
            {
                writer.WritePropertyName("allocationAndRetentionPriorityLevel"u8);
                writer.WriteNumberValue(AllocationAndRetentionPriorityLevel.Value);
            }
            if (Optional.IsDefined(PreemptionCapability))
            {
                writer.WritePropertyName("preemptionCapability"u8);
                writer.WriteStringValue(PreemptionCapability.Value.ToString());
            }
            if (Optional.IsDefined(PreemptionVulnerability))
            {
                writer.WritePropertyName("preemptionVulnerability"u8);
                writer.WriteStringValue(PreemptionVulnerability.Value.ToString());
            }
            writer.WritePropertyName("maximumBitRate"u8);
            writer.WriteObjectValue(MaximumBitRate);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        MobileNetworkQosPolicy IJsonModel<MobileNetworkQosPolicy>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MobileNetworkQosPolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkQosPolicy(document.RootElement, options);
        }

        internal static MobileNetworkQosPolicy DeserializeMobileNetworkQosPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> _5qi = default;
            Optional<int> allocationAndRetentionPriorityLevel = default;
            Optional<MobileNetworkPreemptionCapability> preemptionCapability = default;
            Optional<MobileNetworkPreemptionVulnerability> preemptionVulnerability = default;
            Ambr maximumBitRate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("5qi"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    _5qi = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allocationAndRetentionPriorityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationAndRetentionPriorityLevel = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("preemptionCapability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preemptionCapability = new MobileNetworkPreemptionCapability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("preemptionVulnerability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preemptionVulnerability = new MobileNetworkPreemptionVulnerability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maximumBitRate"u8))
                {
                    maximumBitRate = Ambr.DeserializeAmbr(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MobileNetworkQosPolicy(Optional.ToNullable(_5qi), Optional.ToNullable(allocationAndRetentionPriorityLevel), Optional.ToNullable(preemptionCapability), Optional.ToNullable(preemptionVulnerability), maximumBitRate, serializedAdditionalRawData);
        }

        BinaryData IModel<MobileNetworkQosPolicy>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MobileNetworkQosPolicy)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MobileNetworkQosPolicy IModel<MobileNetworkQosPolicy>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MobileNetworkQosPolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMobileNetworkQosPolicy(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MobileNetworkQosPolicy>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
