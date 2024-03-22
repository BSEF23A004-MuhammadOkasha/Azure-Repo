// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    public partial class DataLakeStoreAccountPatch : IUtf8JsonSerializable, IJsonModel<DataLakeStoreAccountPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeStoreAccountPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataLakeStoreAccountPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreAccountPatch)} does not support writing '{format}' format.");
            }

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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultGroup))
            {
                writer.WritePropertyName("defaultGroup"u8);
                writer.WriteStringValue(DefaultGroup);
            }
            if (Optional.IsDefined(EncryptionConfig))
            {
                writer.WritePropertyName("encryptionConfig"u8);
                writer.WriteObjectValue<UpdateEncryptionConfig>(EncryptionConfig, options);
            }
            if (Optional.IsCollectionDefined(FirewallRules))
            {
                writer.WritePropertyName("firewallRules"u8);
                writer.WriteStartArray();
                foreach (var item in FirewallRules)
                {
                    writer.WriteObjectValue<FirewallRuleForDataLakeStoreAccountUpdateContent>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue<VirtualNetworkRuleForDataLakeStoreAccountUpdateContent>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirewallState))
            {
                writer.WritePropertyName("firewallState"u8);
                writer.WriteStringValue(FirewallState.Value.ToSerialString());
            }
            if (Optional.IsDefined(FirewallAllowAzureIPs))
            {
                writer.WritePropertyName("firewallAllowAzureIps"u8);
                writer.WriteStringValue(FirewallAllowAzureIPs.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(TrustedIdProviders))
            {
                writer.WritePropertyName("trustedIdProviders"u8);
                writer.WriteStartArray();
                foreach (var item in TrustedIdProviders)
                {
                    writer.WriteObjectValue<TrustedIdProviderForDataLakeStoreAccountUpdateContent>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TrustedIdProviderState))
            {
                writer.WritePropertyName("trustedIdProviderState"u8);
                writer.WriteStringValue(TrustedIdProviderState.Value.ToSerialString());
            }
            if (Optional.IsDefined(NewTier))
            {
                writer.WritePropertyName("newTier"u8);
                writer.WriteStringValue(NewTier.Value.ToSerialString());
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

        DataLakeStoreAccountPatch IJsonModel<DataLakeStoreAccountPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreAccountPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeStoreAccountPatch(document.RootElement, options);
        }

        internal static DataLakeStoreAccountPatch DeserializeDataLakeStoreAccountPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            string defaultGroup = default;
            UpdateEncryptionConfig encryptionConfig = default;
            IList<FirewallRuleForDataLakeStoreAccountUpdateContent> firewallRules = default;
            IList<VirtualNetworkRuleForDataLakeStoreAccountUpdateContent> virtualNetworkRules = default;
            DataLakeStoreFirewallState? firewallState = default;
            DataLakeStoreFirewallAllowAzureIPsState? firewallAllowAzureIPs = default;
            IList<TrustedIdProviderForDataLakeStoreAccountUpdateContent> trustedIdProviders = default;
            DataLakeStoreTrustedIdProviderState? trustedIdProviderState = default;
            DataLakeStoreCommitmentTierType? newTier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("defaultGroup"u8))
                        {
                            defaultGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionConfig = UpdateEncryptionConfig.DeserializeUpdateEncryptionConfig(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("firewallRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FirewallRuleForDataLakeStoreAccountUpdateContent> array = new List<FirewallRuleForDataLakeStoreAccountUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FirewallRuleForDataLakeStoreAccountUpdateContent.DeserializeFirewallRuleForDataLakeStoreAccountUpdateContent(item, options));
                            }
                            firewallRules = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualNetworkRuleForDataLakeStoreAccountUpdateContent> array = new List<VirtualNetworkRuleForDataLakeStoreAccountUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualNetworkRuleForDataLakeStoreAccountUpdateContent.DeserializeVirtualNetworkRuleForDataLakeStoreAccountUpdateContent(item, options));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallState = property0.Value.GetString().ToDataLakeStoreFirewallState();
                            continue;
                        }
                        if (property0.NameEquals("firewallAllowAzureIps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallAllowAzureIPs = property0.Value.GetString().ToDataLakeStoreFirewallAllowAzureIPsState();
                            continue;
                        }
                        if (property0.NameEquals("trustedIdProviders"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrustedIdProviderForDataLakeStoreAccountUpdateContent> array = new List<TrustedIdProviderForDataLakeStoreAccountUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrustedIdProviderForDataLakeStoreAccountUpdateContent.DeserializeTrustedIdProviderForDataLakeStoreAccountUpdateContent(item, options));
                            }
                            trustedIdProviders = array;
                            continue;
                        }
                        if (property0.NameEquals("trustedIdProviderState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trustedIdProviderState = property0.Value.GetString().ToDataLakeStoreTrustedIdProviderState();
                            continue;
                        }
                        if (property0.NameEquals("newTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newTier = property0.Value.GetString().ToDataLakeStoreCommitmentTierType();
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
            return new DataLakeStoreAccountPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                defaultGroup,
                encryptionConfig,
                firewallRules ?? new ChangeTrackingList<FirewallRuleForDataLakeStoreAccountUpdateContent>(),
                virtualNetworkRules ?? new ChangeTrackingList<VirtualNetworkRuleForDataLakeStoreAccountUpdateContent>(),
                firewallState,
                firewallAllowAzureIPs,
                trustedIdProviders ?? new ChangeTrackingList<TrustedIdProviderForDataLakeStoreAccountUpdateContent>(),
                trustedIdProviderState,
                newTier,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataLakeStoreAccountPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreAccountPatch)} does not support writing '{options.Format}' format.");
            }
        }

        DataLakeStoreAccountPatch IPersistableModel<DataLakeStoreAccountPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataLakeStoreAccountPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreAccountPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeStoreAccountPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
