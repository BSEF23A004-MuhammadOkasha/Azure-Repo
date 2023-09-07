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

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class PrivateStoreOfferResult : IUtf8JsonSerializable, IModelJsonSerializable<PrivateStoreOfferResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PrivateStoreOfferResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PrivateStoreOfferResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateStoreOfferResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SpecificPlanIdsLimitation))
            {
                writer.WritePropertyName("specificPlanIdsLimitation"u8);
                writer.WriteStartArray();
                foreach (var item in SpecificPlanIdsLimitation)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsUpdateSuppressedDueToIdempotence))
            {
                writer.WritePropertyName("updateSuppressedDueIdempotence"u8);
                writer.WriteBooleanValue(IsUpdateSuppressedDueToIdempotence.Value);
            }
            if (Optional.IsCollectionDefined(IconFileUris))
            {
                writer.WritePropertyName("iconFileUris"u8);
                writer.WriteStartObject();
                foreach (var item in IconFileUris)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.Value.AbsoluteUri);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Plans))
            {
                writer.WritePropertyName("plans"u8);
                writer.WriteStartArray();
                foreach (var item in Plans)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<PrivateStorePlan>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static PrivateStoreOfferResult DeserializePrivateStoreOfferResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> uniqueOfferId = default;
            Optional<string> offerDisplayName = default;
            Optional<string> publisherDisplayName = default;
            Optional<ETag> eTag = default;
            Optional<Guid> privateStoreId = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> modifiedAt = default;
            Optional<IReadOnlyList<string>> specificPlanIdsLimitation = default;
            Optional<bool> updateSuppressedDueIdempotence = default;
            Optional<IReadOnlyDictionary<string, Uri>> iconFileUris = default;
            Optional<IReadOnlyList<PrivateStorePlan>> plans = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uniqueOfferId"u8))
                {
                    uniqueOfferId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerDisplayName"u8))
                {
                    offerDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherDisplayName"u8))
                {
                    publisherDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateStoreId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateStoreId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("modifiedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("specificPlanIdsLimitation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    specificPlanIdsLimitation = array;
                    continue;
                }
                if (property.NameEquals("updateSuppressedDueIdempotence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateSuppressedDueIdempotence = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("iconFileUris"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, Uri> dictionary = new Dictionary<string, Uri>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, new Uri(property0.Value.GetString()));
                        }
                    }
                    iconFileUris = dictionary;
                    continue;
                }
                if (property.NameEquals("plans"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateStorePlan> array = new List<PrivateStorePlan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateStorePlan.DeserializePrivateStorePlan(item));
                    }
                    plans = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PrivateStoreOfferResult(uniqueOfferId.Value, offerDisplayName.Value, publisherDisplayName.Value, Optional.ToNullable(eTag), Optional.ToNullable(privateStoreId), Optional.ToNullable(createdAt), Optional.ToNullable(modifiedAt), Optional.ToList(specificPlanIdsLimitation), Optional.ToNullable(updateSuppressedDueIdempotence), Optional.ToDictionary(iconFileUris), Optional.ToList(plans), serializedAdditionalRawData);
        }

        PrivateStoreOfferResult IModelJsonSerializable<PrivateStoreOfferResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateStoreOfferResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateStoreOfferResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PrivateStoreOfferResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateStoreOfferResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PrivateStoreOfferResult IModelSerializable<PrivateStoreOfferResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateStoreOfferResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePrivateStoreOfferResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PrivateStoreOfferResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PrivateStoreOfferResult"/> to convert. </param>
        public static implicit operator RequestContent(PrivateStoreOfferResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PrivateStoreOfferResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PrivateStoreOfferResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePrivateStoreOfferResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
