// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ReplicationLinkData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ReplicationLinkData DeserializeReplicationLinkData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> partnerServer = default;
            Optional<string> partnerDatabase = default;
            Optional<string> partnerLocation = default;
            Optional<ReplicationRole> role = default;
            Optional<ReplicationRole> partnerRole = default;
            Optional<string> replicationMode = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<int> percentComplete = default;
            Optional<ReplicationState> replicationState = default;
            Optional<bool> isTerminationAllowed = default;
            Optional<ReplicationLinkType> linkType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("partnerServer"))
                        {
                            partnerServer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerDatabase"))
                        {
                            partnerDatabase = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerLocation"))
                        {
                            partnerLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("role"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            role = property0.Value.GetString().ToReplicationRole();
                            continue;
                        }
                        if (property0.NameEquals("partnerRole"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            partnerRole = property0.Value.GetString().ToReplicationRole();
                            continue;
                        }
                        if (property0.NameEquals("replicationMode"))
                        {
                            replicationMode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("percentComplete"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            percentComplete = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("replicationState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            replicationState = new ReplicationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isTerminationAllowed"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isTerminationAllowed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("linkType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            linkType = new ReplicationLinkType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ReplicationLinkData(id, name, type, partnerServer.Value, partnerDatabase.Value, partnerLocation.Value, Optional.ToNullable(role), Optional.ToNullable(partnerRole), replicationMode.Value, Optional.ToNullable(startTime), Optional.ToNullable(percentComplete), Optional.ToNullable(replicationState), Optional.ToNullable(isTerminationAllowed), Optional.ToNullable(linkType));
        }
    }
}
