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

namespace Azure.ResourceManager.Peering.Models
{
    internal partial class PeeringServiceProviderListResult : IUtf8JsonSerializable, IModelJsonSerializable<PeeringServiceProviderListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PeeringServiceProviderListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PeeringServiceProviderListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PeeringServiceProviderListResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<PeeringServiceProvider>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static PeeringServiceProviderListResult DeserializePeeringServiceProviderListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PeeringServiceProvider>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PeeringServiceProvider> array = new List<PeeringServiceProvider>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeeringServiceProvider.DeserializePeeringServiceProvider(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PeeringServiceProviderListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        PeeringServiceProviderListResult IModelJsonSerializable<PeeringServiceProviderListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PeeringServiceProviderListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePeeringServiceProviderListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PeeringServiceProviderListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PeeringServiceProviderListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PeeringServiceProviderListResult IModelSerializable<PeeringServiceProviderListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PeeringServiceProviderListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePeeringServiceProviderListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PeeringServiceProviderListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PeeringServiceProviderListResult"/> to convert. </param>
        public static implicit operator RequestContent(PeeringServiceProviderListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PeeringServiceProviderListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PeeringServiceProviderListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePeeringServiceProviderListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
