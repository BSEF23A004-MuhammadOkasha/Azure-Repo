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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxDiskJobSecrets : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxDiskJobSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxDiskJobSecrets>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxDiskJobSecrets>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataBoxDiskJobSecrets>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("jobSecretsType"u8);
            writer.WriteStringValue(JobSecretsType.ToSerialString());
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

        internal static DataBoxDiskJobSecrets DeserializeDataBoxDiskJobSecrets(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DataBoxDiskSecret>> diskSecrets = default;
            Optional<string> passKey = default;
            Optional<bool> isPasskeyUserDefined = default;
            DataBoxOrderType jobSecretsType = default;
            Optional<DataCenterAccessSecurityCode> dcAccessSecurityCode = default;
            Optional<ResponseError> error = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSecrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxDiskSecret> array = new List<DataBoxDiskSecret>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxDiskSecret.DeserializeDataBoxDiskSecret(item));
                    }
                    diskSecrets = array;
                    continue;
                }
                if (property.NameEquals("passKey"u8))
                {
                    passKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPasskeyUserDefined"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPasskeyUserDefined = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("jobSecretsType"u8))
                {
                    jobSecretsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (property.NameEquals("dcAccessSecurityCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dcAccessSecurityCode = DataCenterAccessSecurityCode.DeserializeDataCenterAccessSecurityCode(property.Value);
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataBoxDiskJobSecrets(jobSecretsType, dcAccessSecurityCode.Value, error.Value, Optional.ToList(diskSecrets), passKey.Value, Optional.ToNullable(isPasskeyUserDefined), rawData);
        }

        DataBoxDiskJobSecrets IModelJsonSerializable<DataBoxDiskJobSecrets>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataBoxDiskJobSecrets>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxDiskJobSecrets(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxDiskJobSecrets>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataBoxDiskJobSecrets>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxDiskJobSecrets IModelSerializable<DataBoxDiskJobSecrets>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataBoxDiskJobSecrets>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxDiskJobSecrets(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DataBoxDiskJobSecrets model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DataBoxDiskJobSecrets(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxDiskJobSecrets(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
