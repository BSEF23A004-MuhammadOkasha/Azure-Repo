// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.MetricsAdvisor.Administration
{
    public partial class DataLakeSharedKeyCredentialEntity : IUtf8JsonSerializable, IModelJsonSerializable<DataLakeSharedKeyCredentialEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataLakeSharedKeyCredentialEntity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataLakeSharedKeyCredentialEntity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataLakeSharedKeyCredentialEntity>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("parameters"u8);
            if (Parameters is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DataLakeGen2SharedKeyParam>)Parameters).Serialize(writer, options);
            }
            writer.WritePropertyName("dataSourceCredentialType"u8);
            writer.WriteStringValue(CredentialKind.ToString());
            writer.WritePropertyName("dataSourceCredentialName"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("dataSourceCredentialDescription"u8);
                writer.WriteStringValue(Description);
            }
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

        internal static DataLakeSharedKeyCredentialEntity DeserializeDataLakeSharedKeyCredentialEntity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataLakeGen2SharedKeyParam parameters = default;
            DataSourceCredentialKind dataSourceCredentialType = default;
            Optional<string> dataSourceCredentialId = default;
            string dataSourceCredentialName = default;
            Optional<string> dataSourceCredentialDescription = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    parameters = DataLakeGen2SharedKeyParam.DeserializeDataLakeGen2SharedKeyParam(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialType"u8))
                {
                    dataSourceCredentialType = new DataSourceCredentialKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialId"u8))
                {
                    dataSourceCredentialId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialName"u8))
                {
                    dataSourceCredentialName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialDescription"u8))
                {
                    dataSourceCredentialDescription = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataLakeSharedKeyCredentialEntity(dataSourceCredentialType, dataSourceCredentialId.Value, dataSourceCredentialName, dataSourceCredentialDescription.Value, parameters, rawData);
        }

        DataLakeSharedKeyCredentialEntity IModelJsonSerializable<DataLakeSharedKeyCredentialEntity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataLakeSharedKeyCredentialEntity>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeSharedKeyCredentialEntity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataLakeSharedKeyCredentialEntity>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataLakeSharedKeyCredentialEntity>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataLakeSharedKeyCredentialEntity IModelSerializable<DataLakeSharedKeyCredentialEntity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataLakeSharedKeyCredentialEntity>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataLakeSharedKeyCredentialEntity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataLakeSharedKeyCredentialEntity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataLakeSharedKeyCredentialEntity"/> to convert. </param>
        public static implicit operator RequestContent(DataLakeSharedKeyCredentialEntity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataLakeSharedKeyCredentialEntity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataLakeSharedKeyCredentialEntity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataLakeSharedKeyCredentialEntity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
