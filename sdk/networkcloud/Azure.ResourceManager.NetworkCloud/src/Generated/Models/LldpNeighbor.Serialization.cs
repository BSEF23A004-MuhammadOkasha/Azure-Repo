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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class LldpNeighbor : IUtf8JsonSerializable, IModelJsonSerializable<LldpNeighbor>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LldpNeighbor>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LldpNeighbor>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LldpNeighbor>(this, options.Format);

            writer.WriteStartObject();
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

        internal static LldpNeighbor DeserializeLldpNeighbor(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> portDescription = default;
            Optional<string> portName = default;
            Optional<string> systemDescription = default;
            Optional<string> systemName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("portDescription"u8))
                {
                    portDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("portName"u8))
                {
                    portName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemDescription"u8))
                {
                    systemDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemName"u8))
                {
                    systemName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LldpNeighbor(portDescription.Value, portName.Value, systemDescription.Value, systemName.Value, rawData);
        }

        LldpNeighbor IModelJsonSerializable<LldpNeighbor>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LldpNeighbor>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLldpNeighbor(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LldpNeighbor>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LldpNeighbor>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LldpNeighbor IModelSerializable<LldpNeighbor>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LldpNeighbor>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLldpNeighbor(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LldpNeighbor"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LldpNeighbor"/> to convert. </param>
        public static implicit operator RequestContent(LldpNeighbor model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LldpNeighbor"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LldpNeighbor(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLldpNeighbor(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
