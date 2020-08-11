// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class AzNsActionGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ActionGroup))
            {
                writer.WritePropertyName("actionGroup");
                writer.WriteStartArray();
                foreach (var item in ActionGroup)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EmailSubject))
            {
                writer.WritePropertyName("emailSubject");
                writer.WriteStringValue(EmailSubject);
            }
            if (Optional.IsDefined(CustomWebhookPayload))
            {
                writer.WritePropertyName("customWebhookPayload");
                writer.WriteStringValue(CustomWebhookPayload);
            }
            writer.WriteEndObject();
        }

        internal static AzNsActionGroup DeserializeAzNsActionGroup(JsonElement element)
        {
            Optional<IList<string>> actionGroup = default;
            Optional<string> emailSubject = default;
            Optional<string> customWebhookPayload = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionGroup"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    actionGroup = array;
                    continue;
                }
                if (property.NameEquals("emailSubject"))
                {
                    emailSubject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customWebhookPayload"))
                {
                    customWebhookPayload = property.Value.GetString();
                    continue;
                }
            }
            return new AzNsActionGroup(Optional.ToList(actionGroup), emailSubject.Value, customWebhookPayload.Value);
        }
    }
}
