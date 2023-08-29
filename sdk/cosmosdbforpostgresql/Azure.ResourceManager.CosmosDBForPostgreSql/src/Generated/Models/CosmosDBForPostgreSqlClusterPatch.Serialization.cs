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

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    public partial class CosmosDBForPostgreSqlClusterPatch : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBForPostgreSqlClusterPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBForPostgreSqlClusterPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBForPostgreSqlClusterPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword"u8);
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(PostgresqlVersion))
            {
                writer.WritePropertyName("postgresqlVersion"u8);
                writer.WriteStringValue(PostgresqlVersion);
            }
            if (Optional.IsDefined(CitusVersion))
            {
                writer.WritePropertyName("citusVersion"u8);
                writer.WriteStringValue(CitusVersion);
            }
            if (Optional.IsDefined(IsShardsOnCoordinatorEnabled))
            {
                writer.WritePropertyName("enableShardsOnCoordinator"u8);
                writer.WriteBooleanValue(IsShardsOnCoordinatorEnabled.Value);
            }
            if (Optional.IsDefined(IsHAEnabled))
            {
                writer.WritePropertyName("enableHa"u8);
                writer.WriteBooleanValue(IsHAEnabled.Value);
            }
            if (Optional.IsDefined(PreferredPrimaryZone))
            {
                writer.WritePropertyName("preferredPrimaryZone"u8);
                writer.WriteStringValue(PreferredPrimaryZone);
            }
            if (Optional.IsDefined(CoordinatorServerEdition))
            {
                writer.WritePropertyName("coordinatorServerEdition"u8);
                writer.WriteStringValue(CoordinatorServerEdition);
            }
            if (Optional.IsDefined(CoordinatorStorageQuotaInMb))
            {
                writer.WritePropertyName("coordinatorStorageQuotaInMb"u8);
                writer.WriteNumberValue(CoordinatorStorageQuotaInMb.Value);
            }
            if (Optional.IsDefined(CoordinatorVCores))
            {
                writer.WritePropertyName("coordinatorVCores"u8);
                writer.WriteNumberValue(CoordinatorVCores.Value);
            }
            if (Optional.IsDefined(IsCoordinatorPublicIPAccessEnabled))
            {
                writer.WritePropertyName("coordinatorEnablePublicIpAccess"u8);
                writer.WriteBooleanValue(IsCoordinatorPublicIPAccessEnabled.Value);
            }
            if (Optional.IsDefined(NodeServerEdition))
            {
                writer.WritePropertyName("nodeServerEdition"u8);
                writer.WriteStringValue(NodeServerEdition);
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (Optional.IsDefined(NodeStorageQuotaInMb))
            {
                writer.WritePropertyName("nodeStorageQuotaInMb"u8);
                writer.WriteNumberValue(NodeStorageQuotaInMb.Value);
            }
            if (Optional.IsDefined(NodeVCores))
            {
                writer.WritePropertyName("nodeVCores"u8);
                writer.WriteNumberValue(NodeVCores.Value);
            }
            if (Optional.IsDefined(MaintenanceWindow))
            {
                writer.WritePropertyName("maintenanceWindow"u8);
                writer.WriteObjectValue(MaintenanceWindow);
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

        internal static CosmosDBForPostgreSqlClusterPatch DeserializeCosmosDBForPostgreSqlClusterPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> administratorLoginPassword = default;
            Optional<string> postgresqlVersion = default;
            Optional<string> citusVersion = default;
            Optional<bool> enableShardsOnCoordinator = default;
            Optional<bool> enableHa = default;
            Optional<string> preferredPrimaryZone = default;
            Optional<string> coordinatorServerEdition = default;
            Optional<int> coordinatorStorageQuotaInMb = default;
            Optional<int> coordinatorVCores = default;
            Optional<bool> coordinatorEnablePublicIPAccess = default;
            Optional<string> nodeServerEdition = default;
            Optional<int> nodeCount = default;
            Optional<int> nodeStorageQuotaInMb = default;
            Optional<int> nodeVCores = default;
            Optional<bool> nodeEnablePublicIPAccess = default;
            Optional<CosmosDBForPostgreSqlMaintenanceWindow> maintenanceWindow = default;
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("administratorLoginPassword"u8))
                        {
                            administratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("postgresqlVersion"u8))
                        {
                            postgresqlVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("citusVersion"u8))
                        {
                            citusVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableShardsOnCoordinator"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableShardsOnCoordinator = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableHa"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableHa = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("preferredPrimaryZone"u8))
                        {
                            preferredPrimaryZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorServerEdition"u8))
                        {
                            coordinatorServerEdition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorStorageQuotaInMb"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coordinatorStorageQuotaInMb = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorVCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coordinatorVCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorEnablePublicIpAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coordinatorEnablePublicIPAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("nodeServerEdition"u8))
                        {
                            nodeServerEdition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("nodeStorageQuotaInMb"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeStorageQuotaInMb = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("nodeVCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeVCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("nodeEnablePublicIpAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeEnablePublicIPAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceWindow = CosmosDBForPostgreSqlMaintenanceWindow.DeserializeCosmosDBForPostgreSqlMaintenanceWindow(property0.Value);
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
            return new CosmosDBForPostgreSqlClusterPatch(Optional.ToDictionary(tags), administratorLoginPassword.Value, postgresqlVersion.Value, citusVersion.Value, Optional.ToNullable(enableShardsOnCoordinator), Optional.ToNullable(enableHa), preferredPrimaryZone.Value, coordinatorServerEdition.Value, Optional.ToNullable(coordinatorStorageQuotaInMb), Optional.ToNullable(coordinatorVCores), Optional.ToNullable(coordinatorEnablePublicIPAccess), nodeServerEdition.Value, Optional.ToNullable(nodeCount), Optional.ToNullable(nodeStorageQuotaInMb), Optional.ToNullable(nodeVCores), Optional.ToNullable(nodeEnablePublicIPAccess), maintenanceWindow.Value, rawData);
        }

        CosmosDBForPostgreSqlClusterPatch IModelJsonSerializable<CosmosDBForPostgreSqlClusterPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBForPostgreSqlClusterPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBForPostgreSqlClusterPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBForPostgreSqlClusterPatch IModelSerializable<CosmosDBForPostgreSqlClusterPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBForPostgreSqlClusterPatch(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CosmosDBForPostgreSqlClusterPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CosmosDBForPostgreSqlClusterPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBForPostgreSqlClusterPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
