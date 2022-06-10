// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class BillingMeter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(MeterId))
            {
                writer.WritePropertyName("meterId");
                writer.WriteStringValue(MeterId);
            }
            if (Optional.IsDefined(BillingLocation))
            {
                writer.WritePropertyName("billingLocation");
                writer.WriteStringValue(BillingLocation);
            }
            if (Optional.IsDefined(ShortName))
            {
                writer.WritePropertyName("shortName");
                writer.WriteStringValue(ShortName);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName");
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(Multiplier))
            {
                writer.WritePropertyName("multiplier");
                writer.WriteNumberValue(Multiplier.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BillingMeter DeserializeBillingMeter(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> meterId = default;
            Optional<string> billingLocation = default;
            Optional<string> shortName = default;
            Optional<string> friendlyName = default;
            Optional<string> osType = default;
            Optional<double> multiplier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("meterId"))
                        {
                            meterId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingLocation"))
                        {
                            billingLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("shortName"))
                        {
                            shortName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osType"))
                        {
                            osType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("multiplier"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            multiplier = property0.Value.GetDouble();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BillingMeter(id, name, type, systemData, kind.Value, meterId.Value, billingLocation.Value, shortName.Value, friendlyName.Value, osType.Value, Optional.ToNullable(multiplier));
        }
    }
}
