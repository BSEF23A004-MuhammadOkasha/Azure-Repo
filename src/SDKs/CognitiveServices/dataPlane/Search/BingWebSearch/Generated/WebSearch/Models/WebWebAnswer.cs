// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.WebSearch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a list of relevant webpage links.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Web/WebAnswer")]
    public partial class WebWebAnswer : SearchResultsAnswer
    {
        /// <summary>
        /// Initializes a new instance of the WebWebAnswer class.
        /// </summary>
        public WebWebAnswer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebWebAnswer class.
        /// </summary>
        /// <param name="value">A list of webpages that are relevant to the
        /// query.</param>
        /// <param name="id">A String identifier.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="totalEstimatedMatches">The estimated number of
        /// webpages that are relevant to the query. Use this number along with
        /// the count and offset query parameters to page the results.</param>
        /// <param name="someResultsRemoved">A Boolean value that indicates
        /// whether the response excluded some results from the answer. If Bing
        /// excluded some results, the value is true.</param>
        public WebWebAnswer(IList<WebPage> value, string id = default(string), string webSearchUrl = default(string), IList<Query> followUpQueries = default(IList<Query>), QueryContext queryContext = default(QueryContext), long? totalEstimatedMatches = default(long?), bool? isFamilyFriendly = default(bool?), bool? someResultsRemoved = default(bool?))
            : base(id, webSearchUrl, followUpQueries, queryContext, totalEstimatedMatches, isFamilyFriendly)
        {
            Value = value;
            SomeResultsRemoved = someResultsRemoved;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of webpages that are relevant to the query.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<WebPage> Value { get; set; }

        /// <summary>
        /// Gets a Boolean value that indicates whether the response excluded
        /// some results from the answer. If Bing excluded some results, the
        /// value is true.
        /// </summary>
        [JsonProperty(PropertyName = "someResultsRemoved")]
        public bool? SomeResultsRemoved { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
