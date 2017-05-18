// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The response model for the list job operation.
    /// </summary>
    public partial class DscNodeConfigurationListResponse : OperationResponseWithSkipToken
    {
        private IList<DscNodeConfiguration> _dscNodeConfigurations;
        
        /// <summary>
        /// Optional. Gets or sets a list of Dsc node configurations.
        /// </summary>
        public IList<DscNodeConfiguration> DscNodeConfigurations
        {
            get { return this._dscNodeConfigurations; }
            set { this._dscNodeConfigurations = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DscNodeConfigurationListResponse
        /// class.
        /// </summary>
        public DscNodeConfigurationListResponse()
        {
            this.DscNodeConfigurations = new LazyList<DscNodeConfiguration>();
        }
    }
}
