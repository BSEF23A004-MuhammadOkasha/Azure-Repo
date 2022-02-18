// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment What-if operation parameters. </summary>
    internal partial class DeploymentWhatIf
    {
        /// <summary> Initializes a new instance of DeploymentWhatIf. </summary>
        /// <param name="properties"> The deployment properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeploymentWhatIf(DeploymentWhatIfProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> The location to store the deployment data. </summary>
        public string Location { get; set; }
        /// <summary> The deployment properties. </summary>
        internal DeploymentWhatIfProperties Properties { get; }
        /// <summary> The format of the What-If results. </summary>
        public WhatIfResultFormat? WhatIfResultFormat
        {
            get => Properties.WhatIfResultFormat;
            set => Properties.WhatIfResultFormat = value;
        }
    }
}
