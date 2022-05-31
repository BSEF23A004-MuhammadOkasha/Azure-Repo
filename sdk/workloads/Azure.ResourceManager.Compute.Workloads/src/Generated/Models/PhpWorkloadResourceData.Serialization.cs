// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Workloads.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute.Workloads
{
    public partial class PhpWorkloadResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AppLocation))
            {
                writer.WritePropertyName("appLocation");
                writer.WriteStringValue(AppLocation);
            }
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration");
                writer.WriteObjectValue(ManagedResourceGroupConfiguration);
            }
            if (Optional.IsDefined(AdminUserProfile))
            {
                writer.WritePropertyName("adminUserProfile");
                writer.WriteObjectValue(AdminUserProfile);
            }
            if (Optional.IsDefined(WebNodesProfile))
            {
                writer.WritePropertyName("webNodesProfile");
                writer.WriteObjectValue(WebNodesProfile);
            }
            if (Optional.IsDefined(ControllerProfile))
            {
                writer.WritePropertyName("controllerProfile");
                writer.WriteObjectValue(ControllerProfile);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile");
                writer.WriteObjectValue(NetworkProfile);
            }
            if (Optional.IsDefined(DatabaseProfile))
            {
                writer.WritePropertyName("databaseProfile");
                writer.WriteObjectValue(DatabaseProfile);
            }
            if (Optional.IsDefined(SiteProfile))
            {
                writer.WritePropertyName("siteProfile");
                writer.WriteObjectValue(SiteProfile);
            }
            if (Optional.IsDefined(FileshareProfile))
            {
                writer.WritePropertyName("fileshareProfile");
                writer.WriteObjectValue(FileshareProfile);
            }
            if (Optional.IsDefined(PhpProfile))
            {
                writer.WritePropertyName("phpProfile");
                writer.WriteObjectValue(PhpProfile);
            }
            if (Optional.IsDefined(SearchProfile))
            {
                writer.WritePropertyName("searchProfile");
                writer.WriteObjectValue(SearchProfile);
            }
            if (Optional.IsDefined(CacheProfile))
            {
                writer.WritePropertyName("cacheProfile");
                writer.WriteObjectValue(CacheProfile);
            }
            if (Optional.IsDefined(BackupProfile))
            {
                writer.WritePropertyName("backupProfile");
                writer.WriteObjectValue(BackupProfile);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PhpWorkloadResourceData DeserializePhpWorkloadResourceData(JsonElement element)
        {
            WorkloadKind kind = default;
            Optional<WorkloadsSku> sku = default;
            Optional<PhpWorkloadResourceIdentity> identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> appLocation = default;
            Optional<ManagedRGConfiguration> managedResourceGroupConfiguration = default;
            Optional<UserProfile> adminUserProfile = default;
            Optional<VmssNodesProfile> webNodesProfile = default;
            Optional<NodeProfile> controllerProfile = default;
            Optional<NetworkProfile> networkProfile = default;
            Optional<DatabaseProfile> databaseProfile = default;
            Optional<SiteProfile> siteProfile = default;
            Optional<FileshareProfile> fileshareProfile = default;
            Optional<PhpProfile> phpProfile = default;
            Optional<SearchProfile> searchProfile = default;
            Optional<CacheProfile> cacheProfile = default;
            Optional<BackupProfile> backupProfile = default;
            Optional<PhpWorkloadProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new WorkloadKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = WorkloadsSku.DeserializeWorkloadsSku(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = PhpWorkloadResourceIdentity.DeserializePhpWorkloadResourceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("appLocation"))
                        {
                            appLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            managedResourceGroupConfiguration = ManagedRGConfiguration.DeserializeManagedRGConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("adminUserProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            adminUserProfile = UserProfile.DeserializeUserProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("webNodesProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            webNodesProfile = VmssNodesProfile.DeserializeVmssNodesProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("controllerProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            controllerProfile = NodeProfile.DeserializeNodeProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkProfile = NetworkProfile.DeserializeNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("databaseProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            databaseProfile = DatabaseProfile.DeserializeDatabaseProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("siteProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            siteProfile = SiteProfile.DeserializeSiteProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("fileshareProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            fileshareProfile = FileshareProfile.DeserializeFileshareProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("phpProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            phpProfile = PhpProfile.DeserializePhpProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("searchProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            searchProfile = SearchProfile.DeserializeSearchProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cacheProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cacheProfile = CacheProfile.DeserializeCacheProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backupProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            backupProfile = BackupProfile.DeserializeBackupProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new PhpWorkloadProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PhpWorkloadResourceData(id, name, type, systemData, tags, location, kind, sku.Value, identity.Value, appLocation.Value, managedResourceGroupConfiguration.Value, adminUserProfile.Value, webNodesProfile.Value, controllerProfile.Value, networkProfile.Value, databaseProfile.Value, siteProfile.Value, fileshareProfile.Value, phpProfile.Value, searchProfile.Value, cacheProfile.Value, backupProfile.Value, Optional.ToNullable(provisioningState));
        }
    }
}
