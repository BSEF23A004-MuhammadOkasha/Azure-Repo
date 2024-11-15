// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Type of the sync activity state. </summary>
    public readonly partial struct ServerEndpointSyncActivityState : IEquatable<ServerEndpointSyncActivityState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServerEndpointSyncActivityState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServerEndpointSyncActivityState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UploadValue = "Upload";
        private const string DownloadValue = "Download";
        private const string UploadAndDownloadValue = "UploadAndDownload";

        /// <summary> Upload. </summary>
        public static ServerEndpointSyncActivityState Upload { get; } = new ServerEndpointSyncActivityState(UploadValue);
        /// <summary> Download. </summary>
        public static ServerEndpointSyncActivityState Download { get; } = new ServerEndpointSyncActivityState(DownloadValue);
        /// <summary> UploadAndDownload. </summary>
        public static ServerEndpointSyncActivityState UploadAndDownload { get; } = new ServerEndpointSyncActivityState(UploadAndDownloadValue);
        /// <summary> Determines if two <see cref="ServerEndpointSyncActivityState"/> values are the same. </summary>
        public static bool operator ==(ServerEndpointSyncActivityState left, ServerEndpointSyncActivityState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServerEndpointSyncActivityState"/> values are not the same. </summary>
        public static bool operator !=(ServerEndpointSyncActivityState left, ServerEndpointSyncActivityState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ServerEndpointSyncActivityState"/>. </summary>
        public static implicit operator ServerEndpointSyncActivityState(string value) => new ServerEndpointSyncActivityState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServerEndpointSyncActivityState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServerEndpointSyncActivityState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
