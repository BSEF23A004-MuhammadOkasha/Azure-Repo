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

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class NetworkFunctionValueWithoutSecrets : IUtf8JsonSerializable, IJsonModel<NetworkFunctionValueWithoutSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFunctionValueWithoutSecrets>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NetworkFunctionValueWithoutSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NetworkFunctionValueWithoutSecrets>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NetworkFunctionValueWithoutSecrets>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DeploymentValues))
            {
                writer.WritePropertyName("deploymentValues"u8);
                writer.WriteStringValue(DeploymentValues);
            }
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
                if (Optional.IsDefined(PublisherName))
                {
                    writer.WritePropertyName("publisherName"u8);
                    writer.WriteStringValue(PublisherName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PublisherScope))
                {
                    writer.WritePropertyName("publisherScope"u8);
                    writer.WriteStringValue(PublisherScope.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(NetworkFunctionDefinitionGroupName))
                {
                    writer.WritePropertyName("networkFunctionDefinitionGroupName"u8);
                    writer.WriteStringValue(NetworkFunctionDefinitionGroupName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(NetworkFunctionDefinitionVersion))
                {
                    writer.WritePropertyName("networkFunctionDefinitionVersion"u8);
                    writer.WriteStringValue(NetworkFunctionDefinitionVersion);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(NetworkFunctionDefinitionOfferingLocation))
                {
                    writer.WritePropertyName("networkFunctionDefinitionOfferingLocation"u8);
                    writer.WriteStringValue(NetworkFunctionDefinitionOfferingLocation);
                }
            }
            if (Optional.IsDefined(NetworkFunctionDefinitionVersionResourceReference))
            {
                writer.WritePropertyName("networkFunctionDefinitionVersionResourceReference"u8);
                writer.WriteObjectValue(NetworkFunctionDefinitionVersionResourceReference);
            }
            if (Optional.IsDefined(NfviType))
            {
                writer.WritePropertyName("nfviType"u8);
                writer.WriteStringValue(NfviType.Value.ToString());
            }
            if (Optional.IsDefined(NfviId))
            {
                writer.WritePropertyName("nfviId"u8);
                writer.WriteStringValue(NfviId);
            }
            if (Optional.IsDefined(AllowSoftwareUpdate))
            {
                writer.WritePropertyName("allowSoftwareUpdate"u8);
                writer.WriteBooleanValue(AllowSoftwareUpdate.Value);
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
            if (Optional.IsCollectionDefined(RoleOverrideValues))
            {
                writer.WritePropertyName("roleOverrideValues"u8);
                writer.WriteStartArray();
                foreach (var item in RoleOverrideValues)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        NetworkFunctionValueWithoutSecrets IJsonModel<NetworkFunctionValueWithoutSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkFunctionValueWithoutSecrets)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFunctionValueWithoutSecrets(document.RootElement, options);
        }

        internal static NetworkFunctionValueWithoutSecrets DeserializeNetworkFunctionValueWithoutSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deploymentValues = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> publisherName = default;
            Optional<PublisherScope> publisherScope = default;
            Optional<string> networkFunctionDefinitionGroupName = default;
            Optional<string> networkFunctionDefinitionVersion = default;
            Optional<string> networkFunctionDefinitionOfferingLocation = default;
            Optional<DeploymentResourceIdReference> networkFunctionDefinitionVersionResourceReference = default;
            Optional<NfviType> nfviType = default;
            Optional<ResourceIdentifier> nfviId = default;
            Optional<bool> allowSoftwareUpdate = default;
            NetworkFunctionConfigurationType configurationType = default;
            Optional<IList<string>> roleOverrideValues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentValues"u8))
                {
                    deploymentValues = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publisherName"u8))
                {
                    publisherName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherScope = new PublisherScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkFunctionDefinitionGroupName"u8))
                {
                    networkFunctionDefinitionGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionDefinitionVersion"u8))
                {
                    networkFunctionDefinitionVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionDefinitionOfferingLocation"u8))
                {
                    networkFunctionDefinitionOfferingLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionDefinitionVersionResourceReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkFunctionDefinitionVersionResourceReference = DeploymentResourceIdReference.DeserializeDeploymentResourceIdReference(property.Value);
                    continue;
                }
                if (property.NameEquals("nfviType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nfviType = new NfviType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nfviId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nfviId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowSoftwareUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowSoftwareUpdate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new NetworkFunctionConfigurationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roleOverrideValues"u8))
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
                    roleOverrideValues = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkFunctionValueWithoutSecrets(Optional.ToNullable(provisioningState), publisherName.Value, Optional.ToNullable(publisherScope), networkFunctionDefinitionGroupName.Value, networkFunctionDefinitionVersion.Value, networkFunctionDefinitionOfferingLocation.Value, networkFunctionDefinitionVersionResourceReference.Value, Optional.ToNullable(nfviType), nfviId.Value, Optional.ToNullable(allowSoftwareUpdate), configurationType, Optional.ToList(roleOverrideValues), serializedAdditionalRawData, deploymentValues.Value);
        }

        BinaryData IPersistableModel<NetworkFunctionValueWithoutSecrets>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkFunctionValueWithoutSecrets)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkFunctionValueWithoutSecrets IPersistableModel<NetworkFunctionValueWithoutSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkFunctionValueWithoutSecrets)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkFunctionValueWithoutSecrets(document.RootElement, options);
        }

        string IPersistableModel<NetworkFunctionValueWithoutSecrets>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
