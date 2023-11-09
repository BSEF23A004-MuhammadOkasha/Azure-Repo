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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayOnDemandProbe : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayOnDemandProbe>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayOnDemandProbe>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ApplicationGatewayOnDemandProbe>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host"u8);
                writer.WriteStringValue(Host);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteNumberValue(Timeout.Value);
            }
            if (Optional.IsDefined(PickHostNameFromBackendHttpSettings))
            {
                writer.WritePropertyName("pickHostNameFromBackendHttpSettings"u8);
                writer.WriteBooleanValue(PickHostNameFromBackendHttpSettings.Value);
            }
            if (Optional.IsDefined(Match))
            {
                writer.WritePropertyName("match"u8);
                writer.WriteObjectValue(Match);
            }
            if (Optional.IsDefined(BackendAddressPool))
            {
                writer.WritePropertyName("backendAddressPool"u8);
                JsonSerializer.Serialize(writer, BackendAddressPool);
            }
            if (Optional.IsDefined(BackendHttpSettings))
            {
                writer.WritePropertyName("backendHttpSettings"u8);
                JsonSerializer.Serialize(writer, BackendHttpSettings);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        ApplicationGatewayOnDemandProbe IJsonModel<ApplicationGatewayOnDemandProbe>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayOnDemandProbe)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayOnDemandProbe(document.RootElement, options);
        }

        internal static ApplicationGatewayOnDemandProbe DeserializeApplicationGatewayOnDemandProbe(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ApplicationGatewayProtocol> protocol = default;
            Optional<string> host = default;
            Optional<string> path = default;
            Optional<int> timeout = default;
            Optional<bool> pickHostNameFromBackendHttpSettings = default;
            Optional<ApplicationGatewayProbeHealthResponseMatch> match = default;
            Optional<WritableSubResource> backendAddressPool = default;
            Optional<WritableSubResource> backendHttpSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new ApplicationGatewayProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pickHostNameFromBackendHttpSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pickHostNameFromBackendHttpSettings = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("match"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    match = ApplicationGatewayProbeHealthResponseMatch.DeserializeApplicationGatewayProbeHealthResponseMatch(property.Value);
                    continue;
                }
                if (property.NameEquals("backendAddressPool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendAddressPool = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("backendHttpSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendHttpSettings = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationGatewayOnDemandProbe(Optional.ToNullable(protocol), host.Value, path.Value, Optional.ToNullable(timeout), Optional.ToNullable(pickHostNameFromBackendHttpSettings), match.Value, backendAddressPool, backendHttpSettings, serializedAdditionalRawData);
        }

        BinaryData IModel<ApplicationGatewayOnDemandProbe>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayOnDemandProbe)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ApplicationGatewayOnDemandProbe IModel<ApplicationGatewayOnDemandProbe>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayOnDemandProbe)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeApplicationGatewayOnDemandProbe(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ApplicationGatewayOnDemandProbe>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
