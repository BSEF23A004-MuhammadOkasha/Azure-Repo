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

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class MachineProperties : IUtf8JsonSerializable, IModelJsonSerializable<MachineProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LocationData))
            {
                writer.WritePropertyName("locationData"u8);
                if (LocationData is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LocationData>)LocationData).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ServiceStatuses))
            {
                writer.WritePropertyName("serviceStatuses"u8);
                if (ServiceStatuses is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<HybridComputeServiceStatuses>)ServiceStatuses).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CloudMetadata))
            {
                writer.WritePropertyName("cloudMetadata"u8);
                if (CloudMetadata is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CloudMetadata>)CloudMetadata).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                if (OSProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OSProfile>)OSProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(VmId))
            {
                writer.WritePropertyName("vmId"u8);
                writer.WriteStringValue(VmId);
            }
            if (Optional.IsDefined(ClientPublicKey))
            {
                writer.WritePropertyName("clientPublicKey"u8);
                writer.WriteStringValue(ClientPublicKey);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(PrivateLinkScopeResourceId))
            {
                writer.WritePropertyName("privateLinkScopeResourceId"u8);
                writer.WriteStringValue(PrivateLinkScopeResourceId);
            }
            if (Optional.IsDefined(ParentClusterResourceId))
            {
                writer.WritePropertyName("parentClusterResourceId"u8);
                writer.WriteStringValue(ParentClusterResourceId);
            }
            if (Optional.IsDefined(MssqlDiscovered))
            {
                writer.WritePropertyName("mssqlDiscovered"u8);
                writer.WriteStringValue(MssqlDiscovered);
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

        internal static MachineProperties DeserializeMachineProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LocationData> locationData = default;
            Optional<AgentConfiguration> agentConfiguration = default;
            Optional<HybridComputeServiceStatuses> serviceStatuses = default;
            Optional<CloudMetadata> cloudMetadata = default;
            Optional<OSProfile> osProfile = default;
            Optional<string> provisioningState = default;
            Optional<HybridComputeStatusType> status = default;
            Optional<DateTimeOffset> lastStatusChange = default;
            Optional<IReadOnlyList<ResponseError>> errorDetails = default;
            Optional<string> agentVersion = default;
            Optional<string> vmId = default;
            Optional<string> displayName = default;
            Optional<string> machineFqdn = default;
            Optional<string> clientPublicKey = default;
            Optional<string> osName = default;
            Optional<string> osVersion = default;
            Optional<string> osType = default;
            Optional<string> vmUuid = default;
            Optional<string> osSku = default;
            Optional<string> domainName = default;
            Optional<string> adFqdn = default;
            Optional<string> dnsFqdn = default;
            Optional<string> privateLinkScopeResourceId = default;
            Optional<string> parentClusterResourceId = default;
            Optional<string> mssqlDiscovered = default;
            Optional<IReadOnlyDictionary<string, string>> detectedProperties = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("locationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    locationData = LocationData.DeserializeLocationData(property.Value);
                    continue;
                }
                if (property.NameEquals("agentConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentConfiguration = AgentConfiguration.DeserializeAgentConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("serviceStatuses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceStatuses = HybridComputeServiceStatuses.DeserializeHybridComputeServiceStatuses(property.Value);
                    continue;
                }
                if (property.NameEquals("cloudMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudMetadata = CloudMetadata.DeserializeCloudMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("osProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osProfile = OSProfile.DeserializeOSProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new HybridComputeStatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastStatusChange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStatusChange = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResponseError> array = new List<ResponseError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<ResponseError>(item.GetRawText()));
                    }
                    errorDetails = array;
                    continue;
                }
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmId"u8))
                {
                    vmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineFqdn"u8))
                {
                    machineFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientPublicKey"u8))
                {
                    clientPublicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osName"u8))
                {
                    osName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osVersion"u8))
                {
                    osVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmUuid"u8))
                {
                    vmUuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osSku"u8))
                {
                    osSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adFqdn"u8))
                {
                    adFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsFqdn"u8))
                {
                    dnsFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateLinkScopeResourceId"u8))
                {
                    privateLinkScopeResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentClusterResourceId"u8))
                {
                    parentClusterResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mssqlDiscovered"u8))
                {
                    mssqlDiscovered = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detectedProperties"u8))
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
                    detectedProperties = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineProperties(locationData.Value, agentConfiguration.Value, serviceStatuses.Value, cloudMetadata.Value, osProfile.Value, provisioningState.Value, Optional.ToNullable(status), Optional.ToNullable(lastStatusChange), Optional.ToList(errorDetails), agentVersion.Value, vmId.Value, displayName.Value, machineFqdn.Value, clientPublicKey.Value, osName.Value, osVersion.Value, osType.Value, vmUuid.Value, osSku.Value, domainName.Value, adFqdn.Value, dnsFqdn.Value, privateLinkScopeResourceId.Value, parentClusterResourceId.Value, mssqlDiscovered.Value, Optional.ToDictionary(detectedProperties), serializedAdditionalRawData);
        }

        MachineProperties IModelJsonSerializable<MachineProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineProperties IModelSerializable<MachineProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineProperties"/> to convert. </param>
        public static implicit operator RequestContent(MachineProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
