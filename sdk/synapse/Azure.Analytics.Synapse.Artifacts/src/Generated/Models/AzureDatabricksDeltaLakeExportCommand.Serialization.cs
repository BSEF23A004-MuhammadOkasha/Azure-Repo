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
    [JsonConverter(typeof(AzureDatabricksDeltaLakeExportCommandConverter))]
    public partial class AzureDatabricksDeltaLakeExportCommand : IUtf8JsonSerializable, IJsonModel<AzureDatabricksDeltaLakeExportCommand>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureDatabricksDeltaLakeExportCommand>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AzureDatabricksDeltaLakeExportCommand>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AzureDatabricksDeltaLakeExportCommand>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AzureDatabricksDeltaLakeExportCommand>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat"u8);
                writer.WriteObjectValue(DateFormat);
            }
            if (Optional.IsDefined(TimestampFormat))
            {
                writer.WritePropertyName("timestampFormat"u8);
                writer.WriteObjectValue(TimestampFormat);
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

        AzureDatabricksDeltaLakeExportCommand IJsonModel<AzureDatabricksDeltaLakeExportCommand>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureDatabricksDeltaLakeExportCommand)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDatabricksDeltaLakeExportCommand(document.RootElement, options);
        }

        internal static AzureDatabricksDeltaLakeExportCommand DeserializeAzureDatabricksDeltaLakeExportCommand(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> dateFormat = default;
            Optional<object> timestampFormat = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateFormat = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("timestampFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestampFormat = property.Value.GetObject();
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
            return new AzureDatabricksDeltaLakeExportCommand(type, additionalProperties, dateFormat.Value, timestampFormat.Value);
        }

        BinaryData IPersistableModel<AzureDatabricksDeltaLakeExportCommand>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureDatabricksDeltaLakeExportCommand)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureDatabricksDeltaLakeExportCommand IPersistableModel<AzureDatabricksDeltaLakeExportCommand>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureDatabricksDeltaLakeExportCommand)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureDatabricksDeltaLakeExportCommand(document.RootElement, options);
        }

        string IPersistableModel<AzureDatabricksDeltaLakeExportCommand>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class AzureDatabricksDeltaLakeExportCommandConverter : JsonConverter<AzureDatabricksDeltaLakeExportCommand>
        {
            public override void Write(Utf8JsonWriter writer, AzureDatabricksDeltaLakeExportCommand model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureDatabricksDeltaLakeExportCommand Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureDatabricksDeltaLakeExportCommand(document.RootElement);
            }
        }
    }
}
