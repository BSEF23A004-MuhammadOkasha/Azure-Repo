// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Authorization
{
    /// <summary>
    /// List role assignments filter.
    /// </summary>
    public partial class ListAssignmentsFilterParameters
    {
        private string _assignedToPrincipalId;
        
        /// <summary>
        /// Optional. Returns role assignments directly assigned to the
        /// principal as well as assignments to the principal's groups
        /// (transitive). Currenly supported only for User Principals
        /// </summary>
        public string AssignedToPrincipalId
        {
            get { return this._assignedToPrincipalId; }
            set { this._assignedToPrincipalId = value; }
        }
        
        private bool _atScope;
        
        /// <summary>
        /// Optional. This returns all role assignments at or above.
        /// </summary>
        public bool AtScope
        {
            get { return this._atScope; }
            set { this._atScope = value; }
        }
        
        private string _principalId;
        
        /// <summary>
        /// Optional. Returns role assignment of the specific principal.
        /// </summary>
        public string PrincipalId
        {
            get { return this._principalId; }
            set { this._principalId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ListAssignmentsFilterParameters
        /// class.
        /// </summary>
        public ListAssignmentsFilterParameters()
        {
        }
    }
}
