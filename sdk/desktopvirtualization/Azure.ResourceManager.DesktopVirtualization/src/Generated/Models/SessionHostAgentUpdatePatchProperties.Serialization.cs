// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class SessionHostAgentUpdatePatchProperties : IUtf8JsonSerializable, IJsonModel<SessionHostAgentUpdatePatchProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SessionHostAgentUpdatePatchProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SessionHostAgentUpdatePatchProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostAgentUpdatePatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SessionHostAgentUpdatePatchProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UpdateType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(UpdateType.Value.ToString());
            }
            if (Optional.IsDefined(DoesUseSessionHostLocalTime))
            {
                writer.WritePropertyName("useSessionHostLocalTime"u8);
                writer.WriteBooleanValue(DoesUseSessionHostLocalTime.Value);
            }
            if (Optional.IsDefined(MaintenanceWindowTimeZone))
            {
                writer.WritePropertyName("maintenanceWindowTimeZone"u8);
                writer.WriteStringValue(MaintenanceWindowTimeZone);
            }
            if (Optional.IsCollectionDefined(MaintenanceWindows))
            {
                writer.WritePropertyName("maintenanceWindows"u8);
                writer.WriteStartArray();
                foreach (var item in MaintenanceWindows)
                {
                    writer.WriteObjectValue<MaintenanceWindowPatchProperties>(item, options);
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
            writer.WriteEndObject();
        }

        SessionHostAgentUpdatePatchProperties IJsonModel<SessionHostAgentUpdatePatchProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostAgentUpdatePatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SessionHostAgentUpdatePatchProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSessionHostAgentUpdatePatchProperties(document.RootElement, options);
        }

        internal static SessionHostAgentUpdatePatchProperties DeserializeSessionHostAgentUpdatePatchProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SessionHostComponentUpdateType? type = default;
            bool? useSessionHostLocalTime = default;
            string maintenanceWindowTimeZone = default;
            IList<MaintenanceWindowPatchProperties> maintenanceWindows = default;
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
                    type = new SessionHostComponentUpdateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useSessionHostLocalTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useSessionHostLocalTime = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maintenanceWindowTimeZone"u8))
                {
                    maintenanceWindowTimeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maintenanceWindows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaintenanceWindowPatchProperties> array = new List<MaintenanceWindowPatchProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaintenanceWindowPatchProperties.DeserializeMaintenanceWindowPatchProperties(item, options));
                    }
                    maintenanceWindows = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SessionHostAgentUpdatePatchProperties(type, useSessionHostLocalTime, maintenanceWindowTimeZone, maintenanceWindows ?? new ChangeTrackingList<MaintenanceWindowPatchProperties>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SessionHostAgentUpdatePatchProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostAgentUpdatePatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SessionHostAgentUpdatePatchProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SessionHostAgentUpdatePatchProperties IPersistableModel<SessionHostAgentUpdatePatchProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostAgentUpdatePatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSessionHostAgentUpdatePatchProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SessionHostAgentUpdatePatchProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SessionHostAgentUpdatePatchProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
