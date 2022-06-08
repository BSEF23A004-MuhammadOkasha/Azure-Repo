// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Diagnostic parameters of diagnostic operations. </summary>
    public partial class DiagnosticContent
    {
        /// <summary> Initializes a new instance of <see cref="DiagnosticContent"/>. </summary>
        public DiagnosticContent()
        {
        }

        /// <summary> App instance name. </summary>
        public string AppInstance { get; set; }
        /// <summary> Your target file path in your own BYOS. </summary>
        public string FilePath { get; set; }
        /// <summary> Duration of your JFR. 1 min can be represented by 1m or 60s. </summary>
        public string DurationValue { get; set; }
    }
}
