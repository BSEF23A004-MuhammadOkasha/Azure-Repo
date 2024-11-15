// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> The variable to be scrubbed from the logs. </summary>
    public readonly partial struct ScrubbingRuleEntryMatchVariable : IEquatable<ScrubbingRuleEntryMatchVariable>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScrubbingRuleEntryMatchVariable"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScrubbingRuleEntryMatchVariable(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RequestIPAddressValue = "RequestIPAddress";
        private const string RequestUriValue = "RequestUri";
        private const string QueryStringArgNamesValue = "QueryStringArgNames";
        private const string RequestHeaderNamesValue = "RequestHeaderNames";
        private const string RequestCookieNamesValue = "RequestCookieNames";
        private const string RequestBodyPostArgNamesValue = "RequestBodyPostArgNames";
        private const string RequestBodyJsonArgNamesValue = "RequestBodyJsonArgNames";

        /// <summary> RequestIPAddress. </summary>
        public static ScrubbingRuleEntryMatchVariable RequestIPAddress { get; } = new ScrubbingRuleEntryMatchVariable(RequestIPAddressValue);
        /// <summary> RequestUri. </summary>
        public static ScrubbingRuleEntryMatchVariable RequestUri { get; } = new ScrubbingRuleEntryMatchVariable(RequestUriValue);
        /// <summary> QueryStringArgNames. </summary>
        public static ScrubbingRuleEntryMatchVariable QueryStringArgNames { get; } = new ScrubbingRuleEntryMatchVariable(QueryStringArgNamesValue);
        /// <summary> RequestHeaderNames. </summary>
        public static ScrubbingRuleEntryMatchVariable RequestHeaderNames { get; } = new ScrubbingRuleEntryMatchVariable(RequestHeaderNamesValue);
        /// <summary> RequestCookieNames. </summary>
        public static ScrubbingRuleEntryMatchVariable RequestCookieNames { get; } = new ScrubbingRuleEntryMatchVariable(RequestCookieNamesValue);
        /// <summary> RequestBodyPostArgNames. </summary>
        public static ScrubbingRuleEntryMatchVariable RequestBodyPostArgNames { get; } = new ScrubbingRuleEntryMatchVariable(RequestBodyPostArgNamesValue);
        /// <summary> RequestBodyJsonArgNames. </summary>
        public static ScrubbingRuleEntryMatchVariable RequestBodyJsonArgNames { get; } = new ScrubbingRuleEntryMatchVariable(RequestBodyJsonArgNamesValue);
        /// <summary> Determines if two <see cref="ScrubbingRuleEntryMatchVariable"/> values are the same. </summary>
        public static bool operator ==(ScrubbingRuleEntryMatchVariable left, ScrubbingRuleEntryMatchVariable right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScrubbingRuleEntryMatchVariable"/> values are not the same. </summary>
        public static bool operator !=(ScrubbingRuleEntryMatchVariable left, ScrubbingRuleEntryMatchVariable right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ScrubbingRuleEntryMatchVariable"/>. </summary>
        public static implicit operator ScrubbingRuleEntryMatchVariable(string value) => new ScrubbingRuleEntryMatchVariable(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScrubbingRuleEntryMatchVariable other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScrubbingRuleEntryMatchVariable other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
