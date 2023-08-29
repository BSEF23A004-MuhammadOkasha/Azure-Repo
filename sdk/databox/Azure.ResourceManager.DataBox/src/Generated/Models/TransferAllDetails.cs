// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Details to transfer all data. </summary>
    public partial class TransferAllDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TransferAllDetails"/>. </summary>
        /// <param name="dataAccountType"> Type of the account of data. </param>
        public TransferAllDetails(DataAccountType dataAccountType)
        {
            DataAccountType = dataAccountType;
        }

        /// <summary> Initializes a new instance of <see cref="TransferAllDetails"/>. </summary>
        /// <param name="dataAccountType"> Type of the account of data. </param>
        /// <param name="transferAllBlobs"> To indicate if all Azure blobs have to be transferred. </param>
        /// <param name="transferAllFiles"> To indicate if all Azure Files have to be transferred. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TransferAllDetails(DataAccountType dataAccountType, bool? transferAllBlobs, bool? transferAllFiles, Dictionary<string, BinaryData> rawData)
        {
            DataAccountType = dataAccountType;
            TransferAllBlobs = transferAllBlobs;
            TransferAllFiles = transferAllFiles;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TransferAllDetails"/> for deserialization. </summary>
        internal TransferAllDetails()
        {
        }

        /// <summary> Type of the account of data. </summary>
        public DataAccountType DataAccountType { get; set; }
        /// <summary> To indicate if all Azure blobs have to be transferred. </summary>
        public bool? TransferAllBlobs { get; set; }
        /// <summary> To indicate if all Azure Files have to be transferred. </summary>
        public bool? TransferAllFiles { get; set; }
    }
}
