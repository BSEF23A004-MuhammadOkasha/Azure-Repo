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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class LinkedAccessCheck : IUtf8JsonSerializable, IModelJsonSerializable<LinkedAccessCheck>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LinkedAccessCheck>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LinkedAccessCheck>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkedAccessCheck>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionName))
            {
                writer.WritePropertyName("actionName"u8);
                writer.WriteStringValue(ActionName);
            }
            if (Optional.IsDefined(LinkedProperty))
            {
                writer.WritePropertyName("linkedProperty"u8);
                writer.WriteStringValue(LinkedProperty);
            }
            if (Optional.IsDefined(LinkedAction))
            {
                writer.WritePropertyName("linkedAction"u8);
                writer.WriteStringValue(LinkedAction);
            }
            if (Optional.IsDefined(LinkedActionVerb))
            {
                writer.WritePropertyName("linkedActionVerb"u8);
                writer.WriteStringValue(LinkedActionVerb);
            }
            if (Optional.IsDefined(LinkedType))
            {
                writer.WritePropertyName("linkedType"u8);
                writer.WriteStringValue(LinkedType);
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

        internal static LinkedAccessCheck DeserializeLinkedAccessCheck(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> actionName = default;
            Optional<string> linkedProperty = default;
            Optional<string> linkedAction = default;
            Optional<string> linkedActionVerb = default;
            Optional<string> linkedType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionName"u8))
                {
                    actionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedProperty"u8))
                {
                    linkedProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedAction"u8))
                {
                    linkedAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedActionVerb"u8))
                {
                    linkedActionVerb = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedType"u8))
                {
                    linkedType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LinkedAccessCheck(actionName.Value, linkedProperty.Value, linkedAction.Value, linkedActionVerb.Value, linkedType.Value, rawData);
        }

        LinkedAccessCheck IModelJsonSerializable<LinkedAccessCheck>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkedAccessCheck>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkedAccessCheck(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LinkedAccessCheck>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkedAccessCheck>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LinkedAccessCheck IModelSerializable<LinkedAccessCheck>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkedAccessCheck>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLinkedAccessCheck(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LinkedAccessCheck"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LinkedAccessCheck"/> to convert. </param>
        public static implicit operator RequestContent(LinkedAccessCheck model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LinkedAccessCheck"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LinkedAccessCheck(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLinkedAccessCheck(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
