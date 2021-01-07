// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Creates combinations of tokens as a single token. This token filter is
    /// implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/shingle/ShingleFilter.html">
    /// ShingleFilter (Lucene API)</see>.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.ShingleTokenFilter")]
    public partial class ShingleTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the ShingleTokenFilter class.
        /// </summary>
        public ShingleTokenFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ShingleTokenFilter class.
        /// </summary>
        /// <param name="name">The name of the token filter. It must only
        /// contain letters, digits, spaces, dashes or underscores, can only
        /// start and end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="maxShingleSize">The maximum shingle size. Default and
        /// minimum value is 2.</param>
        /// <param name="minShingleSize">The minimum shingle size. Default and
        /// minimum value is 2. Must be less than the value of
        /// maxShingleSize.</param>
        /// <param name="outputUnigrams">A value indicating whether the output
        /// stream will contain the input tokens (unigrams) as well as
        /// shingles. Default is true.</param>
        /// <param name="outputUnigramsIfNoShingles">A value indicating whether
        /// to output unigrams for those times when no shingles are available.
        /// This property takes precedence when outputUnigrams is set to false.
        /// Default is false.</param>
        /// <param name="tokenSeparator">The string to use when joining
        /// adjacent tokens to form a shingle. Default is a single space ("
        /// ").</param>
        /// <param name="filterToken">The string to insert for each position at
        /// which there is no token. Default is an underscore ("_").</param>
        public ShingleTokenFilter(string name, int? maxShingleSize = default(int?), int? minShingleSize = default(int?), bool? outputUnigrams = default(bool?), bool? outputUnigramsIfNoShingles = default(bool?), string tokenSeparator = default(string), string filterToken = default(string))
            : base(name)
        {
            MaxShingleSize = maxShingleSize;
            MinShingleSize = minShingleSize;
            OutputUnigrams = outputUnigrams;
            OutputUnigramsIfNoShingles = outputUnigramsIfNoShingles;
            TokenSeparator = tokenSeparator;
            FilterToken = filterToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the maximum shingle size. Default and minimum value is
        /// 2.
        /// </summary>
        [JsonProperty(PropertyName = "maxShingleSize")]
        public int? MaxShingleSize { get; set; }

        /// <summary>
        /// Gets or sets the minimum shingle size. Default and minimum value is
        /// 2. Must be less than the value of maxShingleSize.
        /// </summary>
        [JsonProperty(PropertyName = "minShingleSize")]
        public int? MinShingleSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the output stream will
        /// contain the input tokens (unigrams) as well as shingles. Default is
        /// true.
        /// </summary>
        [JsonProperty(PropertyName = "outputUnigrams")]
        public bool? OutputUnigrams { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to output unigrams for
        /// those times when no shingles are available. This property takes
        /// precedence when outputUnigrams is set to false. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "outputUnigramsIfNoShingles")]
        public bool? OutputUnigramsIfNoShingles { get; set; }

        /// <summary>
        /// Gets or sets the string to use when joining adjacent tokens to form
        /// a shingle. Default is a single space (" ").
        /// </summary>
        [JsonProperty(PropertyName = "tokenSeparator")]
        public string TokenSeparator { get; set; }

        /// <summary>
        /// Gets or sets the string to insert for each position at which there
        /// is no token. Default is an underscore ("_").
        /// </summary>
        [JsonProperty(PropertyName = "filterToken")]
        public string FilterToken { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (MaxShingleSize < 2)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxShingleSize", 2);
            }
            if (MinShingleSize < 2)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinShingleSize", 2);
            }
        }
    }
}
