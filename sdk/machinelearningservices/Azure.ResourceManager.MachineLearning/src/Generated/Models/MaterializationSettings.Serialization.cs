// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MaterializationSettings : IUtf8JsonSerializable, IJsonModel<MaterializationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaterializationSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MaterializationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaterializationSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Notification != null)
            {
                if (Notification != null)
                {
                    writer.WritePropertyName("notification"u8);
                    writer.WriteObjectValue(Notification);
                }
                else
                {
                    writer.WriteNull("notification");
                }
            }
            if (Resource != null)
            {
                if (Resource != null)
                {
                    writer.WritePropertyName("resource"u8);
                    writer.WriteObjectValue(Resource);
                }
                else
                {
                    writer.WriteNull("resource");
                }
            }
            if (Schedule != null)
            {
                if (Schedule != null)
                {
                    writer.WritePropertyName("schedule"u8);
                    writer.WriteObjectValue(Schedule);
                }
                else
                {
                    writer.WriteNull("schedule");
                }
            }
            if (!(SparkConfiguration is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                if (SparkConfiguration != null)
                {
                    writer.WritePropertyName("sparkConfiguration"u8);
                    writer.WriteStartObject();
                    foreach (var item in SparkConfiguration)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("sparkConfiguration");
                }
            }
            if (StoreType.HasValue)
            {
                writer.WritePropertyName("storeType"u8);
                writer.WriteStringValue(StoreType.Value.ToString());
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

        MaterializationSettings IJsonModel<MaterializationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaterializationSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaterializationSettings(document.RootElement, options);
        }

        internal static MaterializationSettings DeserializeMaterializationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NotificationSetting> notification = default;
            Optional<MaterializationComputeResource> resource = default;
            Optional<MachineLearningRecurrenceTrigger> schedule = default;
            IDictionary<string, string> sparkConfiguration = default;
            Optional<MaterializationStoreType> storeType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        notification = null;
                        continue;
                    }
                    notification = NotificationSetting.DeserializeNotificationSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resource = null;
                        continue;
                    }
                    resource = MaterializationComputeResource.DeserializeMaterializationComputeResource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("schedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        schedule = null;
                        continue;
                    }
                    schedule = MachineLearningRecurrenceTrigger.DeserializeMachineLearningRecurrenceTrigger(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sparkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sparkConfiguration = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    sparkConfiguration = dictionary;
                    continue;
                }
                if (property.NameEquals("storeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storeType = new MaterializationStoreType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MaterializationSettings(notification.Value, resource.Value, schedule.Value, sparkConfiguration ?? new ChangeTrackingDictionary<string, string>(), Optional.ToNullable(storeType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MaterializationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MaterializationSettings)} does not support '{options.Format}' format.");
            }
        }

        MaterializationSettings IPersistableModel<MaterializationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMaterializationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MaterializationSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MaterializationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
