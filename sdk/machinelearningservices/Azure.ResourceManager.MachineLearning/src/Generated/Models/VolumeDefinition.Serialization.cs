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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class VolumeDefinition : IUtf8JsonSerializable, IJsonModel<VolumeDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VolumeDefinition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VolumeDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VolumeDefinition)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DefinitionType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(DefinitionType.Value.ToString());
            }
            if (Optional.IsDefined(ReadOnly))
            {
                if (ReadOnly != null)
                {
                    writer.WritePropertyName("readOnly"u8);
                    writer.WriteBooleanValue(ReadOnly.Value);
                }
                else
                {
                    writer.WriteNull("readOnly");
                }
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsDefined(Consistency))
            {
                writer.WritePropertyName("consistency"u8);
                writer.WriteStringValue(Consistency);
            }
            if (Optional.IsDefined(Bind))
            {
                writer.WritePropertyName("bind"u8);
                writer.WriteObjectValue(Bind, options);
            }
            if (Optional.IsDefined(Volume))
            {
                writer.WritePropertyName("volume"u8);
                writer.WriteObjectValue(Volume, options);
            }
            if (Optional.IsDefined(Tmpfs))
            {
                writer.WritePropertyName("tmpfs"u8);
                writer.WriteObjectValue(Tmpfs, options);
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
        }

        VolumeDefinition IJsonModel<VolumeDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VolumeDefinition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVolumeDefinition(document.RootElement, options);
        }

        internal static VolumeDefinition DeserializeVolumeDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VolumeDefinitionType? type = default;
            bool? readOnly = default;
            string source = default;
            string target = default;
            string consistency = default;
            MountBindOptions bind = default;
            VolumeOptions volume = default;
            TmpfsOptions tmpfs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new VolumeDefinitionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("readOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        readOnly = null;
                        continue;
                    }
                    readOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("consistency"u8))
                {
                    consistency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bind = MountBindOptions.DeserializeMountBindOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("volume"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    volume = VolumeOptions.DeserializeVolumeOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tmpfs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tmpfs = TmpfsOptions.DeserializeTmpfsOptions(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VolumeDefinition(
                type,
                readOnly,
                source,
                target,
                consistency,
                bind,
                volume,
                tmpfs,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefinitionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DefinitionType))
                {
                    builder.Append("  type: ");
                    builder.AppendLine($"'{DefinitionType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReadOnly), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  readOnly: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReadOnly))
                {
                    builder.Append("  readOnly: ");
                    var boolValue = ReadOnly.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Source), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  source: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Source))
                {
                    builder.Append("  source: ");
                    if (Source.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Source}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Source}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Target), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  target: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Target))
                {
                    builder.Append("  target: ");
                    if (Target.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Target}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Target}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Consistency), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  consistency: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Consistency))
                {
                    builder.Append("  consistency: ");
                    if (Consistency.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Consistency}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Consistency}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Bind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  bind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Bind))
                {
                    builder.Append("  bind: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Bind, options, 2, false, "  bind: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("Nocopy", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  volume: ");
                builder.AppendLine("{");
                builder.Append("    nocopy: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Volume))
                {
                    builder.Append("  volume: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Volume, options, 2, false, "  volume: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("TmpfsSize", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tmpfs: ");
                builder.AppendLine("{");
                builder.Append("    size: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Tmpfs))
                {
                    builder.Append("  tmpfs: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Tmpfs, options, 2, false, "  tmpfs: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<VolumeDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VolumeDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        VolumeDefinition IPersistableModel<VolumeDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVolumeDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VolumeDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VolumeDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
