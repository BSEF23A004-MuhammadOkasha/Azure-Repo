// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    public partial class PhonePlan
    {
        internal static PhonePlan DeserializePhonePlan(JsonElement element)
        {
            string phonePlanId = default;
            string localizedName = default;
            LocationType locationType = default;
            Optional<IReadOnlyList<string>> areaCodes = default;
            Optional<IReadOnlyList<PhoneNumberCapability>> capabilities = default;
            Optional<int> maximumSearchSize = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("phonePlanId"))
                {
                    phonePlanId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localizedName"))
                {
                    localizedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locationType"))
                {
                    locationType = new LocationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("areaCodes"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    areaCodes = array;
                    continue;
                }
                if (property.NameEquals("capabilities"))
                {
                    List<PhoneNumberCapability> array = new List<PhoneNumberCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PhoneNumberCapability(item.GetString()));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("maximumSearchSize"))
                {
                    maximumSearchSize = property.Value.GetInt32();
                    continue;
                }
            }
            return new PhonePlan(phonePlanId, localizedName, locationType, Optional.ToList(areaCodes), Optional.ToList(capabilities), Optional.ToNullable(maximumSearchSize));
        }
    }
}
