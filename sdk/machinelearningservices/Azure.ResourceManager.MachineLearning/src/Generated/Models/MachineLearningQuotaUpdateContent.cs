// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Quota update parameters. </summary>
    public partial class MachineLearningQuotaUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningQuotaUpdateContent"/>. </summary>
        public MachineLearningQuotaUpdateContent()
        {
            Value = new ChangeTrackingList<MachineLearningQuotaProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningQuotaUpdateContent"/>. </summary>
        /// <param name="value"> The list for update quota. </param>
        /// <param name="location"> Region of workspace quota to be updated. </param>
        internal MachineLearningQuotaUpdateContent(IList<MachineLearningQuotaProperties> value, AzureLocation? location)
        {
            Value = value;
            Location = location;
        }

        /// <summary> The list for update quota. </summary>
        public IList<MachineLearningQuotaProperties> Value { get; }
        /// <summary> Region of workspace quota to be updated. </summary>
        public AzureLocation? Location { get; set; }
    }
}
