// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for Visibility.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(VisibilityConverter))]
    public struct Visibility : System.IEquatable<Visibility>
    {
        private Visibility(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// The track is hidden to video player.
        /// </summary>
        public static readonly Visibility Hidden = "Hidden";

        /// <summary>
        /// The track is visible to video player.
        /// </summary>
        public static readonly Visibility Visible = "Visible";


        /// <summary>
        /// Underlying value of enum Visibility
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for Visibility
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type Visibility
        /// </summary>
        public bool Equals(Visibility e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to Visibility
        /// </summary>
        public static implicit operator Visibility(string value)
        {
            return new Visibility(value);
        }

        /// <summary>
        /// Implicit operator to convert Visibility to string
        /// </summary>
        public static implicit operator string(Visibility e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum Visibility
        /// </summary>
        public static bool operator == (Visibility e1, Visibility e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum Visibility
        /// </summary>
        public static bool operator != (Visibility e1, Visibility e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for Visibility
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Visibility && Equals((Visibility)obj);
        }

        /// <summary>
        /// Returns for hashCode Visibility
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
