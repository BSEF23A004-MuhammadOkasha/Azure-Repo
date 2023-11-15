// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> The SelectiveKeyRestoreOperationParameters. </summary>
    internal partial class SelectiveKeyRestoreOperationParameters
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SelectiveKeyRestoreOperationParameters"/>. </summary>
        /// <param name="sasTokenParameters"></param>
        /// <param name="folder"> The Folder name of the blob where the previous successful full backup was stored. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasTokenParameters"/> or <paramref name="folder"/> is null. </exception>
        public SelectiveKeyRestoreOperationParameters(SASTokenParameter sasTokenParameters, string folder)
        {
            Argument.AssertNotNull(sasTokenParameters, nameof(sasTokenParameters));
            Argument.AssertNotNull(folder, nameof(folder));

            SasTokenParameters = sasTokenParameters;
            Folder = folder;
        }

        /// <summary> Initializes a new instance of <see cref="SelectiveKeyRestoreOperationParameters"/>. </summary>
        /// <param name="sasTokenParameters"></param>
        /// <param name="folder"> The Folder name of the blob where the previous successful full backup was stored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SelectiveKeyRestoreOperationParameters(SASTokenParameter sasTokenParameters, string folder, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SasTokenParameters = sasTokenParameters;
            Folder = folder;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SelectiveKeyRestoreOperationParameters"/> for deserialization. </summary>
        internal SelectiveKeyRestoreOperationParameters()
        {
        }

        /// <summary> Gets the sas token parameters. </summary>
        public SASTokenParameter SasTokenParameters { get; }
        /// <summary> The Folder name of the blob where the previous successful full backup was stored. </summary>
        public string Folder { get; }
    }
}
