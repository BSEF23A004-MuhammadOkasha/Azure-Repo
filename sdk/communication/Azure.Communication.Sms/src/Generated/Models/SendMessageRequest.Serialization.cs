// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Sms.Models
{
    internal partial class SendMessageRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("from"u8);
            writer.WriteStringValue(From);
            writer.WritePropertyName("smsRecipients"u8);
            writer.WriteStartArray();
            foreach (var item in SmsRecipients)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("message"u8);
            writer.WriteStringValue(Message);
            if (Optional.IsDefined(SmsSendOptions))
            {
                writer.WritePropertyName("smsSendOptions"u8);
                writer.WriteObjectValue(SmsSendOptions);
            }
            writer.WriteEndObject();
        }
    }
}
