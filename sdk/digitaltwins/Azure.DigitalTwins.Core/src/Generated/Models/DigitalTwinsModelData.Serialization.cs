// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.DigitalTwins.Core
{
    public partial class DigitalTwinsModelData : IUtf8JsonSerializable, IModelJsonSerializable<DigitalTwinsModelData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DigitalTwinsModelData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DigitalTwinsModelData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Azure.Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsModelData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LanguageDisplayNames))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in LanguageDisplayNames)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(LanguageDescriptions))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStartObject();
                foreach (var item in LanguageDescriptions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(UploadedOn))
            {
                writer.WritePropertyName("uploadTime"u8);
                writer.WriteStringValue(UploadedOn.Value, "O");
            }
            if (Optional.IsDefined(Decommissioned))
            {
                writer.WritePropertyName("decommissioned"u8);
                writer.WriteBooleanValue(Decommissioned.Value);
            }
            if (Optional.IsDefined(DtdlModel))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(DtdlModel);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static DigitalTwinsModelData DeserializeDigitalTwinsModelData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, string>> displayName = default;
            Optional<IReadOnlyDictionary<string, string>> description = default;
            string id = default;
            Optional<DateTimeOffset> uploadTime = default;
            Optional<bool> decommissioned = default;
            Optional<string> model = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    displayName = dictionary;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    description = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uploadTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("decommissioned"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    decommissioned = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DigitalTwinsModelData(Optional.ToDictionary(displayName), Optional.ToDictionary(description), id, Optional.ToNullable(uploadTime), Optional.ToNullable(decommissioned), model.Value, rawData);
        }

        DigitalTwinsModelData IModelJsonSerializable<DigitalTwinsModelData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Azure.Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsModelData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsModelData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DigitalTwinsModelData>.Serialize(ModelSerializerOptions options)
        {
            Azure.Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsModelData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DigitalTwinsModelData IModelSerializable<DigitalTwinsModelData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Azure.Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsModelData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDigitalTwinsModelData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DigitalTwinsModelData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DigitalTwinsModelData"/> to convert. </param>
        public static implicit operator RequestContent(DigitalTwinsModelData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DigitalTwinsModelData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DigitalTwinsModelData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDigitalTwinsModelData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
