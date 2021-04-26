// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AgFoodPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// FarmBeats update request.
    /// </summary>
    public partial class FarmBeatsUpdateRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the FarmBeatsUpdateRequestModel
        /// class.
        /// </summary>
        public FarmBeatsUpdateRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FarmBeatsUpdateRequestModel
        /// class.
        /// </summary>
        /// <param name="tags">Resource tags.</param>
        public FarmBeatsUpdateRequestModel(IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
