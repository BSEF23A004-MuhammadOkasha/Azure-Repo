// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class BatchEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Defaults))
            {
                if (Defaults != null)
                {
                    writer.WritePropertyName("defaults");
                    writer.WriteObjectValue(Defaults);
                }
                else
                {
                    writer.WriteNull("defaults");
                }
            }
            writer.WritePropertyName("authMode");
            writer.WriteStringValue(AuthMode.ToString());
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description");
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsDefined(Keys))
            {
                if (Keys != null)
                {
                    writer.WritePropertyName("keys");
                    writer.WriteObjectValue(Keys);
                }
                else
                {
                    writer.WriteNull("keys");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties");
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            writer.WriteEndObject();
        }

        internal static BatchEndpoint DeserializeBatchEndpoint(JsonElement element)
        {
            Optional<BatchEndpointDefaults> defaults = default;
            Optional<EndpointProvisioningState> provisioningState = default;
            EndpointAuthMode authMode = default;
            Optional<string> description = default;
            Optional<EndpointAuthKeys> keys = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<string> scoringUri = default;
            Optional<string> swaggerUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaults"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaults = null;
                        continue;
                    }
                    defaults = BatchEndpointDefaults.DeserializeBatchEndpointDefaults(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new EndpointProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authMode"))
                {
                    authMode = new EndpointAuthMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keys = null;
                        continue;
                    }
                    keys = EndpointAuthKeys.DeserializeEndpointAuthKeys(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("scoringUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scoringUri = null;
                        continue;
                    }
                    scoringUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("swaggerUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        swaggerUri = null;
                        continue;
                    }
                    swaggerUri = property.Value.GetString();
                    continue;
                }
            }
            return new BatchEndpoint(authMode, description.Value, keys.Value, Optional.ToDictionary(properties), scoringUri.Value, swaggerUri.Value, defaults.Value, Optional.ToNullable(provisioningState));
        }
    }
}
