// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> Part of MultiTenantDiagnosticSettings. Specifies the settings for a particular log. </summary>
    public partial class LogSettings
    {
        /// <summary> Initializes a new instance of LogSettings. </summary>
        /// <param name="enabled"> a value indicating whether this log is enabled. </param>
        public LogSettings(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of LogSettings. </summary>
        /// <param name="category"> Name of a Diagnostic Log category for a resource type this setting is applied to. To obtain the list of Diagnostic Log categories for a resource, first perform a GET diagnostic settings operation. </param>
        /// <param name="enabled"> a value indicating whether this log is enabled. </param>
        /// <param name="retentionPolicy"> the retention policy for this log. </param>
        internal LogSettings(string category, bool enabled, RetentionPolicy retentionPolicy)
        {
            Category = category;
            Enabled = enabled;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary> Name of a Diagnostic Log category for a resource type this setting is applied to. To obtain the list of Diagnostic Log categories for a resource, first perform a GET diagnostic settings operation. </summary>
        public string Category { get; set; }
        /// <summary> a value indicating whether this log is enabled. </summary>
        public bool Enabled { get; set; }
        /// <summary> the retention policy for this log. </summary>
        public RetentionPolicy RetentionPolicy { get; set; }
    }
}
