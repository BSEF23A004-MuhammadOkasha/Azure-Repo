// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(XmlReadSettingsConverter))]
    public partial class XmlReadSettings : IUtf8JsonSerializable, IJsonModel<XmlReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<XmlReadSettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<XmlReadSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<XmlReadSettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<XmlReadSettings>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CompressionProperties))
            {
                writer.WritePropertyName("compressionProperties"u8);
                writer.WriteObjectValue(CompressionProperties);
            }
            if (Optional.IsDefined(ValidationMode))
            {
                writer.WritePropertyName("validationMode"u8);
                writer.WriteObjectValue(ValidationMode);
            }
            if (Optional.IsDefined(DetectDataType))
            {
                writer.WritePropertyName("detectDataType"u8);
                writer.WriteObjectValue(DetectDataType);
            }
            if (Optional.IsDefined(Namespaces))
            {
                writer.WritePropertyName("namespaces"u8);
                writer.WriteObjectValue(Namespaces);
            }
            if (Optional.IsDefined(NamespacePrefixes))
            {
                writer.WritePropertyName("namespacePrefixes"u8);
                writer.WriteObjectValue(NamespacePrefixes);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        XmlReadSettings IJsonModel<XmlReadSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(XmlReadSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeXmlReadSettings(document.RootElement, options);
        }

        internal static XmlReadSettings DeserializeXmlReadSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CompressionReadSettings> compressionProperties = default;
            Optional<object> validationMode = default;
            Optional<object> detectDataType = default;
            Optional<object> namespaces = default;
            Optional<object> namespacePrefixes = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("compressionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressionProperties = CompressionReadSettings.DeserializeCompressionReadSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("validationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationMode = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("detectDataType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectDataType = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("namespaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    namespaces = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("namespacePrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    namespacePrefixes = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new XmlReadSettings(type, additionalProperties, compressionProperties.Value, validationMode.Value, detectDataType.Value, namespaces.Value, namespacePrefixes.Value);
        }

        BinaryData IPersistableModel<XmlReadSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(XmlReadSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        XmlReadSettings IPersistableModel<XmlReadSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(XmlReadSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeXmlReadSettings(document.RootElement, options);
        }

        string IPersistableModel<XmlReadSettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class XmlReadSettingsConverter : JsonConverter<XmlReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, XmlReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override XmlReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeXmlReadSettings(document.RootElement);
            }
        }
    }
}
