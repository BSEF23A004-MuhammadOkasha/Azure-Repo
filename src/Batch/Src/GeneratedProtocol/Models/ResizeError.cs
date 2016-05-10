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
    /// An error that occurred when resizing a pool.
    /// </summary>
    public partial class ResizeError
    {
        /// <summary>
        /// Initializes a new instance of the ResizeError class.
        /// </summary>
        public ResizeError() { }

        /// <summary>
        /// Initializes a new instance of the ResizeError class.
        /// </summary>
        public ResizeError(string code = default(string), string message = default(string), IList<NameValuePair> values = default(IList<NameValuePair>))
        {
            Code = code;
            Message = message;
            Values = values;
        }

        /// <summary>
        /// An identifier for the pool resize error. Codes are invariant and
        /// are intended to be consumed programmatically.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// A message describing the pool resize error, intended to be
        /// suitable for display in a user interface.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// A list of additional error details related to the pool resize
        /// error.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<NameValuePair> Values { get; set; }

    }
}
