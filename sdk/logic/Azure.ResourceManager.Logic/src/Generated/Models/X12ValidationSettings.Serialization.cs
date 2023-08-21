// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class X12ValidationSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("validateCharacterSet"u8);
            writer.WriteBooleanValue(ValidateCharacterSet);
            writer.WritePropertyName("checkDuplicateInterchangeControlNumber"u8);
            writer.WriteBooleanValue(CheckDuplicateInterchangeControlNumber);
            writer.WritePropertyName("interchangeControlNumberValidityDays"u8);
            writer.WriteNumberValue(InterchangeControlNumberValidityDays);
            writer.WritePropertyName("checkDuplicateGroupControlNumber"u8);
            writer.WriteBooleanValue(CheckDuplicateGroupControlNumber);
            writer.WritePropertyName("checkDuplicateTransactionSetControlNumber"u8);
            writer.WriteBooleanValue(CheckDuplicateTransactionSetControlNumber);
            writer.WritePropertyName("validateEDITypes"u8);
            writer.WriteBooleanValue(ValidateEdiTypes);
            writer.WritePropertyName("validateXSDTypes"u8);
            writer.WriteBooleanValue(ValidateXsdTypes);
            writer.WritePropertyName("allowLeadingAndTrailingSpacesAndZeroes"u8);
            writer.WriteBooleanValue(AllowLeadingAndTrailingSpacesAndZeroes);
            writer.WritePropertyName("trimLeadingAndTrailingSpacesAndZeroes"u8);
            writer.WriteBooleanValue(TrimLeadingAndTrailingSpacesAndZeroes);
            writer.WritePropertyName("trailingSeparatorPolicy"u8);
            writer.WriteStringValue(TrailingSeparatorPolicy.ToString());
            writer.WriteEndObject();
        }

        internal static X12ValidationSettings DeserializeX12ValidationSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool validateCharacterSet = default;
            bool checkDuplicateInterchangeControlNumber = default;
            int interchangeControlNumberValidityDays = default;
            bool checkDuplicateGroupControlNumber = default;
            bool checkDuplicateTransactionSetControlNumber = default;
            bool validateEdiTypes = default;
            bool validateXsdTypes = default;
            bool allowLeadingAndTrailingSpacesAndZeroes = default;
            bool trimLeadingAndTrailingSpacesAndZeroes = default;
            TrailingSeparatorPolicy trailingSeparatorPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validateCharacterSet"u8))
                {
                    validateCharacterSet = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("checkDuplicateInterchangeControlNumber"u8))
                {
                    checkDuplicateInterchangeControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("interchangeControlNumberValidityDays"u8))
                {
                    interchangeControlNumberValidityDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("checkDuplicateGroupControlNumber"u8))
                {
                    checkDuplicateGroupControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("checkDuplicateTransactionSetControlNumber"u8))
                {
                    checkDuplicateTransactionSetControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateEDITypes"u8))
                {
                    validateEdiTypes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateXSDTypes"u8))
                {
                    validateXsdTypes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowLeadingAndTrailingSpacesAndZeroes"u8))
                {
                    allowLeadingAndTrailingSpacesAndZeroes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trimLeadingAndTrailingSpacesAndZeroes"u8))
                {
                    trimLeadingAndTrailingSpacesAndZeroes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trailingSeparatorPolicy"u8))
                {
                    trailingSeparatorPolicy = new TrailingSeparatorPolicy(property.Value.GetString());
                    continue;
                }
            }
            return new X12ValidationSettings(validateCharacterSet, checkDuplicateInterchangeControlNumber, interchangeControlNumberValidityDays, checkDuplicateGroupControlNumber, checkDuplicateTransactionSetControlNumber, validateEdiTypes, validateXsdTypes, allowLeadingAndTrailingSpacesAndZeroes, trimLeadingAndTrailingSpacesAndZeroes, trailingSeparatorPolicy);
        }
    }
}
