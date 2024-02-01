// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheActiveDirectorySettings : IUtf8JsonSerializable, IJsonModel<StorageCacheActiveDirectorySettings>, IPersistableModel<StorageCacheActiveDirectorySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageCacheActiveDirectorySettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageCacheActiveDirectorySettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheActiveDirectorySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheActiveDirectorySettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("primaryDnsIpAddress"u8);
            writer.WriteStringValue(PrimaryDnsIPAddress.ToString());
            if (Optional.IsDefined(SecondaryDnsIPAddress))
            {
                writer.WritePropertyName("secondaryDnsIpAddress"u8);
                writer.WriteStringValue(SecondaryDnsIPAddress.ToString());
            }
            writer.WritePropertyName("domainName"u8);
            writer.WriteStringValue(DomainName);
            writer.WritePropertyName("domainNetBiosName"u8);
            writer.WriteStringValue(DomainNetBiosName);
            writer.WritePropertyName("cacheNetBiosName"u8);
            writer.WriteStringValue(CacheNetBiosName);
            if (options.Format != "W" && Optional.IsDefined(DomainJoined))
            {
                writer.WritePropertyName("domainJoined"u8);
                writer.WriteStringValue(DomainJoined.Value.ToString());
            }
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
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

        StorageCacheActiveDirectorySettings IJsonModel<StorageCacheActiveDirectorySettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheActiveDirectorySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheActiveDirectorySettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheActiveDirectorySettings(document.RootElement, options);
        }

        internal static StorageCacheActiveDirectorySettings DeserializeStorageCacheActiveDirectorySettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPAddress primaryDnsIPAddress = default;
            Optional<IPAddress> secondaryDnsIPAddress = default;
            string domainName = default;
            string domainNetBiosName = default;
            string cacheNetBiosName = default;
            Optional<DomainJoinedType> domainJoined = default;
            Optional<StorageCacheActiveDirectorySettingsCredentials> credentials = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryDnsIpAddress"u8))
                {
                    primaryDnsIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secondaryDnsIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryDnsIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainNetBiosName"u8))
                {
                    domainNetBiosName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cacheNetBiosName"u8))
                {
                    cacheNetBiosName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainJoined"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainJoined = new DomainJoinedType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = StorageCacheActiveDirectorySettingsCredentials.DeserializeStorageCacheActiveDirectorySettingsCredentials(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageCacheActiveDirectorySettings(primaryDnsIPAddress, secondaryDnsIPAddress.Value, domainName, domainNetBiosName, cacheNetBiosName, Optional.ToNullable(domainJoined), credentials.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(PrimaryDnsIPAddress))
            {
                builder.Append("  primaryDnsIpAddress:");
                builder.AppendLine($" '{PrimaryDnsIPAddress.ToString()}'");
            }

            if (Optional.IsDefined(SecondaryDnsIPAddress))
            {
                builder.Append("  secondaryDnsIpAddress:");
                builder.AppendLine($" '{SecondaryDnsIPAddress.ToString()}'");
            }

            if (Optional.IsDefined(DomainName))
            {
                builder.Append("  domainName:");
                builder.AppendLine($" '{DomainName}'");
            }

            if (Optional.IsDefined(DomainNetBiosName))
            {
                builder.Append("  domainNetBiosName:");
                builder.AppendLine($" '{DomainNetBiosName}'");
            }

            if (Optional.IsDefined(CacheNetBiosName))
            {
                builder.Append("  cacheNetBiosName:");
                builder.AppendLine($" '{CacheNetBiosName}'");
            }

            if (Optional.IsDefined(DomainJoined))
            {
                builder.Append("  domainJoined:");
                builder.AppendLine($" '{DomainJoined.ToString()}'");
            }

            if (Optional.IsDefined(Credentials))
            {
                builder.Append("  credentials:");
                AppendChildObject(builder, Credentials, options, 2);
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

        BinaryData IPersistableModel<StorageCacheActiveDirectorySettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheActiveDirectorySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StorageCacheActiveDirectorySettings)} does not support '{options.Format}' format.");
            }
        }

        StorageCacheActiveDirectorySettings IPersistableModel<StorageCacheActiveDirectorySettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheActiveDirectorySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageCacheActiveDirectorySettings(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(StorageCacheActiveDirectorySettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageCacheActiveDirectorySettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
