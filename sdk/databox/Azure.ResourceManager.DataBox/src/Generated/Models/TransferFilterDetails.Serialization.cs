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
    public partial class TransferFilterDetails : IUtf8JsonSerializable, IModelJsonSerializable<TransferFilterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TransferFilterDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TransferFilterDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("dataAccountType"u8);
            writer.WriteStringValue(DataAccountType.ToSerialString());
            if (Optional.IsDefined(BlobFilterDetails))
            {
                writer.WritePropertyName("blobFilterDetails"u8);
                writer.WriteObjectValue(BlobFilterDetails);
            }
            if (Optional.IsDefined(AzureFileFilterDetails))
            {
                writer.WritePropertyName("azureFileFilterDetails"u8);
                writer.WriteObjectValue(AzureFileFilterDetails);
            }
            if (Optional.IsCollectionDefined(FilterFileDetails))
            {
                writer.WritePropertyName("filterFileDetails"u8);
                writer.WriteStartArray();
                foreach (var item in FilterFileDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static TransferFilterDetails DeserializeTransferFilterDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataAccountType dataAccountType = default;
            Optional<BlobFilterDetails> blobFilterDetails = default;
            Optional<AzureFileFilterDetails> azureFileFilterDetails = default;
            Optional<IList<FilterFileDetails>> filterFileDetails = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataAccountType"u8))
                {
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("blobFilterDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobFilterDetails = BlobFilterDetails.DeserializeBlobFilterDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("azureFileFilterDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureFileFilterDetails = AzureFileFilterDetails.DeserializeAzureFileFilterDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("filterFileDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FilterFileDetails> array = new List<FilterFileDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.FilterFileDetails.DeserializeFilterFileDetails(item));
                    }
                    filterFileDetails = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TransferFilterDetails(dataAccountType, blobFilterDetails.Value, azureFileFilterDetails.Value, Optional.ToList(filterFileDetails), rawData);
        }

        TransferFilterDetails IModelJsonSerializable<TransferFilterDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTransferFilterDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TransferFilterDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TransferFilterDetails IModelSerializable<TransferFilterDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTransferFilterDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(TransferFilterDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator TransferFilterDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTransferFilterDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
