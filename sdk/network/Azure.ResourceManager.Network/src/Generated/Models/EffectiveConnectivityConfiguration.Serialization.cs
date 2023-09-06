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
    public partial class EffectiveConnectivityConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<EffectiveConnectivityConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EffectiveConnectivityConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EffectiveConnectivityConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EffectiveConnectivityConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsCollectionDefined(ConfigurationGroups))
            {
                writer.WritePropertyName("configurationGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationGroups)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<NetworkConfigurationGroup>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ConnectivityTopology))
            {
                writer.WritePropertyName("connectivityTopology"u8);
                writer.WriteStringValue(ConnectivityTopology.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Hubs))
            {
                writer.WritePropertyName("hubs"u8);
                writer.WriteStartArray();
                foreach (var item in Hubs)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ConnectivityHub>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsGlobal))
            {
                writer.WritePropertyName("isGlobal"u8);
                writer.WriteStringValue(IsGlobal.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AppliesToGroups))
            {
                writer.WritePropertyName("appliesToGroups"u8);
                writer.WriteStartArray();
                foreach (var item in AppliesToGroups)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ConnectivityGroupItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DeleteExistingPeering))
            {
                writer.WritePropertyName("deleteExistingPeering"u8);
                writer.WriteStringValue(DeleteExistingPeering.Value.ToString());
            }
            writer.WriteEndObject();
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

        internal static EffectiveConnectivityConfiguration DeserializeEffectiveConnectivityConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<IReadOnlyList<NetworkConfigurationGroup>> configurationGroups = default;
            Optional<string> description = default;
            Optional<ConnectivityTopology> connectivityTopology = default;
            Optional<IReadOnlyList<ConnectivityHub>> hubs = default;
            Optional<GlobalMeshSupportFlag> isGlobal = default;
            Optional<IReadOnlyList<ConnectivityGroupItem>> appliesToGroups = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<DeleteExistingPeering> deleteExistingPeering = default;
            Optional<Guid> resourceGuid = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkConfigurationGroup> array = new List<NetworkConfigurationGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkConfigurationGroup.DeserializeNetworkConfigurationGroup(item));
                    }
                    configurationGroups = array;
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectivityTopology"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectivityTopology = new ConnectivityTopology(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hubs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectivityHub> array = new List<ConnectivityHub>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectivityHub.DeserializeConnectivityHub(item));
                            }
                            hubs = array;
                            continue;
                        }
                        if (property0.NameEquals("isGlobal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isGlobal = new GlobalMeshSupportFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliesToGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectivityGroupItem> array = new List<ConnectivityGroupItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectivityGroupItem.DeserializeConnectivityGroupItem(item));
                            }
                            appliesToGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deleteExistingPeering"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleteExistingPeering = new DeleteExistingPeering(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EffectiveConnectivityConfiguration(id.Value, Optional.ToList(configurationGroups), description.Value, Optional.ToNullable(connectivityTopology), Optional.ToList(hubs), Optional.ToNullable(isGlobal), Optional.ToList(appliesToGroups), Optional.ToNullable(provisioningState), Optional.ToNullable(deleteExistingPeering), Optional.ToNullable(resourceGuid), rawData);
        }

        EffectiveConnectivityConfiguration IModelJsonSerializable<EffectiveConnectivityConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EffectiveConnectivityConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEffectiveConnectivityConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EffectiveConnectivityConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EffectiveConnectivityConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EffectiveConnectivityConfiguration IModelSerializable<EffectiveConnectivityConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EffectiveConnectivityConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEffectiveConnectivityConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EffectiveConnectivityConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EffectiveConnectivityConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(EffectiveConnectivityConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EffectiveConnectivityConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EffectiveConnectivityConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEffectiveConnectivityConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
