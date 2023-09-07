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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ExpressRouteConnectionInformation : IUtf8JsonSerializable, IModelJsonSerializable<ExpressRouteConnectionInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExpressRouteConnectionInformation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExpressRouteConnectionInformation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExpressRouteConnectionInformation>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("expressRouteCircuitId"u8);
            writer.WriteStringValue(ExpressRouteCircuitId);
            if (Optional.IsDefined(ExpressRouteAuthorizationKey))
            {
                writer.WritePropertyName("expressRouteAuthorizationKey"u8);
                writer.WriteStringValue(ExpressRouteAuthorizationKey);
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

        internal static ExpressRouteConnectionInformation DeserializeExpressRouteConnectionInformation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier expressRouteCircuitId = default;
            Optional<string> expressRouteAuthorizationKey = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expressRouteCircuitId"u8))
                {
                    expressRouteCircuitId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expressRouteAuthorizationKey"u8))
                {
                    expressRouteAuthorizationKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExpressRouteConnectionInformation(expressRouteCircuitId, expressRouteAuthorizationKey.Value, serializedAdditionalRawData);
        }

        ExpressRouteConnectionInformation IModelJsonSerializable<ExpressRouteConnectionInformation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExpressRouteConnectionInformation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteConnectionInformation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExpressRouteConnectionInformation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExpressRouteConnectionInformation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExpressRouteConnectionInformation IModelSerializable<ExpressRouteConnectionInformation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExpressRouteConnectionInformation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExpressRouteConnectionInformation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExpressRouteConnectionInformation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExpressRouteConnectionInformation"/> to convert. </param>
        public static implicit operator RequestContent(ExpressRouteConnectionInformation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExpressRouteConnectionInformation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExpressRouteConnectionInformation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExpressRouteConnectionInformation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
