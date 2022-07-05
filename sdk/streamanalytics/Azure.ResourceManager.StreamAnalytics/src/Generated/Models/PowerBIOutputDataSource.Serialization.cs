// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class PowerBIOutputDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(OutputDataSourceType);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RefreshToken))
            {
                writer.WritePropertyName("refreshToken");
                writer.WriteStringValue(RefreshToken);
            }
            if (Optional.IsDefined(TokenUserPrincipalName))
            {
                writer.WritePropertyName("tokenUserPrincipalName");
                writer.WriteStringValue(TokenUserPrincipalName);
            }
            if (Optional.IsDefined(TokenUserDisplayName))
            {
                writer.WritePropertyName("tokenUserDisplayName");
                writer.WriteStringValue(TokenUserDisplayName);
            }
            if (Optional.IsDefined(Dataset))
            {
                writer.WritePropertyName("dataset");
                writer.WriteStringValue(Dataset);
            }
            if (Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table");
                writer.WriteStringValue(Table);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId");
                writer.WriteStringValue(GroupId);
            }
            if (Optional.IsDefined(GroupName))
            {
                writer.WritePropertyName("groupName");
                writer.WriteStringValue(GroupName);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode");
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PowerBIOutputDataSource DeserializePowerBIOutputDataSource(JsonElement element)
        {
            string type = default;
            Optional<string> refreshToken = default;
            Optional<string> tokenUserPrincipalName = default;
            Optional<string> tokenUserDisplayName = default;
            Optional<string> dataset = default;
            Optional<string> table = default;
            Optional<string> groupId = default;
            Optional<string> groupName = default;
            Optional<AuthenticationMode> authenticationMode = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("refreshToken"))
                        {
                            refreshToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tokenUserPrincipalName"))
                        {
                            tokenUserPrincipalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tokenUserDisplayName"))
                        {
                            tokenUserDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataset"))
                        {
                            dataset = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("table"))
                        {
                            table = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("groupId"))
                        {
                            groupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("groupName"))
                        {
                            groupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            authenticationMode = new AuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PowerBIOutputDataSource(type, refreshToken.Value, tokenUserPrincipalName.Value, tokenUserDisplayName.Value, dataset.Value, table.Value, groupId.Value, groupName.Value, Optional.ToNullable(authenticationMode));
        }
    }
}
