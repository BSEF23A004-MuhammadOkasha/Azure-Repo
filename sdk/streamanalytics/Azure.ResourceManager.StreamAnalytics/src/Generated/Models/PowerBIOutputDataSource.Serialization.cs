// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class PowerBIOutputDataSource : IUtf8JsonSerializable, IJsonModel<PowerBIOutputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PowerBIOutputDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PowerBIOutputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PowerBIOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PowerBIOutputDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(OutputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RefreshToken))
            {
                writer.WritePropertyName("refreshToken"u8);
                writer.WriteStringValue(RefreshToken);
            }
            if (Optional.IsDefined(TokenUserPrincipalName))
            {
                writer.WritePropertyName("tokenUserPrincipalName"u8);
                writer.WriteStringValue(TokenUserPrincipalName);
            }
            if (Optional.IsDefined(TokenUserDisplayName))
            {
                writer.WritePropertyName("tokenUserDisplayName"u8);
                writer.WriteStringValue(TokenUserDisplayName);
            }
            if (Optional.IsDefined(Dataset))
            {
                writer.WritePropertyName("dataset"u8);
                writer.WriteStringValue(Dataset);
            }
            if (Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table"u8);
                writer.WriteStringValue(Table);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId.Value);
            }
            if (Optional.IsDefined(GroupName))
            {
                writer.WritePropertyName("groupName"u8);
                writer.WriteStringValue(GroupName);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
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

        PowerBIOutputDataSource IJsonModel<PowerBIOutputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PowerBIOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PowerBIOutputDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePowerBIOutputDataSource(document.RootElement, options);
        }

        internal static PowerBIOutputDataSource DeserializePowerBIOutputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string refreshToken = default;
            string tokenUserPrincipalName = default;
            string tokenUserDisplayName = default;
            string dataset = default;
            string table = default;
            Guid? groupId = default;
            string groupName = default;
            StreamAnalyticsAuthenticationMode? authenticationMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("refreshToken"u8))
                        {
                            refreshToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tokenUserPrincipalName"u8))
                        {
                            tokenUserPrincipalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tokenUserDisplayName"u8))
                        {
                            tokenUserDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataset"u8))
                        {
                            dataset = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("table"u8))
                        {
                            table = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("groupId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            groupId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("groupName"u8))
                        {
                            groupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
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
            return new PowerBIOutputDataSource(
                type,
                serializedAdditionalRawData,
                refreshToken,
                tokenUserPrincipalName,
                tokenUserDisplayName,
                dataset,
                table,
                groupId,
                groupName,
                authenticationMode);
        }

        BinaryData IPersistableModel<PowerBIOutputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PowerBIOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PowerBIOutputDataSource)} does not support '{options.Format}' format.");
            }
        }

        PowerBIOutputDataSource IPersistableModel<PowerBIOutputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PowerBIOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePowerBIOutputDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PowerBIOutputDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PowerBIOutputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
