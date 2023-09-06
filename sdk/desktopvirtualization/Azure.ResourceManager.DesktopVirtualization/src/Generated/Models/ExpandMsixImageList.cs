// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> List of MSIX package properties retrieved from MSIX Image expansion. </summary>
    internal partial class ExpandMsixImageList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExpandMsixImageList"/>. </summary>
        internal ExpandMsixImageList()
        {
            Value = new ChangeTrackingList<ExpandMsixImage>();
        }

        /// <summary> Initializes a new instance of <see cref="ExpandMsixImageList"/>. </summary>
        /// <param name="value"> List of MSIX package properties from give MSIX Image. </param>
        /// <param name="nextLink"> Link to the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpandMsixImageList(IReadOnlyList<ExpandMsixImage> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of MSIX package properties from give MSIX Image. </summary>
        public IReadOnlyList<ExpandMsixImage> Value { get; }
        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
    }
}
