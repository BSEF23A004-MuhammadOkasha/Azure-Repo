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
    internal partial class DataCollectionEndpointNetworkAcls : IUtf8JsonSerializable, IModelJsonSerializable<DataCollectionEndpointNetworkAcls>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataCollectionEndpointNetworkAcls>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataCollectionEndpointNetworkAcls>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataCollectionEndpointNetworkAcls>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
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

        internal static DataCollectionEndpointNetworkAcls DeserializeDataCollectionEndpointNetworkAcls(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MonitorPublicNetworkAccess> publicNetworkAccess = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new MonitorPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataCollectionEndpointNetworkAcls(Optional.ToNullable(publicNetworkAccess), rawData);
        }

        DataCollectionEndpointNetworkAcls IModelJsonSerializable<DataCollectionEndpointNetworkAcls>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataCollectionEndpointNetworkAcls>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionEndpointNetworkAcls(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataCollectionEndpointNetworkAcls>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataCollectionEndpointNetworkAcls>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataCollectionEndpointNetworkAcls IModelSerializable<DataCollectionEndpointNetworkAcls>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataCollectionEndpointNetworkAcls>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataCollectionEndpointNetworkAcls(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataCollectionEndpointNetworkAcls"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataCollectionEndpointNetworkAcls"/> to convert. </param>
        public static implicit operator RequestContent(DataCollectionEndpointNetworkAcls model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataCollectionEndpointNetworkAcls"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataCollectionEndpointNetworkAcls(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataCollectionEndpointNetworkAcls(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
