// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class DataSourceCredentialPatch : IUtf8JsonSerializable, IJsonModel<DataSourceCredentialPatch>
    {
        void IJsonModel<DataSourceCredentialPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DataSourceCredentialPatch>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DataSourceCredentialPatch>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("dataSourceCredentialType"u8);
            writer.WriteStringValue(DataSourceCredentialType.ToString());
            if (Optional.IsDefined(DataSourceCredentialName))
            {
                writer.WritePropertyName("dataSourceCredentialName"u8);
                writer.WriteStringValue(DataSourceCredentialName);
            }
            if (Optional.IsDefined(DataSourceCredentialDescription))
            {
                writer.WritePropertyName("dataSourceCredentialDescription"u8);
                writer.WriteStringValue(DataSourceCredentialDescription);
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

        DataSourceCredentialPatch IJsonModel<DataSourceCredentialPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataSourceCredentialPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataSourceCredentialPatch(document.RootElement, options);
        }

        internal static DataSourceCredentialPatch DeserializeDataSourceCredentialPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("dataSourceCredentialType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureSQLConnectionString": return AzureSQLConnectionStringCredentialPatch.DeserializeAzureSQLConnectionStringCredentialPatch(element);
                    case "DataLakeGen2SharedKey": return DataLakeGen2SharedKeyCredentialPatch.DeserializeDataLakeGen2SharedKeyCredentialPatch(element);
                    case "ServicePrincipal": return ServicePrincipalCredentialPatch.DeserializeServicePrincipalCredentialPatch(element);
                    case "ServicePrincipalInKV": return ServicePrincipalInKVCredentialPatch.DeserializeServicePrincipalInKVCredentialPatch(element);
                }
            }
            return UnknownDataSourceCredentialPatch.DeserializeUnknownDataSourceCredentialPatch(element);
        }

        BinaryData IPersistableModel<DataSourceCredentialPatch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataSourceCredentialPatch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataSourceCredentialPatch IPersistableModel<DataSourceCredentialPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataSourceCredentialPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataSourceCredentialPatch(document.RootElement, options);
        }

        string IPersistableModel<DataSourceCredentialPatch>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
