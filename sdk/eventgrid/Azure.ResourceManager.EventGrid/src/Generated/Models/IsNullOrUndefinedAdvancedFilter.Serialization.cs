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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class IsNullOrUndefinedAdvancedFilter : IUtf8JsonSerializable, IModelJsonSerializable<IsNullOrUndefinedAdvancedFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IsNullOrUndefinedAdvancedFilter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IsNullOrUndefinedAdvancedFilter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IsNullOrUndefinedAdvancedFilter>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("operatorType"u8);
            writer.WriteStringValue(OperatorType.ToString());
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
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

        internal static IsNullOrUndefinedAdvancedFilter DeserializeIsNullOrUndefinedAdvancedFilter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AdvancedFilterOperatorType operatorType = default;
            Optional<string> key = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operatorType"u8))
                {
                    operatorType = new AdvancedFilterOperatorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IsNullOrUndefinedAdvancedFilter(operatorType, key.Value, rawData);
        }

        IsNullOrUndefinedAdvancedFilter IModelJsonSerializable<IsNullOrUndefinedAdvancedFilter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IsNullOrUndefinedAdvancedFilter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIsNullOrUndefinedAdvancedFilter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IsNullOrUndefinedAdvancedFilter>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IsNullOrUndefinedAdvancedFilter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IsNullOrUndefinedAdvancedFilter IModelSerializable<IsNullOrUndefinedAdvancedFilter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IsNullOrUndefinedAdvancedFilter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIsNullOrUndefinedAdvancedFilter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IsNullOrUndefinedAdvancedFilter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IsNullOrUndefinedAdvancedFilter"/> to convert. </param>
        public static implicit operator RequestContent(IsNullOrUndefinedAdvancedFilter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IsNullOrUndefinedAdvancedFilter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IsNullOrUndefinedAdvancedFilter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIsNullOrUndefinedAdvancedFilter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
