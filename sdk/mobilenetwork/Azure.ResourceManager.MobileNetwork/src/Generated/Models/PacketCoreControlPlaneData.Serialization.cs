// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class PacketCoreControlPlaneData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UserAssignedIdentity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(UserAssignedIdentity);
            }
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
            if (Optional.IsDefined(Installation))
            {
                writer.WritePropertyName("installation"u8);
                writer.WriteObjectValue(Installation);
            }
            writer.WritePropertyName("sites"u8);
            writer.WriteStartArray();
            foreach (var item in Sites)
            {
                JsonSerializer.Serialize(writer, item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("platform"u8);
            writer.WriteObjectValue(Platform);
            if (Optional.IsDefined(CoreNetworkTechnology))
            {
                writer.WritePropertyName("coreNetworkTechnology"u8);
                writer.WriteStringValue(CoreNetworkTechnology.Value.ToSerialString());
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            writer.WritePropertyName("controlPlaneAccessInterface"u8);
            writer.WriteObjectValue(ControlPlaneAccessInterface);
            writer.WritePropertyName("sku"u8);
            writer.WriteStringValue(Sku.ToString());
            if (Optional.IsDefined(UeMtu))
            {
                writer.WritePropertyName("ueMtu"u8);
                writer.WriteNumberValue(UeMtu.Value);
            }
            writer.WritePropertyName("localDiagnosticsAccess"u8);
            writer.WriteObjectValue(LocalDiagnosticsAccess);
            if (Optional.IsDefined(DiagnosticsUpload))
            {
                writer.WritePropertyName("diagnosticsUpload"u8);
                writer.WriteObjectValue(DiagnosticsUpload);
            }
            if (Optional.IsDefined(InteropSettings))
            {
                writer.WritePropertyName("interopSettings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(InteropSettings);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(InteropSettings.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PacketCoreControlPlaneData DeserializePacketCoreControlPlaneData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MobileNetworkManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<MobileNetworkProvisioningState> provisioningState = default;
            Optional<MobileNetworkInstallation> installation = default;
            IList<WritableSubResource> sites = default;
            MobileNetworkPlatformConfiguration platform = default;
            Optional<MobileNetworkCoreNetworkType> coreNetworkTechnology = default;
            Optional<string> version = default;
            Optional<string> installedVersion = default;
            Optional<string> rollbackVersion = default;
            MobileNetworkInterfaceProperties controlPlaneAccessInterface = default;
            MobileNetworkBillingSku sku = default;
            Optional<int> ueMtu = default;
            MobileNetworkLocalDiagnosticsAccessConfiguration localDiagnosticsAccess = default;
            Optional<DiagnosticsUploadConfiguration> diagnosticsUpload = default;
            Optional<BinaryData> interopSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = MobileNetworkManagedServiceIdentity.DeserializeMobileNetworkManagedServiceIdentity(property.Value);
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MobileNetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("installation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            installation = MobileNetworkInstallation.DeserializeMobileNetworkInstallation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sites"u8))
                        {
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            sites = array;
                            continue;
                        }
                        if (property0.NameEquals("platform"u8))
                        {
                            platform = MobileNetworkPlatformConfiguration.DeserializeMobileNetworkPlatformConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("coreNetworkTechnology"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coreNetworkTechnology = property0.Value.GetString().ToMobileNetworkCoreNetworkType();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("installedVersion"u8))
                        {
                            installedVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("rollbackVersion"u8))
                        {
                            rollbackVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("controlPlaneAccessInterface"u8))
                        {
                            controlPlaneAccessInterface = MobileNetworkInterfaceProperties.DeserializeMobileNetworkInterfaceProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            sku = new MobileNetworkBillingSku(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ueMtu"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ueMtu = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("localDiagnosticsAccess"u8))
                        {
                            localDiagnosticsAccess = MobileNetworkLocalDiagnosticsAccessConfiguration.DeserializeMobileNetworkLocalDiagnosticsAccessConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("diagnosticsUpload"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diagnosticsUpload = DiagnosticsUploadConfiguration.DeserializeDiagnosticsUploadConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("interopSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interopSettings = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PacketCoreControlPlaneData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity.Value, Optional.ToNullable(provisioningState), installation.Value, sites, platform, Optional.ToNullable(coreNetworkTechnology), version.Value, installedVersion.Value, rollbackVersion.Value, controlPlaneAccessInterface, sku, Optional.ToNullable(ueMtu), localDiagnosticsAccess, diagnosticsUpload.Value, interopSettings.Value);
        }
    }
}
