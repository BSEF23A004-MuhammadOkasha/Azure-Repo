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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    public partial class PostgreSqlFlexibleServerData : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlFlexibleServerData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlFlexibleServerData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlFlexibleServerData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PostgreSqlFlexibleServerSku>)Sku).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                if (Identity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PostgreSqlFlexibleServerUserAssignedIdentity>)Identity).Serialize(writer, options);
                }
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
            if (Optional.IsDefined(AdministratorLogin))
            {
                writer.WritePropertyName("administratorLogin"u8);
                writer.WriteStringValue(AdministratorLogin);
            }
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword"u8);
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version.Value.ToString());
            }
            if (Optional.IsDefined(Storage))
            {
                writer.WritePropertyName("storage"u8);
                if (Storage is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PostgreSqlFlexibleServerStorage>)Storage).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AuthConfig))
            {
                writer.WritePropertyName("authConfig"u8);
                if (AuthConfig is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PostgreSqlFlexibleServerAuthConfig>)AuthConfig).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DataEncryption))
            {
                writer.WritePropertyName("dataEncryption"u8);
                if (DataEncryption is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PostgreSqlFlexibleServerDataEncryption>)DataEncryption).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Backup))
            {
                writer.WritePropertyName("backup"u8);
                if (Backup is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PostgreSqlFlexibleServerBackupProperties>)Backup).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Network))
            {
                writer.WritePropertyName("network"u8);
                if (Network is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PostgreSqlFlexibleServerNetwork>)Network).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(HighAvailability))
            {
                writer.WritePropertyName("highAvailability"u8);
                if (HighAvailability is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PostgreSqlFlexibleServerHighAvailability>)HighAvailability).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(MaintenanceWindow))
            {
                writer.WritePropertyName("maintenanceWindow"u8);
                if (MaintenanceWindow is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PostgreSqlFlexibleServerMaintenanceWindow>)MaintenanceWindow).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SourceServerResourceId))
            {
                writer.WritePropertyName("sourceServerResourceId"u8);
                writer.WriteStringValue(SourceServerResourceId);
            }
            if (Optional.IsDefined(PointInTimeUtc))
            {
                writer.WritePropertyName("pointInTimeUTC"u8);
                writer.WriteStringValue(PointInTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(AvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteStringValue(AvailabilityZone);
            }
            if (Optional.IsDefined(ReplicationRole))
            {
                writer.WritePropertyName("replicationRole"u8);
                writer.WriteStringValue(ReplicationRole.Value.ToString());
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
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

        internal static PostgreSqlFlexibleServerData DeserializePostgreSqlFlexibleServerData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PostgreSqlFlexibleServerSku> sku = default;
            Optional<PostgreSqlFlexibleServerUserAssignedIdentity> identity = default;
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
            Optional<PostgreSqlFlexibleServerAuthConfig> authConfig = default;
            Optional<PostgreSqlFlexibleServerDataEncryption> dataEncryption = default;
            Optional<PostgreSqlFlexibleServerBackupProperties> backup = default;
            Optional<PostgreSqlFlexibleServerNetwork> network = default;
            Optional<PostgreSqlFlexibleServerHighAvailability> highAvailability = default;
            Optional<PostgreSqlFlexibleServerMaintenanceWindow> maintenanceWindow = default;
            Optional<ResourceIdentifier> sourceServerResourceId = default;
            Optional<DateTimeOffset> pointInTimeUTC = default;
            Optional<string> availabilityZone = default;
            Optional<PostgreSqlFlexibleServerReplicationRole> replicationRole = default;
            Optional<int> replicaCapacity = default;
            Optional<PostgreSqlFlexibleServerCreateMode> createMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = PostgreSqlFlexibleServerSku.DeserializePostgreSqlFlexibleServerSku(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = PostgreSqlFlexibleServerUserAssignedIdentity.DeserializePostgreSqlFlexibleServerUserAssignedIdentity(property.Value);
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
                        if (property0.NameEquals("administratorLogin"u8))
                        {
                            administratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administratorLoginPassword"u8))
                        {
                            administratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            version = new PostgreSqlFlexibleServerVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("minorVersion"u8))
                        {
                            minorVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new PostgreSqlFlexibleServerState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fullyQualifiedDomainName"u8))
                        {
                            fullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storage = PostgreSqlFlexibleServerStorage.DeserializePostgreSqlFlexibleServerStorage(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("authConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authConfig = PostgreSqlFlexibleServerAuthConfig.DeserializePostgreSqlFlexibleServerAuthConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataEncryption = PostgreSqlFlexibleServerDataEncryption.DeserializePostgreSqlFlexibleServerDataEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backup = PostgreSqlFlexibleServerBackupProperties.DeserializePostgreSqlFlexibleServerBackupProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("network"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            network = PostgreSqlFlexibleServerNetwork.DeserializePostgreSqlFlexibleServerNetwork(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("highAvailability"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            highAvailability = PostgreSqlFlexibleServerHighAvailability.DeserializePostgreSqlFlexibleServerHighAvailability(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceWindow = PostgreSqlFlexibleServerMaintenanceWindow.DeserializePostgreSqlFlexibleServerMaintenanceWindow(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sourceServerResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceServerResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("pointInTimeUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pointInTimeUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("availabilityZone"u8))
                        {
                            availabilityZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("replicationRole"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicationRole = new PostgreSqlFlexibleServerReplicationRole(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("replicaCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicaCapacity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("createMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createMode = new PostgreSqlFlexibleServerCreateMode(property0.Value.GetString());
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
            return new PostgreSqlFlexibleServerData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, identity.Value, administratorLogin.Value, administratorLoginPassword.Value, Optional.ToNullable(version), minorVersion.Value, Optional.ToNullable(state), fullyQualifiedDomainName.Value, storage.Value, authConfig.Value, dataEncryption.Value, backup.Value, network.Value, highAvailability.Value, maintenanceWindow.Value, sourceServerResourceId.Value, Optional.ToNullable(pointInTimeUTC), availabilityZone.Value, Optional.ToNullable(replicationRole), Optional.ToNullable(replicaCapacity), Optional.ToNullable(createMode), rawData);
        }

        PostgreSqlFlexibleServerData IModelJsonSerializable<PostgreSqlFlexibleServerData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlFlexibleServerData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlFlexibleServerData IModelSerializable<PostgreSqlFlexibleServerData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlFlexibleServerData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PostgreSqlFlexibleServerData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PostgreSqlFlexibleServerData"/> to convert. </param>
        public static implicit operator RequestContent(PostgreSqlFlexibleServerData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PostgreSqlFlexibleServerData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PostgreSqlFlexibleServerData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlFlexibleServerData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
