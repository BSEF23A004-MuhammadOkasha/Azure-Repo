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

namespace Azure.ResourceManager.HybridConnectivity.Models
{
    public partial class TargetResourceEndpointAccess : IUtf8JsonSerializable, IJsonModel<TargetResourceEndpointAccess>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TargetResourceEndpointAccess>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<TargetResourceEndpointAccess>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<TargetResourceEndpointAccess>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<TargetResourceEndpointAccess>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("relay"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(NamespaceName))
            {
                writer.WritePropertyName("namespaceName"u8);
                writer.WriteStringValue(NamespaceName);
            }
            if (Optional.IsDefined(NamespaceNameSuffix))
            {
                writer.WritePropertyName("namespaceNameSuffix"u8);
                writer.WriteStringValue(NamespaceNameSuffix);
            }
            if (Optional.IsDefined(HybridConnectionName))
            {
                writer.WritePropertyName("hybridConnectionName"u8);
                writer.WriteStringValue(HybridConnectionName);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(AccessKey))
                {
                    writer.WritePropertyName("accessKey"u8);
                    writer.WriteStringValue(AccessKey);
                }
            }
            if (Optional.IsDefined(ExpiresOn))
            {
                writer.WritePropertyName("expiresOn"u8);
                writer.WriteNumberValue(ExpiresOn.Value);
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

        TargetResourceEndpointAccess IJsonModel<TargetResourceEndpointAccess>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TargetResourceEndpointAccess)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTargetResourceEndpointAccess(document.RootElement, options);
        }

        internal static TargetResourceEndpointAccess DeserializeTargetResourceEndpointAccess(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> namespaceName = default;
            Optional<string> namespaceNameSuffix = default;
            Optional<string> hybridConnectionName = default;
            Optional<string> accessKey = default;
            Optional<long> expiresOn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("namespaceName"u8))
                        {
                            namespaceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("namespaceNameSuffix"u8))
                        {
                            namespaceNameSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hybridConnectionName"u8))
                        {
                            hybridConnectionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accessKey"u8))
                        {
                            accessKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("expiresOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expiresOn = property0.Value.GetInt64();
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
            return new TargetResourceEndpointAccess(namespaceName.Value, namespaceNameSuffix.Value, hybridConnectionName.Value, accessKey.Value, Optional.ToNullable(expiresOn), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TargetResourceEndpointAccess>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TargetResourceEndpointAccess)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        TargetResourceEndpointAccess IPersistableModel<TargetResourceEndpointAccess>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TargetResourceEndpointAccess)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeTargetResourceEndpointAccess(document.RootElement, options);
        }

        string IPersistableModel<TargetResourceEndpointAccess>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
