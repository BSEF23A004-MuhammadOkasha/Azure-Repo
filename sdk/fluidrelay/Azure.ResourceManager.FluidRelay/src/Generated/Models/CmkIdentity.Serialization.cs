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

namespace Azure.ResourceManager.FluidRelay.Models
{
    public partial class CmkIdentity : IUtf8JsonSerializable, IJsonModel<CmkIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CmkIdentity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CmkIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CmkIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CmkIdentity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IdentityType))
            {
                writer.WritePropertyName("identityType"u8);
                writer.WriteStringValue(IdentityType.Value.ToSerialString());
            }
            if (Optional.IsDefined(UserAssignedIdentityResourceId))
            {
                writer.WritePropertyName("userAssignedIdentityResourceId"u8);
                writer.WriteStringValue(UserAssignedIdentityResourceId);
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

        CmkIdentity IJsonModel<CmkIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CmkIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CmkIdentity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCmkIdentity(document.RootElement, options);
        }

        internal static CmkIdentity DeserializeCmkIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CmkIdentityType> identityType = default;
            Optional<ResourceIdentifier> userAssignedIdentityResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityType = property.Value.GetString().ToCmkIdentityType();
                    continue;
                }
                if (property.NameEquals("userAssignedIdentityResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedIdentityResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CmkIdentity(Optional.ToNullable(identityType), userAssignedIdentityResourceId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CmkIdentity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CmkIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CmkIdentity)} does not support '{options.Format}' format.");
            }
        }

        CmkIdentity IPersistableModel<CmkIdentity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CmkIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCmkIdentity(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CmkIdentity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CmkIdentity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
