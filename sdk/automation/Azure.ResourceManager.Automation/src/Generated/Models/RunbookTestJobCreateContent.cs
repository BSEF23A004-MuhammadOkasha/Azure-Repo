// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create test job operation. </summary>
    public partial class RunbookTestJobCreateContent
    {
        /// <summary> Initializes a new instance of RunbookTestJobCreateContent. </summary>
        public RunbookTestJobCreateContent()
        {
            Parameters = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets the parameters of the test job. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> Gets or sets the runOn which specifies the group name where the job is to be executed. </summary>
        public string RunOn { get; set; }
    }
}
