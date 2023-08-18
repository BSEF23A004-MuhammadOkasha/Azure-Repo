// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Cross-Origin Resource Sharing (CORS) settings for the app. </summary>
    public partial class AppServiceCorsSettings
    {
        /// <summary> Initializes a new instance of AppServiceCorsSettings. </summary>
        public AppServiceCorsSettings()
        {
            AllowedOrigins = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AppServiceCorsSettings. </summary>
        /// <param name="allowedOrigins">
        /// Gets or sets the list of origins that should be allowed to make cross-origin
        /// calls (for example: http://example.com:12345). Use "*" to allow all.
        /// </param>
        /// <param name="isCredentialsSupported">
        /// Gets or sets whether CORS requests with credentials are allowed. See
        /// https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS#Requests_with_credentials
        /// for more details.
        /// </param>
        internal AppServiceCorsSettings(IList<string> allowedOrigins, bool? isCredentialsSupported)
        {
            AllowedOrigins = allowedOrigins;
            IsCredentialsSupported = isCredentialsSupported;
        }

        /// <summary>
        /// Gets or sets the list of origins that should be allowed to make cross-origin
        /// calls (for example: http://example.com:12345). Use "*" to allow all.
        /// </summary>
        public IList<string> AllowedOrigins { get; }
        /// <summary>
        /// Gets or sets whether CORS requests with credentials are allowed. See
        /// https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS#Requests_with_credentials
        /// for more details.
        /// </summary>
        public bool? IsCredentialsSupported { get; set; }
    }
}
