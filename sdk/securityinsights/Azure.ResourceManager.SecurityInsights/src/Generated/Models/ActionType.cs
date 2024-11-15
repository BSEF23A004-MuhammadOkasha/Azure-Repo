// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The type of the automation rule action. </summary>
    internal readonly partial struct ActionType : IEquatable<ActionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ActionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ModifyPropertiesValue = "ModifyProperties";
        private const string RunPlaybookValue = "RunPlaybook";
        private const string AddIncidentTaskValue = "AddIncidentTask";

        /// <summary> Modify an object's properties. </summary>
        public static ActionType ModifyProperties { get; } = new ActionType(ModifyPropertiesValue);
        /// <summary> Run a playbook on an object. </summary>
        public static ActionType RunPlaybook { get; } = new ActionType(RunPlaybookValue);
        /// <summary> Add a task to an incident object. </summary>
        public static ActionType AddIncidentTask { get; } = new ActionType(AddIncidentTaskValue);
        /// <summary> Determines if two <see cref="ActionType"/> values are the same. </summary>
        public static bool operator ==(ActionType left, ActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ActionType"/> values are not the same. </summary>
        public static bool operator !=(ActionType left, ActionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ActionType"/>. </summary>
        public static implicit operator ActionType(string value) => new ActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
