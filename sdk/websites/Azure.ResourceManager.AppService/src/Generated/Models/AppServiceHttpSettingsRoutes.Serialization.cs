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
    internal partial class AppServiceHttpSettingsRoutes : IUtf8JsonSerializable, IJsonModel<AppServiceHttpSettingsRoutes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceHttpSettingsRoutes>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AppServiceHttpSettingsRoutes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AppServiceHttpSettingsRoutes>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AppServiceHttpSettingsRoutes>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ApiPrefix))
            {
                writer.WritePropertyName("apiPrefix"u8);
                writer.WriteStringValue(ApiPrefix);
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

        AppServiceHttpSettingsRoutes IJsonModel<AppServiceHttpSettingsRoutes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppServiceHttpSettingsRoutes)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceHttpSettingsRoutes(document.RootElement, options);
        }

        internal static AppServiceHttpSettingsRoutes DeserializeAppServiceHttpSettingsRoutes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> apiPrefix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiPrefix"u8))
                {
                    apiPrefix = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceHttpSettingsRoutes(apiPrefix.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceHttpSettingsRoutes>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppServiceHttpSettingsRoutes)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AppServiceHttpSettingsRoutes IPersistableModel<AppServiceHttpSettingsRoutes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppServiceHttpSettingsRoutes)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAppServiceHttpSettingsRoutes(document.RootElement, options);
        }

        string IPersistableModel<AppServiceHttpSettingsRoutes>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
