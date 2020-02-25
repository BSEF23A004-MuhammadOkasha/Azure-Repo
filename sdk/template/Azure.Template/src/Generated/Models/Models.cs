// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace Azure.Template.Models
{
    /// <summary> Response to the list custom models operation. </summary>
    public partial class Models
    {
        /// <summary> Summary of all trained custom models. </summary>
        public ModelsSummary Summary { get; set; }
        /// <summary> Collection of trained custom models. </summary>
        public ICollection<ModelInfo> ModelList { get; set; }
        /// <summary> Link to the next page of custom models. </summary>
        public string NextLink { get; set; }
    }
}
