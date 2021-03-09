// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The EmailHookInfoPatch. </summary>
    public partial class EmailHookInfoPatch : HookInfoPatch
    {
        /// <summary> Initializes a new instance of EmailHookInfoPatch. </summary>
        public EmailHookInfoPatch()
        {
            HookType = HookType.Email;
        }

        public EmailHookParameter HookParameter { get; set; }
    }
}
