// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication.ShortCodes;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    public partial class MessageDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (!(SupportedProtocols is ChangeTrackingList<MessageProtocol> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("supportedProtocols"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Recurrence.HasValue)
            {
                writer.WritePropertyName("recurrence"u8);
                writer.WriteStringValue(Recurrence.Value.ToString());
            }
            if (HelpMessage != null)
            {
                writer.WritePropertyName("helpMessage"u8);
                writer.WriteStringValue(HelpMessage);
            }
            if (OptOutMessage != null)
            {
                writer.WritePropertyName("optOutMessage"u8);
                writer.WriteStringValue(OptOutMessage);
            }
            if (OptInMessage != null)
            {
                writer.WritePropertyName("optInMessage"u8);
                writer.WriteStringValue(OptInMessage);
            }
            if (OptInReply != null)
            {
                writer.WritePropertyName("optInReply"u8);
                writer.WriteStringValue(OptInReply);
            }
            if (ConfirmationMessage != null)
            {
                writer.WritePropertyName("confirmationMessage"u8);
                writer.WriteStringValue(ConfirmationMessage);
            }
            if (Directionality.HasValue)
            {
                writer.WritePropertyName("directionality"u8);
                writer.WriteStringValue(Directionality.Value.ToString());
            }
            if (!(UseCases is ChangeTrackingList<UseCase> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("useCases"u8);
                writer.WriteStartArray();
                foreach (var item in UseCases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static MessageDetails DeserializeMessageDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MessageProtocol> supportedProtocols = default;
            MessageRecurrence? recurrence = default;
            string helpMessage = default;
            string optOutMessage = default;
            string optInMessage = default;
            string optInReply = default;
            string confirmationMessage = default;
            MessageDirectionality? directionality = default;
            IList<UseCase> useCases = default;
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
            }
            return new MessageDetails(
                supportedProtocols ?? new ChangeTrackingList<MessageProtocol>(),
                recurrence,
                helpMessage,
                optOutMessage,
                optInMessage,
                optInReply,
                confirmationMessage,
                directionality,
                useCases ?? new ChangeTrackingList<UseCase>());
        }
    }
}
