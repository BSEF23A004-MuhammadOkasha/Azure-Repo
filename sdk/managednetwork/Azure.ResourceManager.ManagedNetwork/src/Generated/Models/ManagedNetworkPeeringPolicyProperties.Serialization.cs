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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    public partial class ManagedNetworkPeeringPolicyProperties : IUtf8JsonSerializable, IModelJsonSerializable<ManagedNetworkPeeringPolicyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedNetworkPeeringPolicyProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedNetworkPeeringPolicyProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedNetworkPeeringPolicyProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ConnectivityType.ToString());
            if (Optional.IsDefined(Hub))
            {
                writer.WritePropertyName("hub"u8);
                JsonSerializer.Serialize(writer, Hub);
            }
            if (Optional.IsCollectionDefined(Spokes))
            {
                writer.WritePropertyName("spokes"u8);
                writer.WriteStartArray();
                foreach (var item in Spokes)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Mesh))
            {
                writer.WritePropertyName("mesh"u8);
                writer.WriteStartArray();
                foreach (var item in Mesh)
                {
                    JsonSerializer.Serialize(writer, item);
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

        internal static ManagedNetworkPeeringPolicyProperties DeserializeManagedNetworkPeeringPolicyProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ConnectivityType type = default;
            Optional<WritableSubResource> hub = default;
            Optional<IList<WritableSubResource>> spokes = default;
            Optional<IList<WritableSubResource>> mesh = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<ETag> etag = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ConnectivityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hub"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hub = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("spokes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    spokes = array;
                    continue;
                }
                if (property.NameEquals("mesh"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    mesh = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedNetworkPeeringPolicyProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(etag), type, hub, Optional.ToList(spokes), Optional.ToList(mesh), serializedAdditionalRawData);
        }

        ManagedNetworkPeeringPolicyProperties IModelJsonSerializable<ManagedNetworkPeeringPolicyProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedNetworkPeeringPolicyProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedNetworkPeeringPolicyProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedNetworkPeeringPolicyProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedNetworkPeeringPolicyProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedNetworkPeeringPolicyProperties IModelSerializable<ManagedNetworkPeeringPolicyProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedNetworkPeeringPolicyProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedNetworkPeeringPolicyProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedNetworkPeeringPolicyProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedNetworkPeeringPolicyProperties"/> to convert. </param>
        public static implicit operator RequestContent(ManagedNetworkPeeringPolicyProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedNetworkPeeringPolicyProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedNetworkPeeringPolicyProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedNetworkPeeringPolicyProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
