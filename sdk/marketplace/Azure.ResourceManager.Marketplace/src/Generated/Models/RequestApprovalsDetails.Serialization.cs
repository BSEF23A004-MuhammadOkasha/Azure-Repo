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
    public partial class RequestApprovalsDetails : IUtf8JsonSerializable, IJsonModel<RequestApprovalsDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RequestApprovalsDetails>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<RequestApprovalsDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RequestApprovalsDetails>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RequestApprovalsDetails>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OfferId))
            {
                writer.WritePropertyName("offerId"u8);
                writer.WriteStringValue(OfferId);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(PublisherId))
            {
                writer.WritePropertyName("publisherId"u8);
                writer.WriteStringValue(PublisherId);
            }
            if (Optional.IsDefined(MessageCode))
            {
                writer.WritePropertyName("messageCode"u8);
                writer.WriteNumberValue(MessageCode.Value);
            }
            if (Optional.IsDefined(IconUri))
            {
                writer.WritePropertyName("icon"u8);
                writer.WriteStringValue(IconUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(Plans))
            {
                writer.WritePropertyName("plans"u8);
                writer.WriteStartArray();
                foreach (var item in Plans)
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

        RequestApprovalsDetails IJsonModel<RequestApprovalsDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RequestApprovalsDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRequestApprovalsDetails(document.RootElement, options);
        }

        internal static RequestApprovalsDetails DeserializeRequestApprovalsDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> offerId = default;
            Optional<string> displayName = default;
            Optional<string> publisherId = default;
            Optional<long> messageCode = default;
            Optional<Uri> icon = default;
            Optional<IReadOnlyList<PlanNotificationDetails>> plans = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerId"u8))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherId"u8))
                {
                    publisherId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messageCode = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("icon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    icon = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("plans"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PlanNotificationDetails> array = new List<PlanNotificationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PlanNotificationDetails.DeserializePlanNotificationDetails(item));
                    }
                    plans = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RequestApprovalsDetails(offerId.Value, displayName.Value, publisherId.Value, Optional.ToNullable(messageCode), icon.Value, Optional.ToList(plans), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RequestApprovalsDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RequestApprovalsDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RequestApprovalsDetails IPersistableModel<RequestApprovalsDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RequestApprovalsDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRequestApprovalsDetails(document.RootElement, options);
        }

        string IPersistableModel<RequestApprovalsDetails>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
