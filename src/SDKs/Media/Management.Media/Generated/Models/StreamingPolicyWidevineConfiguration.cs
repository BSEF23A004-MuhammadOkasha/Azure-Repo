// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class to specify configurations of Widevine in Streaming Policy
    /// </summary>
    public partial class StreamingPolicyWidevineConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StreamingPolicyWidevineConfiguration class.
        /// </summary>
        public StreamingPolicyWidevineConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StreamingPolicyWidevineConfiguration class.
        /// </summary>
        /// <param name="customLicenseAcquisitionUrlTemplate">Template for the
        /// URL of the custom service delivering licenses to end user players.
        /// Not required when using Azure Media Services for issuing licenses.
        /// The template supports replaceable tokens that the service will
        /// update at runtime with the value specific to the request.  The
        /// currently supported token values are {AlternativeMediaId}, which is
        /// replaced with the value of StreamingLocatorId.AlternativeMediaId,
        /// and {ContentKeyId}, which is replaced with the value of identifier
        /// of the key being requested.</param>
        public StreamingPolicyWidevineConfiguration(string customLicenseAcquisitionUrlTemplate = default(string))
        {
            CustomLicenseAcquisitionUrlTemplate = customLicenseAcquisitionUrlTemplate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets template for the URL of the custom service delivering
        /// licenses to end user players.  Not required when using Azure Media
        /// Services for issuing licenses.  The template supports replaceable
        /// tokens that the service will update at runtime with the value
        /// specific to the request.  The currently supported token values are
        /// {AlternativeMediaId}, which is replaced with the value of
        /// StreamingLocatorId.AlternativeMediaId, and {ContentKeyId}, which is
        /// replaced with the value of identifier of the key being requested.
        /// </summary>
        [JsonProperty(PropertyName = "customLicenseAcquisitionUrlTemplate")]
        public string CustomLicenseAcquisitionUrlTemplate { get; set; }

    }
}
