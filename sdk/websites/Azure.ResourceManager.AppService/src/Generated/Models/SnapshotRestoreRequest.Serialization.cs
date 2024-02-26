// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SnapshotRestoreRequest : IUtf8JsonSerializable, IJsonModel<SnapshotRestoreRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SnapshotRestoreRequest>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SnapshotRestoreRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotRestoreRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SnapshotRestoreRequest)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (SnapshotTime != null)
            {
                writer.WritePropertyName("snapshotTime"u8);
                writer.WriteStringValue(SnapshotTime);
            }
            if (RecoverySource != null)
            {
                writer.WritePropertyName("recoverySource"u8);
                writer.WriteObjectValue(RecoverySource);
            }
            if (CanOverwrite.HasValue)
            {
                writer.WritePropertyName("overwrite"u8);
                writer.WriteBooleanValue(CanOverwrite.Value);
            }
            if (RecoverConfiguration.HasValue)
            {
                writer.WritePropertyName("recoverConfiguration"u8);
                writer.WriteBooleanValue(RecoverConfiguration.Value);
            }
            if (IgnoreConflictingHostNames.HasValue)
            {
                writer.WritePropertyName("ignoreConflictingHostNames"u8);
                writer.WriteBooleanValue(IgnoreConflictingHostNames.Value);
            }
            if (UseDRSecondary.HasValue)
            {
                writer.WritePropertyName("useDRSecondary"u8);
                writer.WriteBooleanValue(UseDRSecondary.Value);
            }
            writer.WriteEndObject();
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

        SnapshotRestoreRequest IJsonModel<SnapshotRestoreRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotRestoreRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SnapshotRestoreRequest)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSnapshotRestoreRequest(document.RootElement, options);
        }

        internal static SnapshotRestoreRequest DeserializeSnapshotRestoreRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> snapshotTime = default;
            Optional<SnapshotRecoverySource> recoverySource = default;
            Optional<bool> overwrite = default;
            Optional<bool> recoverConfiguration = default;
            Optional<bool> ignoreConflictingHostNames = default;
            Optional<bool> useDRSecondary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("snapshotTime"u8))
                        {
                            snapshotTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recoverySource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recoverySource = SnapshotRecoverySource.DeserializeSnapshotRecoverySource(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("overwrite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overwrite = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("recoverConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recoverConfiguration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ignoreConflictingHostNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ignoreConflictingHostNames = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useDRSecondary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useDRSecondary = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SnapshotRestoreRequest(id, name, type, systemData.Value, snapshotTime.Value, recoverySource.Value, Optional.ToNullable(overwrite), Optional.ToNullable(recoverConfiguration), Optional.ToNullable(ignoreConflictingHostNames), Optional.ToNullable(useDRSecondary), kind.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SnapshotRestoreRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotRestoreRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SnapshotRestoreRequest)} does not support '{options.Format}' format.");
            }
        }

        SnapshotRestoreRequest IPersistableModel<SnapshotRestoreRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotRestoreRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSnapshotRestoreRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SnapshotRestoreRequest)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SnapshotRestoreRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
