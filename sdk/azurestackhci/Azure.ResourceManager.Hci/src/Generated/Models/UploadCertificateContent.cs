// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The UploadCertificateContent. </summary>
    public partial class UploadCertificateContent
    {
        /// <summary> Initializes a new instance of <see cref="UploadCertificateContent"/>. </summary>
        public UploadCertificateContent()
        {
        }

        /// <summary> Gets or sets the properties. </summary>
        internal RawCertificateData Properties { get; set; }
        /// <summary> Gets the certificates. </summary>
        public IList<string> Certificates
        {
            get
            {
                if (Properties is null)
                    Properties = new RawCertificateData();
                return Properties.Certificates;
            }
        }
    }
}
