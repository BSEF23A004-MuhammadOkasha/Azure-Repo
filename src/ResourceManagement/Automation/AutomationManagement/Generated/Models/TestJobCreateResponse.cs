// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The response model for the create test job operation.
    /// </summary>
    public partial class TestJobCreateResponse : AzureOperationResponse
    {
        private TestJob _testJob;
        
        /// <summary>
        /// Optional. Gets or sets a test job.
        /// </summary>
        public TestJob TestJob
        {
            get { return this._testJob; }
            set { this._testJob = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TestJobCreateResponse class.
        /// </summary>
        public TestJobCreateResponse()
        {
        }
    }
}
