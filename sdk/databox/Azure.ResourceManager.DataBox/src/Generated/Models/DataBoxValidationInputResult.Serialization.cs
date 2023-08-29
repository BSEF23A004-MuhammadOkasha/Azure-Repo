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
    public partial class DataBoxValidationInputResult : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxValidationInputResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxValidationInputResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxValidationInputResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("validationType"u8);
            writer.WriteStringValue(ValidationType.ToSerialString());
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

        internal static DataBoxValidationInputResult DeserializeDataBoxValidationInputResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("validationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ValidateCreateOrderLimit": return CreateOrderLimitForSubscriptionValidationResult.DeserializeCreateOrderLimitForSubscriptionValidationResult(element);
                    case "ValidateDataTransferDetails": return DataTransferDetailsValidationResult.DeserializeDataTransferDetailsValidationResult(element);
                    case "ValidatePreferences": return PreferencesValidationResult.DeserializePreferencesValidationResult(element);
                    case "ValidateSkuAvailability": return SkuAvailabilityValidationResult.DeserializeSkuAvailabilityValidationResult(element);
                    case "ValidateSubscriptionIsAllowedToCreateJob": return SubscriptionIsAllowedToCreateJobValidationResult.DeserializeSubscriptionIsAllowedToCreateJobValidationResult(element);
                    case "ValidateAddress": return AddressValidationResult.DeserializeAddressValidationResult(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            DataBoxValidationInputDiscriminator validationType = default;
            Optional<ResponseError> error = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationType"u8))
                {
                    validationType = property.Value.GetString().ToDataBoxValidationInputDiscriminator();
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
            return new UnknownValidationInputResponse(validationType, error.Value, rawData);
        }

        DataBoxValidationInputResult IModelJsonSerializable<DataBoxValidationInputResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxValidationInputResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxValidationInputResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxValidationInputResult IModelSerializable<DataBoxValidationInputResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxValidationInputResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DataBoxValidationInputResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DataBoxValidationInputResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxValidationInputResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
