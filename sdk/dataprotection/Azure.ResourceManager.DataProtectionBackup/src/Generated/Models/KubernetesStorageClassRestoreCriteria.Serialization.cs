// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class KubernetesStorageClassRestoreCriteria : IUtf8JsonSerializable, IJsonModel<KubernetesStorageClassRestoreCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesStorageClassRestoreCriteria>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KubernetesStorageClassRestoreCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesStorageClassRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesStorageClassRestoreCriteria)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(SelectedStorageClassName))
            {
                writer.WritePropertyName("selectedStorageClassName"u8);
                writer.WriteStringValue(SelectedStorageClassName);
            }
            if (Optional.IsDefined(Provisioner))
            {
                writer.WritePropertyName("provisioner"u8);
                writer.WriteStringValue(Provisioner);
            }
        }

        KubernetesStorageClassRestoreCriteria IJsonModel<KubernetesStorageClassRestoreCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesStorageClassRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesStorageClassRestoreCriteria)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesStorageClassRestoreCriteria(document.RootElement, options);
        }

        internal static KubernetesStorageClassRestoreCriteria DeserializeKubernetesStorageClassRestoreCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string selectedStorageClassName = default;
            string provisioner = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedStorageClassName"u8))
                {
                    selectedStorageClassName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioner"u8))
                {
                    provisioner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KubernetesStorageClassRestoreCriteria(objectType, serializedAdditionalRawData, selectedStorageClassName, provisioner);
        }

        BinaryData IPersistableModel<KubernetesStorageClassRestoreCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesStorageClassRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesStorageClassRestoreCriteria)} does not support writing '{options.Format}' format.");
            }
        }

        KubernetesStorageClassRestoreCriteria IPersistableModel<KubernetesStorageClassRestoreCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesStorageClassRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesStorageClassRestoreCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesStorageClassRestoreCriteria)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesStorageClassRestoreCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
