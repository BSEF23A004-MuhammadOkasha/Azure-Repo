// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents recommended elastic pool metric.
    /// </summary>
    public partial class RecommendedElasticPoolMetric
    {
        /// <summary>
        /// Initializes a new instance of the RecommendedElasticPoolMetric
        /// class.
        /// </summary>
        public RecommendedElasticPoolMetric()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecommendedElasticPoolMetric
        /// class.
        /// </summary>
        /// <param name="dateTime">The time of metric (ISO8601 format).</param>
        /// <param name="dtu">Gets or sets the DTUs (Database Transaction
        /// Units). See
        /// https://azure.microsoft.com/documentation/articles/sql-database-what-is-a-dtu/</param>
        /// <param name="sizeGB">Gets or sets size in gigabytes.</param>
        public RecommendedElasticPoolMetric(System.DateTime? dateTime = default(System.DateTime?), double? dtu = default(double?), double? sizeGB = default(double?))
        {
            DateTime = dateTime;
            Dtu = dtu;
            SizeGB = sizeGB;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time of metric (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "dateTime")]
        public System.DateTime? DateTime { get; set; }

        /// <summary>
        /// Gets or sets the DTUs (Database Transaction Units). See
        /// https://azure.microsoft.com/documentation/articles/sql-database-what-is-a-dtu/
        /// </summary>
        [JsonProperty(PropertyName = "dtu")]
        public double? Dtu { get; set; }

        /// <summary>
        /// Gets or sets size in gigabytes.
        /// </summary>
        [JsonProperty(PropertyName = "sizeGB")]
        public double? SizeGB { get; set; }

    }
}
