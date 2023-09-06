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

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class FieldRestrictions : IUtf8JsonSerializable, IModelJsonSerializable<FieldRestrictions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FieldRestrictions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FieldRestrictions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FieldRestrictions>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Restrictions))
            {
                writer.WritePropertyName("restrictions"u8);
                writer.WriteStartArray();
                foreach (var item in Restrictions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<FieldRestriction>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static FieldRestrictions DeserializeFieldRestrictions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> field = default;
            Optional<IReadOnlyList<FieldRestriction>> restrictions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field"u8))
                {
                    field = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FieldRestriction> array = new List<FieldRestriction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FieldRestriction.DeserializeFieldRestriction(item));
                    }
                    restrictions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FieldRestrictions(field.Value, Optional.ToList(restrictions), rawData);
        }

        FieldRestrictions IModelJsonSerializable<FieldRestrictions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FieldRestrictions>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFieldRestrictions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FieldRestrictions>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FieldRestrictions>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FieldRestrictions IModelSerializable<FieldRestrictions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FieldRestrictions>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFieldRestrictions(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FieldRestrictions"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FieldRestrictions"/> to convert. </param>
        public static implicit operator RequestContent(FieldRestrictions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FieldRestrictions"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FieldRestrictions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFieldRestrictions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
