// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ServiceAssociationLink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedResourceType))
            {
                writer.WritePropertyName("linkedResourceType");
                writer.WriteStringValue(LinkedResourceType);
            }
            if (Optional.IsDefined(Link))
            {
                writer.WritePropertyName("link");
                writer.WriteStringValue(Link);
            }
            if (Optional.IsDefined(AllowDelete))
            {
                writer.WritePropertyName("allowDelete");
                writer.WriteBooleanValue(AllowDelete.Value);
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations");
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServiceAssociationLink DeserializeServiceAssociationLink(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> linkedResourceType = default;
            Optional<string> link = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<bool> allowDelete = default;
            Optional<IList<string>> locations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
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
                        if (property0.NameEquals("linkedResourceType"))
                        {
                            linkedResourceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("link"))
                        {
                            link = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowDelete"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowDelete = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("locations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            locations = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServiceAssociationLink(id.Value, name.Value, etag.Value, type.Value, linkedResourceType.Value, link.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(allowDelete), Optional.ToList(locations));
        }
    }
}
