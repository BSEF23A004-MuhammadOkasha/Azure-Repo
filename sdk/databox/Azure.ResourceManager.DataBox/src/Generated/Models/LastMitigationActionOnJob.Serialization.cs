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
    public partial class LastMitigationActionOnJob : IUtf8JsonSerializable, IModelJsonSerializable<LastMitigationActionOnJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LastMitigationActionOnJob>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LastMitigationActionOnJob>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionPerformedOn))
            {
                writer.WritePropertyName("actionDateTimeInUtc"u8);
                writer.WriteStringValue(ActionPerformedOn.Value, "O");
            }
            if (Optional.IsDefined(IsPerformedByCustomer))
            {
                writer.WritePropertyName("isPerformedByCustomer"u8);
                writer.WriteBooleanValue(IsPerformedByCustomer.Value);
            }
            if (Optional.IsDefined(CustomerResolution))
            {
                writer.WritePropertyName("customerResolution"u8);
                writer.WriteStringValue(CustomerResolution.Value.ToSerialString());
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

        internal static LastMitigationActionOnJob DeserializeLastMitigationActionOnJob(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> actionDateTimeInUtc = default;
            Optional<bool> isPerformedByCustomer = default;
            Optional<CustomerResolutionCode> customerResolution = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionDateTimeInUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionDateTimeInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isPerformedByCustomer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPerformedByCustomer = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customerResolution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customerResolution = property.Value.GetString().ToCustomerResolutionCode();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LastMitigationActionOnJob(Optional.ToNullable(actionDateTimeInUtc), Optional.ToNullable(isPerformedByCustomer), Optional.ToNullable(customerResolution), rawData);
        }

        LastMitigationActionOnJob IModelJsonSerializable<LastMitigationActionOnJob>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLastMitigationActionOnJob(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LastMitigationActionOnJob>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LastMitigationActionOnJob IModelSerializable<LastMitigationActionOnJob>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLastMitigationActionOnJob(doc.RootElement, options);
        }

        public static implicit operator RequestContent(LastMitigationActionOnJob model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator LastMitigationActionOnJob(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLastMitigationActionOnJob(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
