// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A2A container mapping input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class A2AContainerMappingInput : ReplicationProviderSpecificContainerMappingInput
    {
        /// <summary>
        /// Initializes a new instance of the A2AContainerMappingInput class.
        /// </summary>
        public A2AContainerMappingInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AContainerMappingInput class.
        /// </summary>
        /// <param name="agentAutoUpdateStatus">A value indicating whether the
        /// auto update is enabled. Possible values include: 'Disabled',
        /// 'Enabled'</param>
        /// <param name="automationAccountArmId">The automation account arm
        /// id.</param>
        /// <param name="automationAccountAuthenticationType">A value
        /// indicating the type authentication to use for automation Account.
        /// Possible values include: 'RunAsAccount',
        /// 'SystemAssignedIdentity'</param>
        public A2AContainerMappingInput(string agentAutoUpdateStatus = default(string), string automationAccountArmId = default(string), string automationAccountAuthenticationType = default(string))
        {
            AgentAutoUpdateStatus = agentAutoUpdateStatus;
            AutomationAccountArmId = automationAccountArmId;
            AutomationAccountAuthenticationType = automationAccountAuthenticationType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating whether the auto update is enabled.
        /// Possible values include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "agentAutoUpdateStatus")]
        public string AgentAutoUpdateStatus { get; set; }

        /// <summary>
        /// Gets or sets the automation account arm id.
        /// </summary>
        [JsonProperty(PropertyName = "automationAccountArmId")]
        public string AutomationAccountArmId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the type authentication to use for
        /// automation Account. Possible values include: 'RunAsAccount',
        /// 'SystemAssignedIdentity'
        /// </summary>
        [JsonProperty(PropertyName = "automationAccountAuthenticationType")]
        public string AutomationAccountAuthenticationType { get; set; }

    }
}
