// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The DeploymentLogs. </summary>
    public partial class DeploymentLogs
    {
        /// <summary> Initializes a new instance of DeploymentLogs. </summary>
        internal DeploymentLogs()
        {
        }

        /// <summary> Initializes a new instance of DeploymentLogs. </summary>
        /// <param name="content"> The retrieved online deployment logs. </param>
        internal DeploymentLogs(string content)
        {
            Content = content;
        }

        /// <summary> The retrieved online deployment logs. </summary>
        public string Content { get; }
    }
}
