// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class ReplacementMaps : IUtf8JsonSerializable, IJsonModel<ReplacementMaps>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReplacementMaps>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReplacementMaps>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplacementMaps>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ReplacementMaps)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(WebResults))
            {
                writer.WritePropertyName("webResults"u8);
                writer.WriteStartArray();
                foreach (var item in WebResults)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Diagnostics))
            {
                writer.WritePropertyName("diagnostics"u8);
                writer.WriteStartArray();
                foreach (var item in Diagnostics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Troubleshooters))
            {
                writer.WritePropertyName("troubleshooters"u8);
                writer.WriteStartArray();
                foreach (var item in Troubleshooters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MetricsBasedCharts))
            {
                writer.WritePropertyName("metricsBasedCharts"u8);
                writer.WriteStartArray();
                foreach (var item in MetricsBasedCharts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Videos))
            {
                writer.WritePropertyName("videos"u8);
                writer.WriteStartArray();
                foreach (var item in Videos)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VideoGroups))
            {
                writer.WritePropertyName("videoGroups"u8);
                writer.WriteStartArray();
                foreach (var item in VideoGroups)
                {
                    writer.WriteObjectValue(item);
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

        ReplacementMaps IJsonModel<ReplacementMaps>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplacementMaps>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ReplacementMaps)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReplacementMaps(document.RootElement, options);
        }

        internal static ReplacementMaps DeserializeReplacementMaps(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<WebResult>> webResults = default;
            Optional<IList<SolutionsDiagnostic>> diagnostics = default;
            Optional<IList<SolutionsTroubleshooters>> troubleshooters = default;
            Optional<IList<MetricsBasedChart>> metricsBasedCharts = default;
            Optional<IList<SelfHelpVideo>> videos = default;
            Optional<IList<VideoGroup>> videoGroups = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("webResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebResult> array = new List<WebResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebResult.DeserializeWebResult(item));
                    }
                    webResults = array;
                    continue;
                }
                if (property.NameEquals("diagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SolutionsDiagnostic> array = new List<SolutionsDiagnostic>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SolutionsDiagnostic.DeserializeSolutionsDiagnostic(item));
                    }
                    diagnostics = array;
                    continue;
                }
                if (property.NameEquals("troubleshooters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SolutionsTroubleshooters> array = new List<SolutionsTroubleshooters>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SolutionsTroubleshooters.DeserializeSolutionsTroubleshooters(item));
                    }
                    troubleshooters = array;
                    continue;
                }
                if (property.NameEquals("metricsBasedCharts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricsBasedChart> array = new List<MetricsBasedChart>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricsBasedChart.DeserializeMetricsBasedChart(item));
                    }
                    metricsBasedCharts = array;
                    continue;
                }
                if (property.NameEquals("videos"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SelfHelpVideo> array = new List<SelfHelpVideo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SelfHelpVideo.DeserializeSelfHelpVideo(item));
                    }
                    videos = array;
                    continue;
                }
                if (property.NameEquals("videoGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VideoGroup> array = new List<VideoGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VideoGroup.DeserializeVideoGroup(item));
                    }
                    videoGroups = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReplacementMaps(Optional.ToList(webResults), Optional.ToList(diagnostics), Optional.ToList(troubleshooters), Optional.ToList(metricsBasedCharts), Optional.ToList(videos), Optional.ToList(videoGroups), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReplacementMaps>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplacementMaps>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ReplacementMaps)} does not support '{options.Format}' format.");
            }
        }

        ReplacementMaps IPersistableModel<ReplacementMaps>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplacementMaps>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReplacementMaps(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ReplacementMaps)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReplacementMaps>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
