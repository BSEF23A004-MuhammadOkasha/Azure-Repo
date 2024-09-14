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
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class HciClusterSecuritySettingData : IUtf8JsonSerializable, IJsonModel<HciClusterSecuritySettingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HciClusterSecuritySettingData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HciClusterSecuritySettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterSecuritySettingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciClusterSecuritySettingData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SecuredCoreComplianceAssignment))
            {
                writer.WritePropertyName("securedCoreComplianceAssignment"u8);
                writer.WriteStringValue(SecuredCoreComplianceAssignment.Value.ToString());
            }
            if (Optional.IsDefined(WdacComplianceAssignment))
            {
                writer.WritePropertyName("wdacComplianceAssignment"u8);
                writer.WriteStringValue(WdacComplianceAssignment.Value.ToString());
            }
            if (Optional.IsDefined(SmbEncryptionForIntraClusterTrafficComplianceAssignment))
            {
                writer.WritePropertyName("smbEncryptionForIntraClusterTrafficComplianceAssignment"u8);
                writer.WriteStringValue(SmbEncryptionForIntraClusterTrafficComplianceAssignment.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SecurityComplianceStatus))
            {
                writer.WritePropertyName("securityComplianceStatus"u8);
                writer.WriteObjectValue(SecurityComplianceStatus, options);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        HciClusterSecuritySettingData IJsonModel<HciClusterSecuritySettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterSecuritySettingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciClusterSecuritySettingData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHciClusterSecuritySettingData(document.RootElement, options);
        }

        internal static HciClusterSecuritySettingData DeserializeHciClusterSecuritySettingData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            HciClusterComplianceAssignmentType? securedCoreComplianceAssignment = default;
            HciClusterComplianceAssignmentType? wdacComplianceAssignment = default;
            HciClusterComplianceAssignmentType? smbEncryptionForIntraClusterTrafficComplianceAssignment = default;
            SecurityComplianceStatus securityComplianceStatus = default;
            HciProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("securedCoreComplianceAssignment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securedCoreComplianceAssignment = new HciClusterComplianceAssignmentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("wdacComplianceAssignment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            wdacComplianceAssignment = new HciClusterComplianceAssignmentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("smbEncryptionForIntraClusterTrafficComplianceAssignment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            smbEncryptionForIntraClusterTrafficComplianceAssignment = new HciClusterComplianceAssignmentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("securityComplianceStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityComplianceStatus = SecurityComplianceStatus.DeserializeSecurityComplianceStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HciProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HciClusterSecuritySettingData(
                id,
                name,
                type,
                systemData,
                securedCoreComplianceAssignment,
                wdacComplianceAssignment,
                smbEncryptionForIntraClusterTrafficComplianceAssignment,
                securityComplianceStatus,
                provisioningState,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SecuredCoreComplianceAssignment), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    securedCoreComplianceAssignment: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SecuredCoreComplianceAssignment))
                {
                    builder.Append("    securedCoreComplianceAssignment: ");
                    builder.AppendLine($"'{SecuredCoreComplianceAssignment.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WdacComplianceAssignment), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    wdacComplianceAssignment: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WdacComplianceAssignment))
                {
                    builder.Append("    wdacComplianceAssignment: ");
                    builder.AppendLine($"'{WdacComplianceAssignment.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SmbEncryptionForIntraClusterTrafficComplianceAssignment), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    smbEncryptionForIntraClusterTrafficComplianceAssignment: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SmbEncryptionForIntraClusterTrafficComplianceAssignment))
                {
                    builder.Append("    smbEncryptionForIntraClusterTrafficComplianceAssignment: ");
                    builder.AppendLine($"'{SmbEncryptionForIntraClusterTrafficComplianceAssignment.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SecurityComplianceStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    securityComplianceStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SecurityComplianceStatus))
                {
                    builder.Append("    securityComplianceStatus: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SecurityComplianceStatus, options, 4, false, "    securityComplianceStatus: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<HciClusterSecuritySettingData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterSecuritySettingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HciClusterSecuritySettingData)} does not support writing '{options.Format}' format.");
            }
        }

        HciClusterSecuritySettingData IPersistableModel<HciClusterSecuritySettingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterSecuritySettingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHciClusterSecuritySettingData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HciClusterSecuritySettingData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HciClusterSecuritySettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
