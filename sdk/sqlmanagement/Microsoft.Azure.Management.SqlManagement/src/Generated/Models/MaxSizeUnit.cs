// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for MaxSizeUnit.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(MaxSizeUnitConverter))]
    public struct MaxSizeUnit : System.IEquatable<MaxSizeUnit>
    {
        private MaxSizeUnit(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly MaxSizeUnit Megabytes = "Megabytes";

        public static readonly MaxSizeUnit Gigabytes = "Gigabytes";

        public static readonly MaxSizeUnit Terabytes = "Terabytes";

        public static readonly MaxSizeUnit Petabytes = "Petabytes";


        /// <summary>
        /// Underlying value of enum MaxSizeUnit
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for MaxSizeUnit
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type MaxSizeUnit
        /// </summary>
        public bool Equals(MaxSizeUnit e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to MaxSizeUnit
        /// </summary>
        public static implicit operator MaxSizeUnit(string value)
        {
            return new MaxSizeUnit(value);
        }

        /// <summary>
        /// Implicit operator to convert MaxSizeUnit to string
        /// </summary>
        public static implicit operator string(MaxSizeUnit e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum MaxSizeUnit
        /// </summary>
        public static bool operator == (MaxSizeUnit e1, MaxSizeUnit e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum MaxSizeUnit
        /// </summary>
        public static bool operator != (MaxSizeUnit e1, MaxSizeUnit e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for MaxSizeUnit
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is MaxSizeUnit && Equals((MaxSizeUnit)obj);
        }

        /// <summary>
        /// Returns for hashCode MaxSizeUnit
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
