// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace Azure.Template.Models
{
    internal static class FieldValueTypeExtensions
    {
        public static string ToSerialString(this FieldValueType value) => value switch
        {
            FieldValueType.String => "string",
            FieldValueType.Date => "date",
            FieldValueType.Time => "time",
            FieldValueType.PhoneNumber => "phoneNumber",
            FieldValueType.Number => "number",
            FieldValueType.Integer => "integer",
            FieldValueType.Array => "array",
            FieldValueType.Object => "object",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FieldValueType value.")
        };

        public static FieldValueType ToFieldValueType(this string value) => value switch
        {
            "string" => FieldValueType.String,
            "date" => FieldValueType.Date,
            "time" => FieldValueType.Time,
            "phoneNumber" => FieldValueType.PhoneNumber,
            "number" => FieldValueType.Number,
            "integer" => FieldValueType.Integer,
            "array" => FieldValueType.Array,
            "object" => FieldValueType.Object,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FieldValueType value.")
        };
    }
}
