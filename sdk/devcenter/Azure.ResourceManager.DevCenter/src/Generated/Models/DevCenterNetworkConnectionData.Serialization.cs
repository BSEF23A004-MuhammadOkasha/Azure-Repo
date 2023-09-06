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
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    public partial class DevCenterNetworkConnectionData : IUtf8JsonSerializable, IModelJsonSerializable<DevCenterNetworkConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevCenterNetworkConnectionData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevCenterNetworkConnectionData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevCenterNetworkConnectionData>(this, options.Format);

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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (Optional.IsDefined(OrganizationUnit))
            {
                writer.WritePropertyName("organizationUnit"u8);
                writer.WriteStringValue(OrganizationUnit);
            }
            if (Optional.IsDefined(DomainUsername))
            {
                writer.WritePropertyName("domainUsername"u8);
                writer.WriteStringValue(DomainUsername);
            }
            if (Optional.IsDefined(DomainPassword))
            {
                writer.WritePropertyName("domainPassword"u8);
                writer.WriteStringValue(DomainPassword);
            }
            if (Optional.IsDefined(NetworkingResourceGroupName))
            {
                writer.WritePropertyName("networkingResourceGroupName"u8);
                writer.WriteStringValue(NetworkingResourceGroupName);
            }
            if (Optional.IsDefined(DomainJoinType))
            {
                writer.WritePropertyName("domainJoinType"u8);
                writer.WriteStringValue(DomainJoinType.Value.ToString());
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

        internal static DevCenterNetworkConnectionData DeserializeDevCenterNetworkConnectionData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> subnetId = default;
            Optional<string> domainName = default;
            Optional<string> organizationUnit = default;
            Optional<string> domainUsername = default;
            Optional<string> domainPassword = default;
            Optional<DevCenterProvisioningState> provisioningState = default;
            Optional<DevCenterHealthCheckStatus> healthCheckStatus = default;
            Optional<string> networkingResourceGroupName = default;
            Optional<DomainJoinType> domainJoinType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("subnetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("domainName"u8))
                        {
                            domainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("organizationUnit"u8))
                        {
                            organizationUnit = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainUsername"u8))
                        {
                            domainUsername = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainPassword"u8))
                        {
                            domainPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DevCenterProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("healthCheckStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            healthCheckStatus = new DevCenterHealthCheckStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("networkingResourceGroupName"u8))
                        {
                            networkingResourceGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainJoinType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            domainJoinType = new DomainJoinType(property0.Value.GetString());
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
            return new DevCenterNetworkConnectionData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, subnetId.Value, domainName.Value, organizationUnit.Value, domainUsername.Value, domainPassword.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(healthCheckStatus), networkingResourceGroupName.Value, Optional.ToNullable(domainJoinType), rawData);
        }

        DevCenterNetworkConnectionData IModelJsonSerializable<DevCenterNetworkConnectionData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevCenterNetworkConnectionData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterNetworkConnectionData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevCenterNetworkConnectionData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevCenterNetworkConnectionData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevCenterNetworkConnectionData IModelSerializable<DevCenterNetworkConnectionData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevCenterNetworkConnectionData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevCenterNetworkConnectionData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevCenterNetworkConnectionData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevCenterNetworkConnectionData"/> to convert. </param>
        public static implicit operator RequestContent(DevCenterNetworkConnectionData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevCenterNetworkConnectionData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevCenterNetworkConnectionData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevCenterNetworkConnectionData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
