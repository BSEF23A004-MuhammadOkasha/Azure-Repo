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
    public partial class MachineLearningDeploymentResourceConfiguration : IUtf8JsonSerializable, IJsonModel<MachineLearningDeploymentResourceConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningDeploymentResourceConfiguration>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MachineLearningDeploymentResourceConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MachineLearningDeploymentResourceConfiguration>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MachineLearningDeploymentResourceConfiguration>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InstanceCount))
            {
                writer.WritePropertyName("instanceCount"u8);
                writer.WriteNumberValue(InstanceCount.Value);
            }
            if (Optional.IsDefined(InstanceType))
            {
                if (InstanceType != null)
                {
                    writer.WritePropertyName("instanceType"u8);
                    writer.WriteStringValue(InstanceType);
                }
                else
                {
                    writer.WriteNull("instanceType");
                }
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                if (Locations != null)
                {
                    writer.WritePropertyName("locations"u8);
                    writer.WriteStartArray();
                    foreach (var item in Locations)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("locations");
                }
            }
            if (Optional.IsDefined(MaxInstanceCount))
            {
                if (MaxInstanceCount != null)
                {
                    writer.WritePropertyName("maxInstanceCount"u8);
                    writer.WriteNumberValue(MaxInstanceCount.Value);
                }
                else
                {
                    writer.WriteNull("maxInstanceCount");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        if (item.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                        using (JsonDocument document = JsonDocument.Parse(item.Value))
                        {
                            JsonSerializer.Serialize(writer, document.RootElement);
                        }
#endif
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
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

        MachineLearningDeploymentResourceConfiguration IJsonModel<MachineLearningDeploymentResourceConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningDeploymentResourceConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningDeploymentResourceConfiguration(document.RootElement, options);
        }

        internal static MachineLearningDeploymentResourceConfiguration DeserializeMachineLearningDeploymentResourceConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> instanceCount = default;
            Optional<string> instanceType = default;
            Optional<IList<string>> locations = default;
            Optional<int?> maxInstanceCount = default;
            Optional<IDictionary<string, BinaryData>> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        instanceType = null;
                        continue;
                    }
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        locations = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("maxInstanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxInstanceCount = null;
                        continue;
                    }
                    maxInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningDeploymentResourceConfiguration(Optional.ToNullable(instanceCount), instanceType.Value, Optional.ToList(locations), Optional.ToNullable(maxInstanceCount), Optional.ToDictionary(properties), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningDeploymentResourceConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningDeploymentResourceConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningDeploymentResourceConfiguration IPersistableModel<MachineLearningDeploymentResourceConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningDeploymentResourceConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningDeploymentResourceConfiguration(document.RootElement, options);
        }

        string IPersistableModel<MachineLearningDeploymentResourceConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
