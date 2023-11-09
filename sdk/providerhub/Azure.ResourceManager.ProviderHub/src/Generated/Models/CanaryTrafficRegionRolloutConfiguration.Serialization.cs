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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class CanaryTrafficRegionRolloutConfiguration : IUtf8JsonSerializable, IJsonModel<CanaryTrafficRegionRolloutConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CanaryTrafficRegionRolloutConfiguration>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<CanaryTrafficRegionRolloutConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SkipRegions))
            {
                writer.WritePropertyName("skipRegions"u8);
                writer.WriteStartArray();
                foreach (var item in SkipRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Regions))
            {
                writer.WritePropertyName("regions"u8);
                writer.WriteStartArray();
                foreach (var item in Regions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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

        CanaryTrafficRegionRolloutConfiguration IJsonModel<CanaryTrafficRegionRolloutConfiguration>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CanaryTrafficRegionRolloutConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCanaryTrafficRegionRolloutConfiguration(document.RootElement, options);
        }

        internal static CanaryTrafficRegionRolloutConfiguration DeserializeCanaryTrafficRegionRolloutConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AzureLocation>> skipRegions = default;
            Optional<IList<AzureLocation>> regions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    skipRegions = array;
                    continue;
                }
                if (property.NameEquals("regions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    regions = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CanaryTrafficRegionRolloutConfiguration(Optional.ToList(skipRegions), Optional.ToList(regions), serializedAdditionalRawData);
        }

        BinaryData IModel<CanaryTrafficRegionRolloutConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CanaryTrafficRegionRolloutConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        CanaryTrafficRegionRolloutConfiguration IModel<CanaryTrafficRegionRolloutConfiguration>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CanaryTrafficRegionRolloutConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeCanaryTrafficRegionRolloutConfiguration(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<CanaryTrafficRegionRolloutConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
