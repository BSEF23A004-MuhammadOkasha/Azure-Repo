// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The InfluxDBDataFeedPatch. </summary>
    internal partial class InfluxDBDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of <see cref="InfluxDBDataFeedPatch"/>. </summary>
        public InfluxDBDataFeedPatch()
        {
            DataSourceType = DataFeedSourceKind.InfluxDb;
        }

        /// <summary> Initializes a new instance of <see cref="InfluxDBDataFeedPatch"/>. </summary>
        /// <param name="dataSourceType"> data source type. </param>
        /// <param name="dataFeedName"> data feed name. </param>
        /// <param name="dataFeedDescription"> data feed description. </param>
        /// <param name="timestampColumn"> user-defined timestamp column. if timestampColumn is null, start time of every time slice will be used as default value. </param>
        /// <param name="dataStartFrom"> ingestion start time. </param>
        /// <param name="startOffsetInSeconds"> the time that the beginning of data ingestion task will delay for every data slice according to this offset. </param>
        /// <param name="maxConcurrency"> the max concurrency of data ingestion queries against user data source. 0 means no limitation. </param>
        /// <param name="minRetryIntervalInSeconds"> the min retry interval for failed data ingestion tasks. </param>
        /// <param name="stopRetryAfterInSeconds"> stop retry data ingestion after the data slice first schedule time in seconds. </param>
        /// <param name="needRollup"> mark if the data feed need rollup. </param>
        /// <param name="rollUpMethod"> roll up method. </param>
        /// <param name="rollUpColumns"> roll up columns. </param>
        /// <param name="allUpIdentification"> the identification value for the row of calculated all-up value. </param>
        /// <param name="fillMissingPointType"> the type of fill missing point for anomaly detection. </param>
        /// <param name="fillMissingPointValue"> the value of fill missing point for anomaly detection. </param>
        /// <param name="viewMode"> data feed access mode, default is Private. </param>
        /// <param name="admins"> data feed administrator. </param>
        /// <param name="viewers"> data feed viewer. </param>
        /// <param name="status"> data feed status. </param>
        /// <param name="actionLinkTemplate"> action link for alert. </param>
        /// <param name="authenticationType"> authentication type for corresponding data source. </param>
        /// <param name="credentialId"> The credential entity id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="dataSourceParameter"></param>
        internal InfluxDBDataFeedPatch(DataFeedSourceKind dataSourceType, string dataFeedName, string dataFeedDescription, string timestampColumn, DateTimeOffset? dataStartFrom, long? startOffsetInSeconds, int? maxConcurrency, long? minRetryIntervalInSeconds, long? stopRetryAfterInSeconds, DataFeedRollupType? needRollup, DataFeedAutoRollupMethod? rollUpMethod, IList<string> rollUpColumns, string allUpIdentification, DataFeedMissingDataPointFillType? fillMissingPointType, double? fillMissingPointValue, DataFeedAccessMode? viewMode, IList<string> admins, IList<string> viewers, DataFeedStatus? status, string actionLinkTemplate, AuthenticationTypeEnum? authenticationType, string credentialId, IDictionary<string, BinaryData> serializedAdditionalRawData, InfluxDBParameterPatch dataSourceParameter) : base(dataSourceType, dataFeedName, dataFeedDescription, timestampColumn, dataStartFrom, startOffsetInSeconds, maxConcurrency, minRetryIntervalInSeconds, stopRetryAfterInSeconds, needRollup, rollUpMethod, rollUpColumns, allUpIdentification, fillMissingPointType, fillMissingPointValue, viewMode, admins, viewers, status, actionLinkTemplate, authenticationType, credentialId, serializedAdditionalRawData)
        {
            DataSourceParameter = dataSourceParameter;
            DataSourceType = dataSourceType;
        }

        /// <summary> Gets or sets the data source parameter. </summary>
        public InfluxDBParameterPatch DataSourceParameter { get; set; }
    }
}
