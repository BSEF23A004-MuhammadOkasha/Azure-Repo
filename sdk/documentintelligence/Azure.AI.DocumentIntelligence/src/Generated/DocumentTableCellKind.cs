// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Table cell kind. </summary>
    public readonly partial struct DocumentTableCellKind : IEquatable<DocumentTableCellKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentTableCellKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentTableCellKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ContentValue = "content";
        private const string RowHeaderValue = "rowHeader";
        private const string ColumnHeaderValue = "columnHeader";
        private const string StubHeadValue = "stubHead";
        private const string DescriptionValue = "description";

        /// <summary> Contains the main content/data. </summary>
        public static DocumentTableCellKind Content { get; } = new DocumentTableCellKind(ContentValue);
        /// <summary> Describes the content of the row. </summary>
        public static DocumentTableCellKind RowHeader { get; } = new DocumentTableCellKind(RowHeaderValue);
        /// <summary> Describes the content of the column. </summary>
        public static DocumentTableCellKind ColumnHeader { get; } = new DocumentTableCellKind(ColumnHeaderValue);
        /// <summary> Describes the row headers, usually located at the top left corner of a table. </summary>
        public static DocumentTableCellKind StubHead { get; } = new DocumentTableCellKind(StubHeadValue);
        /// <summary> Describes the content in (parts of) the table. </summary>
        public static DocumentTableCellKind Description { get; } = new DocumentTableCellKind(DescriptionValue);
        /// <summary> Determines if two <see cref="DocumentTableCellKind"/> values are the same. </summary>
        public static bool operator ==(DocumentTableCellKind left, DocumentTableCellKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentTableCellKind"/> values are not the same. </summary>
        public static bool operator !=(DocumentTableCellKind left, DocumentTableCellKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DocumentTableCellKind"/>. </summary>
        public static implicit operator DocumentTableCellKind(string value) => new DocumentTableCellKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentTableCellKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentTableCellKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
