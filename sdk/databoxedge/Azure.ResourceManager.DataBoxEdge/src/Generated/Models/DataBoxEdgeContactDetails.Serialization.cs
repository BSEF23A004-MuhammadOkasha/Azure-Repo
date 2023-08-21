// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeContactDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("contactPerson"u8);
            writer.WriteStringValue(ContactPerson);
            writer.WritePropertyName("companyName"u8);
            writer.WriteStringValue(CompanyName);
            writer.WritePropertyName("phone"u8);
            writer.WriteStringValue(Phone);
            writer.WritePropertyName("emailList"u8);
            writer.WriteStartArray();
            foreach (var item in EmailList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static DataBoxEdgeContactDetails DeserializeDataBoxEdgeContactDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string contactPerson = default;
            string companyName = default;
            string phone = default;
            IList<string> emailList = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contactPerson"u8))
                {
                    contactPerson = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("companyName"u8))
                {
                    companyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"u8))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("emailList"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    emailList = array;
                    continue;
                }
            }
            return new DataBoxEdgeContactDetails(contactPerson, companyName, phone, emailList);
        }
    }
}
