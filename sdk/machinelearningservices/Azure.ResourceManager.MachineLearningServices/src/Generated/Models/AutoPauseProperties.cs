// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Auto pause properties. </summary>
    public partial class AutoPauseProperties
    {
        /// <summary> Initializes a new instance of AutoPauseProperties. </summary>
        public AutoPauseProperties()
        {
        }

        /// <summary> Initializes a new instance of AutoPauseProperties. </summary>
        /// <param name="delayInMinutes"></param>
        /// <param name="enabled"></param>
        internal AutoPauseProperties(int? delayInMinutes, bool? enabled)
        {
            DelayInMinutes = delayInMinutes;
            Enabled = enabled;
        }

        public int? DelayInMinutes { get; set; }
        public bool? Enabled { get; set; }
    }
}
