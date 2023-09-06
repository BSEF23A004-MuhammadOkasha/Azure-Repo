// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The Authentication properties for the client. </summary>
    public partial class EventGridNamespaceClientAuthentication
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventGridNamespaceClientAuthentication"/>. </summary>
        public EventGridNamespaceClientAuthentication()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventGridNamespaceClientAuthentication"/>. </summary>
        /// <param name="certificateThumbprint"> The self signed certificate's thumbprints data used for authentication. </param>
        /// <param name="certificateSubject"> The CA certificate subject name used for authentication. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventGridNamespaceClientAuthentication(ClientCertificateThumbprint certificateThumbprint, ClientCertificateSubjectDistinguishedName certificateSubject, Dictionary<string, BinaryData> rawData)
        {
            CertificateThumbprint = certificateThumbprint;
            CertificateSubject = certificateSubject;
            _rawData = rawData;
        }

        /// <summary> The self signed certificate's thumbprints data used for authentication. </summary>
        public ClientCertificateThumbprint CertificateThumbprint { get; set; }
        /// <summary> The CA certificate subject name used for authentication. </summary>
        public ClientCertificateSubjectDistinguishedName CertificateSubject { get; set; }
    }
}
