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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class IstioServiceMesh : IUtf8JsonSerializable, IJsonModel<IstioServiceMesh>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IstioServiceMesh>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IstioServiceMesh>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioServiceMesh>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IstioServiceMesh)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Components))
            {
                writer.WritePropertyName("components"u8);
                writer.WriteObjectValue(Components, options);
            }
            if (Optional.IsDefined(CertificateAuthority))
            {
                writer.WritePropertyName("certificateAuthority"u8);
                writer.WriteObjectValue(CertificateAuthority, options);
            }
            if (Optional.IsCollectionDefined(Revisions))
            {
                writer.WritePropertyName("revisions"u8);
                writer.WriteStartArray();
                foreach (var item in Revisions)
                {
                    writer.WriteStringValue(item);
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

        IstioServiceMesh IJsonModel<IstioServiceMesh>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioServiceMesh>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IstioServiceMesh)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIstioServiceMesh(document.RootElement, options);
        }

        internal static IstioServiceMesh DeserializeIstioServiceMesh(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IstioComponents components = default;
            IstioCertificateAuthority certificateAuthority = default;
            IList<string> revisions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("components"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    components = IstioComponents.DeserializeIstioComponents(property.Value, options);
                    continue;
                }
                if (property.NameEquals("certificateAuthority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateAuthority = IstioCertificateAuthority.DeserializeIstioCertificateAuthority(property.Value, options);
                    continue;
                }
                if (property.NameEquals("revisions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    revisions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IstioServiceMesh(components, certificateAuthority, revisions ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Components), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  components: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Components))
                {
                    builder.Append("  components: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Components, options, 2, false, "  components: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("CertificateAuthorityPlugin", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  certificateAuthority: ");
                builder.AppendLine("{");
                builder.Append("    plugin: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(CertificateAuthority))
                {
                    builder.Append("  certificateAuthority: ");
                    BicepSerializationHelpers.AppendChildObject(builder, CertificateAuthority, options, 2, false, "  certificateAuthority: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Revisions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  revisions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Revisions))
                {
                    if (Revisions.Any())
                    {
                        builder.Append("  revisions: ");
                        builder.AppendLine("[");
                        foreach (var item in Revisions)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<IstioServiceMesh>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioServiceMesh>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(IstioServiceMesh)} does not support writing '{options.Format}' format.");
            }
        }

        IstioServiceMesh IPersistableModel<IstioServiceMesh>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioServiceMesh>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIstioServiceMesh(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IstioServiceMesh)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IstioServiceMesh>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
