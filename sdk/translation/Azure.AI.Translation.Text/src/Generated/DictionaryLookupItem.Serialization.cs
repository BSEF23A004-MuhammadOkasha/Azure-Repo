// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    public partial class DictionaryLookupItem : IUtf8JsonSerializable, IJsonModel<DictionaryLookupItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DictionaryLookupItem>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<DictionaryLookupItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DictionaryLookupItem>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DictionaryLookupItem>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("normalizedSource"u8);
            writer.WriteStringValue(NormalizedSource);
            writer.WritePropertyName("displaySource"u8);
            writer.WriteStringValue(DisplaySource);
            writer.WritePropertyName("translations"u8);
            writer.WriteStartArray();
            foreach (var item in Translations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        DictionaryLookupItem IJsonModel<DictionaryLookupItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DictionaryLookupItem)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDictionaryLookupItem(document.RootElement, options);
        }

        internal static DictionaryLookupItem DeserializeDictionaryLookupItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string normalizedSource = default;
            string displaySource = default;
            IReadOnlyList<DictionaryTranslation> translations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("normalizedSource"u8))
                {
                    normalizedSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displaySource"u8))
                {
                    displaySource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("translations"u8))
                {
                    List<DictionaryTranslation> array = new List<DictionaryTranslation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DictionaryTranslation.DeserializeDictionaryTranslation(item));
                    }
                    translations = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DictionaryLookupItem(normalizedSource, displaySource, translations, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DictionaryLookupItem>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DictionaryLookupItem)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DictionaryLookupItem IPersistableModel<DictionaryLookupItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DictionaryLookupItem)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDictionaryLookupItem(document.RootElement, options);
        }

        string IPersistableModel<DictionaryLookupItem>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DictionaryLookupItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDictionaryLookupItem(document.RootElement, ModelReaderWriterOptions.Wire);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
