// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The information type.
    /// </summary>
    public partial class InformationType
    {
        /// <summary>
        /// Initializes a new instance of the InformationType class.
        /// </summary>
        public InformationType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InformationType class.
        /// </summary>
        /// <param name="displayName">The name of the information type.</param>
        /// <param name="description">The description of the information
        /// type.</param>
        /// <param name="order">The order of the information type.</param>
        /// <param name="recommendedLabelId">The recommended label id to be
        /// associated with this information type.</param>
        /// <param name="enabled">Indicates whether the information type is
        /// enabled or not.</param>
        /// <param name="custom">Indicates whether the information type is
        /// custom or not.</param>
        /// <param name="keywords">The information type keywords.</param>
        public InformationType(string displayName = default(string), string description = default(string), int? order = default(int?), System.Guid? recommendedLabelId = default(System.Guid?), bool? enabled = default(bool?), bool? custom = default(bool?), IList<InformationProtectionKeyword> keywords = default(IList<InformationProtectionKeyword>))
        {
            DisplayName = displayName;
            Description = description;
            Order = order;
            RecommendedLabelId = recommendedLabelId;
            Enabled = enabled;
            Custom = custom;
            Keywords = keywords;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the information type.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description of the information type.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the order of the information type.
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or sets the recommended label id to be associated with this
        /// information type.
        /// </summary>
        [JsonProperty(PropertyName = "recommendedLabelId")]
        public System.Guid? RecommendedLabelId { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the information type is enabled or
        /// not.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the information type is custom or
        /// not.
        /// </summary>
        [JsonProperty(PropertyName = "custom")]
        public bool? Custom { get; set; }

        /// <summary>
        /// Gets or sets the information type keywords.
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public IList<InformationProtectionKeyword> Keywords { get; set; }

    }
}
