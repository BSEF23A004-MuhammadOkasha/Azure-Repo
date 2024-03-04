// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ConnectivityCheckRequestHttpConfiguration : IUtf8JsonSerializable, IJsonModel<ConnectivityCheckRequestHttpConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectivityCheckRequestHttpConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectivityCheckRequestHttpConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityCheckRequestHttpConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityCheckRequestHttpConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Method))
            {
                writer.WritePropertyName("method"u8);
                writer.WriteStringValue(Method.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ValidStatusCodes))
            {
                writer.WritePropertyName("validStatusCodes"u8);
                writer.WriteStartArray();
                foreach (var item in ValidStatusCodes)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartArray();
                foreach (var item in Headers)
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

        ConnectivityCheckRequestHttpConfiguration IJsonModel<ConnectivityCheckRequestHttpConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityCheckRequestHttpConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityCheckRequestHttpConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectivityCheckRequestHttpConfiguration(document.RootElement, options);
        }

        internal static ConnectivityCheckRequestHttpConfiguration DeserializeConnectivityCheckRequestHttpConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HttpMethodConfiguration? method = default;
            IList<long> validStatusCodes = default;
            IList<HttpHeaderConfiguration> headers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("method"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    method = new HttpMethodConfiguration(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("validStatusCodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<long> array = new List<long>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt64());
                    }
                    validStatusCodes = array;
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HttpHeaderConfiguration> array = new List<HttpHeaderConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HttpHeaderConfiguration.DeserializeHttpHeaderConfiguration(item, options));
                    }
                    headers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectivityCheckRequestHttpConfiguration(method, validStatusCodes ?? new ChangeTrackingList<long>(), headers ?? new ChangeTrackingList<HttpHeaderConfiguration>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectivityCheckRequestHttpConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityCheckRequestHttpConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectivityCheckRequestHttpConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ConnectivityCheckRequestHttpConfiguration IPersistableModel<ConnectivityCheckRequestHttpConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityCheckRequestHttpConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectivityCheckRequestHttpConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectivityCheckRequestHttpConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectivityCheckRequestHttpConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
