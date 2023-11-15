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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceHttpSettings : IUtf8JsonSerializable, IJsonModel<AppServiceHttpSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceHttpSettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AppServiceHttpSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AppServiceHttpSettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AppServiceHttpSettings>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsHttpsRequired))
            {
                writer.WritePropertyName("requireHttps"u8);
                writer.WriteBooleanValue(IsHttpsRequired.Value);
            }
            if (Optional.IsDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteObjectValue(Routes);
            }
            if (Optional.IsDefined(ForwardProxy))
            {
                writer.WritePropertyName("forwardProxy"u8);
                writer.WriteObjectValue(ForwardProxy);
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

        AppServiceHttpSettings IJsonModel<AppServiceHttpSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppServiceHttpSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceHttpSettings(document.RootElement, options);
        }

        internal static AppServiceHttpSettings DeserializeAppServiceHttpSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> requireHttps = default;
            Optional<AppServiceHttpSettingsRoutes> routes = default;
            Optional<AppServiceForwardProxy> forwardProxy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requireHttps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireHttps = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routes = AppServiceHttpSettingsRoutes.DeserializeAppServiceHttpSettingsRoutes(property.Value);
                    continue;
                }
                if (property.NameEquals("forwardProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forwardProxy = AppServiceForwardProxy.DeserializeAppServiceForwardProxy(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceHttpSettings(Optional.ToNullable(requireHttps), routes.Value, forwardProxy.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceHttpSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppServiceHttpSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AppServiceHttpSettings IPersistableModel<AppServiceHttpSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppServiceHttpSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAppServiceHttpSettings(document.RootElement, options);
        }

        string IPersistableModel<AppServiceHttpSettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
