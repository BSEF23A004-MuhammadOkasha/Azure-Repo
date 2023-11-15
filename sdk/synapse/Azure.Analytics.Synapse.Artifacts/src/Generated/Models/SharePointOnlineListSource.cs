// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity source for sharePoint online list source. </summary>
    public partial class SharePointOnlineListSource : CopySource
    {
        /// <summary> Initializes a new instance of <see cref="SharePointOnlineListSource"/>. </summary>
        public SharePointOnlineListSource()
        {
            Type = "SharePointOnlineListSource";
        }

        /// <summary> Initializes a new instance of <see cref="SharePointOnlineListSource"/>. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="query"> The OData query to filter the data in SharePoint Online list. For example, "$top=1". Type: string (or Expression with resultType string). </param>
        /// <param name="httpRequestTimeout"> The wait time to get a response from SharePoint Online. Default value is 5 minutes (00:05:00). Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        internal SharePointOnlineListSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object query, object httpRequestTimeout) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            Query = query;
            HttpRequestTimeout = httpRequestTimeout;
            Type = type ?? "SharePointOnlineListSource";
        }

        /// <summary> The OData query to filter the data in SharePoint Online list. For example, "$top=1". Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
        /// <summary> The wait time to get a response from SharePoint Online. Default value is 5 minutes (00:05:00). Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public object HttpRequestTimeout { get; set; }
    }
}
