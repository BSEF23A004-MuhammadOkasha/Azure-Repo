// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class WorkbookTemplatePatch : IUtf8JsonSerializable, IJsonModel<WorkbookTemplatePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkbookTemplatePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkbookTemplatePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkbookTemplatePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkbookTemplatePatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(Author))
            {
                writer.WritePropertyName("author"u8);
                writer.WriteStringValue(Author);
            }
            if (Optional.IsDefined(TemplateData))
            {
                writer.WritePropertyName("templateData"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TemplateData);
#else
                using (JsonDocument document = JsonDocument.Parse(TemplateData))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(Galleries))
            {
                writer.WritePropertyName("galleries"u8);
                writer.WriteStartArray();
                foreach (var item in Galleries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Localized))
            {
                writer.WritePropertyName("localized"u8);
                writer.WriteStartObject();
                foreach (var item in Localized)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
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

        WorkbookTemplatePatch IJsonModel<WorkbookTemplatePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkbookTemplatePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkbookTemplatePatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkbookTemplatePatch(document.RootElement, options);
        }

        internal static WorkbookTemplatePatch DeserializeWorkbookTemplatePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<int> priority = default;
            Optional<string> author = default;
            Optional<BinaryData> templateData = default;
            Optional<IList<WorkbookTemplateGallery>> galleries = default;
            Optional<IDictionary<string, IList<WorkbookTemplateLocalizedGallery>>> localized = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("author"u8))
                        {
                            author = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("templateData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            templateData = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("galleries"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WorkbookTemplateGallery> array = new List<WorkbookTemplateGallery>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WorkbookTemplateGallery.DeserializeWorkbookTemplateGallery(item, options));
                            }
                            galleries = array;
                            continue;
                        }
                        if (property0.NameEquals("localized"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, IList<WorkbookTemplateLocalizedGallery>> dictionary = new Dictionary<string, IList<WorkbookTemplateLocalizedGallery>>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    List<WorkbookTemplateLocalizedGallery> array = new List<WorkbookTemplateLocalizedGallery>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(WorkbookTemplateLocalizedGallery.DeserializeWorkbookTemplateLocalizedGallery(item, options));
                                    }
                                    dictionary.Add(property1.Name, array);
                                }
                            }
                            localized = dictionary;
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
            return new WorkbookTemplatePatch(Optional.ToDictionary(tags), Optional.ToNullable(priority), author.Value, templateData.Value, Optional.ToList(galleries), Optional.ToDictionary(localized), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkbookTemplatePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkbookTemplatePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkbookTemplatePatch)} does not support '{options.Format}' format.");
            }
        }

        WorkbookTemplatePatch IPersistableModel<WorkbookTemplatePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkbookTemplatePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkbookTemplatePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkbookTemplatePatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkbookTemplatePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
