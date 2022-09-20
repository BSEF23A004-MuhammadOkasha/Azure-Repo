// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class DatadogSingleSignOnProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SingleSignOnState))
            {
                writer.WritePropertyName("singleSignOnState");
                writer.WriteStringValue(SingleSignOnState.Value.ToString());
            }
            if (Optional.IsDefined(EnterpriseAppId))
            {
                writer.WritePropertyName("enterpriseAppId");
                writer.WriteStringValue(EnterpriseAppId);
            }
            writer.WriteEndObject();
        }

        internal static DatadogSingleSignOnProperties DeserializeDatadogSingleSignOnProperties(JsonElement element)
        {
            Optional<ProvisioningState> provisioningState = default;
            Optional<SingleSignOnState> singleSignOnState = default;
            Optional<string> enterpriseAppId = default;
            Optional<Uri> singleSignOnUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("singleSignOnState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    singleSignOnState = new SingleSignOnState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enterpriseAppId"))
                {
                    enterpriseAppId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("singleSignOnUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        singleSignOnUrl = null;
                        continue;
                    }
                    singleSignOnUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new DatadogSingleSignOnProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(singleSignOnState), enterpriseAppId.Value, singleSignOnUrl.Value);
        }
    }
}
