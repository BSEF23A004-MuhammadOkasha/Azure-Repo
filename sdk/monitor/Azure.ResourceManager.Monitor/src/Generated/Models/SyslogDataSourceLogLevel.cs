// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The SyslogDataSourceLogLevel. </summary>
    public readonly partial struct SyslogDataSourceLogLevel : IEquatable<SyslogDataSourceLogLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SyslogDataSourceLogLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SyslogDataSourceLogLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DebugValue = "Debug";
        private const string InfoValue = "Info";
        private const string NoticeValue = "Notice";
        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";
        private const string CriticalValue = "Critical";
        private const string AlertValue = "Alert";
        private const string EmergencyValue = "Emergency";
        private const string AsteriskValue = "*";

        /// <summary> Debug. </summary>
        public static SyslogDataSourceLogLevel Debug { get; } = new SyslogDataSourceLogLevel(DebugValue);
        /// <summary> Info. </summary>
        public static SyslogDataSourceLogLevel Info { get; } = new SyslogDataSourceLogLevel(InfoValue);
        /// <summary> Notice. </summary>
        public static SyslogDataSourceLogLevel Notice { get; } = new SyslogDataSourceLogLevel(NoticeValue);
        /// <summary> Warning. </summary>
        public static SyslogDataSourceLogLevel Warning { get; } = new SyslogDataSourceLogLevel(WarningValue);
        /// <summary> Error. </summary>
        public static SyslogDataSourceLogLevel Error { get; } = new SyslogDataSourceLogLevel(ErrorValue);
        /// <summary> Critical. </summary>
        public static SyslogDataSourceLogLevel Critical { get; } = new SyslogDataSourceLogLevel(CriticalValue);
        /// <summary> Alert. </summary>
        public static SyslogDataSourceLogLevel Alert { get; } = new SyslogDataSourceLogLevel(AlertValue);
        /// <summary> Emergency. </summary>
        public static SyslogDataSourceLogLevel Emergency { get; } = new SyslogDataSourceLogLevel(EmergencyValue);
        /// <summary> *. </summary>
        public static SyslogDataSourceLogLevel Asterisk { get; } = new SyslogDataSourceLogLevel(AsteriskValue);
        /// <summary> Determines if two <see cref="SyslogDataSourceLogLevel"/> values are the same. </summary>
        public static bool operator ==(SyslogDataSourceLogLevel left, SyslogDataSourceLogLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SyslogDataSourceLogLevel"/> values are not the same. </summary>
        public static bool operator !=(SyslogDataSourceLogLevel left, SyslogDataSourceLogLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SyslogDataSourceLogLevel"/>. </summary>
        public static implicit operator SyslogDataSourceLogLevel(string value) => new SyslogDataSourceLogLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SyslogDataSourceLogLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SyslogDataSourceLogLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
