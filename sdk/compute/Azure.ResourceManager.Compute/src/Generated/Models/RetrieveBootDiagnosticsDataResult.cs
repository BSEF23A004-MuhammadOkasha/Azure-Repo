// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The SAS URIs of the console screenshot and serial log blobs. </summary>
    public partial class RetrieveBootDiagnosticsDataResult
    {
        /// <summary> Initializes a new instance of <see cref="RetrieveBootDiagnosticsDataResult"/>. </summary>
        internal RetrieveBootDiagnosticsDataResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RetrieveBootDiagnosticsDataResult"/>. </summary>
        /// <param name="consoleScreenshotBlobUri"> The console screenshot blob URI. </param>
        /// <param name="serialConsoleLogBlobUri"> The serial console log blob URI. </param>
        internal RetrieveBootDiagnosticsDataResult(Uri consoleScreenshotBlobUri, Uri serialConsoleLogBlobUri)
        {
            ConsoleScreenshotBlobUri = consoleScreenshotBlobUri;
            SerialConsoleLogBlobUri = serialConsoleLogBlobUri;
        }

        /// <summary> The console screenshot blob URI. </summary>
        public Uri ConsoleScreenshotBlobUri { get; }
        /// <summary> The serial console log blob URI. </summary>
        public Uri SerialConsoleLogBlobUri { get; }
    }
}
