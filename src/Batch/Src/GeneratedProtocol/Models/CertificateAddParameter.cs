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
    /// A certificate that can be installed on compute nodes and can be used
    /// to authenticate operations on the machine.
    /// </summary>
    public partial class CertificateAddParameter
    {
        /// <summary>
        /// Initializes a new instance of the CertificateAddParameter class.
        /// </summary>
        public CertificateAddParameter() { }

        /// <summary>
        /// Initializes a new instance of the CertificateAddParameter class.
        /// </summary>
        public CertificateAddParameter(string thumbprint, string thumbprintAlgorithm, string data, CertificateFormat? certificateFormat = default(CertificateFormat?), string password = default(string))
        {
            Thumbprint = thumbprint;
            ThumbprintAlgorithm = thumbprintAlgorithm;
            Data = data;
            CertificateFormat = certificateFormat;
            Password = password;
        }

        /// <summary>
        /// The X.509 thumbprint of the certificate. This is a sequence of up
        /// to 40 hex digits (it may include spaces but these are removed).
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// The algorithm used to derive the thumbprint. This must be sha1.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprintAlgorithm")]
        public string ThumbprintAlgorithm { get; set; }

        /// <summary>
        /// The base64-encoded contents of the certificate. The maximum size
        /// is 10KB.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        /// <summary>
        /// The format of the certificate data. Possible values include:
        /// 'pfx', 'cer', 'unmapped'
        /// </summary>
        [JsonProperty(PropertyName = "certificateFormat")]
        public CertificateFormat? CertificateFormat { get; set; }

        /// <summary>
        /// The password to access the certificate's private key.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Thumbprint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Thumbprint");
            }
            if (ThumbprintAlgorithm == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ThumbprintAlgorithm");
            }
            if (Data == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Data");
            }
        }
    }
}
