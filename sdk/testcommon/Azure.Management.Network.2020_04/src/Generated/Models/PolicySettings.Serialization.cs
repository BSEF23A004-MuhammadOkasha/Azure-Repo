// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PolicySettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(RequestBodyCheck))
            {
                writer.WritePropertyName("requestBodyCheck");
                writer.WriteBooleanValue(RequestBodyCheck.Value);
            }
            if (Optional.IsDefined(MaxRequestBodySizeInKb))
            {
                writer.WritePropertyName("maxRequestBodySizeInKb");
                writer.WriteNumberValue(MaxRequestBodySizeInKb.Value);
            }
            if (Optional.IsDefined(FileUploadLimitInMb))
            {
                writer.WritePropertyName("fileUploadLimitInMb");
                writer.WriteNumberValue(FileUploadLimitInMb.Value);
            }
            writer.WriteEndObject();
        }

        internal static PolicySettings DeserializePolicySettings(JsonElement element)
        {
            Optional<WebApplicationFirewallEnabledState> state = default;
            Optional<WebApplicationFirewallMode> mode = default;
            Optional<bool> requestBodyCheck = default;
            Optional<int> maxRequestBodySizeInKb = default;
            Optional<int> fileUploadLimitInMb = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new WebApplicationFirewallEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mode = new WebApplicationFirewallMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requestBodyCheck"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestBodyCheck = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxRequestBodySizeInKb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxRequestBodySizeInKb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fileUploadLimitInMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileUploadLimitInMb = property.Value.GetInt32();
                    continue;
                }
            }
            return new PolicySettings(Optional.ToNullable(state), Optional.ToNullable(mode), Optional.ToNullable(requestBodyCheck), Optional.ToNullable(maxRequestBodySizeInKb), Optional.ToNullable(fileUploadLimitInMb));
        }
    }
}
