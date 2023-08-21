// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingSubscriptionMergeContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(TargetBillingSubscriptionName))
            {
                writer.WritePropertyName("targetBillingSubscriptionName"u8);
                writer.WriteStringValue(TargetBillingSubscriptionName);
            }
            if (Core.Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
            }
            writer.WriteEndObject();
        }
    }
}
