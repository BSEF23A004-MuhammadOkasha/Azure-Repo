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
    /// A list of REST API operations supported by an Azure Resource Provider.
    /// It contains an URL link to get the next set of results.
    /// </summary>
    public partial class OperationListResult
    {
        /// <summary>
        /// Initializes a new instance of the OperationListResult class.
        /// </summary>
        public OperationListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationListResult class.
        /// </summary>
        /// <param name="value">List of operations supported by the resource
        /// provider</param>
        /// <param name="nextLink">URL to get the next set of operation list
        /// results (if there are any).</param>
        public OperationListResult(IList<Operation> value = default(IList<Operation>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of operations supported by the resource provider
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Operation> Value { get; private set; }

        /// <summary>
        /// Gets URL to get the next set of operation list results (if there
        /// are any).
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
