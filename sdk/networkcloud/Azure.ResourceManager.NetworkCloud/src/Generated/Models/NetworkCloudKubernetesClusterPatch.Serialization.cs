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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkCloudKubernetesClusterPatch : IUtf8JsonSerializable, IJsonModel<NetworkCloudKubernetesClusterPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudKubernetesClusterPatch>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NetworkCloudKubernetesClusterPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NetworkCloudKubernetesClusterPatch>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NetworkCloudKubernetesClusterPatch>)} interface");
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
            if (Optional.IsDefined(ControlPlaneNodeConfiguration))
            {
                writer.WritePropertyName("controlPlaneNodeConfiguration"u8);
                writer.WriteObjectValue(ControlPlaneNodeConfiguration);
            }
            if (Optional.IsDefined(KubernetesVersion))
            {
                writer.WritePropertyName("kubernetesVersion"u8);
                writer.WriteStringValue(KubernetesVersion);
            }
            writer.WriteEndObject();
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

        NetworkCloudKubernetesClusterPatch IJsonModel<NetworkCloudKubernetesClusterPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkCloudKubernetesClusterPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudKubernetesClusterPatch(document.RootElement, options);
        }

        internal static NetworkCloudKubernetesClusterPatch DeserializeNetworkCloudKubernetesClusterPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<ControlPlaneNodePatchConfiguration> controlPlaneNodeConfiguration = default;
            Optional<string> kubernetesVersion = default;
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
                        if (property0.NameEquals("controlPlaneNodeConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            controlPlaneNodeConfiguration = ControlPlaneNodePatchConfiguration.DeserializeControlPlaneNodePatchConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("kubernetesVersion"u8))
                        {
                            kubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkCloudKubernetesClusterPatch(Optional.ToDictionary(tags), controlPlaneNodeConfiguration.Value, kubernetesVersion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudKubernetesClusterPatch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkCloudKubernetesClusterPatch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkCloudKubernetesClusterPatch IPersistableModel<NetworkCloudKubernetesClusterPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkCloudKubernetesClusterPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkCloudKubernetesClusterPatch(document.RootElement, options);
        }

        string IPersistableModel<NetworkCloudKubernetesClusterPatch>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
