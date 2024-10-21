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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraClusterBackupSchedule : IUtf8JsonSerializable, IJsonModel<CassandraClusterBackupSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CassandraClusterBackupSchedule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CassandraClusterBackupSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterBackupSchedule)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ScheduleName))
            {
                writer.WritePropertyName("scheduleName"u8);
                writer.WriteStringValue(ScheduleName);
            }
            if (Optional.IsDefined(CronExpression))
            {
                writer.WritePropertyName("cronExpression"u8);
                writer.WriteStringValue(CronExpression);
            }
            if (Optional.IsDefined(RetentionInHours))
            {
                writer.WritePropertyName("retentionInHours"u8);
                writer.WriteNumberValue(RetentionInHours.Value);
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

        CassandraClusterBackupSchedule IJsonModel<CassandraClusterBackupSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterBackupSchedule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraClusterBackupSchedule(document.RootElement, options);
        }

        internal static CassandraClusterBackupSchedule DeserializeCassandraClusterBackupSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string scheduleName = default;
            string cronExpression = default;
            int? retentionInHours = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleName"u8))
                {
                    scheduleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cronExpression"u8))
                {
                    cronExpression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retentionInHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionInHours = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CassandraClusterBackupSchedule(scheduleName, cronExpression, retentionInHours, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ScheduleName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scheduleName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ScheduleName))
                {
                    builder.Append("  scheduleName: ");
                    if (ScheduleName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ScheduleName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ScheduleName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CronExpression), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  cronExpression: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CronExpression))
                {
                    builder.Append("  cronExpression: ");
                    if (CronExpression.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CronExpression}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CronExpression}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RetentionInHours), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  retentionInHours: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RetentionInHours))
                {
                    builder.Append("  retentionInHours: ");
                    builder.AppendLine($"{RetentionInHours.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CassandraClusterBackupSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterBackupSchedule)} does not support writing '{options.Format}' format.");
            }
        }

        CassandraClusterBackupSchedule IPersistableModel<CassandraClusterBackupSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCassandraClusterBackupSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterBackupSchedule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CassandraClusterBackupSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
