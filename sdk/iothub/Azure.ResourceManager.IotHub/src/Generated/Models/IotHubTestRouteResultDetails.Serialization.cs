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

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class IotHubTestRouteResultDetails : IUtf8JsonSerializable, IModelJsonSerializable<IotHubTestRouteResultDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotHubTestRouteResultDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotHubTestRouteResultDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubTestRouteResultDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CompilationErrors))
            {
                writer.WritePropertyName("compilationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in CompilationErrors)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RouteCompilationError>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static IotHubTestRouteResultDetails DeserializeIotHubTestRouteResultDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<RouteCompilationError>> compilationErrors = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("compilationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteCompilationError> array = new List<RouteCompilationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteCompilationError.DeserializeRouteCompilationError(item));
                    }
                    compilationErrors = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotHubTestRouteResultDetails(Optional.ToList(compilationErrors), serializedAdditionalRawData);
        }

        IotHubTestRouteResultDetails IModelJsonSerializable<IotHubTestRouteResultDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubTestRouteResultDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubTestRouteResultDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotHubTestRouteResultDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubTestRouteResultDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotHubTestRouteResultDetails IModelSerializable<IotHubTestRouteResultDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubTestRouteResultDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotHubTestRouteResultDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotHubTestRouteResultDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotHubTestRouteResultDetails"/> to convert. </param>
        public static implicit operator RequestContent(IotHubTestRouteResultDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotHubTestRouteResultDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotHubTestRouteResultDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotHubTestRouteResultDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
