// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class TriggeredJobRun : IUtf8JsonSerializable, IJsonModel<TriggeredJobRun>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TriggeredJobRun>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TriggeredJobRun>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggeredJobRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TriggeredJobRun)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (WebJobId != null)
            {
                writer.WritePropertyName("web_job_id"u8);
                writer.WriteStringValue(WebJobId);
            }
            if (WebJobName != null)
            {
                writer.WritePropertyName("web_job_name"u8);
                writer.WriteStringValue(WebJobName);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (StartOn.HasValue)
            {
                writer.WritePropertyName("start_time"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (EndOn.HasValue)
            {
                writer.WritePropertyName("end_time"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Duration.HasValue)
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "c");
            }
            if (OutputUri != null)
            {
                writer.WritePropertyName("output_url"u8);
                writer.WriteStringValue(OutputUri.AbsoluteUri);
            }
            if (ErrorUri != null)
            {
                writer.WritePropertyName("error_url"u8);
                writer.WriteStringValue(ErrorUri.AbsoluteUri);
            }
            if (Uri != null)
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (JobName != null)
            {
                writer.WritePropertyName("job_name"u8);
                writer.WriteStringValue(JobName);
            }
            if (Trigger != null)
            {
                writer.WritePropertyName("trigger"u8);
                writer.WriteStringValue(Trigger);
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

        TriggeredJobRun IJsonModel<TriggeredJobRun>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggeredJobRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TriggeredJobRun)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTriggeredJobRun(document.RootElement, options);
        }

        internal static TriggeredJobRun DeserializeTriggeredJobRun(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> webJobId = default;
            Optional<string> webJobName = default;
            Optional<TriggeredWebJobStatus> status = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<TimeSpan> duration = default;
            Optional<Uri> outputUrl = default;
            Optional<Uri> errorUrl = default;
            Optional<Uri> url = default;
            Optional<string> jobName = default;
            Optional<string> trigger = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("web_job_id"u8))
                {
                    webJobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("web_job_name"u8))
                {
                    webJobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToTriggeredWebJobStatus();
                    continue;
                }
                if (property.NameEquals("start_time"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("end_time"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("output_url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error_url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("job_name"u8))
                {
                    jobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trigger"u8))
                {
                    trigger = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TriggeredJobRun(webJobId.Value, webJobName.Value, Optional.ToNullable(status), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(duration), outputUrl.Value, errorUrl.Value, url.Value, jobName.Value, trigger.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TriggeredJobRun>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggeredJobRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TriggeredJobRun)} does not support '{options.Format}' format.");
            }
        }

        TriggeredJobRun IPersistableModel<TriggeredJobRun>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggeredJobRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTriggeredJobRun(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TriggeredJobRun)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TriggeredJobRun>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
