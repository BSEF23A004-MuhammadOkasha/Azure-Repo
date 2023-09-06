// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxDeploymentUpdateProperties. </summary>
    public partial class NginxDeploymentUpdateProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NginxDeploymentUpdateProperties"/>. </summary>
        public NginxDeploymentUpdateProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NginxDeploymentUpdateProperties"/>. </summary>
        /// <param name="enableDiagnosticsSupport"></param>
        /// <param name="logging"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NginxDeploymentUpdateProperties(bool? enableDiagnosticsSupport, NginxLogging logging, Dictionary<string, BinaryData> rawData)
        {
            EnableDiagnosticsSupport = enableDiagnosticsSupport;
            Logging = logging;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the enable diagnostics support. </summary>
        public bool? EnableDiagnosticsSupport { get; set; }
        /// <summary> Gets or sets the logging. </summary>
        internal NginxLogging Logging { get; set; }
        /// <summary> Gets or sets the logging storage account. </summary>
        public NginxStorageAccount LoggingStorageAccount
        {
            get => Logging is null ? default : Logging.StorageAccount;
            set
            {
                if (Logging is null)
                    Logging = new NginxLogging();
                Logging.StorageAccount = value;
            }
        }
    }
}
