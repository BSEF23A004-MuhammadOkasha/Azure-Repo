// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> Pass fail criteria for a test. </summary>
    public partial class PassFailCriteria
    {
        /// <summary> Initializes a new instance of PassFailCriteria. </summary>
        public PassFailCriteria()
        {
            PassFailMetrics = new ChangeTrackingDictionary<string, PassFailMetric>();
        }

        /// <summary> Initializes a new instance of PassFailCriteria. </summary>
        /// <param name="passFailMetrics"> Map of id and pass fail metrics { id  : pass fail metrics }. </param>
        internal PassFailCriteria(IDictionary<string, PassFailMetric> passFailMetrics)
        {
            PassFailMetrics = passFailMetrics;
        }

        /// <summary> Map of id and pass fail metrics { id  : pass fail metrics }. </summary>
        public IDictionary<string, PassFailMetric> PassFailMetrics { get; }
    }
}
