// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DatacenterAddressLocationResponse
    {
        internal static DatacenterAddressLocationResponse DeserializeDatacenterAddressLocationResponse(JsonElement element)
        {
            Optional<string> contactPersonName = default;
            Optional<string> company = default;
            Optional<string> street1 = default;
            Optional<string> street2 = default;
            Optional<string> street3 = default;
            Optional<string> city = default;
            Optional<string> state = default;
            Optional<string> zip = default;
            Optional<string> country = default;
            Optional<string> phone = default;
            Optional<string> phoneExtension = default;
            Optional<string> addressType = default;
            Optional<string> additionalShippingInformation = default;
            DatacenterAddressType datacenterAddressType = default;
            Optional<IReadOnlyList<string>> supportedCarriersForReturnShipment = default;
            Optional<string> dataCenterAzureLocation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contactPersonName"))
                {
                    contactPersonName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("company"))
                {
                    company = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("street1"))
                {
                    street1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("street2"))
                {
                    street2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("street3"))
                {
                    street3 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zip"))
                {
                    zip = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneExtension"))
                {
                    phoneExtension = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressType"))
                {
                    addressType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalShippingInformation"))
                {
                    additionalShippingInformation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datacenterAddressType"))
                {
                    datacenterAddressType = property.Value.GetString().ToDatacenterAddressType();
                    continue;
                }
                if (property.NameEquals("supportedCarriersForReturnShipment"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedCarriersForReturnShipment = array;
                    continue;
                }
                if (property.NameEquals("dataCenterAzureLocation"))
                {
                    dataCenterAzureLocation = property.Value.GetString();
                    continue;
                }
            }
            return new DatacenterAddressLocationResponse(datacenterAddressType, Optional.ToList(supportedCarriersForReturnShipment), dataCenterAzureLocation.Value, contactPersonName.Value, company.Value, street1.Value, street2.Value, street3.Value, city.Value, state.Value, zip.Value, country.Value, phone.Value, phoneExtension.Value, addressType.Value, additionalShippingInformation.Value);
        }
    }
}
