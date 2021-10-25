// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;

    using System.Reflection;

    /// <summary>
    /// Defines values for SkuName.
    /// </summary>
    public sealed class SkuNameConverter : JsonConverter
    {

        /// <summary>
        /// Returns if objectType can be converted to SkuName by the converter.
        /// </summary>
        public override bool CanConvert(System.Type objectType)
        {
            return typeof(SkuName).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        /// <summary>
        /// Overrides ReadJson and converts token to SkuName.
        /// </summary>
        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
            {
                return null;
            }
            return (SkuName)serializer.Deserialize<string>(reader);
        }

        /// <summary>
        /// Overriding WriteJson for SkuName for serialization.
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

    }
}
