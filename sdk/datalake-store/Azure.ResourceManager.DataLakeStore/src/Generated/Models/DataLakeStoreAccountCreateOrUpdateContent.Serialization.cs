// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    public partial class DataLakeStoreAccountCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultGroup))
            {
                writer.WritePropertyName("defaultGroup");
                writer.WriteStringValue(DefaultGroup);
            }
            if (Optional.IsDefined(EncryptionConfig))
            {
                writer.WritePropertyName("encryptionConfig");
                writer.WriteObjectValue(EncryptionConfig);
            }
            if (Optional.IsDefined(EncryptionState))
            {
                writer.WritePropertyName("encryptionState");
                writer.WriteStringValue(EncryptionState.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(FirewallRules))
            {
                writer.WritePropertyName("firewallRules");
                writer.WriteStartArray();
                foreach (var item in FirewallRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules");
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirewallState))
            {
                writer.WritePropertyName("firewallState");
                writer.WriteStringValue(FirewallState.Value.ToSerialString());
            }
            if (Optional.IsDefined(FirewallAllowAzureIPs))
            {
                writer.WritePropertyName("firewallAllowAzureIps");
                writer.WriteStringValue(FirewallAllowAzureIPs.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(TrustedIdProviders))
            {
                writer.WritePropertyName("trustedIdProviders");
                writer.WriteStartArray();
                foreach (var item in TrustedIdProviders)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TrustedIdProviderState))
            {
                writer.WritePropertyName("trustedIdProviderState");
                writer.WriteStringValue(TrustedIdProviderState.Value.ToSerialString());
            }
            if (Optional.IsDefined(NewTier))
            {
                writer.WritePropertyName("newTier");
                writer.WriteStringValue(NewTier.Value.ToSerialString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
