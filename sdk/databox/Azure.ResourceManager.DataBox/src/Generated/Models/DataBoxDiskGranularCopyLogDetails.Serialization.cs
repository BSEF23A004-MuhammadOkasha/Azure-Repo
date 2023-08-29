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
    public partial class DataBoxDiskGranularCopyLogDetails : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxDiskGranularCopyLogDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxDiskGranularCopyLogDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxDiskGranularCopyLogDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataBoxDiskGranularCopyLogDetails>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("copyLogDetailsType"u8);
            writer.WriteStringValue(CopyLogDetailsType.ToSerialString());
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

        internal static DataBoxDiskGranularCopyLogDetails DeserializeDataBoxDiskGranularCopyLogDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serialNumber = default;
            Optional<ResourceIdentifier> accountId = default;
            Optional<string> errorLogLink = default;
            Optional<string> verboseLogLink = default;
            DataBoxOrderType copyLogDetailsType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorLogLink"u8))
                {
                    errorLogLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verboseLogLink"u8))
                {
                    verboseLogLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyLogDetailsType"u8))
                {
                    copyLogDetailsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataBoxDiskGranularCopyLogDetails(copyLogDetailsType, serialNumber.Value, accountId.Value, errorLogLink.Value, verboseLogLink.Value, rawData);
        }

        DataBoxDiskGranularCopyLogDetails IModelJsonSerializable<DataBoxDiskGranularCopyLogDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataBoxDiskGranularCopyLogDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxDiskGranularCopyLogDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxDiskGranularCopyLogDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataBoxDiskGranularCopyLogDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxDiskGranularCopyLogDetails IModelSerializable<DataBoxDiskGranularCopyLogDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataBoxDiskGranularCopyLogDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxDiskGranularCopyLogDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DataBoxDiskGranularCopyLogDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DataBoxDiskGranularCopyLogDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxDiskGranularCopyLogDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
