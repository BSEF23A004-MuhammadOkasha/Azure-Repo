// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MediaGraphParameterType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MediaGraphParameterType
    {
        /// <summary>
        /// A string parameter value.
        /// </summary>
        [EnumMember(Value = "String")]
        String,
        /// <summary>
        /// A string to hold sensitive information as parameter value.
        /// </summary>
        [EnumMember(Value = "SecretString")]
        SecretString,
        /// <summary>
        /// A 32-bit signed integer as parameter value.
        /// </summary>
        [EnumMember(Value = "Int")]
        Int,
        /// <summary>
        /// A 64-bit double-precision floating point type as parameter value.
        /// </summary>
        [EnumMember(Value = "Double")]
        Double,
        /// <summary>
        /// A boolean value that is either true or false.
        /// </summary>
        [EnumMember(Value = "Bool")]
        Bool
    }
    internal static class MediaGraphParameterTypeEnumExtension
    {
        internal static string ToSerializedValue(this MediaGraphParameterType? value)
        {
            return value == null ? null : ((MediaGraphParameterType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MediaGraphParameterType value)
        {
            switch( value )
            {
                case MediaGraphParameterType.String:
                    return "String";
                case MediaGraphParameterType.SecretString:
                    return "SecretString";
                case MediaGraphParameterType.Int:
                    return "Int";
                case MediaGraphParameterType.Double:
                    return "Double";
                case MediaGraphParameterType.Bool:
                    return "Bool";
            }
            return null;
        }

        internal static MediaGraphParameterType? ParseMediaGraphParameterType(this string value)
        {
            switch( value )
            {
                case "String":
                    return MediaGraphParameterType.String;
                case "SecretString":
                    return MediaGraphParameterType.SecretString;
                case "Int":
                    return MediaGraphParameterType.Int;
                case "Double":
                    return MediaGraphParameterType.Double;
                case "Bool":
                    return MediaGraphParameterType.Bool;
            }
            return null;
        }
    }
}
