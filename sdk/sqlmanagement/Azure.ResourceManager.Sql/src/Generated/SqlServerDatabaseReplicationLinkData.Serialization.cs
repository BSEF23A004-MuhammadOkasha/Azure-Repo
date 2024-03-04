// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerDatabaseReplicationLinkData : IUtf8JsonSerializable, IJsonModel<SqlServerDatabaseReplicationLinkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServerDatabaseReplicationLinkData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlServerDatabaseReplicationLinkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerDatabaseReplicationLinkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerDatabaseReplicationLinkData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PartnerServer))
            {
                writer.WritePropertyName("partnerServer"u8);
                writer.WriteStringValue(PartnerServer);
            }
            if (options.Format != "W" && Optional.IsDefined(PartnerDatabase))
            {
                writer.WritePropertyName("partnerDatabase"u8);
                writer.WriteStringValue(PartnerDatabase);
            }
            if (options.Format != "W" && Optional.IsDefined(PartnerLocation))
            {
                writer.WritePropertyName("partnerLocation"u8);
                writer.WriteStringValue(PartnerLocation.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(PartnerRole))
            {
                writer.WritePropertyName("partnerRole"u8);
                writer.WriteStringValue(PartnerRole.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationMode))
            {
                writer.WritePropertyName("replicationMode"u8);
                writer.WriteStringValue(ReplicationMode);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(PercentComplete))
            {
                writer.WritePropertyName("percentComplete"u8);
                writer.WriteNumberValue(PercentComplete.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationState))
            {
                writer.WritePropertyName("replicationState"u8);
                writer.WriteStringValue(ReplicationState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IsTerminationAllowed))
            {
                writer.WritePropertyName("isTerminationAllowed"u8);
                writer.WriteBooleanValue(IsTerminationAllowed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LinkType))
            {
                writer.WritePropertyName("linkType"u8);
                writer.WriteStringValue(LinkType.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SqlServerDatabaseReplicationLinkData IJsonModel<SqlServerDatabaseReplicationLinkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerDatabaseReplicationLinkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerDatabaseReplicationLinkData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerDatabaseReplicationLinkData(document.RootElement, options);
        }

        internal static SqlServerDatabaseReplicationLinkData DeserializeSqlServerDatabaseReplicationLinkData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string partnerServer = default;
            string partnerDatabase = default;
            AzureLocation? partnerLocation = default;
            SqlServerDatabaseReplicationRole? role = default;
            SqlServerDatabaseReplicationRole? partnerRole = default;
            string replicationMode = default;
            DateTimeOffset? startTime = default;
            int? percentComplete = default;
            ReplicationLinkState? replicationState = default;
            bool? isTerminationAllowed = default;
            ReplicationLinkType? linkType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("partnerServer"u8))
                        {
                            partnerServer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerDatabase"u8))
                        {
                            partnerDatabase = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("role"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            role = property0.Value.GetString().ToSqlServerDatabaseReplicationRole();
                            continue;
                        }
                        if (property0.NameEquals("partnerRole"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerRole = property0.Value.GetString().ToSqlServerDatabaseReplicationRole();
                            continue;
                        }
                        if (property0.NameEquals("replicationMode"u8))
                        {
                            replicationMode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("percentComplete"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            percentComplete = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("replicationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicationState = new ReplicationLinkState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isTerminationAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isTerminationAllowed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("linkType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkType = new ReplicationLinkType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlServerDatabaseReplicationLinkData(
                id,
                name,
                type,
                systemData,
                partnerServer,
                partnerDatabase,
                partnerLocation,
                role,
                partnerRole,
                replicationMode,
                startTime,
                percentComplete,
                replicationState,
                isTerminationAllowed,
                linkType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlServerDatabaseReplicationLinkData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerDatabaseReplicationLinkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlServerDatabaseReplicationLinkData)} does not support '{options.Format}' format.");
            }
        }

        SqlServerDatabaseReplicationLinkData IPersistableModel<SqlServerDatabaseReplicationLinkData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerDatabaseReplicationLinkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlServerDatabaseReplicationLinkData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlServerDatabaseReplicationLinkData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlServerDatabaseReplicationLinkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
