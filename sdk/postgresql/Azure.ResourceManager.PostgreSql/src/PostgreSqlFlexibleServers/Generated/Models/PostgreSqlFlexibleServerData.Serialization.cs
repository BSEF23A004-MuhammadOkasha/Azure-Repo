// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    public partial class PostgreSqlFlexibleServerData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorLogin))
            {
                writer.WritePropertyName("administratorLogin");
                writer.WriteStringValue(AdministratorLogin);
            }
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword");
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version.Value.ToString());
            }
            if (Optional.IsDefined(Storage))
            {
                writer.WritePropertyName("storage");
                writer.WriteObjectValue(Storage);
            }
            if (Optional.IsDefined(Backup))
            {
                writer.WritePropertyName("backup");
                writer.WriteObjectValue(Backup);
            }
            if (Optional.IsDefined(Network))
            {
                writer.WritePropertyName("network");
                writer.WriteObjectValue(Network);
            }
            if (Optional.IsDefined(HighAvailability))
            {
                writer.WritePropertyName("highAvailability");
                writer.WriteObjectValue(HighAvailability);
            }
            if (Optional.IsDefined(MaintenanceWindow))
            {
                writer.WritePropertyName("maintenanceWindow");
                writer.WriteObjectValue(MaintenanceWindow);
            }
            if (Optional.IsDefined(SourceServerResourceId))
            {
                writer.WritePropertyName("sourceServerResourceId");
                writer.WriteStringValue(SourceServerResourceId);
            }
            if (Optional.IsDefined(PointInTimeUTC))
            {
                writer.WritePropertyName("pointInTimeUTC");
                writer.WriteStringValue(PointInTimeUTC.Value, "O");
            }
            if (Optional.IsDefined(AvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone");
                writer.WriteStringValue(AvailabilityZone);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode");
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PostgreSqlFlexibleServerData DeserializePostgreSqlFlexibleServerData(JsonElement element)
        {
            Optional<PostgreSqlFlexibleServerSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> administratorLogin = default;
            Optional<string> administratorLoginPassword = default;
            Optional<PostgreSqlFlexibleServerVersion> version = default;
            Optional<string> minorVersion = default;
            Optional<PostgreSqlFlexibleServerState> state = default;
            Optional<string> fullyQualifiedDomainName = default;
            Optional<PostgreSqlFlexibleServerStorage> storage = default;
            Optional<PostgreSqlFlexibleServerBackupProperties> backup = default;
            Optional<PostgreSqlFlexibleServerNetwork> network = default;
            Optional<PostgreSqlFlexibleServerHighAvailability> highAvailability = default;
            Optional<PostgreSqlFlexibleServerMaintenanceWindow> maintenanceWindow = default;
            Optional<ResourceIdentifier> sourceServerResourceId = default;
            Optional<DateTimeOffset> pointInTimeUTC = default;
            Optional<string> availabilityZone = default;
            Optional<PostgreSqlFlexibleServerCreateMode> createMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = PostgreSqlFlexibleServerSku.DeserializePostgreSqlFlexibleServerSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                        if (property0.NameEquals("administratorLogin"))
                        {
                            administratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administratorLoginPassword"))
                        {
                            administratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            version = new PostgreSqlFlexibleServerVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("minorVersion"))
                        {
                            minorVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new PostgreSqlFlexibleServerState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fullyQualifiedDomainName"))
                        {
                            fullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            storage = PostgreSqlFlexibleServerStorage.DeserializePostgreSqlFlexibleServerStorage(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backup"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            backup = PostgreSqlFlexibleServerBackupProperties.DeserializePostgreSqlFlexibleServerBackupProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("network"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            network = PostgreSqlFlexibleServerNetwork.DeserializePostgreSqlFlexibleServerNetwork(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("highAvailability"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            highAvailability = PostgreSqlFlexibleServerHighAvailability.DeserializePostgreSqlFlexibleServerHighAvailability(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindow"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maintenanceWindow = PostgreSqlFlexibleServerMaintenanceWindow.DeserializePostgreSqlFlexibleServerMaintenanceWindow(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sourceServerResourceId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceServerResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("pointInTimeUTC"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            pointInTimeUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("availabilityZone"))
                        {
                            availabilityZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createMode = new PostgreSqlFlexibleServerCreateMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, administratorLogin.Value, administratorLoginPassword.Value, Optional.ToNullable(version), minorVersion.Value, Optional.ToNullable(state), fullyQualifiedDomainName.Value, storage.Value, backup.Value, network.Value, highAvailability.Value, maintenanceWindow.Value, sourceServerResourceId.Value, Optional.ToNullable(pointInTimeUTC), availabilityZone.Value, Optional.ToNullable(createMode));
        }
    }
}
