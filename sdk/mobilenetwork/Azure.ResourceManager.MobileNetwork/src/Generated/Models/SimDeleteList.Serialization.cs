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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class SimDeleteList : IUtf8JsonSerializable, IModelJsonSerializable<SimDeleteList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SimDeleteList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SimDeleteList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SimDeleteList>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sims"u8);
            writer.WriteStartArray();
            foreach (var item in Sims)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        internal static SimDeleteList DeserializeSimDeleteList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> sims = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sims"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sims = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SimDeleteList(sims, rawData);
        }

        SimDeleteList IModelJsonSerializable<SimDeleteList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SimDeleteList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSimDeleteList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SimDeleteList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SimDeleteList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SimDeleteList IModelSerializable<SimDeleteList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SimDeleteList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSimDeleteList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SimDeleteList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SimDeleteList"/> to convert. </param>
        public static implicit operator RequestContent(SimDeleteList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SimDeleteList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SimDeleteList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSimDeleteList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
