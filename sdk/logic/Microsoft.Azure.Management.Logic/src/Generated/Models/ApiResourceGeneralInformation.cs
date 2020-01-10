// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The API general information.
    /// </summary>
    public partial class ApiResourceGeneralInformation
    {
        /// <summary>
        /// Initializes a new instance of the ApiResourceGeneralInformation
        /// class.
        /// </summary>
        public ApiResourceGeneralInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiResourceGeneralInformation
        /// class.
        /// </summary>
        /// <param name="iconUrl">The icon url.</param>
        /// <param name="displayName">The display name.</param>
        /// <param name="description">The description.</param>
        /// <param name="termsOfUseUrl">The terms of use url.</param>
        /// <param name="releaseTag">The release tag.</param>
        /// <param name="tier">The tier. Possible values include:
        /// 'NotSpecified', 'Enterprise', 'Standard', 'Premium'</param>
        public ApiResourceGeneralInformation(string iconUrl = default(string), string displayName = default(string), string description = default(string), string termsOfUseUrl = default(string), string releaseTag = default(string), string tier = default(string))
        {
            IconUrl = iconUrl;
            DisplayName = displayName;
            Description = description;
            TermsOfUseUrl = termsOfUseUrl;
            ReleaseTag = releaseTag;
            Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the icon url.
        /// </summary>
        [JsonProperty(PropertyName = "iconUrl")]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the terms of use url.
        /// </summary>
        [JsonProperty(PropertyName = "termsOfUseUrl")]
        public string TermsOfUseUrl { get; set; }

        /// <summary>
        /// Gets or sets the release tag.
        /// </summary>
        [JsonProperty(PropertyName = "releaseTag")]
        public string ReleaseTag { get; set; }

        /// <summary>
        /// Gets or sets the tier. Possible values include: 'NotSpecified',
        /// 'Enterprise', 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

    }
}
