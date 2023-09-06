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

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataCollectionEndpointFailoverConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<DataCollectionEndpointFailoverConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataCollectionEndpointFailoverConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataCollectionEndpointFailoverConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataCollectionEndpointFailoverConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ActiveLocation))
            {
                writer.WritePropertyName("activeLocation"u8);
                writer.WriteStringValue(ActiveLocation);
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DataCollectionRuleBcdrLocationSpec>)item).Serialize(writer, options);
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

        internal static DataCollectionEndpointFailoverConfiguration DeserializeDataCollectionEndpointFailoverConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> activeLocation = default;
            Optional<IReadOnlyList<DataCollectionRuleBcdrLocationSpec>> locations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeLocation"u8))
                {
                    activeLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleBcdrLocationSpec> array = new List<DataCollectionRuleBcdrLocationSpec>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleBcdrLocationSpec.DeserializeDataCollectionRuleBcdrLocationSpec(item));
                    }
                    locations = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataCollectionEndpointFailoverConfiguration(activeLocation.Value, Optional.ToList(locations), rawData);
        }

        DataCollectionEndpointFailoverConfiguration IModelJsonSerializable<DataCollectionEndpointFailoverConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataCollectionEndpointFailoverConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionEndpointFailoverConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataCollectionEndpointFailoverConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataCollectionEndpointFailoverConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataCollectionEndpointFailoverConfiguration IModelSerializable<DataCollectionEndpointFailoverConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataCollectionEndpointFailoverConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataCollectionEndpointFailoverConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataCollectionEndpointFailoverConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataCollectionEndpointFailoverConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(DataCollectionEndpointFailoverConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataCollectionEndpointFailoverConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataCollectionEndpointFailoverConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataCollectionEndpointFailoverConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
