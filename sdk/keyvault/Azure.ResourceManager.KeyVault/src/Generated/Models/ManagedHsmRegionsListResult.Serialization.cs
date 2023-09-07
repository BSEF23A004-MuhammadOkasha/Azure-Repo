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

namespace Azure.ResourceManager.KeyVault.Models
{
    internal partial class ManagedHsmRegionsListResult : IUtf8JsonSerializable, IModelJsonSerializable<ManagedHsmRegionsListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedHsmRegionsListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedHsmRegionsListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedHsmRegionsListResult>(this, options.Format);

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
                        ((IModelJsonSerializable<ManagedHsmGeoReplicatedRegion>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static ManagedHsmRegionsListResult DeserializeManagedHsmRegionsListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ManagedHsmGeoReplicatedRegion>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedHsmGeoReplicatedRegion> array = new List<ManagedHsmGeoReplicatedRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedHsmGeoReplicatedRegion.DeserializeManagedHsmGeoReplicatedRegion(item));
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
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedHsmRegionsListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        ManagedHsmRegionsListResult IModelJsonSerializable<ManagedHsmRegionsListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedHsmRegionsListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedHsmRegionsListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedHsmRegionsListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedHsmRegionsListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedHsmRegionsListResult IModelSerializable<ManagedHsmRegionsListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedHsmRegionsListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedHsmRegionsListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedHsmRegionsListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedHsmRegionsListResult"/> to convert. </param>
        public static implicit operator RequestContent(ManagedHsmRegionsListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedHsmRegionsListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedHsmRegionsListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedHsmRegionsListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
