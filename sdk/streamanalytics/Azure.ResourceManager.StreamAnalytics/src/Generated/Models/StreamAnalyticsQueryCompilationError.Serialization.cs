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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsQueryCompilationError : IUtf8JsonSerializable, IJsonModel<StreamAnalyticsQueryCompilationError>, IPersistableModel<StreamAnalyticsQueryCompilationError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamAnalyticsQueryCompilationError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamAnalyticsQueryCompilationError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsQueryCompilationError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsQueryCompilationError)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Optional.IsDefined(StartLine))
            {
                writer.WritePropertyName("startLine"u8);
                writer.WriteNumberValue(StartLine.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StartColumn))
            {
                writer.WritePropertyName("startColumn"u8);
                writer.WriteNumberValue(StartColumn.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EndLine))
            {
                writer.WritePropertyName("endLine"u8);
                writer.WriteNumberValue(EndLine.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EndColumn))
            {
                writer.WritePropertyName("endColumn"u8);
                writer.WriteNumberValue(EndColumn.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsGlobal))
            {
                writer.WritePropertyName("isGlobal"u8);
                writer.WriteBooleanValue(IsGlobal.Value);
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

        StreamAnalyticsQueryCompilationError IJsonModel<StreamAnalyticsQueryCompilationError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsQueryCompilationError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsQueryCompilationError)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsQueryCompilationError(document.RootElement, options);
        }

        internal static StreamAnalyticsQueryCompilationError DeserializeStreamAnalyticsQueryCompilationError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> message = default;
            Optional<int> startLine = default;
            Optional<int> startColumn = default;
            Optional<int> endLine = default;
            Optional<int> endColumn = default;
            Optional<bool> isGlobal = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startLine"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startLine = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startColumn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startColumn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endLine"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endLine = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endColumn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endColumn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isGlobal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isGlobal = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamAnalyticsQueryCompilationError(message.Value, Optional.ToNullable(startLine), Optional.ToNullable(startColumn), Optional.ToNullable(endLine), Optional.ToNullable(endColumn), Optional.ToNullable(isGlobal), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Message))
            {
                builder.Append("  message:");
                builder.AppendLine($" '{Message}'");
            }

            if (Optional.IsDefined(StartLine))
            {
                builder.Append("  startLine:");
                builder.AppendLine($" '{StartLine.Value.ToString()}'");
            }

            if (Optional.IsDefined(StartColumn))
            {
                builder.Append("  startColumn:");
                builder.AppendLine($" '{StartColumn.Value.ToString()}'");
            }

            if (Optional.IsDefined(EndLine))
            {
                builder.Append("  endLine:");
                builder.AppendLine($" '{EndLine.Value.ToString()}'");
            }

            if (Optional.IsDefined(EndColumn))
            {
                builder.Append("  endColumn:");
                builder.AppendLine($" '{EndColumn.Value.ToString()}'");
            }

            if (Optional.IsDefined(IsGlobal))
            {
                builder.Append("  isGlobal:");
                var boolValue = IsGlobal.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<StreamAnalyticsQueryCompilationError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsQueryCompilationError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsQueryCompilationError)} does not support '{options.Format}' format.");
            }
        }

        StreamAnalyticsQueryCompilationError IPersistableModel<StreamAnalyticsQueryCompilationError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsQueryCompilationError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamAnalyticsQueryCompilationError(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsQueryCompilationError)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamAnalyticsQueryCompilationError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
