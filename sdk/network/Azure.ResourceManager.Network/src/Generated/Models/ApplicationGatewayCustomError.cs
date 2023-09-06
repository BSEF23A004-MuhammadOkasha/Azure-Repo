// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Custom error of an application gateway. </summary>
    public partial class ApplicationGatewayCustomError
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayCustomError"/>. </summary>
        public ApplicationGatewayCustomError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayCustomError"/>. </summary>
        /// <param name="statusCode"> Status code of the application gateway custom error. </param>
        /// <param name="customErrorPageUri"> Error page URL of the application gateway custom error. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayCustomError(ApplicationGatewayCustomErrorStatusCode? statusCode, Uri customErrorPageUri, Dictionary<string, BinaryData> rawData)
        {
            StatusCode = statusCode;
            CustomErrorPageUri = customErrorPageUri;
            _rawData = rawData;
        }

        /// <summary> Status code of the application gateway custom error. </summary>
        public ApplicationGatewayCustomErrorStatusCode? StatusCode { get; set; }
        /// <summary> Error page URL of the application gateway custom error. </summary>
        public Uri CustomErrorPageUri { get; set; }
    }
}
