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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountAssemblyProperties : IUtf8JsonSerializable, IJsonModel<IntegrationAccountAssemblyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationAccountAssemblyProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<IntegrationAccountAssemblyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<IntegrationAccountAssemblyProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<IntegrationAccountAssemblyProperties>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("assemblyName"u8);
            writer.WriteStringValue(AssemblyName);
            if (Optional.IsDefined(AssemblyVersion))
            {
                writer.WritePropertyName("assemblyVersion"u8);
                writer.WriteStringValue(AssemblyVersion);
            }
            if (Optional.IsDefined(AssemblyCulture))
            {
                writer.WritePropertyName("assemblyCulture"u8);
                writer.WriteStringValue(AssemblyCulture);
            }
            if (Optional.IsDefined(AssemblyPublicKeyToken))
            {
                writer.WritePropertyName("assemblyPublicKeyToken"u8);
                writer.WriteStringValue(AssemblyPublicKeyToken);
            }
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Content);
#else
                using (JsonDocument document = JsonDocument.Parse(Content))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType"u8);
                writer.WriteStringValue(ContentType.Value.ToString());
            }
            if (Optional.IsDefined(ContentLink))
            {
                writer.WritePropertyName("contentLink"u8);
                writer.WriteObjectValue(ContentLink);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(ChangedOn))
            {
                writer.WritePropertyName("changedTime"u8);
                writer.WriteStringValue(ChangedOn.Value, "O");
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        IntegrationAccountAssemblyProperties IJsonModel<IntegrationAccountAssemblyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IntegrationAccountAssemblyProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationAccountAssemblyProperties(document.RootElement, options);
        }

        internal static IntegrationAccountAssemblyProperties DeserializeIntegrationAccountAssemblyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assemblyName = default;
            Optional<string> assemblyVersion = default;
            Optional<string> assemblyCulture = default;
            Optional<string> assemblyPublicKeyToken = default;
            Optional<BinaryData> content = default;
            Optional<ContentType> contentType = default;
            Optional<LogicContentLink> contentLink = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> changedTime = default;
            Optional<BinaryData> metadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assemblyName"u8))
                {
                    assemblyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assemblyVersion"u8))
                {
                    assemblyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assemblyCulture"u8))
                {
                    assemblyCulture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assemblyPublicKeyToken"u8))
                {
                    assemblyPublicKeyToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    content = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentType = new ContentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentLink = LogicContentLink.DeserializeLogicContentLink(property.Value);
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("changedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IntegrationAccountAssemblyProperties(Optional.ToNullable(createdTime), Optional.ToNullable(changedTime), metadata.Value, serializedAdditionalRawData, content.Value, Optional.ToNullable(contentType), contentLink.Value, assemblyName, assemblyVersion.Value, assemblyCulture.Value, assemblyPublicKeyToken.Value);
        }

        BinaryData IPersistableModel<IntegrationAccountAssemblyProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IntegrationAccountAssemblyProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IntegrationAccountAssemblyProperties IPersistableModel<IntegrationAccountAssemblyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IntegrationAccountAssemblyProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIntegrationAccountAssemblyProperties(document.RootElement, options);
        }

        string IPersistableModel<IntegrationAccountAssemblyProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
