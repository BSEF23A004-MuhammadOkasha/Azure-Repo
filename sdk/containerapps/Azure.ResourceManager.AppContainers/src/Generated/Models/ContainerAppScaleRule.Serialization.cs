// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppScaleRule : IUtf8JsonSerializable, IJsonModel<ContainerAppScaleRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppScaleRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppScaleRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppScaleRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AzureQueue))
            {
                writer.WritePropertyName("azureQueue"u8);
                writer.WriteObjectValue(AzureQueue);
            }
            if (Optional.IsDefined(Custom))
            {
                writer.WritePropertyName("custom"u8);
                writer.WriteObjectValue(Custom);
            }
            if (Optional.IsDefined(Http))
            {
                writer.WritePropertyName("http"u8);
                writer.WriteObjectValue(Http);
            }
            if (Optional.IsDefined(Tcp))
            {
                writer.WritePropertyName("tcp"u8);
                writer.WriteObjectValue(Tcp);
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
            writer.WriteEndObject();
        }

        ContainerAppScaleRule IJsonModel<ContainerAppScaleRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppScaleRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppScaleRule(document.RootElement, options);
        }

        internal static ContainerAppScaleRule DeserializeContainerAppScaleRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ContainerAppQueueScaleRule azureQueue = default;
            ContainerAppCustomScaleRule custom = default;
            ContainerAppHttpScaleRule http = default;
            ContainerAppTcpScaleRule tcp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureQueue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureQueue = ContainerAppQueueScaleRule.DeserializeContainerAppQueueScaleRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("custom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    custom = ContainerAppCustomScaleRule.DeserializeContainerAppCustomScaleRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("http"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    http = ContainerAppHttpScaleRule.DeserializeContainerAppHttpScaleRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tcp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcp = ContainerAppTcpScaleRule.DeserializeContainerAppTcpScaleRule(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppScaleRule(
                name,
                azureQueue,
                custom,
                http,
                tcp,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (Optional.IsDefined(Name) || hasPropertyOverride)
            {
                builder.Append("  name: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureQueue), out propertyOverride);
            if (Optional.IsDefined(AzureQueue) || hasPropertyOverride)
            {
                builder.Append("  azureQueue: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, AzureQueue, options, 2, false, "  azureQueue: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Custom), out propertyOverride);
            if (Optional.IsDefined(Custom) || hasPropertyOverride)
            {
                builder.Append("  custom: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, Custom, options, 2, false, "  custom: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Http), out propertyOverride);
            if (Optional.IsDefined(Http) || hasPropertyOverride)
            {
                builder.Append("  http: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, Http, options, 2, false, "  http: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tcp), out propertyOverride);
            if (Optional.IsDefined(Tcp) || hasPropertyOverride)
            {
                builder.Append("  tcp: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, Tcp, options, 2, false, "  tcp: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine, string formattedPropertyName)
        {
            string indent = new string(' ', spaces);
            int emptyObjectLength = 2 + spaces + Environment.NewLine.Length + Environment.NewLine.Length;
            int length = stringBuilder.Length;
            bool inMultilineString = false;

            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($"{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
            if (stringBuilder.Length == length + emptyObjectLength)
            {
                stringBuilder.Length = stringBuilder.Length - emptyObjectLength - formattedPropertyName.Length;
            }
        }

        BinaryData IPersistableModel<ContainerAppScaleRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppScaleRule)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppScaleRule IPersistableModel<ContainerAppScaleRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppScaleRule(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerAppScaleRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppScaleRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
