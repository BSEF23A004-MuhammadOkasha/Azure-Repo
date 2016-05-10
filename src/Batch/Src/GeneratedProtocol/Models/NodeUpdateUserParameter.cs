// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters for a ComputeNodeOperations.UpdateUser request.
    /// </summary>
    public partial class NodeUpdateUserParameter
    {
        /// <summary>
        /// Initializes a new instance of the NodeUpdateUserParameter class.
        /// </summary>
        public NodeUpdateUserParameter() { }

        /// <summary>
        /// Initializes a new instance of the NodeUpdateUserParameter class.
        /// </summary>
        public NodeUpdateUserParameter(string password = default(string), DateTime? expiryTime = default(DateTime?), string sshPublicKey = default(string))
        {
            Password = password;
            ExpiryTime = expiryTime;
            SshPublicKey = sshPublicKey;
        }

        /// <summary>
        /// The password of the account.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// The time at which the account should expire. If omitted, the
        /// default is 1 day from the current time.
        /// </summary>
        [JsonProperty(PropertyName = "expiryTime")]
        public DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// The SSH public key that can be used for remote login to the
        /// compute node.
        /// </summary>
        [JsonProperty(PropertyName = "sshPublicKey")]
        public string SshPublicKey { get; set; }

    }
}
