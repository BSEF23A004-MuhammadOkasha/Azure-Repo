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

namespace Azure.ResourceManager.Maps.Models
{
    public partial class MapsAccountKeys : IUtf8JsonSerializable, IModelJsonSerializable<MapsAccountKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MapsAccountKeys>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MapsAccountKeys>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapsAccountKeys>(this, options.Format);

            writer.WriteStartObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static MapsAccountKeys DeserializeMapsAccountKeys(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> primaryKeyLastUpdated = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            Optional<DateTimeOffset> secondaryKeyLastUpdated = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKeyLastUpdated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryKeyLastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKeyLastUpdated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryKeyLastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MapsAccountKeys(Optional.ToNullable(primaryKeyLastUpdated), primaryKey.Value, secondaryKey.Value, Optional.ToNullable(secondaryKeyLastUpdated), serializedAdditionalRawData);
        }

        MapsAccountKeys IModelJsonSerializable<MapsAccountKeys>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapsAccountKeys>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMapsAccountKeys(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MapsAccountKeys>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapsAccountKeys>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MapsAccountKeys IModelSerializable<MapsAccountKeys>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapsAccountKeys>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMapsAccountKeys(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MapsAccountKeys"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MapsAccountKeys"/> to convert. </param>
        public static implicit operator RequestContent(MapsAccountKeys model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MapsAccountKeys"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MapsAccountKeys(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMapsAccountKeys(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
