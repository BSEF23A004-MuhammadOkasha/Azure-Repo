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
using Microsoft.Azure.Management.TrafficManager.Models;

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    /// <summary>
    /// Class respresenting a Traffic Manager endpoint.
    /// </summary>
    public partial class Endpoint
    {
        private string _id;
        
        /// <summary>
        /// Optional. Gets or sets the ID of the Traffic Manager endpoint.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the name of the Traffic Manager endpoint.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private EndpointProperties _properties;
        
        /// <summary>
        /// Required. Gets or sets the properties of the Traffic Manager
        /// endpoint.
        /// </summary>
        public EndpointProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Gets or sets the endpoint type of the Traffic Manager
        /// endpoint.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Endpoint class.
        /// </summary>
        public Endpoint()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the Endpoint class with required
        /// arguments.
        /// </summary>
        public Endpoint(EndpointProperties properties)
            : this()
        {
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }
            this.Properties = properties;
        }
    }
}
