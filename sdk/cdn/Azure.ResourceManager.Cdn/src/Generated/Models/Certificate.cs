// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Certificate used for https. </summary>
    internal partial class Certificate
    {
        /// <summary> Initializes a new instance of Certificate. </summary>
        internal Certificate()
        {
        }

        /// <summary> Subject name in the certificate. </summary>
        public string Subject { get; }
        /// <summary> Certificate expiration date. </summary>
        public string ExpirationDate { get; }
        /// <summary> Certificate thumbprint. </summary>
        public string Thumbprint { get; }
    }
}
