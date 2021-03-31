// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Databricks Delta Lake export command settings. </summary>
    public partial class AzureDatabricksDeltaLakeExportCommand : ExportSettings
    {
        /// <summary> Initializes a new instance of AzureDatabricksDeltaLakeExportCommand. </summary>
        public AzureDatabricksDeltaLakeExportCommand()
        {
            Type = "AzureDatabricksDeltaLakeExportCommand";
        }

        /// <summary> Initializes a new instance of AzureDatabricksDeltaLakeExportCommand. </summary>
        /// <param name="type"> The export setting type. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="dateFormat"> Specify the date format for the csv in Azure Databricks Delta Lake Copy. Type: string (or Expression with resultType string). </param>
        /// <param name="timestampFormat"> Specify the timestamp format for the csv in Azure Databricks Delta Lake Copy. Type: string (or Expression with resultType string). </param>
        internal AzureDatabricksDeltaLakeExportCommand(string type, IDictionary<string, object> additionalProperties, object dateFormat, object timestampFormat) : base(type, additionalProperties)
        {
            DateFormat = dateFormat;
            TimestampFormat = timestampFormat;
            Type = type ?? "AzureDatabricksDeltaLakeExportCommand";
        }

        /// <summary> Specify the date format for the csv in Azure Databricks Delta Lake Copy. Type: string (or Expression with resultType string). </summary>
        public object DateFormat { get; set; }
        /// <summary> Specify the timestamp format for the csv in Azure Databricks Delta Lake Copy. Type: string (or Expression with resultType string). </summary>
        public object TimestampFormat { get; set; }
    }
}
