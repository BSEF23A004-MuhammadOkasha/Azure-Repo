// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Will describe the query to run against the IDPS signatures DB
    /// </summary>
    public partial class IDPSQueryObject
    {
        /// <summary>
        /// Initializes a new instance of the IDPSQueryObject class.
        /// </summary>
        public IDPSQueryObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IDPSQueryObject class.
        /// </summary>
        /// <param name="filters">Contain all filters names and values</param>
        /// <param name="search">Search term in all columns</param>
        /// <param name="orderBy">Column to sort response by</param>
        /// <param name="resultsPerPage">The number of the results to return in
        /// each page</param>
        /// <param name="skip">The number of records matching the filter to
        /// skip</param>
        public IDPSQueryObject(IList<FilterItems> filters = default(IList<FilterItems>), string search = default(string), OrderBy orderBy = default(OrderBy), int? resultsPerPage = default(int?), int? skip = default(int?))
        {
            Filters = filters;
            Search = search;
            OrderBy = orderBy;
            ResultsPerPage = resultsPerPage;
            Skip = skip;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets contain all filters names and values
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<FilterItems> Filters { get; set; }

        /// <summary>
        /// Gets or sets search term in all columns
        /// </summary>
        [JsonProperty(PropertyName = "search")]
        public string Search { get; set; }

        /// <summary>
        /// Gets or sets column to sort response by
        /// </summary>
        [JsonProperty(PropertyName = "orderBy")]
        public OrderBy OrderBy { get; set; }

        /// <summary>
        /// Gets or sets the number of the results to return in each page
        /// </summary>
        [JsonProperty(PropertyName = "resultsPerPage")]
        public int? ResultsPerPage { get; set; }

        /// <summary>
        /// Gets or sets the number of records matching the filter to skip
        /// </summary>
        [JsonProperty(PropertyName = "skip")]
        public int? Skip { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResultsPerPage != null)
            {
                if (ResultsPerPage > 1000)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "ResultsPerPage", 1000);
                }
                if (ResultsPerPage < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "ResultsPerPage", 1);
                }
            }
        }
    }
}
