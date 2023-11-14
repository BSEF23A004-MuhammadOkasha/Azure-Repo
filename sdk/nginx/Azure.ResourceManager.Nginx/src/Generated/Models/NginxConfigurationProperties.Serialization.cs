// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxConfigurationProperties : IUtf8JsonSerializable, IJsonModel<NginxConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NginxConfigurationProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NginxConfigurationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NginxConfigurationProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NginxConfigurationProperties>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files"u8);
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ProtectedFiles))
            {
                writer.WritePropertyName("protectedFiles"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedFiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Package))
            {
                writer.WritePropertyName("package"u8);
                writer.WriteObjectValue(Package);
            }
            if (Optional.IsDefined(RootFile))
            {
                writer.WritePropertyName("rootFile"u8);
                writer.WriteStringValue(RootFile);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        NginxConfigurationProperties IJsonModel<NginxConfigurationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NginxConfigurationProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxConfigurationProperties(document.RootElement, options);
        }

        internal static NginxConfigurationProperties DeserializeNginxConfigurationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<IList<NginxConfigurationFile>> files = default;
            Optional<IList<NginxConfigurationFile>> protectedFiles = default;
            Optional<NginxConfigurationPackage> package = default;
            Optional<string> rootFile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("files"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NginxConfigurationFile> array = new List<NginxConfigurationFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxConfigurationFile.DeserializeNginxConfigurationFile(item));
                    }
                    files = array;
                    continue;
                }
                if (property.NameEquals("protectedFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NginxConfigurationFile> array = new List<NginxConfigurationFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxConfigurationFile.DeserializeNginxConfigurationFile(item));
                    }
                    protectedFiles = array;
                    continue;
                }
                if (property.NameEquals("package"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    package = NginxConfigurationPackage.DeserializeNginxConfigurationPackage(property.Value);
                    continue;
                }
                if (property.NameEquals("rootFile"u8))
                {
                    rootFile = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NginxConfigurationProperties(Optional.ToNullable(provisioningState), Optional.ToList(files), Optional.ToList(protectedFiles), package.Value, rootFile.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NginxConfigurationProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NginxConfigurationProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NginxConfigurationProperties IPersistableModel<NginxConfigurationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NginxConfigurationProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNginxConfigurationProperties(document.RootElement, options);
        }

        string IPersistableModel<NginxConfigurationProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
