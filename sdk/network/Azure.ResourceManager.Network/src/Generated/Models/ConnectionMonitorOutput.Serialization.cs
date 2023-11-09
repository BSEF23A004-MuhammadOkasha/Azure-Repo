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

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorOutput : IUtf8JsonSerializable, IJsonModel<ConnectionMonitorOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectionMonitorOutput>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ConnectionMonitorOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OutputType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(OutputType.Value.ToString());
            }
            if (Optional.IsDefined(WorkspaceSettings))
            {
                writer.WritePropertyName("workspaceSettings"u8);
                writer.WriteObjectValue(WorkspaceSettings);
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

        ConnectionMonitorOutput IJsonModel<ConnectionMonitorOutput>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorOutput)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionMonitorOutput(document.RootElement, options);
        }

        internal static ConnectionMonitorOutput DeserializeConnectionMonitorOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OutputType> type = default;
            Optional<ConnectionMonitorWorkspaceSettings> workspaceSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new OutputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("workspaceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceSettings = ConnectionMonitorWorkspaceSettings.DeserializeConnectionMonitorWorkspaceSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectionMonitorOutput(Optional.ToNullable(type), workspaceSettings.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<ConnectionMonitorOutput>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorOutput)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ConnectionMonitorOutput IModel<ConnectionMonitorOutput>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorOutput)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeConnectionMonitorOutput(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ConnectionMonitorOutput>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
