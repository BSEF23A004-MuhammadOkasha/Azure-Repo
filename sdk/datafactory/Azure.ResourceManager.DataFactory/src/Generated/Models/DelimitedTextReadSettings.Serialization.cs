// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DelimitedTextReadSettings : IUtf8JsonSerializable, IModelJsonSerializable<DelimitedTextReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DelimitedTextReadSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DelimitedTextReadSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DelimitedTextReadSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SkipLineCount))
            {
                writer.WritePropertyName("skipLineCount"u8);
                JsonSerializer.Serialize(writer, SkipLineCount);
            }
            if (Optional.IsDefined(CompressionProperties))
            {
                writer.WritePropertyName("compressionProperties"u8);
                writer.WriteObjectValue(CompressionProperties);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FormatReadSettingsType);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static DelimitedTextReadSettings DeserializeDelimitedTextReadSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<int>> skipLineCount = default;
            Optional<CompressionReadSettings> compressionProperties = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipLineCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipLineCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("compressionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressionProperties = CompressionReadSettings.DeserializeCompressionReadSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DelimitedTextReadSettings(type, additionalProperties, skipLineCount.Value, compressionProperties.Value);
        }

        DelimitedTextReadSettings IModelJsonSerializable<DelimitedTextReadSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DelimitedTextReadSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDelimitedTextReadSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DelimitedTextReadSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DelimitedTextReadSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DelimitedTextReadSettings IModelSerializable<DelimitedTextReadSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DelimitedTextReadSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDelimitedTextReadSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DelimitedTextReadSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DelimitedTextReadSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDelimitedTextReadSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
