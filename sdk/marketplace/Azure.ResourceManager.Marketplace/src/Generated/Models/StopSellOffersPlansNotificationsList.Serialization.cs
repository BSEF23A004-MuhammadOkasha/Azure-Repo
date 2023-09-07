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
    public partial class StopSellOffersPlansNotificationsList : IUtf8JsonSerializable, IModelJsonSerializable<StopSellOffersPlansNotificationsList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StopSellOffersPlansNotificationsList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StopSellOffersPlansNotificationsList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StopSellOffersPlansNotificationsList>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StopSellNotifications))
            {
                writer.WritePropertyName("stopSellNotifications"u8);
                writer.WriteStartArray();
                foreach (var item in StopSellNotifications)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<StopSellOffersPlansNotificationsResult>)item).Serialize(writer, options);
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

        internal static StopSellOffersPlansNotificationsList DeserializeStopSellOffersPlansNotificationsList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<StopSellOffersPlansNotificationsResult>> stopSellNotifications = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stopSellNotifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StopSellOffersPlansNotificationsResult> array = new List<StopSellOffersPlansNotificationsResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StopSellOffersPlansNotificationsResult.DeserializeStopSellOffersPlansNotificationsResult(item));
                    }
                    stopSellNotifications = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StopSellOffersPlansNotificationsList(Optional.ToList(stopSellNotifications), serializedAdditionalRawData);
        }

        StopSellOffersPlansNotificationsList IModelJsonSerializable<StopSellOffersPlansNotificationsList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StopSellOffersPlansNotificationsList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStopSellOffersPlansNotificationsList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StopSellOffersPlansNotificationsList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StopSellOffersPlansNotificationsList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StopSellOffersPlansNotificationsList IModelSerializable<StopSellOffersPlansNotificationsList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StopSellOffersPlansNotificationsList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStopSellOffersPlansNotificationsList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StopSellOffersPlansNotificationsList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StopSellOffersPlansNotificationsList"/> to convert. </param>
        public static implicit operator RequestContent(StopSellOffersPlansNotificationsList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StopSellOffersPlansNotificationsList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StopSellOffersPlansNotificationsList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStopSellOffersPlansNotificationsList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
