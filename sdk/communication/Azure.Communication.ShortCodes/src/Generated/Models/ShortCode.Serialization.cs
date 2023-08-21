// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    public partial class ShortCode
    {
        internal static ShortCode DeserializeShortCode(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> number = default;
            Optional<NumberType> numberType = default;
            Optional<string> countryCode = default;
            Optional<IReadOnlyList<string>> programBriefIds = default;
            Optional<DateTimeOffset> purchaseDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("number"u8))
                {
                    number = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberType = new NumberType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("countryCode"u8))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("programBriefIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    programBriefIds = array;
                    continue;
                }
                if (property.NameEquals("purchaseDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purchaseDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ShortCode(number.Value, Optional.ToNullable(numberType), countryCode.Value, Optional.ToList(programBriefIds), Optional.ToNullable(purchaseDate));
        }
    }
}
