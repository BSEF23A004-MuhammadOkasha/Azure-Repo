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

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionOperationJobExtendedInfo : IUtf8JsonSerializable, IModelJsonSerializable<DataProtectionOperationJobExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataProtectionOperationJobExtendedInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataProtectionOperationJobExtendedInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionOperationJobExtendedInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(JobResourceId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobResourceId);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        internal static DataProtectionOperationJobExtendedInfo DeserializeDataProtectionOperationJobExtendedInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> jobId = default;
            string objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataProtectionOperationJobExtendedInfo(objectType, jobId.Value, rawData);
        }

        DataProtectionOperationJobExtendedInfo IModelJsonSerializable<DataProtectionOperationJobExtendedInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionOperationJobExtendedInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionOperationJobExtendedInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataProtectionOperationJobExtendedInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionOperationJobExtendedInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataProtectionOperationJobExtendedInfo IModelSerializable<DataProtectionOperationJobExtendedInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionOperationJobExtendedInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataProtectionOperationJobExtendedInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataProtectionOperationJobExtendedInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataProtectionOperationJobExtendedInfo"/> to convert. </param>
        public static implicit operator RequestContent(DataProtectionOperationJobExtendedInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataProtectionOperationJobExtendedInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataProtectionOperationJobExtendedInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataProtectionOperationJobExtendedInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
