// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoClusterPatch : IUtf8JsonSerializable, IJsonModel<KustoClusterPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KustoClusterPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KustoClusterPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoClusterPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoClusterPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (!(Zones is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
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
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Uri != null)
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (options.Format != "W" && DataIngestionUri != null)
            {
                writer.WritePropertyName("dataIngestionUri"u8);
                writer.WriteStringValue(DataIngestionUri.AbsoluteUri);
            }
            if (options.Format != "W" && StateReason != null)
            {
                writer.WritePropertyName("stateReason"u8);
                writer.WriteStringValue(StateReason);
            }
            if (!(TrustedExternalTenants is ChangeTrackingList<KustoClusterTrustedExternalTenant> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("trustedExternalTenants"u8);
                writer.WriteStartArray();
                foreach (var item in TrustedExternalTenants)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OptimizedAutoscale != null)
            {
                writer.WritePropertyName("optimizedAutoscale"u8);
                writer.WriteObjectValue(OptimizedAutoscale);
            }
            if (IsDiskEncryptionEnabled.HasValue)
            {
                writer.WritePropertyName("enableDiskEncryption"u8);
                writer.WriteBooleanValue(IsDiskEncryptionEnabled.Value);
            }
            if (IsStreamingIngestEnabled.HasValue)
            {
                writer.WritePropertyName("enableStreamingIngest"u8);
                writer.WriteBooleanValue(IsStreamingIngestEnabled.Value);
            }
            if (VirtualNetworkConfiguration != null)
            {
                writer.WritePropertyName("virtualNetworkConfiguration"u8);
                writer.WriteObjectValue(VirtualNetworkConfiguration);
            }
            if (KeyVaultProperties != null)
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                writer.WriteObjectValue(KeyVaultProperties);
            }
            if (IsPurgeEnabled.HasValue)
            {
                writer.WritePropertyName("enablePurge"u8);
                writer.WriteBooleanValue(IsPurgeEnabled.Value);
            }
            if (LanguageExtensions != null)
            {
                writer.WritePropertyName("languageExtensions"u8);
                writer.WriteObjectValue(LanguageExtensions);
            }
            if (IsDoubleEncryptionEnabled.HasValue)
            {
                writer.WritePropertyName("enableDoubleEncryption"u8);
                writer.WriteBooleanValue(IsDoubleEncryptionEnabled.Value);
            }
            if (PublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (!(AllowedIPRangeList is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("allowedIpRangeList"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedIPRangeList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (EngineType.HasValue)
            {
                writer.WritePropertyName("engineType"u8);
                writer.WriteStringValue(EngineType.Value.ToString());
            }
            if (!(AcceptedAudiences is ChangeTrackingList<AcceptedAudience> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("acceptedAudiences"u8);
                writer.WriteStartArray();
                foreach (var item in AcceptedAudiences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsAutoStopEnabled.HasValue)
            {
                writer.WritePropertyName("enableAutoStop"u8);
                writer.WriteBooleanValue(IsAutoStopEnabled.Value);
            }
            if (RestrictOutboundNetworkAccess.HasValue)
            {
                writer.WritePropertyName("restrictOutboundNetworkAccess"u8);
                writer.WriteStringValue(RestrictOutboundNetworkAccess.Value.ToString());
            }
            if (!(AllowedFqdnList is ChangeTrackingList<string> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("allowedFqdnList"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedFqdnList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (PublicIPType.HasValue)
            {
                writer.WritePropertyName("publicIPType"u8);
                writer.WriteStringValue(PublicIPType.Value.ToString());
            }
            if (VirtualClusterGraduationProperties != null)
            {
                writer.WritePropertyName("virtualClusterGraduationProperties"u8);
                writer.WriteStringValue(VirtualClusterGraduationProperties);
            }
            if (options.Format != "W" && !(PrivateEndpointConnections is ChangeTrackingList<KustoPrivateEndpointConnectionData> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && MigrationCluster != null)
            {
                writer.WritePropertyName("migrationCluster"u8);
                writer.WriteObjectValue(MigrationCluster);
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

        KustoClusterPatch IJsonModel<KustoClusterPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoClusterPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoClusterPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoClusterPatch(document.RootElement, options);
        }

        internal static KustoClusterPatch DeserializeKustoClusterPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<KustoSku> sku = default;
            IList<string> zones = default;
            Optional<ManagedServiceIdentity> identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<KustoClusterState> state = default;
            Optional<KustoProvisioningState> provisioningState = default;
            Optional<Uri> uri = default;
            Optional<Uri> dataIngestionUri = default;
            Optional<string> stateReason = default;
            IList<KustoClusterTrustedExternalTenant> trustedExternalTenants = default;
            Optional<OptimizedAutoscale> optimizedAutoscale = default;
            Optional<bool> enableDiskEncryption = default;
            Optional<bool> enableStreamingIngest = default;
            Optional<KustoClusterVirtualNetworkConfiguration> virtualNetworkConfiguration = default;
            Optional<KustoKeyVaultProperties> keyVaultProperties = default;
            Optional<bool> enablePurge = default;
            Optional<KustoLanguageExtensionList> languageExtensions = default;
            Optional<bool> enableDoubleEncryption = default;
            Optional<KustoClusterPublicNetworkAccess> publicNetworkAccess = default;
            IList<string> allowedIPRangeList = default;
            Optional<KustoClusterEngineType> engineType = default;
            IList<AcceptedAudience> acceptedAudiences = default;
            Optional<bool> enableAutoStop = default;
            Optional<KustoClusterNetworkAccessFlag> restrictOutboundNetworkAccess = default;
            IList<string> allowedFqdnList = default;
            Optional<KustoClusterPublicIPType> publicIPType = default;
            Optional<string> virtualClusterGraduationProperties = default;
            IReadOnlyList<KustoPrivateEndpointConnectionData> privateEndpointConnections = default;
            Optional<MigrationClusterProperties> migrationCluster = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = KustoSku.DeserializeKustoSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
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
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new KustoClusterState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new KustoProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("uri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataIngestionUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataIngestionUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("stateReason"u8))
                        {
                            stateReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("trustedExternalTenants"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KustoClusterTrustedExternalTenant> array = new List<KustoClusterTrustedExternalTenant>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KustoClusterTrustedExternalTenant.DeserializeKustoClusterTrustedExternalTenant(item, options));
                            }
                            trustedExternalTenants = array;
                            continue;
                        }
                        if (property0.NameEquals("optimizedAutoscale"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optimizedAutoscale = OptimizedAutoscale.DeserializeOptimizedAutoscale(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enableDiskEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDiskEncryption = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableStreamingIngest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableStreamingIngest = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkConfiguration = KustoClusterVirtualNetworkConfiguration.DeserializeKustoClusterVirtualNetworkConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("keyVaultProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyVaultProperties = KustoKeyVaultProperties.DeserializeKustoKeyVaultProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enablePurge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePurge = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("languageExtensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            languageExtensions = KustoLanguageExtensionList.DeserializeKustoLanguageExtensionList(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enableDoubleEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDoubleEncryption = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new KustoClusterPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowedIpRangeList"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            allowedIPRangeList = array;
                            continue;
                        }
                        if (property0.NameEquals("engineType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            engineType = new KustoClusterEngineType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("acceptedAudiences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AcceptedAudience> array = new List<AcceptedAudience>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AcceptedAudience.DeserializeAcceptedAudience(item, options));
                            }
                            acceptedAudiences = array;
                            continue;
                        }
                        if (property0.NameEquals("enableAutoStop"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAutoStop = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("restrictOutboundNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restrictOutboundNetworkAccess = new KustoClusterNetworkAccessFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowedFqdnList"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            allowedFqdnList = array;
                            continue;
                        }
                        if (property0.NameEquals("publicIPType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPType = new KustoClusterPublicIPType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualClusterGraduationProperties"u8))
                        {
                            virtualClusterGraduationProperties = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KustoPrivateEndpointConnectionData> array = new List<KustoPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KustoPrivateEndpointConnectionData.DeserializeKustoPrivateEndpointConnectionData(item, options));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("migrationCluster"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationCluster = MigrationClusterProperties.DeserializeMigrationClusterProperties(property0.Value, options);
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
            return new KustoClusterPatch(id, name, type, systemData.Value, tags ?? new ChangeTrackingDictionary<string, string>(), location, sku.Value, zones ?? new ChangeTrackingList<string>(), identity, Optional.ToNullable(state), Optional.ToNullable(provisioningState), uri.Value, dataIngestionUri.Value, stateReason.Value, trustedExternalTenants ?? new ChangeTrackingList<KustoClusterTrustedExternalTenant>(), optimizedAutoscale.Value, Optional.ToNullable(enableDiskEncryption), Optional.ToNullable(enableStreamingIngest), virtualNetworkConfiguration.Value, keyVaultProperties.Value, Optional.ToNullable(enablePurge), languageExtensions.Value, Optional.ToNullable(enableDoubleEncryption), Optional.ToNullable(publicNetworkAccess), allowedIPRangeList ?? new ChangeTrackingList<string>(), Optional.ToNullable(engineType), acceptedAudiences ?? new ChangeTrackingList<AcceptedAudience>(), Optional.ToNullable(enableAutoStop), Optional.ToNullable(restrictOutboundNetworkAccess), allowedFqdnList ?? new ChangeTrackingList<string>(), Optional.ToNullable(publicIPType), virtualClusterGraduationProperties.Value, privateEndpointConnections ?? new ChangeTrackingList<KustoPrivateEndpointConnectionData>(), migrationCluster.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KustoClusterPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoClusterPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KustoClusterPatch)} does not support '{options.Format}' format.");
            }
        }

        KustoClusterPatch IPersistableModel<KustoClusterPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoClusterPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKustoClusterPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KustoClusterPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KustoClusterPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
