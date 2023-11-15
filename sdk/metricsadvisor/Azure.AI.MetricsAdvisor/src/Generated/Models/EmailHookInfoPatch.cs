// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The EmailHookInfoPatch. </summary>
    internal partial class EmailHookInfoPatch : HookInfoPatch
    {
        /// <summary> Initializes a new instance of <see cref="EmailHookInfoPatch"/>. </summary>
        public EmailHookInfoPatch()
        {
            HookType = NotificationHookKind.Email;
        }

        /// <summary> Initializes a new instance of <see cref="EmailHookInfoPatch"/>. </summary>
        /// <param name="hookType"> hook type. </param>
        /// <param name="hookName"> hook unique name. </param>
        /// <param name="description"> hook description. </param>
        /// <param name="externalLink"> hook external link. </param>
        /// <param name="admins"> hook administrators. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="hookParameter"></param>
        internal EmailHookInfoPatch(NotificationHookKind hookType, string hookName, string description, string externalLink, IList<string> admins, IDictionary<string, BinaryData> serializedAdditionalRawData, EmailHookParameterPatch hookParameter) : base(hookType, hookName, description, externalLink, admins, serializedAdditionalRawData)
        {
            HookParameter = hookParameter;
            HookType = hookType;
        }

        /// <summary> Gets or sets the hook parameter. </summary>
        public EmailHookParameterPatch HookParameter { get; set; }
    }
}
