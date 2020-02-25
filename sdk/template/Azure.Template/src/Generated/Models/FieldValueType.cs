// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.Template.Models
{
    /// <summary> Semantic data type of the field value. </summary>
    public enum FieldValueType
    {
        /// <summary> string. </summary>
        String,
        /// <summary> date. </summary>
        Date,
        /// <summary> time. </summary>
        Time,
        /// <summary> phoneNumber. </summary>
        PhoneNumber,
        /// <summary> number. </summary>
        Number,
        /// <summary> integer. </summary>
        Integer,
        /// <summary> array. </summary>
        Array,
        /// <summary> object. </summary>
        Object
    }
}
