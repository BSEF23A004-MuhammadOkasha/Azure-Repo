// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownReplicationProviderSpecificSettings))]
    public partial class ReplicationProviderSpecificSettings : IUtf8JsonSerializable, IJsonModel<ReplicationProviderSpecificSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReplicationProviderSpecificSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReplicationProviderSpecificSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProviderSpecificSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationProviderSpecificSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        ReplicationProviderSpecificSettings IJsonModel<ReplicationProviderSpecificSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProviderSpecificSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationProviderSpecificSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationProviderSpecificSettings(document.RootElement, options);
        }

        internal static ReplicationProviderSpecificSettings DeserializeReplicationProviderSpecificSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2AReplicationDetails.DeserializeA2AReplicationDetails(element, options);
                    case "A2ACrossClusterMigration": return A2ACrossClusterMigrationReplicationDetails.DeserializeA2ACrossClusterMigrationReplicationDetails(element, options);
                    case "HyperVReplica2012": return HyperVReplicaReplicationDetails.DeserializeHyperVReplicaReplicationDetails(element, options);
                    case "HyperVReplica2012R2": return HyperVReplicaBlueReplicationDetails.DeserializeHyperVReplicaBlueReplicationDetails(element, options);
                    case "HyperVReplicaAzure": return HyperVReplicaAzureReplicationDetails.DeserializeHyperVReplicaAzureReplicationDetails(element, options);
                    case "HyperVReplicaBaseReplicationDetails": return HyperVReplicaBaseReplicationDetails.DeserializeHyperVReplicaBaseReplicationDetails(element, options);
                    case "InMage": return InMageReplicationDetails.DeserializeInMageReplicationDetails(element, options);
                    case "InMageAzureV2": return InMageAzureV2ReplicationDetails.DeserializeInMageAzureV2ReplicationDetails(element, options);
                    case "InMageRcm": return InMageRcmReplicationDetails.DeserializeInMageRcmReplicationDetails(element, options);
                    case "InMageRcmFailback": return InMageRcmFailbackReplicationDetails.DeserializeInMageRcmFailbackReplicationDetails(element, options);
                }
            }
            return UnknownReplicationProviderSpecificSettings.DeserializeUnknownReplicationProviderSpecificSettings(element, options);
        }

        BinaryData IPersistableModel<ReplicationProviderSpecificSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProviderSpecificSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReplicationProviderSpecificSettings)} does not support '{options.Format}' format.");
            }
        }

        ReplicationProviderSpecificSettings IPersistableModel<ReplicationProviderSpecificSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProviderSpecificSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReplicationProviderSpecificSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReplicationProviderSpecificSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReplicationProviderSpecificSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
