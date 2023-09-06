// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The WebhookHookParameterPatch. </summary>
    internal partial class WebhookHookParameterPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebhookHookParameterPatch"/>. </summary>
        public WebhookHookParameterPatch()
        {
            Headers = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="WebhookHookParameterPatch"/>. </summary>
        /// <param name="endpoint"> API address, will be called when alert is triggered, only support POST method via SSL. </param>
        /// <param name="username"> (Deprecated) The username, if using basic authentication. </param>
        /// <param name="password"> (Deprecated) The password, if using basic authentication. </param>
        /// <param name="headers"> custom headers in api call. </param>
        /// <param name="certificateKey"> The certificate key, if using client certificate. </param>
        /// <param name="certificatePassword"> The certificate password, if using client certificate. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebhookHookParameterPatch(string endpoint, string username, string password, IDictionary<string, string> headers, string certificateKey, string certificatePassword, Dictionary<string, BinaryData> rawData)
        {
            Endpoint = endpoint;
            Username = username;
            Password = password;
            Headers = headers;
            CertificateKey = certificateKey;
            CertificatePassword = certificatePassword;
            _rawData = rawData;
        }

        /// <summary> API address, will be called when alert is triggered, only support POST method via SSL. </summary>
        public string Endpoint { get; set; }
        /// <summary> (Deprecated) The username, if using basic authentication. </summary>
        public string Username { get; set; }
        /// <summary> (Deprecated) The password, if using basic authentication. </summary>
        public string Password { get; set; }
        /// <summary> The certificate key, if using client certificate. </summary>
        public string CertificateKey { get; set; }
        /// <summary> The certificate password, if using client certificate. </summary>
        public string CertificatePassword { get; set; }
    }
}
