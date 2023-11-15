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
    public partial class MachineLearningContainerResourceSettings : IUtf8JsonSerializable, IJsonModel<MachineLearningContainerResourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningContainerResourceSettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MachineLearningContainerResourceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MachineLearningContainerResourceSettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MachineLearningContainerResourceSettings>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Cpu))
            {
                if (Cpu != null)
                {
                    writer.WritePropertyName("cpu"u8);
                    writer.WriteStringValue(Cpu);
                }
                else
                {
                    writer.WriteNull("cpu");
                }
            }
            if (Optional.IsDefined(Gpu))
            {
                if (Gpu != null)
                {
                    writer.WritePropertyName("gpu"u8);
                    writer.WriteStringValue(Gpu);
                }
                else
                {
                    writer.WriteNull("gpu");
                }
            }
            if (Optional.IsDefined(Memory))
            {
                if (Memory != null)
                {
                    writer.WritePropertyName("memory"u8);
                    writer.WriteStringValue(Memory);
                }
                else
                {
                    writer.WriteNull("memory");
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

        MachineLearningContainerResourceSettings IJsonModel<MachineLearningContainerResourceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningContainerResourceSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningContainerResourceSettings(document.RootElement, options);
        }

        internal static MachineLearningContainerResourceSettings DeserializeMachineLearningContainerResourceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cpu = default;
            Optional<string> gpu = default;
            Optional<string> memory = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cpu = null;
                        continue;
                    }
                    cpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        gpu = null;
                        continue;
                    }
                    gpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        memory = null;
                        continue;
                    }
                    memory = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningContainerResourceSettings(cpu.Value, gpu.Value, memory.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningContainerResourceSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningContainerResourceSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningContainerResourceSettings IPersistableModel<MachineLearningContainerResourceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningContainerResourceSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningContainerResourceSettings(document.RootElement, options);
        }

        string IPersistableModel<MachineLearningContainerResourceSettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
