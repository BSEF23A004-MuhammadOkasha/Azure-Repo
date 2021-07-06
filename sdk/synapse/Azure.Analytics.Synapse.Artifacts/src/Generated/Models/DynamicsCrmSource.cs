// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Dynamics CRM source. </summary>
    public partial class DynamicsCrmSource : CopySource
    {
        /// <summary> Initializes a new instance of DynamicsCrmSource. </summary>
        public DynamicsCrmSource()
        {
            AdditionalColumns = new ChangeTrackingList<AdditionalColumns>();
            Type = "DynamicsCrmSource";
        }

        /// <summary> Initializes a new instance of DynamicsCrmSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="query"> FetchXML is a proprietary query language that is used in Microsoft Dynamics CRM (online &amp; on-premises). Type: string (or Expression with resultType string). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects (or Expression with resultType array of objects). </param>
        internal DynamicsCrmSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object query, IList<AdditionalColumns> additionalColumns) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            Query = query;
            AdditionalColumns = additionalColumns;
            Type = type ?? "DynamicsCrmSource";
        }

        /// <summary> FetchXML is a proprietary query language that is used in Microsoft Dynamics CRM (online &amp; on-premises). Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects (or Expression with resultType array of objects). </summary>
        public IList<AdditionalColumns> AdditionalColumns { get; }
    }
}
