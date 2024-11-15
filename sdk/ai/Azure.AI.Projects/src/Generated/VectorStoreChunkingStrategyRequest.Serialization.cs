// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    [PersistableModelProxy(typeof(UnknownVectorStoreChunkingStrategyRequest))]
    public partial class VectorStoreChunkingStrategyRequest : IUtf8JsonSerializable, IJsonModel<VectorStoreChunkingStrategyRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VectorStoreChunkingStrategyRequest>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VectorStoreChunkingStrategyRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStoreChunkingStrategyRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VectorStoreChunkingStrategyRequest)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
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

        VectorStoreChunkingStrategyRequest IJsonModel<VectorStoreChunkingStrategyRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStoreChunkingStrategyRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VectorStoreChunkingStrategyRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVectorStoreChunkingStrategyRequest(document.RootElement, options);
        }

        internal static VectorStoreChunkingStrategyRequest DeserializeVectorStoreChunkingStrategyRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "auto": return VectorStoreAutoChunkingStrategyRequest.DeserializeVectorStoreAutoChunkingStrategyRequest(element, options);
                    case "static": return VectorStoreStaticChunkingStrategyRequest.DeserializeVectorStoreStaticChunkingStrategyRequest(element, options);
                }
            }
            return UnknownVectorStoreChunkingStrategyRequest.DeserializeUnknownVectorStoreChunkingStrategyRequest(element, options);
        }

        BinaryData IPersistableModel<VectorStoreChunkingStrategyRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStoreChunkingStrategyRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VectorStoreChunkingStrategyRequest)} does not support writing '{options.Format}' format.");
            }
        }

        VectorStoreChunkingStrategyRequest IPersistableModel<VectorStoreChunkingStrategyRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStoreChunkingStrategyRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVectorStoreChunkingStrategyRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VectorStoreChunkingStrategyRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VectorStoreChunkingStrategyRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static VectorStoreChunkingStrategyRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeVectorStoreChunkingStrategyRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
