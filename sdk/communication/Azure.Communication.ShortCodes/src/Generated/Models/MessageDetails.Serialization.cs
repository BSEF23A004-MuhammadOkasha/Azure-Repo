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

namespace Azure.Communication.ShortCodes.Models
{
    public partial class MessageDetails : IUtf8JsonSerializable, IModelJsonSerializable<MessageDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MessageDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MessageDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SupportedProtocols))
            {
                writer.WritePropertyName("supportedProtocols"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Recurrence))
            {
                writer.WritePropertyName("recurrence"u8);
                writer.WriteStringValue(Recurrence.Value.ToString());
            }
            if (Optional.IsDefined(HelpMessage))
            {
                writer.WritePropertyName("helpMessage"u8);
                writer.WriteStringValue(HelpMessage);
            }
            if (Optional.IsDefined(OptOutMessage))
            {
                writer.WritePropertyName("optOutMessage"u8);
                writer.WriteStringValue(OptOutMessage);
            }
            if (Optional.IsDefined(OptInMessage))
            {
                writer.WritePropertyName("optInMessage"u8);
                writer.WriteStringValue(OptInMessage);
            }
            if (Optional.IsDefined(OptInReply))
            {
                writer.WritePropertyName("optInReply"u8);
                writer.WriteStringValue(OptInReply);
            }
            if (Optional.IsDefined(ConfirmationMessage))
            {
                writer.WritePropertyName("confirmationMessage"u8);
                writer.WriteStringValue(ConfirmationMessage);
            }
            if (Optional.IsDefined(Directionality))
            {
                writer.WritePropertyName("directionality"u8);
                writer.WriteStringValue(Directionality.Value.ToString());
            }
            if (Optional.IsCollectionDefined(UseCases))
            {
                writer.WritePropertyName("useCases"u8);
                writer.WriteStartArray();
                foreach (var item in UseCases)
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

        internal static MessageDetails DeserializeMessageDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<MessageProtocol>> supportedProtocols = default;
            Optional<MessageRecurrence> recurrence = default;
            Optional<string> helpMessage = default;
            Optional<string> optOutMessage = default;
            Optional<string> optInMessage = default;
            Optional<string> optInReply = default;
            Optional<string> confirmationMessage = default;
            Optional<MessageDirectionality> directionality = default;
            Optional<IList<UseCase>> useCases = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportedProtocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MessageProtocol> array = new List<MessageProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new MessageProtocol(item.GetString()));
                    }
                    supportedProtocols = array;
                    continue;
                }
                if (property.NameEquals("recurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recurrence = new MessageRecurrence(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("helpMessage"u8))
                {
                    helpMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("optOutMessage"u8))
                {
                    optOutMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("optInMessage"u8))
                {
                    optInMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("optInReply"u8))
                {
                    optInReply = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confirmationMessage"u8))
                {
                    confirmationMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("directionality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    directionality = new MessageDirectionality(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useCases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UseCase> array = new List<UseCase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UseCase.DeserializeUseCase(item));
                    }
                    useCases = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MessageDetails(Optional.ToList(supportedProtocols), Optional.ToNullable(recurrence), helpMessage.Value, optOutMessage.Value, optInMessage.Value, optInReply.Value, confirmationMessage.Value, Optional.ToNullable(directionality), Optional.ToList(useCases), rawData);
        }

        MessageDetails IModelJsonSerializable<MessageDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMessageDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MessageDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MessageDetails IModelSerializable<MessageDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMessageDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MessageDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MessageDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMessageDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
