// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxDeploymentProperties : IUtf8JsonSerializable, IJsonModel<NginxDeploymentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NginxDeploymentProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NginxDeploymentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NginxDeploymentProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NginxDeploymentProperties>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(NginxVersion))
                {
                    writer.WritePropertyName("nginxVersion"u8);
                    writer.WriteStringValue(NginxVersion);
                }
            }
            if (Optional.IsDefined(ManagedResourceGroup))
            {
                writer.WritePropertyName("managedResourceGroup"u8);
                writer.WriteStringValue(ManagedResourceGroup);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IPAddress))
                {
                    writer.WritePropertyName("ipAddress"u8);
                    writer.WriteStringValue(IPAddress);
                }
            }
            if (Optional.IsDefined(EnableDiagnosticsSupport))
            {
                writer.WritePropertyName("enableDiagnosticsSupport"u8);
                writer.WriteBooleanValue(EnableDiagnosticsSupport.Value);
            }
            if (Optional.IsDefined(Logging))
            {
                writer.WritePropertyName("logging"u8);
                writer.WriteObjectValue(Logging);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        NginxDeploymentProperties IJsonModel<NginxDeploymentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NginxDeploymentProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxDeploymentProperties(document.RootElement, options);
        }

        internal static NginxDeploymentProperties DeserializeNginxDeploymentProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> nginxVersion = default;
            Optional<string> managedResourceGroup = default;
            Optional<NginxNetworkProfile> networkProfile = default;
            Optional<string> ipAddress = default;
            Optional<bool> enableDiagnosticsSupport = default;
            Optional<NginxLogging> logging = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nginxVersion"u8))
                {
                    nginxVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedResourceGroup"u8))
                {
                    managedResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkProfile = NginxNetworkProfile.DeserializeNginxNetworkProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableDiagnosticsSupport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDiagnosticsSupport = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("logging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logging = NginxLogging.DeserializeNginxLogging(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NginxDeploymentProperties(Optional.ToNullable(provisioningState), nginxVersion.Value, managedResourceGroup.Value, networkProfile.Value, ipAddress.Value, Optional.ToNullable(enableDiagnosticsSupport), logging.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NginxDeploymentProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NginxDeploymentProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NginxDeploymentProperties IPersistableModel<NginxDeploymentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NginxDeploymentProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNginxDeploymentProperties(document.RootElement, options);
        }

        string IPersistableModel<NginxDeploymentProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
