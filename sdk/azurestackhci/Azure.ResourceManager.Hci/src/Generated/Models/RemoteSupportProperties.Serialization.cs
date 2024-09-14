// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class RemoteSupportProperties : IUtf8JsonSerializable, IJsonModel<RemoteSupportProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RemoteSupportProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RemoteSupportProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoteSupportProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RemoteSupportProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(AccessLevel))
            {
                writer.WritePropertyName("accessLevel"u8);
                writer.WriteStringValue(AccessLevel.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationTimeStamp"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(RemoteSupportType))
            {
                writer.WritePropertyName("remoteSupportType"u8);
                writer.WriteStringValue(RemoteSupportType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RemoteSupportNodeSettings))
            {
                writer.WritePropertyName("remoteSupportNodeSettings"u8);
                writer.WriteStartArray();
                foreach (var item in RemoteSupportNodeSettings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RemoteSupportSessionDetails))
            {
                writer.WritePropertyName("remoteSupportSessionDetails"u8);
                writer.WriteStartArray();
                foreach (var item in RemoteSupportSessionDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        RemoteSupportProperties IJsonModel<RemoteSupportProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoteSupportProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RemoteSupportProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRemoteSupportProperties(document.RootElement, options);
        }

        internal static RemoteSupportProperties DeserializeRemoteSupportProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HciClusterAccessLevel? accessLevel = default;
            DateTimeOffset? expirationTimeStamp = default;
            RemoteSupportType? remoteSupportType = default;
            IReadOnlyList<RemoteSupportNodeSettings> remoteSupportNodeSettings = default;
            IReadOnlyList<PerNodeRemoteSupportSession> remoteSupportSessionDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessLevel = new HciClusterAccessLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expirationTimeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTimeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("remoteSupportType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remoteSupportType = new RemoteSupportType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteSupportNodeSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RemoteSupportNodeSettings> array = new List<RemoteSupportNodeSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.RemoteSupportNodeSettings.DeserializeRemoteSupportNodeSettings(item, options));
                    }
                    remoteSupportNodeSettings = array;
                    continue;
                }
                if (property.NameEquals("remoteSupportSessionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PerNodeRemoteSupportSession> array = new List<PerNodeRemoteSupportSession>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PerNodeRemoteSupportSession.DeserializePerNodeRemoteSupportSession(item, options));
                    }
                    remoteSupportSessionDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RemoteSupportProperties(
                accessLevel,
                expirationTimeStamp,
                remoteSupportType,
                remoteSupportNodeSettings ?? new ChangeTrackingList<RemoteSupportNodeSettings>(),
                remoteSupportSessionDetails ?? new ChangeTrackingList<PerNodeRemoteSupportSession>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccessLevel), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  accessLevel: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccessLevel))
                {
                    builder.Append("  accessLevel: ");
                    builder.AppendLine($"'{AccessLevel.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExpireOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  expirationTimeStamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExpireOn))
                {
                    builder.Append("  expirationTimeStamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(ExpireOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RemoteSupportType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  remoteSupportType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RemoteSupportType))
                {
                    builder.Append("  remoteSupportType: ");
                    builder.AppendLine($"'{RemoteSupportType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RemoteSupportNodeSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  remoteSupportNodeSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(RemoteSupportNodeSettings))
                {
                    if (RemoteSupportNodeSettings.Any())
                    {
                        builder.Append("  remoteSupportNodeSettings: ");
                        builder.AppendLine("[");
                        foreach (var item in RemoteSupportNodeSettings)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  remoteSupportNodeSettings: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RemoteSupportSessionDetails), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  remoteSupportSessionDetails: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(RemoteSupportSessionDetails))
                {
                    if (RemoteSupportSessionDetails.Any())
                    {
                        builder.Append("  remoteSupportSessionDetails: ");
                        builder.AppendLine("[");
                        foreach (var item in RemoteSupportSessionDetails)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  remoteSupportSessionDetails: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RemoteSupportProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoteSupportProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RemoteSupportProperties)} does not support writing '{options.Format}' format.");
            }
        }

        RemoteSupportProperties IPersistableModel<RemoteSupportProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoteSupportProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRemoteSupportProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RemoteSupportProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RemoteSupportProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
