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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceDeploymentLocations : IUtf8JsonSerializable, IJsonModel<AppServiceDeploymentLocations>, IPersistableModel<AppServiceDeploymentLocations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceDeploymentLocations>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceDeploymentLocations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceDeploymentLocations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceDeploymentLocations)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HostingEnvironments))
            {
                writer.WritePropertyName("hostingEnvironments"u8);
                writer.WriteStartArray();
                foreach (var item in HostingEnvironments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HostingEnvironmentDeploymentInfos))
            {
                writer.WritePropertyName("hostingEnvironmentDeploymentInfos"u8);
                writer.WriteStartArray();
                foreach (var item in HostingEnvironmentDeploymentInfos)
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

        AppServiceDeploymentLocations IJsonModel<AppServiceDeploymentLocations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceDeploymentLocations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceDeploymentLocations)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceDeploymentLocations(document.RootElement, options);
        }

        internal static AppServiceDeploymentLocations DeserializeAppServiceDeploymentLocations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AppServiceGeoRegion>> locations = default;
            Optional<IReadOnlyList<AppServiceEnvironmentProperties>> hostingEnvironments = default;
            Optional<IReadOnlyList<HostingEnvironmentDeploymentInfo>> hostingEnvironmentDeploymentInfos = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppServiceGeoRegion> array = new List<AppServiceGeoRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceGeoRegion.DeserializeAppServiceGeoRegion(item));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("hostingEnvironments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppServiceEnvironmentProperties> array = new List<AppServiceEnvironmentProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceEnvironmentProperties.DeserializeAppServiceEnvironmentProperties(item));
                    }
                    hostingEnvironments = array;
                    continue;
                }
                if (property.NameEquals("hostingEnvironmentDeploymentInfos"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HostingEnvironmentDeploymentInfo> array = new List<HostingEnvironmentDeploymentInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HostingEnvironmentDeploymentInfo.DeserializeHostingEnvironmentDeploymentInfo(item));
                    }
                    hostingEnvironmentDeploymentInfos = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceDeploymentLocations(Optional.ToList(locations), Optional.ToList(hostingEnvironments), Optional.ToList(hostingEnvironmentDeploymentInfos), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(Locations))
            {
                builder.Append("  locations:");
                builder.AppendLine(" [");
                foreach (var item in Locations)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(HostingEnvironments))
            {
                builder.Append("  hostingEnvironments:");
                builder.AppendLine(" [");
                foreach (var item in HostingEnvironments)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(HostingEnvironmentDeploymentInfos))
            {
                builder.Append("  hostingEnvironmentDeploymentInfos:");
                builder.AppendLine(" [");
                foreach (var item in HostingEnvironmentDeploymentInfos)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<AppServiceDeploymentLocations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceDeploymentLocations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceDeploymentLocations)} does not support '{options.Format}' format.");
            }
        }

        AppServiceDeploymentLocations IPersistableModel<AppServiceDeploymentLocations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceDeploymentLocations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceDeploymentLocations(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AppServiceDeploymentLocations)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceDeploymentLocations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
