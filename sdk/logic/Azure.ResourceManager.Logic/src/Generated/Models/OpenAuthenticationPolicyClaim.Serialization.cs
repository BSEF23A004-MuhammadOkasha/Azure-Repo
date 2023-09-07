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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class OpenAuthenticationPolicyClaim : IUtf8JsonSerializable, IModelJsonSerializable<OpenAuthenticationPolicyClaim>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OpenAuthenticationPolicyClaim>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OpenAuthenticationPolicyClaim>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OpenAuthenticationPolicyClaim>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
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

        internal static OpenAuthenticationPolicyClaim DeserializeOpenAuthenticationPolicyClaim(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OpenAuthenticationPolicyClaim(name.Value, value.Value, serializedAdditionalRawData);
        }

        OpenAuthenticationPolicyClaim IModelJsonSerializable<OpenAuthenticationPolicyClaim>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OpenAuthenticationPolicyClaim>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenAuthenticationPolicyClaim(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OpenAuthenticationPolicyClaim>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OpenAuthenticationPolicyClaim>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OpenAuthenticationPolicyClaim IModelSerializable<OpenAuthenticationPolicyClaim>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OpenAuthenticationPolicyClaim>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOpenAuthenticationPolicyClaim(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OpenAuthenticationPolicyClaim"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OpenAuthenticationPolicyClaim"/> to convert. </param>
        public static implicit operator RequestContent(OpenAuthenticationPolicyClaim model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OpenAuthenticationPolicyClaim"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OpenAuthenticationPolicyClaim(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOpenAuthenticationPolicyClaim(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
