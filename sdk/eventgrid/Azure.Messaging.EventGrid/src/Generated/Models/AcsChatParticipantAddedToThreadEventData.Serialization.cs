// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsChatParticipantAddedToThreadEventDataConverter))]
    public partial class AcsChatParticipantAddedToThreadEventData : IUtf8JsonSerializable, IJsonModel<AcsChatParticipantAddedToThreadEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsChatParticipantAddedToThreadEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AcsChatParticipantAddedToThreadEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatParticipantAddedToThreadEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AcsChatParticipantAddedToThreadEventData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Time))
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time.Value, "O");
            }
            if (Optional.IsDefined(AddedByCommunicationIdentifier))
            {
                writer.WritePropertyName("addedByCommunicationIdentifier"u8);
                writer.WriteObjectValue(AddedByCommunicationIdentifier);
            }
            if (Optional.IsDefined(ParticipantAdded))
            {
                writer.WritePropertyName("participantAdded"u8);
                writer.WriteObjectValue(ParticipantAdded);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsDefined(TransactionId))
            {
                writer.WritePropertyName("transactionId"u8);
                writer.WriteStringValue(TransactionId);
            }
            if (Optional.IsDefined(ThreadId))
            {
                writer.WritePropertyName("threadId"u8);
                writer.WriteStringValue(ThreadId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        AcsChatParticipantAddedToThreadEventData IJsonModel<AcsChatParticipantAddedToThreadEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatParticipantAddedToThreadEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AcsChatParticipantAddedToThreadEventData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsChatParticipantAddedToThreadEventData(document.RootElement, options);
        }

        internal static AcsChatParticipantAddedToThreadEventData DeserializeAcsChatParticipantAddedToThreadEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> time = default;
            Optional<CommunicationIdentifierModel> addedByCommunicationIdentifier = default;
            Optional<AcsChatThreadParticipantProperties> participantAdded = default;
            Optional<long> version = default;
            Optional<string> transactionId = default;
            Optional<string> threadId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("time"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("addedByCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    addedByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("participantAdded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    participantAdded = AcsChatThreadParticipantProperties.DeserializeAcsChatThreadParticipantProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transactionId"u8))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threadId"u8))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AcsChatParticipantAddedToThreadEventData(transactionId.Value, threadId.Value, serializedAdditionalRawData, Optional.ToNullable(time), addedByCommunicationIdentifier.Value, participantAdded.Value, Optional.ToNullable(version));
        }

        BinaryData IPersistableModel<AcsChatParticipantAddedToThreadEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatParticipantAddedToThreadEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AcsChatParticipantAddedToThreadEventData)} does not support '{options.Format}' format.");
            }
        }

        AcsChatParticipantAddedToThreadEventData IPersistableModel<AcsChatParticipantAddedToThreadEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatParticipantAddedToThreadEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAcsChatParticipantAddedToThreadEventData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AcsChatParticipantAddedToThreadEventData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcsChatParticipantAddedToThreadEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class AcsChatParticipantAddedToThreadEventDataConverter : JsonConverter<AcsChatParticipantAddedToThreadEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatParticipantAddedToThreadEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsChatParticipantAddedToThreadEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatParticipantAddedToThreadEventData(document.RootElement);
            }
        }
    }
}
