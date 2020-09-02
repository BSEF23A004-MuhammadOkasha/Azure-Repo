// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Extracted information from a single page. </summary>
    internal partial class PageResult
    {
        /// <summary> Initializes a new instance of PageResult. </summary>
        /// <param name="page"> Page number. </param>
        internal PageResult(int page)
        {
            Page = page;
            KeyValuePairs = new ChangeTrackingList<KeyValuePair>();
            Tables = new ChangeTrackingList<DataTable>();
        }

        /// <summary> Initializes a new instance of PageResult. </summary>
        /// <param name="page"> Page number. </param>
        /// <param name="clusterId"> Cluster identifier. </param>
        /// <param name="keyValuePairs"> List of key-value pairs extracted from the page. </param>
        /// <param name="tables"> List of data tables extracted from the page. </param>
        internal PageResult(int page, int? clusterId, IReadOnlyList<KeyValuePair> keyValuePairs, IReadOnlyList<DataTable> tables)
        {
            Page = page;
            ClusterId = clusterId;
            KeyValuePairs = keyValuePairs;
            Tables = tables;
        }

        /// <summary> Page number. </summary>
        public int Page { get; }
        /// <summary> Cluster identifier. </summary>
        public int? ClusterId { get; }
        /// <summary> List of key-value pairs extracted from the page. </summary>
        public IReadOnlyList<KeyValuePair> KeyValuePairs { get; }
        /// <summary> List of data tables extracted from the page. </summary>
        public IReadOnlyList<DataTable> Tables { get; }
    }
}
