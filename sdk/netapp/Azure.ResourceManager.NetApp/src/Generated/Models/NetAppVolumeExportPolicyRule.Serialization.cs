// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeExportPolicyRule : IUtf8JsonSerializable, IJsonModel<NetAppVolumeExportPolicyRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeExportPolicyRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetAppVolumeExportPolicyRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeExportPolicyRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeExportPolicyRule)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RuleIndex))
            {
                writer.WritePropertyName("ruleIndex"u8);
                writer.WriteNumberValue(RuleIndex.Value);
            }
            if (Optional.IsDefined(IsUnixReadOnly))
            {
                writer.WritePropertyName("unixReadOnly"u8);
                writer.WriteBooleanValue(IsUnixReadOnly.Value);
            }
            if (Optional.IsDefined(IsUnixReadWrite))
            {
                writer.WritePropertyName("unixReadWrite"u8);
                writer.WriteBooleanValue(IsUnixReadWrite.Value);
            }
            if (Optional.IsDefined(IsKerberos5ReadOnly))
            {
                writer.WritePropertyName("kerberos5ReadOnly"u8);
                writer.WriteBooleanValue(IsKerberos5ReadOnly.Value);
            }
            if (Optional.IsDefined(IsKerberos5ReadWrite))
            {
                writer.WritePropertyName("kerberos5ReadWrite"u8);
                writer.WriteBooleanValue(IsKerberos5ReadWrite.Value);
            }
            if (Optional.IsDefined(IsKerberos5iReadOnly))
            {
                writer.WritePropertyName("kerberos5iReadOnly"u8);
                writer.WriteBooleanValue(IsKerberos5iReadOnly.Value);
            }
            if (Optional.IsDefined(IsKerberos5iReadWrite))
            {
                writer.WritePropertyName("kerberos5iReadWrite"u8);
                writer.WriteBooleanValue(IsKerberos5iReadWrite.Value);
            }
            if (Optional.IsDefined(IsKerberos5pReadOnly))
            {
                writer.WritePropertyName("kerberos5pReadOnly"u8);
                writer.WriteBooleanValue(IsKerberos5pReadOnly.Value);
            }
            if (Optional.IsDefined(IsKerberos5pReadWrite))
            {
                writer.WritePropertyName("kerberos5pReadWrite"u8);
                writer.WriteBooleanValue(IsKerberos5pReadWrite.Value);
            }
            if (Optional.IsDefined(AllowCifsProtocol))
            {
                writer.WritePropertyName("cifs"u8);
                writer.WriteBooleanValue(AllowCifsProtocol.Value);
            }
            if (Optional.IsDefined(AllowNfsV3Protocol))
            {
                writer.WritePropertyName("nfsv3"u8);
                writer.WriteBooleanValue(AllowNfsV3Protocol.Value);
            }
            if (Optional.IsDefined(AllowNfsV41Protocol))
            {
                writer.WritePropertyName("nfsv41"u8);
                writer.WriteBooleanValue(AllowNfsV41Protocol.Value);
            }
            if (Optional.IsDefined(AllowedClients))
            {
                writer.WritePropertyName("allowedClients"u8);
                writer.WriteStringValue(AllowedClients);
            }
            if (Optional.IsDefined(HasRootAccess))
            {
                writer.WritePropertyName("hasRootAccess"u8);
                writer.WriteBooleanValue(HasRootAccess.Value);
            }
            if (Optional.IsDefined(ChownMode))
            {
                writer.WritePropertyName("chownMode"u8);
                writer.WriteStringValue(ChownMode.Value.ToString());
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
        }

        NetAppVolumeExportPolicyRule IJsonModel<NetAppVolumeExportPolicyRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeExportPolicyRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeExportPolicyRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeExportPolicyRule(document.RootElement, options);
        }

        internal static NetAppVolumeExportPolicyRule DeserializeNetAppVolumeExportPolicyRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? ruleIndex = default;
            bool? unixReadOnly = default;
            bool? unixReadWrite = default;
            bool? kerberos5ReadOnly = default;
            bool? kerberos5ReadWrite = default;
            bool? kerberos5iReadOnly = default;
            bool? kerberos5iReadWrite = default;
            bool? kerberos5pReadOnly = default;
            bool? kerberos5pReadWrite = default;
            bool? cifs = default;
            bool? nfsv3 = default;
            bool? nfsv41 = default;
            string allowedClients = default;
            bool? hasRootAccess = default;
            NetAppChownMode? chownMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleIndex"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ruleIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unixReadOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unixReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("unixReadWrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unixReadWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5ReadOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kerberos5ReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5ReadWrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kerberos5ReadWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5iReadOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kerberos5iReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5iReadWrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kerberos5iReadWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5pReadOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kerberos5pReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5pReadWrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kerberos5pReadWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cifs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cifs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nfsv3"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nfsv3 = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nfsv41"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nfsv41 = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedClients"u8))
                {
                    allowedClients = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hasRootAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasRootAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("chownMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    chownMode = new NetAppChownMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetAppVolumeExportPolicyRule(
                ruleIndex,
                unixReadOnly,
                unixReadWrite,
                kerberos5ReadOnly,
                kerberos5ReadWrite,
                kerberos5iReadOnly,
                kerberos5iReadWrite,
                kerberos5pReadOnly,
                kerberos5pReadWrite,
                cifs,
                nfsv3,
                nfsv41,
                allowedClients,
                hasRootAccess,
                chownMode,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeExportPolicyRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeExportPolicyRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeExportPolicyRule)} does not support writing '{options.Format}' format.");
            }
        }

        NetAppVolumeExportPolicyRule IPersistableModel<NetAppVolumeExportPolicyRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeExportPolicyRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppVolumeExportPolicyRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeExportPolicyRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppVolumeExportPolicyRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
