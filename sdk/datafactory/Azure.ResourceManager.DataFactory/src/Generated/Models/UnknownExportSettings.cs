// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The UnknownExportSettings. </summary>
    internal partial class UnknownExportSettings : ExportSettings
    {
        /// <summary> Initializes a new instance of <see cref="UnknownExportSettings"/>. </summary>
        /// <param name="exportSettingsType"> The export setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownExportSettings(string exportSettingsType, IDictionary<string, BinaryData> additionalProperties) : base(exportSettingsType, additionalProperties)
        {
            ExportSettingsType = exportSettingsType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownExportSettings"/> for deserialization. </summary>
        internal UnknownExportSettings()
        {
        }
    }
}
