// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppJobScaleRule : IUtf8JsonSerializable, IJsonModel<ContainerAppJobScaleRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppJobScaleRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppJobScaleRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobScaleRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(JobScaleRuleType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(JobScaleRuleType);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(Auth))
            {
                writer.WritePropertyName("auth"u8);
                writer.WriteStartArray();
                foreach (var item in Auth)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ContainerAppJobScaleRule IJsonModel<ContainerAppJobScaleRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobScaleRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppJobScaleRule(document.RootElement, options);
        }

        internal static ContainerAppJobScaleRule DeserializeContainerAppJobScaleRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string type = default;
            BinaryData metadata = default;
            IList<ContainerAppScaleRuleAuth> auth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("auth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppScaleRuleAuth> array = new List<ContainerAppScaleRuleAuth>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppScaleRuleAuth.DeserializeContainerAppScaleRuleAuth(item, options));
                    }
                    auth = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppJobScaleRule(name, type, metadata, auth ?? new ChangeTrackingList<ContainerAppScaleRuleAuth>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Metadata), out propertyOverride);
            if (Optional.IsDefined(Metadata) || hasPropertyOverride)
            {
                builder.Append("  metadata: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{Metadata.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Auth), out propertyOverride);
            if (Optional.IsCollectionDefined(Auth) || hasPropertyOverride)
            {
                if (Auth.Any() || hasPropertyOverride)
                {
                    builder.Append("  auth: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in Auth)
                        {
                            AppendChildObject(builder, item, options, 4, true, "  auth: ");
                        }
                        builder.AppendLine("  ]");
                    }
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

        BinaryData IPersistableModel<ContainerAppJobScaleRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobScaleRule)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppJobScaleRule IPersistableModel<ContainerAppJobScaleRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppJobScaleRule(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobScaleRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppJobScaleRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
