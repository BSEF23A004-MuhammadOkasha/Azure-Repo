// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The video codec used by the Media Profile. </summary>
    public readonly partial struct VideoEncoding : IEquatable<VideoEncoding>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VideoEncoding"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VideoEncoding(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string JpegValue = "JPEG";
        private const string H264Value = "H264";
        private const string Mpeg4Value = "MPEG4";

        /// <summary> The Media Profile uses JPEG encoding. </summary>
        public static VideoEncoding Jpeg { get; } = new VideoEncoding(JpegValue);
        /// <summary> The Media Profile uses H264 encoding. </summary>
        public static VideoEncoding H264 { get; } = new VideoEncoding(H264Value);
        /// <summary> The Media Profile uses MPEG4 encoding. </summary>
        public static VideoEncoding Mpeg4 { get; } = new VideoEncoding(Mpeg4Value);
        /// <summary> Determines if two <see cref="VideoEncoding"/> values are the same. </summary>
        public static bool operator ==(VideoEncoding left, VideoEncoding right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VideoEncoding"/> values are not the same. </summary>
        public static bool operator !=(VideoEncoding left, VideoEncoding right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VideoEncoding"/>. </summary>
        public static implicit operator VideoEncoding(string value) => new VideoEncoding(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VideoEncoding other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VideoEncoding other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
