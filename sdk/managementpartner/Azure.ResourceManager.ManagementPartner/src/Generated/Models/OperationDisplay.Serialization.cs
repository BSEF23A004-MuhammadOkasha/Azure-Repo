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

namespace Azure.ResourceManager.ManagementPartner.Models
{
    public partial class OperationDisplay : IUtf8JsonSerializable, IModelJsonSerializable<OperationDisplay>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OperationDisplay>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OperationDisplay>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationDisplay>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Provider))
            {
                writer.WritePropertyName("provider"u8);
                writer.WriteStringValue(Provider);
            }
            if (Optional.IsDefined(Resource))
            {
                writer.WritePropertyName("resource"u8);
                writer.WriteStringValue(Resource);
            }
            if (Optional.IsDefined(Operation))
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        internal static OperationDisplay DeserializeOperationDisplay(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> provider = default;
            Optional<string> resource = default;
            Optional<string> operation = default;
            Optional<string> description = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provider"u8))
                {
                    provider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resource"u8))
                {
                    resource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operation"u8))
                {
                    operation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OperationDisplay(provider.Value, resource.Value, operation.Value, description.Value, serializedAdditionalRawData);
        }

        OperationDisplay IModelJsonSerializable<OperationDisplay>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationDisplay>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationDisplay(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OperationDisplay>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationDisplay>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OperationDisplay IModelSerializable<OperationDisplay>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationDisplay>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOperationDisplay(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OperationDisplay"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OperationDisplay"/> to convert. </param>
        public static implicit operator RequestContent(OperationDisplay model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OperationDisplay"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OperationDisplay(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOperationDisplay(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
