// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Content type to stream, eg. audio, audio/video. </summary>
    public readonly partial struct MediaStreamingContent : IEquatable<MediaStreamingContent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaStreamingContent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaStreamingContent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AudioValue = "audio";

        /// <summary> audio. </summary>
        public static MediaStreamingContent Audio { get; } = new MediaStreamingContent(AudioValue);
        /// <summary> Determines if two <see cref="MediaStreamingContent"/> values are the same. </summary>
        public static bool operator ==(MediaStreamingContent left, MediaStreamingContent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaStreamingContent"/> values are not the same. </summary>
        public static bool operator !=(MediaStreamingContent left, MediaStreamingContent right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MediaStreamingContent"/>. </summary>
        public static implicit operator MediaStreamingContent(string value) => new MediaStreamingContent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaStreamingContent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaStreamingContent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
