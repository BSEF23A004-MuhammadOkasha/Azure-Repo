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
    public partial class NetworkTapPatch : IUtf8JsonSerializable, IModelJsonSerializable<NetworkTapPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkTapPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkTapPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkTapPatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsDefined(PollingType))
            {
                writer.WritePropertyName("pollingType"u8);
                writer.WriteStringValue(PollingType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Destinations))
            {
                writer.WritePropertyName("destinations"u8);
                writer.WriteStartArray();
                foreach (var item in Destinations)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<NetworkTapPatchableParametersDestinationsItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static NetworkTapPatch DeserializeNetworkTapPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> annotation = default;
            Optional<NetworkTapPollingType> pollingType = default;
            Optional<IList<NetworkTapPatchableParametersDestinationsItem>> destinations = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pollingType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pollingType = new NetworkTapPollingType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("destinations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkTapPatchableParametersDestinationsItem> array = new List<NetworkTapPatchableParametersDestinationsItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkTapPatchableParametersDestinationsItem.DeserializeNetworkTapPatchableParametersDestinationsItem(item));
                            }
                            destinations = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkTapPatch(Optional.ToDictionary(tags), annotation.Value, Optional.ToNullable(pollingType), Optional.ToList(destinations), serializedAdditionalRawData);
        }

        NetworkTapPatch IModelJsonSerializable<NetworkTapPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkTapPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkTapPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkTapPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkTapPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkTapPatch IModelSerializable<NetworkTapPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkTapPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkTapPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkTapPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkTapPatch"/> to convert. </param>
        public static implicit operator RequestContent(NetworkTapPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkTapPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkTapPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkTapPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
