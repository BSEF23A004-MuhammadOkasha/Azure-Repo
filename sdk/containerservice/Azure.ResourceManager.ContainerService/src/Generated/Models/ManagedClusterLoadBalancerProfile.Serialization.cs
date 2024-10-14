// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterLoadBalancerProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterLoadBalancerProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterLoadBalancerProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterLoadBalancerProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ManagedOutboundIPs))
            {
                writer.WritePropertyName("managedOutboundIPs"u8);
                writer.WriteObjectValue(ManagedOutboundIPs, options);
            }
            if (Optional.IsDefined(OutboundIPPrefixes))
            {
                writer.WritePropertyName("outboundIPPrefixes"u8);
                writer.WriteObjectValue(OutboundIPPrefixes, options);
            }
            if (Optional.IsDefined(OutboundIPs))
            {
                writer.WritePropertyName("outboundIPs"u8);
                writer.WriteObjectValue(OutboundIPs, options);
            }
            if (Optional.IsCollectionDefined(EffectiveOutboundIPs))
            {
                writer.WritePropertyName("effectiveOutboundIPs"u8);
                writer.WriteStartArray();
                foreach (var item in EffectiveOutboundIPs)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllocatedOutboundPorts))
            {
                writer.WritePropertyName("allocatedOutboundPorts"u8);
                writer.WriteNumberValue(AllocatedOutboundPorts.Value);
            }
            if (Optional.IsDefined(IdleTimeoutInMinutes))
            {
                writer.WritePropertyName("idleTimeoutInMinutes"u8);
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(EnableMultipleStandardLoadBalancers))
            {
                writer.WritePropertyName("enableMultipleStandardLoadBalancers"u8);
                writer.WriteBooleanValue(EnableMultipleStandardLoadBalancers.Value);
            }
            if (Optional.IsDefined(BackendPoolType))
            {
                writer.WritePropertyName("backendPoolType"u8);
                writer.WriteStringValue(BackendPoolType.Value.ToString());
            }
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
        }

        ManagedClusterLoadBalancerProfile IJsonModel<ManagedClusterLoadBalancerProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterLoadBalancerProfile(document.RootElement, options);
        }

        internal static ManagedClusterLoadBalancerProfile DeserializeManagedClusterLoadBalancerProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedClusterLoadBalancerProfileManagedOutboundIPs managedOutboundIPs = default;
            ManagedClusterLoadBalancerProfileOutboundIPPrefixes outboundIPPrefixes = default;
            ManagedClusterLoadBalancerProfileOutboundIPs outboundIPs = default;
            IList<WritableSubResource> effectiveOutboundIPs = default;
            int? allocatedOutboundPorts = default;
            int? idleTimeoutInMinutes = default;
            bool? enableMultipleStandardLoadBalancers = default;
            ManagedClusterLoadBalancerBackendPoolType? backendPoolType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedOutboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedOutboundIPs = ManagedClusterLoadBalancerProfileManagedOutboundIPs.DeserializeManagedClusterLoadBalancerProfileManagedOutboundIPs(property.Value, options);
                    continue;
                }
                if (property.NameEquals("outboundIPPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundIPPrefixes = ManagedClusterLoadBalancerProfileOutboundIPPrefixes.DeserializeManagedClusterLoadBalancerProfileOutboundIPPrefixes(property.Value, options);
                    continue;
                }
                if (property.NameEquals("outboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundIPs = ManagedClusterLoadBalancerProfileOutboundIPs.DeserializeManagedClusterLoadBalancerProfileOutboundIPs(property.Value, options);
                    continue;
                }
                if (property.NameEquals("effectiveOutboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    effectiveOutboundIPs = array;
                    continue;
                }
                if (property.NameEquals("allocatedOutboundPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocatedOutboundPorts = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("idleTimeoutInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    idleTimeoutInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableMultipleStandardLoadBalancers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableMultipleStandardLoadBalancers = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backendPoolType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendPoolType = new ManagedClusterLoadBalancerBackendPoolType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterLoadBalancerProfile(
                managedOutboundIPs,
                outboundIPPrefixes,
                outboundIPs,
                effectiveOutboundIPs ?? new ChangeTrackingList<WritableSubResource>(),
                allocatedOutboundPorts,
                idleTimeoutInMinutes,
                enableMultipleStandardLoadBalancers,
                backendPoolType,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ManagedOutboundIPs), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  managedOutboundIPs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ManagedOutboundIPs))
                {
                    builder.Append("  managedOutboundIPs: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ManagedOutboundIPs, options, 2, false, "  managedOutboundIPs: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("OutboundPublicIPPrefixes", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  outboundIPPrefixes: ");
                builder.AppendLine("{");
                builder.Append("    publicIPPrefixes: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(OutboundIPPrefixes))
                {
                    builder.Append("  outboundIPPrefixes: ");
                    BicepSerializationHelpers.AppendChildObject(builder, OutboundIPPrefixes, options, 2, false, "  outboundIPPrefixes: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("OutboundPublicIPs", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  outboundIPs: ");
                builder.AppendLine("{");
                builder.Append("    publicIPs: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(OutboundIPs))
                {
                    builder.Append("  outboundIPs: ");
                    BicepSerializationHelpers.AppendChildObject(builder, OutboundIPs, options, 2, false, "  outboundIPs: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EffectiveOutboundIPs), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  effectiveOutboundIPs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(EffectiveOutboundIPs))
                {
                    if (EffectiveOutboundIPs.Any())
                    {
                        builder.Append("  effectiveOutboundIPs: ");
                        builder.AppendLine("[");
                        foreach (var item in EffectiveOutboundIPs)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  effectiveOutboundIPs: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllocatedOutboundPorts), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allocatedOutboundPorts: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AllocatedOutboundPorts))
                {
                    builder.Append("  allocatedOutboundPorts: ");
                    builder.AppendLine($"{AllocatedOutboundPorts.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IdleTimeoutInMinutes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  idleTimeoutInMinutes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IdleTimeoutInMinutes))
                {
                    builder.Append("  idleTimeoutInMinutes: ");
                    builder.AppendLine($"{IdleTimeoutInMinutes.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnableMultipleStandardLoadBalancers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableMultipleStandardLoadBalancers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnableMultipleStandardLoadBalancers))
                {
                    builder.Append("  enableMultipleStandardLoadBalancers: ");
                    var boolValue = EnableMultipleStandardLoadBalancers.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackendPoolType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  backendPoolType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BackendPoolType))
                {
                    builder.Append("  backendPoolType: ");
                    builder.AppendLine($"'{BackendPoolType.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedClusterLoadBalancerProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterLoadBalancerProfile IPersistableModel<ManagedClusterLoadBalancerProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterLoadBalancerProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterLoadBalancerProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
