// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    public partial class SignalRUpstreamAuthSettings : IUtf8JsonSerializable, IJsonModel<SignalRUpstreamAuthSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SignalRUpstreamAuthSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SignalRUpstreamAuthSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRUpstreamAuthSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SignalRUpstreamAuthSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AuthType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(AuthType.Value.ToString());
            }
            if (Optional.IsDefined(ManagedIdentity))
            {
                writer.WritePropertyName("managedIdentity"u8);
                writer.WriteObjectValue(ManagedIdentity);
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

        SignalRUpstreamAuthSettings IJsonModel<SignalRUpstreamAuthSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRUpstreamAuthSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SignalRUpstreamAuthSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSignalRUpstreamAuthSettings(document.RootElement, options);
        }

        internal static SignalRUpstreamAuthSettings DeserializeSignalRUpstreamAuthSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SignalRUpstreamAuthType> type = default;
            Optional<ManagedIdentitySettings> managedIdentity = default;
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
                    type = new SignalRUpstreamAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedIdentity = ManagedIdentitySettings.DeserializeManagedIdentitySettings(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SignalRUpstreamAuthSettings(Optional.ToNullable(type), managedIdentity.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SignalRUpstreamAuthSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRUpstreamAuthSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SignalRUpstreamAuthSettings)} does not support '{options.Format}' format.");
            }
        }

        SignalRUpstreamAuthSettings IPersistableModel<SignalRUpstreamAuthSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRUpstreamAuthSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSignalRUpstreamAuthSettings(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SignalRUpstreamAuthSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SignalRUpstreamAuthSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
