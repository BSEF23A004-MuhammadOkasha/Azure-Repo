// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Messages
{
    /// <summary> The type of message. </summary>
    internal readonly partial struct CommunicationMessageKind : IEquatable<CommunicationMessageKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CommunicationMessageKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommunicationMessageKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextValue = "text";
        private const string ImageValue = "image";
        private const string ImageV0Value = "image_v0";
        private const string DocumentValue = "document";
        private const string VideoValue = "video";
        private const string AudioValue = "audio";
        private const string TemplateValue = "template";

        /// <summary> Text message type. </summary>
        public static CommunicationMessageKind Text { get; } = new CommunicationMessageKind(TextValue);
        /// <summary> Image message type. </summary>
        public static CommunicationMessageKind Image { get; } = new CommunicationMessageKind(ImageValue);
        /// <summary> Image message type. Legacy image type for `MediaNotificationContent` which is being deprecated. </summary>
        public static CommunicationMessageKind ImageV0 { get; } = new CommunicationMessageKind(ImageV0Value);
        /// <summary> Document message type. </summary>
        public static CommunicationMessageKind Document { get; } = new CommunicationMessageKind(DocumentValue);
        /// <summary> Video message type. </summary>
        public static CommunicationMessageKind Video { get; } = new CommunicationMessageKind(VideoValue);
        /// <summary> Audio message type. </summary>
        public static CommunicationMessageKind Audio { get; } = new CommunicationMessageKind(AudioValue);
        /// <summary> Template message type. </summary>
        public static CommunicationMessageKind Template { get; } = new CommunicationMessageKind(TemplateValue);
        /// <summary> Determines if two <see cref="CommunicationMessageKind"/> values are the same. </summary>
        public static bool operator ==(CommunicationMessageKind left, CommunicationMessageKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommunicationMessageKind"/> values are not the same. </summary>
        public static bool operator !=(CommunicationMessageKind left, CommunicationMessageKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CommunicationMessageKind"/>. </summary>
        public static implicit operator CommunicationMessageKind(string value) => new CommunicationMessageKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommunicationMessageKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommunicationMessageKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
