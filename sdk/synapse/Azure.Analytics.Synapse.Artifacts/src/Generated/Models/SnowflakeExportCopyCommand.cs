// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Snowflake export command settings. </summary>
    public partial class SnowflakeExportCopyCommand : ExportSettings
    {
        /// <summary> Initializes a new instance of SnowflakeExportCopyCommand. </summary>
        public SnowflakeExportCopyCommand()
        {
            AdditionalCopyOptions = new ChangeTrackingDictionary<string, object>();
            AdditionalFormatOptions = new ChangeTrackingDictionary<string, object>();
            Type = "SnowflakeExportCopyCommand";
        }

        /// <summary> Initializes a new instance of SnowflakeExportCopyCommand. </summary>
        /// <param name="type"> The export setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="additionalCopyOptions"> Additional copy options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalCopyOptions": { "DATE_FORMAT": "MM/DD/YYYY", "TIME_FORMAT": "'HH24:MI:SS.FF'" }. </param>
        /// <param name="additionalFormatOptions"> Additional format options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalFormatOptions": { "OVERWRITE": "TRUE", "MAX_FILE_SIZE": "'FALSE'" }. </param>
        internal SnowflakeExportCopyCommand(string type, IDictionary<string, object> additionalProperties, IDictionary<string, object> additionalCopyOptions, IDictionary<string, object> additionalFormatOptions) : base(type, additionalProperties)
        {
            AdditionalCopyOptions = additionalCopyOptions;
            AdditionalFormatOptions = additionalFormatOptions;
            Type = type ?? "SnowflakeExportCopyCommand";
        }

        /// <summary> Additional copy options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalCopyOptions": { "DATE_FORMAT": "MM/DD/YYYY", "TIME_FORMAT": "'HH24:MI:SS.FF'" }. </summary>
        public IDictionary<string, object> AdditionalCopyOptions { get; }
        /// <summary> Additional format options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalFormatOptions": { "OVERWRITE": "TRUE", "MAX_FILE_SIZE": "'FALSE'" }. </summary>
        public IDictionary<string, object> AdditionalFormatOptions { get; }
    }
}
