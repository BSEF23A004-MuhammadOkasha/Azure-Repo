﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceTableStorageApplicationLogsConfig
    {
        /// <summary> Uri of the resource. </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("This property has been replaced by ResourceUriString", false)]
        public System.Uri Sas1Uri { get; set; }
    }
}
