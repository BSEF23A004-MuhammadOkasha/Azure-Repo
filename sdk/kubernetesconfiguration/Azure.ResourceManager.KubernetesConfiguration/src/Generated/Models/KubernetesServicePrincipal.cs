// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Parameters to authenticate using Service Principal. </summary>
    public partial class KubernetesServicePrincipal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KubernetesServicePrincipal"/>. </summary>
        public KubernetesServicePrincipal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesServicePrincipal"/>. </summary>
        /// <param name="clientId"> The client Id for authenticating a Service Principal. </param>
        /// <param name="tenantId"> The tenant Id for authenticating a Service Principal. </param>
        /// <param name="clientSecret"> The client secret for authenticating a Service Principal. </param>
        /// <param name="clientCertificate"> Base64-encoded certificate used to authenticate a Service Principal. </param>
        /// <param name="clientCertificatePassword"> The password for the certificate used to authenticate a Service Principal. </param>
        /// <param name="clientCertificateSendChain"> Specifies whether to include x5c header in client claims when acquiring a token to enable subject name / issuer based authentication for the Client Certificate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesServicePrincipal(Guid? clientId, Guid? tenantId, string clientSecret, string clientCertificate, string clientCertificatePassword, bool? clientCertificateSendChain, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClientId = clientId;
            TenantId = tenantId;
            ClientSecret = clientSecret;
            ClientCertificate = clientCertificate;
            ClientCertificatePassword = clientCertificatePassword;
            ClientCertificateSendChain = clientCertificateSendChain;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The client Id for authenticating a Service Principal. </summary>
        public Guid? ClientId { get; set; }
        /// <summary> The tenant Id for authenticating a Service Principal. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> The client secret for authenticating a Service Principal. </summary>
        public string ClientSecret { get; set; }
        /// <summary> Base64-encoded certificate used to authenticate a Service Principal. </summary>
        public string ClientCertificate { get; set; }
        /// <summary> The password for the certificate used to authenticate a Service Principal. </summary>
        public string ClientCertificatePassword { get; set; }
        /// <summary> Specifies whether to include x5c header in client claims when acquiring a token to enable subject name / issuer based authentication for the Client Certificate. </summary>
        public bool? ClientCertificateSendChain { get; set; }
    }
}
