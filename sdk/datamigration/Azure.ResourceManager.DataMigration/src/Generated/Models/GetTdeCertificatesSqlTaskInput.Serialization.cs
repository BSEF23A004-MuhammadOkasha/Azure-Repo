// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class GetTdeCertificatesSqlTaskInput : IUtf8JsonSerializable, IModelJsonSerializable<GetTdeCertificatesSqlTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GetTdeCertificatesSqlTaskInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GetTdeCertificatesSqlTaskInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("connectionInfo"u8);
            writer.WriteObjectValue(ConnectionInfo);
            writer.WritePropertyName("backupFileShare"u8);
            writer.WriteObjectValue(BackupFileShare);
            writer.WritePropertyName("selectedCertificates"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedCertificates)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static GetTdeCertificatesSqlTaskInput DeserializeGetTdeCertificatesSqlTaskInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlConnectionInfo connectionInfo = default;
            FileShare backupFileShare = default;
            IList<SelectedCertificateInput> selectedCertificates = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionInfo"u8))
                {
                    connectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("backupFileShare"u8))
                {
                    backupFileShare = FileShare.DeserializeFileShare(property.Value);
                    continue;
                }
                if (property.NameEquals("selectedCertificates"u8))
                {
                    List<SelectedCertificateInput> array = new List<SelectedCertificateInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SelectedCertificateInput.DeserializeSelectedCertificateInput(item));
                    }
                    selectedCertificates = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GetTdeCertificatesSqlTaskInput(connectionInfo, backupFileShare, selectedCertificates, rawData);
        }

        GetTdeCertificatesSqlTaskInput IModelJsonSerializable<GetTdeCertificatesSqlTaskInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGetTdeCertificatesSqlTaskInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GetTdeCertificatesSqlTaskInput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GetTdeCertificatesSqlTaskInput IModelSerializable<GetTdeCertificatesSqlTaskInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGetTdeCertificatesSqlTaskInput(doc.RootElement, options);
        }

        public static implicit operator RequestContent(GetTdeCertificatesSqlTaskInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator GetTdeCertificatesSqlTaskInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGetTdeCertificatesSqlTaskInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
