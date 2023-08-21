// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationOrderBillingPlanInformation
    {
        internal static ReservationOrderBillingPlanInformation DeserializeReservationOrderBillingPlanInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PurchasePrice> pricingCurrencyTotal = default;
            Optional<DateTimeOffset> startDate = default;
            Optional<DateTimeOffset> nextPaymentDueDate = default;
            Optional<IReadOnlyList<PaymentDetail>> transactions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pricingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pricingCurrencyTotal = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("nextPaymentDueDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextPaymentDueDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("transactions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PaymentDetail> array = new List<PaymentDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PaymentDetail.DeserializePaymentDetail(item));
                    }
                    transactions = array;
                    continue;
                }
            }
            return new ReservationOrderBillingPlanInformation(pricingCurrencyTotal.Value, Optional.ToNullable(startDate), Optional.ToNullable(nextPaymentDueDate), Optional.ToList(transactions));
        }
    }
}
