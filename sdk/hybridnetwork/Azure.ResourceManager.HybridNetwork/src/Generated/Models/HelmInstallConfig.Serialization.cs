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
    public partial class HelmInstallConfig : IUtf8JsonSerializable, IJsonModel<HelmInstallConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HelmInstallConfig>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<HelmInstallConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<HelmInstallConfig>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<HelmInstallConfig>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Atomic))
            {
                writer.WritePropertyName("atomic"u8);
                writer.WriteStringValue(Atomic);
            }
            if (Optional.IsDefined(Wait))
            {
                writer.WritePropertyName("wait"u8);
                writer.WriteStringValue(Wait);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout);
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

        HelmInstallConfig IJsonModel<HelmInstallConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HelmInstallConfig)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHelmInstallConfig(document.RootElement, options);
        }

        internal static HelmInstallConfig DeserializeHelmInstallConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> atomic = default;
            Optional<string> wait = default;
            Optional<string> timeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("atomic"u8))
                {
                    atomic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wait"u8))
                {
                    wait = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    timeout = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HelmInstallConfig(atomic.Value, wait.Value, timeout.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HelmInstallConfig>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HelmInstallConfig)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HelmInstallConfig IPersistableModel<HelmInstallConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HelmInstallConfig)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHelmInstallConfig(document.RootElement, options);
        }

        string IPersistableModel<HelmInstallConfig>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
