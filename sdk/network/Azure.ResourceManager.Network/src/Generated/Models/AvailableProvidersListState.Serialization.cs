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

namespace Azure.ResourceManager.Network.Models
{
    public partial class AvailableProvidersListState : IUtf8JsonSerializable, IModelJsonSerializable<AvailableProvidersListState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AvailableProvidersListState>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AvailableProvidersListState>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailableProvidersListState>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(StateName))
            {
                writer.WritePropertyName("stateName"u8);
                writer.WriteStringValue(StateName);
            }
            if (Optional.IsCollectionDefined(Providers))
            {
                writer.WritePropertyName("providers"u8);
                writer.WriteStartArray();
                foreach (var item in Providers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Cities))
            {
                writer.WritePropertyName("cities"u8);
                writer.WriteStartArray();
                foreach (var item in Cities)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AvailableProvidersListCity>)item).Serialize(writer, options);
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

        internal static AvailableProvidersListState DeserializeAvailableProvidersListState(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> stateName = default;
            Optional<IReadOnlyList<string>> providers = default;
            Optional<IReadOnlyList<AvailableProvidersListCity>> cities = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stateName"u8))
                {
                    stateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    providers = array;
                    continue;
                }
                if (property.NameEquals("cities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailableProvidersListCity> array = new List<AvailableProvidersListCity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableProvidersListCity.DeserializeAvailableProvidersListCity(item));
                    }
                    cities = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AvailableProvidersListState(stateName.Value, Optional.ToList(providers), Optional.ToList(cities), rawData);
        }

        AvailableProvidersListState IModelJsonSerializable<AvailableProvidersListState>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailableProvidersListState>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailableProvidersListState(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AvailableProvidersListState>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailableProvidersListState>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AvailableProvidersListState IModelSerializable<AvailableProvidersListState>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailableProvidersListState>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAvailableProvidersListState(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AvailableProvidersListState"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AvailableProvidersListState"/> to convert. </param>
        public static implicit operator RequestContent(AvailableProvidersListState model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AvailableProvidersListState"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AvailableProvidersListState(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAvailableProvidersListState(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
