// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for ReplaceContent operation.
    /// </summary>
    public partial class RunbookDraftReplaceContentHeaders
    {
        /// <summary>
        /// Initializes a new instance of the RunbookDraftReplaceContentHeaders
        /// class.
        /// </summary>
        public RunbookDraftReplaceContentHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunbookDraftReplaceContentHeaders
        /// class.
        /// </summary>
        /// <param name="location">URL to query for status of the
        /// operation.</param>
        public RunbookDraftReplaceContentHeaders(string location = default(string))
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URL to query for status of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

    }
}
