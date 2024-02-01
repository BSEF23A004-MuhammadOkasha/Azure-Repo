// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    public partial class SapApplicationServerInstanceData : IUtf8JsonSerializable, IJsonModel<SapApplicationServerInstanceData>, IPersistableModel<SapApplicationServerInstanceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapApplicationServerInstanceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SapApplicationServerInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapApplicationServerInstanceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapApplicationServerInstanceData)} does not support '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(InstanceNo))
            {
                writer.WritePropertyName("instanceNo"u8);
                writer.WriteStringValue(InstanceNo);
            }
            if (options.Format != "W" && Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnet"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (options.Format != "W" && Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (options.Format != "W" && Optional.IsDefined(KernelVersion))
            {
                writer.WritePropertyName("kernelVersion"u8);
                writer.WriteStringValue(KernelVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(KernelPatch))
            {
                writer.WritePropertyName("kernelPatch"u8);
                writer.WriteStringValue(KernelPatch);
            }
            if (options.Format != "W" && Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(GatewayPort))
            {
                if (GatewayPort != null)
                {
                    writer.WritePropertyName("gatewayPort"u8);
                    writer.WriteNumberValue(GatewayPort.Value);
                }
                else
                {
                    writer.WriteNull("gatewayPort");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(IcmHttpPort))
            {
                if (IcmHttpPort != null)
                {
                    writer.WritePropertyName("icmHttpPort"u8);
                    writer.WriteNumberValue(IcmHttpPort.Value);
                }
                else
                {
                    writer.WriteNull("icmHttpPort");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(IcmHttpsPort))
            {
                if (IcmHttpsPort != null)
                {
                    writer.WritePropertyName("icmHttpsPort"u8);
                    writer.WriteNumberValue(IcmHttpsPort.Value);
                }
                else
                {
                    writer.WriteNull("icmHttpsPort");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(LoadBalancerDetails))
            {
                writer.WritePropertyName("loadBalancerDetails"u8);
                JsonSerializer.Serialize(writer, LoadBalancerDetails);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VmDetails))
            {
                writer.WritePropertyName("vmDetails"u8);
                writer.WriteStartArray();
                foreach (var item in VmDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Health))
            {
                writer.WritePropertyName("health"u8);
                writer.WriteStringValue(Health.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteObjectValue(Errors);
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

        SapApplicationServerInstanceData IJsonModel<SapApplicationServerInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapApplicationServerInstanceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapApplicationServerInstanceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapApplicationServerInstanceData(document.RootElement, options);
        }

        internal static SapApplicationServerInstanceData DeserializeSapApplicationServerInstanceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> instanceNo = default;
            Optional<ResourceIdentifier> subnet = default;
            Optional<string> hostname = default;
            Optional<string> kernelVersion = default;
            Optional<string> kernelPatch = default;
            Optional<string> ipAddress = default;
            Optional<long?> gatewayPort = default;
            Optional<long?> icmHttpPort = default;
            Optional<long?> icmHttpsPort = default;
            Optional<SubResource> loadBalancerDetails = default;
            Optional<IReadOnlyList<ApplicationServerVmDetails>> vmDetails = default;
            Optional<SapVirtualInstanceStatus> status = default;
            Optional<SapHealthState> health = default;
            Optional<SapVirtualInstanceProvisioningState> provisioningState = default;
            Optional<SapVirtualInstanceError> errors = default;
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
                        if (property0.NameEquals("instanceNo"u8))
                        {
                            instanceNo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnet = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostname"u8))
                        {
                            hostname = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kernelVersion"u8))
                        {
                            kernelVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kernelPatch"u8))
                        {
                            kernelPatch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"u8))
                        {
                            ipAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("gatewayPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                gatewayPort = null;
                                continue;
                            }
                            gatewayPort = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("icmHttpPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                icmHttpPort = null;
                                continue;
                            }
                            icmHttpPort = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("icmHttpsPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                icmHttpsPort = null;
                                continue;
                            }
                            icmHttpsPort = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loadBalancerDetails = JsonSerializer.Deserialize<SubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("vmDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationServerVmDetails> array = new List<ApplicationServerVmDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationServerVmDetails.DeserializeApplicationServerVmDetails(item));
                            }
                            vmDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SapVirtualInstanceStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("health"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            health = new SapHealthState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SapVirtualInstanceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errors = SapVirtualInstanceError.DeserializeSapVirtualInstanceError(property0.Value);
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
            return new SapApplicationServerInstanceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, instanceNo.Value, subnet.Value, hostname.Value, kernelVersion.Value, kernelPatch.Value, ipAddress.Value, Optional.ToNullable(gatewayPort), Optional.ToNullable(icmHttpPort), Optional.ToNullable(icmHttpsPort), loadBalancerDetails, Optional.ToList(vmDetails), Optional.ToNullable(status), Optional.ToNullable(health), Optional.ToNullable(provisioningState), errors.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(InstanceNo))
            {
                builder.Append("  instanceNo:");
                builder.AppendLine($" '{InstanceNo}'");
            }

            if (Optional.IsDefined(SubnetId))
            {
                builder.Append("  subnet:");
                builder.AppendLine($" '{SubnetId.ToString()}'");
            }

            if (Optional.IsDefined(Hostname))
            {
                builder.Append("  hostname:");
                builder.AppendLine($" '{Hostname}'");
            }

            if (Optional.IsDefined(KernelVersion))
            {
                builder.Append("  kernelVersion:");
                builder.AppendLine($" '{KernelVersion}'");
            }

            if (Optional.IsDefined(KernelPatch))
            {
                builder.Append("  kernelPatch:");
                builder.AppendLine($" '{KernelPatch}'");
            }

            if (Optional.IsDefined(IPAddress))
            {
                builder.Append("  ipAddress:");
                builder.AppendLine($" '{IPAddress}'");
            }

            if (Optional.IsDefined(GatewayPort))
            {
                builder.Append("  gatewayPort:");
                builder.AppendLine($" '{GatewayPort.Value.ToString()}'");
            }

            if (Optional.IsDefined(IcmHttpPort))
            {
                builder.Append("  icmHttpPort:");
                builder.AppendLine($" '{IcmHttpPort.Value.ToString()}'");
            }

            if (Optional.IsDefined(IcmHttpsPort))
            {
                builder.Append("  icmHttpsPort:");
                builder.AppendLine($" '{IcmHttpsPort.Value.ToString()}'");
            }

            if (Optional.IsDefined(LoadBalancerDetails))
            {
                builder.Append("  loadBalancerDetails:");
                AppendChildObject(builder, LoadBalancerDetails, options, 2);
            }

            if (Optional.IsCollectionDefined(VmDetails))
            {
                builder.Append("  vmDetails:");
                builder.AppendLine(" [");
                foreach (var item in VmDetails)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                builder.AppendLine($" '{Status.ToString()}'");
            }

            if (Optional.IsDefined(Health))
            {
                builder.Append("  health:");
                builder.AppendLine($" '{Health.ToString()}'");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("  provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(Errors))
            {
                builder.Append("  errors:");
                AppendChildObject(builder, Errors, options, 2);
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                builder.Append("  tags:");
                builder.AppendLine(" {");
                foreach (var item in Tags)
                {
                    builder.Append($"    {item.Key}: ");
                    if (item.Value == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($" '{item.Value}'");
                }
                builder.AppendLine("  }");
            }

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.ToString()}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<SapApplicationServerInstanceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapApplicationServerInstanceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SapApplicationServerInstanceData)} does not support '{options.Format}' format.");
            }
        }

        SapApplicationServerInstanceData IPersistableModel<SapApplicationServerInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapApplicationServerInstanceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapApplicationServerInstanceData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SapApplicationServerInstanceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapApplicationServerInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
