// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Gallery.Models
{
    /// <summary> The GalleryExpand. </summary>
    public readonly partial struct GalleryExpand : IEquatable<GalleryExpand>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GalleryExpand"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GalleryExpand(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SharingProfileGroupsValue = "SharingProfile/Groups";

        /// <summary> SharingProfile/Groups. </summary>
        public static GalleryExpand SharingProfileGroups { get; } = new GalleryExpand(SharingProfileGroupsValue);
        /// <summary> Determines if two <see cref="GalleryExpand"/> values are the same. </summary>
        public static bool operator ==(GalleryExpand left, GalleryExpand right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GalleryExpand"/> values are not the same. </summary>
        public static bool operator !=(GalleryExpand left, GalleryExpand right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="GalleryExpand"/>. </summary>
        public static implicit operator GalleryExpand(string value) => new GalleryExpand(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GalleryExpand other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GalleryExpand other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
