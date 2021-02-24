// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> json text configuration. </summary>
    internal partial class JsonTextConfigurationInternal
    {
        /// <summary> Initializes a new instance of JsonTextConfigurationInternal. </summary>
        /// <param name="recordSeparator"> record separator. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recordSeparator"/> is null. </exception>
        public JsonTextConfigurationInternal(string recordSeparator)
        {
            if (recordSeparator == null)
            {
                throw new ArgumentNullException(nameof(recordSeparator));
            }

            RecordSeparator = recordSeparator;
        }

        /// <summary> record separator. </summary>
        public string RecordSeparator { get; }
    }
}
