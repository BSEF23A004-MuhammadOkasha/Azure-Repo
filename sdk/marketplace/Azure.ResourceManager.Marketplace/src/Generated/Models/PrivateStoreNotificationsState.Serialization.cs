// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class PrivateStoreNotificationsState : IUtf8JsonSerializable, IJsonModel<PrivateStoreNotificationsState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateStoreNotificationsState>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PrivateStoreNotificationsState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PrivateStoreNotificationsState>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PrivateStoreNotificationsState>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StopSellNotifications))
            {
                writer.WritePropertyName("stopSellNotifications"u8);
                writer.WriteStartArray();
                foreach (var item in StopSellNotifications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NewNotifications))
            {
                writer.WritePropertyName("newNotifications"u8);
                writer.WriteStartArray();
                foreach (var item in NewNotifications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApprovalRequests))
            {
                writer.WritePropertyName("approvalRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ApprovalRequests)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        PrivateStoreNotificationsState IJsonModel<PrivateStoreNotificationsState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PrivateStoreNotificationsState)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateStoreNotificationsState(document.RootElement, options);
        }

        internal static PrivateStoreNotificationsState DeserializePrivateStoreNotificationsState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<StopSellNotifications>> stopSellNotifications = default;
            Optional<IReadOnlyList<NewPlanNotification>> newNotifications = default;
            Optional<IReadOnlyList<RequestApprovalsDetails>> approvalRequests = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stopSellNotifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StopSellNotifications> array = new List<StopSellNotifications>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.StopSellNotifications.DeserializeStopSellNotifications(item));
                    }
                    stopSellNotifications = array;
                    continue;
                }
                if (property.NameEquals("newNotifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NewPlanNotification> array = new List<NewPlanNotification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NewPlanNotification.DeserializeNewPlanNotification(item));
                    }
                    newNotifications = array;
                    continue;
                }
                if (property.NameEquals("approvalRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RequestApprovalsDetails> array = new List<RequestApprovalsDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RequestApprovalsDetails.DeserializeRequestApprovalsDetails(item));
                    }
                    approvalRequests = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrivateStoreNotificationsState(Optional.ToList(stopSellNotifications), Optional.ToList(newNotifications), Optional.ToList(approvalRequests), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateStoreNotificationsState>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PrivateStoreNotificationsState)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PrivateStoreNotificationsState IPersistableModel<PrivateStoreNotificationsState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PrivateStoreNotificationsState)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePrivateStoreNotificationsState(document.RootElement, options);
        }

        string IPersistableModel<PrivateStoreNotificationsState>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
