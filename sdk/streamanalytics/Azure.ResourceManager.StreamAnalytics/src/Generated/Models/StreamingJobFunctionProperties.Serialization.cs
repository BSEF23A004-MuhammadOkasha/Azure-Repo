// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    [PersistableModelProxy(typeof(UnknownFunctionProperties))]
    public partial class StreamingJobFunctionProperties : IUtf8JsonSerializable, IJsonModel<StreamingJobFunctionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingJobFunctionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingJobFunctionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobFunctionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FunctionPropertiesType);
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (!(Inputs is ChangeTrackingList<StreamingJobFunctionInput> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Output != null)
            {
                writer.WritePropertyName("output"u8);
                writer.WriteObjectValue(Output);
            }
            if (Binding != null)
            {
                writer.WritePropertyName("binding"u8);
                writer.WriteObjectValue(Binding);
            }
            writer.WriteEndObject();
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

        StreamingJobFunctionProperties IJsonModel<StreamingJobFunctionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobFunctionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingJobFunctionProperties(document.RootElement, options);
        }

        internal static StreamingJobFunctionProperties DeserializeStreamingJobFunctionProperties(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "Aggregate": return AggregateFunctionProperties.DeserializeAggregateFunctionProperties(element, options);
                    case "Scalar": return ScalarFunctionProperties.DeserializeScalarFunctionProperties(element, options);
                }
            }
            return UnknownFunctionProperties.DeserializeUnknownFunctionProperties(element, options);
        }

        BinaryData IPersistableModel<StreamingJobFunctionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingJobFunctionProperties)} does not support '{options.Format}' format.");
            }
        }

        StreamingJobFunctionProperties IPersistableModel<StreamingJobFunctionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingJobFunctionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingJobFunctionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingJobFunctionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
