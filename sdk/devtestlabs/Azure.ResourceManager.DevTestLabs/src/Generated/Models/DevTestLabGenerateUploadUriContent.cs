// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties for generating an upload URI. </summary>
    public partial class DevTestLabGenerateUploadUriContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabGenerateUploadUriContent"/>. </summary>
        public DevTestLabGenerateUploadUriContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabGenerateUploadUriContent"/>. </summary>
        /// <param name="blobName"> The blob name of the upload URI. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabGenerateUploadUriContent(string blobName, Dictionary<string, BinaryData> rawData)
        {
            BlobName = blobName;
            _rawData = rawData;
        }

        /// <summary> The blob name of the upload URI. </summary>
        public string BlobName { get; set; }
    }
}
