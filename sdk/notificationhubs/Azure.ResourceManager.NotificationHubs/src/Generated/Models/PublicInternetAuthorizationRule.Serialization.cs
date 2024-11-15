// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    internal partial class PublicInternetAuthorizationRule : IUtf8JsonSerializable, IJsonModel<PublicInternetAuthorizationRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PublicInternetAuthorizationRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PublicInternetAuthorizationRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicInternetAuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublicInternetAuthorizationRule)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("rights"u8);
            writer.WriteStartArray();
            foreach (var item in AccessRights)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
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

        PublicInternetAuthorizationRule IJsonModel<PublicInternetAuthorizationRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicInternetAuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublicInternetAuthorizationRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePublicInternetAuthorizationRule(document.RootElement, options);
        }

        internal static PublicInternetAuthorizationRule DeserializePublicInternetAuthorizationRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AuthorizationRuleAccessRightExt> rights = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rights"u8))
                {
                    List<AuthorizationRuleAccessRightExt> array = new List<AuthorizationRuleAccessRightExt>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AuthorizationRuleAccessRightExt(item.GetString()));
                    }
                    rights = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PublicInternetAuthorizationRule(rights, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PublicInternetAuthorizationRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicInternetAuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PublicInternetAuthorizationRule)} does not support writing '{options.Format}' format.");
            }
        }

        PublicInternetAuthorizationRule IPersistableModel<PublicInternetAuthorizationRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicInternetAuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePublicInternetAuthorizationRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PublicInternetAuthorizationRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PublicInternetAuthorizationRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
