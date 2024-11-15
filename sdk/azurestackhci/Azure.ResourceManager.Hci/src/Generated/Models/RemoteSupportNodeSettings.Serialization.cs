// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class RemoteSupportNodeSettings : IUtf8JsonSerializable, IJsonModel<RemoteSupportNodeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RemoteSupportNodeSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RemoteSupportNodeSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoteSupportNodeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RemoteSupportNodeSettings)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ArcResourceId))
            {
                writer.WritePropertyName("arcResourceId"u8);
                writer.WriteStringValue(ArcResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedAt"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectionStatus))
            {
                writer.WritePropertyName("connectionStatus"u8);
                writer.WriteStringValue(ConnectionStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectionErrorMessage))
            {
                writer.WritePropertyName("connectionErrorMessage"u8);
                writer.WriteStringValue(ConnectionErrorMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(TranscriptLocation))
            {
                writer.WritePropertyName("transcriptLocation"u8);
                writer.WriteStringValue(TranscriptLocation);
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
        }

        RemoteSupportNodeSettings IJsonModel<RemoteSupportNodeSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoteSupportNodeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RemoteSupportNodeSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRemoteSupportNodeSettings(document.RootElement, options);
        }

        internal static RemoteSupportNodeSettings DeserializeRemoteSupportNodeSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier arcResourceId = default;
            string state = default;
            DateTimeOffset? createdAt = default;
            DateTimeOffset? updatedAt = default;
            string connectionStatus = default;
            string connectionErrorMessage = default;
            string transcriptLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("arcResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arcResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("connectionStatus"u8))
                {
                    connectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionErrorMessage"u8))
                {
                    connectionErrorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transcriptLocation"u8))
                {
                    transcriptLocation = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RemoteSupportNodeSettings(
                arcResourceId,
                state,
                createdAt,
                updatedAt,
                connectionStatus,
                connectionErrorMessage,
                transcriptLocation,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ArcResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  arcResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ArcResourceId))
                {
                    builder.Append("  arcResourceId: ");
                    builder.AppendLine($"'{ArcResourceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(State), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  state: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(State))
                {
                    builder.Append("  state: ");
                    if (State.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{State}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{State}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  createdAt: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    builder.Append("  createdAt: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpdatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  updatedAt: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UpdatedOn))
                {
                    builder.Append("  updatedAt: ");
                    var formattedDateTimeString = TypeFormatters.ToString(UpdatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConnectionStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  connectionStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConnectionStatus))
                {
                    builder.Append("  connectionStatus: ");
                    if (ConnectionStatus.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ConnectionStatus}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ConnectionStatus}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConnectionErrorMessage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  connectionErrorMessage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConnectionErrorMessage))
                {
                    builder.Append("  connectionErrorMessage: ");
                    if (ConnectionErrorMessage.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ConnectionErrorMessage}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ConnectionErrorMessage}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TranscriptLocation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  transcriptLocation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TranscriptLocation))
                {
                    builder.Append("  transcriptLocation: ");
                    if (TranscriptLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TranscriptLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TranscriptLocation}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RemoteSupportNodeSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoteSupportNodeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RemoteSupportNodeSettings)} does not support writing '{options.Format}' format.");
            }
        }

        RemoteSupportNodeSettings IPersistableModel<RemoteSupportNodeSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoteSupportNodeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRemoteSupportNodeSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RemoteSupportNodeSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RemoteSupportNodeSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
