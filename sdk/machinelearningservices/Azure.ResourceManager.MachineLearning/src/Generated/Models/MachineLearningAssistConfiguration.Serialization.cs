// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownMLAssistConfiguration))]
    public partial class MachineLearningAssistConfiguration : IUtf8JsonSerializable, IJsonModel<MachineLearningAssistConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningAssistConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningAssistConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAssistConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAssistConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("mlAssist"u8);
            writer.WriteStringValue(MlAssist.ToString());
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

        MachineLearningAssistConfiguration IJsonModel<MachineLearningAssistConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAssistConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAssistConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAssistConfiguration(document.RootElement, options);
        }

        internal static MachineLearningAssistConfiguration DeserializeMachineLearningAssistConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("mlAssist", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Disabled": return MLAssistConfigurationDisabled.DeserializeMLAssistConfigurationDisabled(element, options);
                    case "Enabled": return MachineLearningAssistEnabledConfiguration.DeserializeMachineLearningAssistEnabledConfiguration(element, options);
                }
            }
            return UnknownMLAssistConfiguration.DeserializeUnknownMLAssistConfiguration(element, options);
        }

        BinaryData IPersistableModel<MachineLearningAssistConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAssistConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAssistConfiguration)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningAssistConfiguration IPersistableModel<MachineLearningAssistConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAssistConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningAssistConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAssistConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningAssistConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
