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

namespace Azure.ResourceManager.HybridContainerService.Models
{
    internal partial class ProvisionedClustersCommonPropertiesFeatures : IUtf8JsonSerializable, IJsonModel<ProvisionedClustersCommonPropertiesFeatures>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProvisionedClustersCommonPropertiesFeatures>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ProvisionedClustersCommonPropertiesFeatures>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ProvisionedClustersCommonPropertiesFeatures>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ProvisionedClustersCommonPropertiesFeatures>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ArcAgentProfile))
            {
                writer.WritePropertyName("arcAgentProfile"u8);
                writer.WriteObjectValue(ArcAgentProfile);
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

        ProvisionedClustersCommonPropertiesFeatures IJsonModel<ProvisionedClustersCommonPropertiesFeatures>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProvisionedClustersCommonPropertiesFeatures)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProvisionedClustersCommonPropertiesFeatures(document.RootElement, options);
        }

        internal static ProvisionedClustersCommonPropertiesFeatures DeserializeProvisionedClustersCommonPropertiesFeatures(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArcAgentProfile> arcAgentProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("arcAgentProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arcAgentProfile = ArcAgentProfile.DeserializeArcAgentProfile(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProvisionedClustersCommonPropertiesFeatures(arcAgentProfile.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProvisionedClustersCommonPropertiesFeatures>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProvisionedClustersCommonPropertiesFeatures)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ProvisionedClustersCommonPropertiesFeatures IPersistableModel<ProvisionedClustersCommonPropertiesFeatures>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProvisionedClustersCommonPropertiesFeatures)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeProvisionedClustersCommonPropertiesFeatures(document.RootElement, options);
        }

        string IPersistableModel<ProvisionedClustersCommonPropertiesFeatures>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
