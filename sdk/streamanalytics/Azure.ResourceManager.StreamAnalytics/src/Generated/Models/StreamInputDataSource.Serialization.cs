// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    [PersistableModelProxy(typeof(UnknownStreamInputDataSource))]
    public partial class StreamInputDataSource : IUtf8JsonSerializable, IJsonModel<StreamInputDataSource>, IPersistableModel<StreamInputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamInputDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamInputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamInputDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StreamInputDataSourceType);
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

        StreamInputDataSource IJsonModel<StreamInputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamInputDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamInputDataSource(document.RootElement, options);
        }

        internal static StreamInputDataSource DeserializeStreamInputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "GatewayMessageBus": return GatewayMessageBusStreamInputDataSource.DeserializeGatewayMessageBusStreamInputDataSource(element);
                    case "Microsoft.Devices/IotHubs": return IoTHubStreamInputDataSource.DeserializeIoTHubStreamInputDataSource(element);
                    case "Microsoft.EventGrid/EventSubscriptions": return EventGridStreamInputDataSource.DeserializeEventGridStreamInputDataSource(element);
                    case "Microsoft.EventHub/EventHub": return EventHubV2StreamInputDataSource.DeserializeEventHubV2StreamInputDataSource(element);
                    case "Microsoft.ServiceBus/EventHub": return EventHubStreamInputDataSource.DeserializeEventHubStreamInputDataSource(element);
                    case "Microsoft.Storage/Blob": return BlobStreamInputDataSource.DeserializeBlobStreamInputDataSource(element);
                    case "Raw": return RawStreamInputDataSource.DeserializeRawStreamInputDataSource(element);
                }
            }
            return UnknownStreamInputDataSource.DeserializeUnknownStreamInputDataSource(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(StreamInputDataSourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{StreamInputDataSourceType}'");
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

        BinaryData IPersistableModel<StreamInputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StreamInputDataSource)} does not support '{options.Format}' format.");
            }
        }

        StreamInputDataSource IPersistableModel<StreamInputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamInputDataSource(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(StreamInputDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamInputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
