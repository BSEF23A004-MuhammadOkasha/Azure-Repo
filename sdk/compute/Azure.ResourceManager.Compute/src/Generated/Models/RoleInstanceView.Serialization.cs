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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RoleInstanceView : IUtf8JsonSerializable, IModelJsonSerializable<RoleInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RoleInstanceView>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RoleInstanceView>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static RoleInstanceView DeserializeRoleInstanceView(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> platformUpdateDomain = default;
            Optional<int> platformFaultDomain = default;
            Optional<string> privateId = default;
            Optional<IReadOnlyList<ResourceInstanceViewStatus>> statuses = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("platformUpdateDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    platformUpdateDomain = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("platformFaultDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    platformFaultDomain = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("privateId"u8))
                {
                    privateId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statuses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceInstanceViewStatus> array = new List<ResourceInstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceInstanceViewStatus.DeserializeResourceInstanceViewStatus(item));
                    }
                    statuses = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RoleInstanceView(Optional.ToNullable(platformUpdateDomain), Optional.ToNullable(platformFaultDomain), privateId.Value, Optional.ToList(statuses), serializedAdditionalRawData);
        }

        RoleInstanceView IModelJsonSerializable<RoleInstanceView>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleInstanceView(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RoleInstanceView>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RoleInstanceView IModelSerializable<RoleInstanceView>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRoleInstanceView(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RoleInstanceView"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RoleInstanceView"/> to convert. </param>
        public static implicit operator RequestContent(RoleInstanceView model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RoleInstanceView"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RoleInstanceView(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRoleInstanceView(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
