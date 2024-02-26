// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkTapPatchableParametersDestinationsItem : IUtf8JsonSerializable, IJsonModel<NetworkTapPatchableParametersDestinationsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkTapPatchableParametersDestinationsItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkTapPatchableParametersDestinationsItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkTapPatchableParametersDestinationsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkTapPatchableParametersDestinationsItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (DestinationType.HasValue)
            {
                writer.WritePropertyName("destinationType"u8);
                writer.WriteStringValue(DestinationType.Value.ToString());
            }
            if (DestinationId != null)
            {
                writer.WritePropertyName("destinationId"u8);
                writer.WriteStringValue(DestinationId);
            }
            if (IsolationDomainProperties != null)
            {
                writer.WritePropertyName("isolationDomainProperties"u8);
                writer.WriteObjectValue(IsolationDomainProperties);
            }
            if (DestinationTapRuleId != null)
            {
                writer.WritePropertyName("destinationTapRuleId"u8);
                writer.WriteStringValue(DestinationTapRuleId);
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
            writer.WriteEndObject();
        }

        NetworkTapPatchableParametersDestinationsItem IJsonModel<NetworkTapPatchableParametersDestinationsItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkTapPatchableParametersDestinationsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkTapPatchableParametersDestinationsItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkTapPatchableParametersDestinationsItem(document.RootElement, options);
        }

        internal static NetworkTapPatchableParametersDestinationsItem DeserializeNetworkTapPatchableParametersDestinationsItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<NetworkTapDestinationType> destinationType = default;
            Optional<ResourceIdentifier> destinationId = default;
            Optional<IsolationDomainProperties> isolationDomainProperties = default;
            Optional<ResourceIdentifier> destinationTapRuleId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationType = new NetworkTapDestinationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("destinationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isolationDomainProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isolationDomainProperties = IsolationDomainProperties.DeserializeIsolationDomainProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("destinationTapRuleId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationTapRuleId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkTapPatchableParametersDestinationsItem(name.Value, Optional.ToNullable(destinationType), destinationId.Value, isolationDomainProperties.Value, destinationTapRuleId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkTapPatchableParametersDestinationsItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkTapPatchableParametersDestinationsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkTapPatchableParametersDestinationsItem)} does not support '{options.Format}' format.");
            }
        }

        NetworkTapPatchableParametersDestinationsItem IPersistableModel<NetworkTapPatchableParametersDestinationsItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkTapPatchableParametersDestinationsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkTapPatchableParametersDestinationsItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkTapPatchableParametersDestinationsItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkTapPatchableParametersDestinationsItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
