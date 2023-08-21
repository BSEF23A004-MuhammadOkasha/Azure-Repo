// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Confluent.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Confluent
{
    public partial class ConfluentOrganizationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
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
            writer.WritePropertyName("offerDetail"u8);
            writer.WriteObjectValue(OfferDetail);
            writer.WritePropertyName("userDetail"u8);
            writer.WriteObjectValue(UserDetail);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ConfluentOrganizationData DeserializeConfluentOrganizationData(JsonElement element)
        {
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
            Optional<DateTimeOffset> createdTime = default;
            Optional<ConfluentProvisionState> provisioningState = default;
            Optional<Guid> organizationId = default;
            Optional<Uri> ssoUrl = default;
            ConfluentOfferDetail offerDetail = default;
            ConfluentUserDetail userDetail = default;
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
                        if (property0.NameEquals("createdTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ConfluentProvisionState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("organizationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            organizationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("ssoUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ssoUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("offerDetail"u8))
                        {
                            offerDetail = ConfluentOfferDetail.DeserializeConfluentOfferDetail(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("userDetail"u8))
                        {
                            userDetail = ConfluentUserDetail.DeserializeConfluentUserDetail(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConfluentOrganizationData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(createdTime), Optional.ToNullable(provisioningState), Optional.ToNullable(organizationId), ssoUrl.Value, offerDetail, userDetail);
        }
    }
}
