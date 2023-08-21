// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the update automation account operation. </summary>
    public partial class AutomationAccountPatch
    {
        /// <summary> Initializes a new instance of AutomationAccountPatch. </summary>
        public AutomationAccountPatch()
        {
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets the name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the location of the resource. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Sets the identity property for automation account. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Gets or sets the tags attached to the resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets account SKU. </summary>
        public AutomationSku Sku { get; set; }
        /// <summary> Set the encryption properties for the automation account. </summary>
        public AutomationEncryptionProperties Encryption { get; set; }
        /// <summary> Indicates whether traffic on the non-ARM endpoint (Webhook/Agent) is allowed from the public internet. </summary>
        public bool? IsPublicNetworkAccessAllowed { get; set; }
        /// <summary> Indicates whether requests using non-AAD authentication are blocked. </summary>
        public bool? IsLocalAuthDisabled { get; set; }
    }
}
