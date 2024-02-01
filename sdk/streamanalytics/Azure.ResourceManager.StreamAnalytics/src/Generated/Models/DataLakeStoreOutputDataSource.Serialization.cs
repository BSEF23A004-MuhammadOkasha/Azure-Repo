// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class DataLakeStoreOutputDataSource : IUtf8JsonSerializable, IJsonModel<DataLakeStoreOutputDataSource>, IPersistableModel<DataLakeStoreOutputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeStoreOutputDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataLakeStoreOutputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreOutputDataSource)} does not support '{format}' format.");
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
            if (Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(FilePathPrefix))
            {
                writer.WritePropertyName("filePathPrefix"u8);
                writer.WriteStringValue(FilePathPrefix);
            }
            if (Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat"u8);
                writer.WriteStringValue(DateFormat);
            }
            if (Optional.IsDefined(TimeFormat))
            {
                writer.WritePropertyName("timeFormat"u8);
                writer.WriteStringValue(TimeFormat);
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

        DataLakeStoreOutputDataSource IJsonModel<DataLakeStoreOutputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreOutputDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeStoreOutputDataSource(document.RootElement, options);
        }

        internal static DataLakeStoreOutputDataSource DeserializeDataLakeStoreOutputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> refreshToken = default;
            Optional<string> tokenUserPrincipalName = default;
            Optional<string> tokenUserDisplayName = default;
            Optional<string> accountName = default;
            Optional<Guid> tenantId = default;
            Optional<string> filePathPrefix = default;
            Optional<string> dateFormat = default;
            Optional<string> timeFormat = default;
            Optional<StreamAnalyticsAuthenticationMode> authenticationMode = default;
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
                        if (property0.NameEquals("accountName"u8))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("filePathPrefix"u8))
                        {
                            filePathPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dateFormat"u8))
                        {
                            dateFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeFormat"u8))
                        {
                            timeFormat = property0.Value.GetString();
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
            return new DataLakeStoreOutputDataSource(type, serializedAdditionalRawData, refreshToken.Value, tokenUserPrincipalName.Value, tokenUserDisplayName.Value, accountName.Value, Optional.ToNullable(tenantId), filePathPrefix.Value, dateFormat.Value, timeFormat.Value, Optional.ToNullable(authenticationMode));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(RefreshToken))
            {
                builder.Append("  refreshToken:");
                builder.AppendLine($" '{RefreshToken}'");
            }

            if (Optional.IsDefined(TokenUserPrincipalName))
            {
                builder.Append("  tokenUserPrincipalName:");
                builder.AppendLine($" '{TokenUserPrincipalName}'");
            }

            if (Optional.IsDefined(TokenUserDisplayName))
            {
                builder.Append("  tokenUserDisplayName:");
                builder.AppendLine($" '{TokenUserDisplayName}'");
            }

            if (Optional.IsDefined(AccountName))
            {
                builder.Append("  accountName:");
                builder.AppendLine($" '{AccountName}'");
            }

            if (Optional.IsDefined(TenantId))
            {
                builder.Append("  tenantId:");
                builder.AppendLine($" '{TenantId.Value.ToString()}'");
            }

            if (Optional.IsDefined(FilePathPrefix))
            {
                builder.Append("  filePathPrefix:");
                builder.AppendLine($" '{FilePathPrefix}'");
            }

            if (Optional.IsDefined(DateFormat))
            {
                builder.Append("  dateFormat:");
                builder.AppendLine($" '{DateFormat}'");
            }

            if (Optional.IsDefined(TimeFormat))
            {
                builder.Append("  timeFormat:");
                builder.AppendLine($" '{TimeFormat}'");
            }

            if (Optional.IsDefined(AuthenticationMode))
            {
                builder.Append("  authenticationMode:");
                builder.AppendLine($" '{AuthenticationMode.ToString()}'");
            }

            if (Optional.IsDefined(OutputDataSourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{OutputDataSourceType}'");
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

        BinaryData IPersistableModel<DataLakeStoreOutputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreOutputDataSource)} does not support '{options.Format}' format.");
            }
        }

        DataLakeStoreOutputDataSource IPersistableModel<DataLakeStoreOutputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataLakeStoreOutputDataSource(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreOutputDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeStoreOutputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
