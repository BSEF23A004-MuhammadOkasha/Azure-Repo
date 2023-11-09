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

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeBackupDetail : IUtf8JsonSerializable, IJsonModel<NetAppVolumeBackupDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeBackupDetail>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<NetAppVolumeBackupDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VolumeName))
            {
                writer.WritePropertyName("volumeName"u8);
                writer.WriteStringValue(VolumeName);
            }
            if (Optional.IsDefined(BackupsCount))
            {
                writer.WritePropertyName("backupsCount"u8);
                writer.WriteNumberValue(BackupsCount.Value);
            }
            if (Optional.IsDefined(IsPolicyEnabled))
            {
                writer.WritePropertyName("policyEnabled"u8);
                writer.WriteBooleanValue(IsPolicyEnabled.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        NetAppVolumeBackupDetail IJsonModel<NetAppVolumeBackupDetail>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBackupDetail)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeBackupDetail(document.RootElement, options);
        }

        internal static NetAppVolumeBackupDetail DeserializeNetAppVolumeBackupDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> volumeName = default;
            Optional<int> backupsCount = default;
            Optional<bool> policyEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("volumeName"u8))
                {
                    volumeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppVolumeBackupDetail(volumeName.Value, Optional.ToNullable(backupsCount), Optional.ToNullable(policyEnabled), serializedAdditionalRawData);
        }

        BinaryData IModel<NetAppVolumeBackupDetail>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBackupDetail)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetAppVolumeBackupDetail IModel<NetAppVolumeBackupDetail>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBackupDetail)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetAppVolumeBackupDetail(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<NetAppVolumeBackupDetail>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
