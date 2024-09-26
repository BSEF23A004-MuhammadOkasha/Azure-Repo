// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class UriSigningParamIdentifier : IUtf8JsonSerializable, IJsonModel<UriSigningParamIdentifier>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UriSigningParamIdentifier>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UriSigningParamIdentifier>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UriSigningParamIdentifier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UriSigningParamIdentifier)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("paramIndicator"u8);
            writer.WriteStringValue(ParamIndicator.ToString());
            writer.WritePropertyName("paramName"u8);
            writer.WriteStringValue(ParamName);
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

        UriSigningParamIdentifier IJsonModel<UriSigningParamIdentifier>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UriSigningParamIdentifier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UriSigningParamIdentifier)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUriSigningParamIdentifier(document.RootElement, options);
        }

        internal static UriSigningParamIdentifier DeserializeUriSigningParamIdentifier(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ParamIndicator paramIndicator = default;
            string paramName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("paramIndicator"u8))
                {
                    paramIndicator = new ParamIndicator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("paramName"u8))
                {
                    paramName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UriSigningParamIdentifier(paramIndicator, paramName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UriSigningParamIdentifier>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UriSigningParamIdentifier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UriSigningParamIdentifier)} does not support writing '{options.Format}' format.");
            }
        }

        UriSigningParamIdentifier IPersistableModel<UriSigningParamIdentifier>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UriSigningParamIdentifier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUriSigningParamIdentifier(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UriSigningParamIdentifier)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UriSigningParamIdentifier>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
