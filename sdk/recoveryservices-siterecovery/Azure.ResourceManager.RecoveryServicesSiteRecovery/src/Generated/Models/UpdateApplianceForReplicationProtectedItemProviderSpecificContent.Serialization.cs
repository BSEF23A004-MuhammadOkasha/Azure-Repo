// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownUpdateApplianceForReplicationProtectedItemProviderSpecificContent))]
    public partial class UpdateApplianceForReplicationProtectedItemProviderSpecificContent : IUtf8JsonSerializable, IJsonModel<UpdateApplianceForReplicationProtectedItemProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateApplianceForReplicationProtectedItemProviderSpecificContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UpdateApplianceForReplicationProtectedItemProviderSpecificContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateApplianceForReplicationProtectedItemProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(UpdateApplianceForReplicationProtectedItemProviderSpecificContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        UpdateApplianceForReplicationProtectedItemProviderSpecificContent IJsonModel<UpdateApplianceForReplicationProtectedItemProviderSpecificContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateApplianceForReplicationProtectedItemProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(UpdateApplianceForReplicationProtectedItemProviderSpecificContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateApplianceForReplicationProtectedItemProviderSpecificContent(document.RootElement, options);
        }

        internal static UpdateApplianceForReplicationProtectedItemProviderSpecificContent DeserializeUpdateApplianceForReplicationProtectedItemProviderSpecificContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "InMageRcm": return InMageRcmUpdateApplianceForReplicationProtectedItemContent.DeserializeInMageRcmUpdateApplianceForReplicationProtectedItemContent(element);
                }
            }
            return UnknownUpdateApplianceForReplicationProtectedItemProviderSpecificContent.DeserializeUnknownUpdateApplianceForReplicationProtectedItemProviderSpecificContent(element);
        }

        BinaryData IPersistableModel<UpdateApplianceForReplicationProtectedItemProviderSpecificContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateApplianceForReplicationProtectedItemProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(UpdateApplianceForReplicationProtectedItemProviderSpecificContent)} does not support '{options.Format}' format.");
            }
        }

        UpdateApplianceForReplicationProtectedItemProviderSpecificContent IPersistableModel<UpdateApplianceForReplicationProtectedItemProviderSpecificContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateApplianceForReplicationProtectedItemProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpdateApplianceForReplicationProtectedItemProviderSpecificContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(UpdateApplianceForReplicationProtectedItemProviderSpecificContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateApplianceForReplicationProtectedItemProviderSpecificContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
