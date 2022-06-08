// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> The state of a private link service connection. </summary>
    public partial class AppConfigurationPrivateLinkServiceConnectionState
    {
        /// <summary> Initializes a new instance of <see cref="AppConfigurationPrivateLinkServiceConnectionState"/>. </summary>
        public AppConfigurationPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> Any action that is required beyond basic workflow (approve/ reject/ disconnect). </param>
        internal AppConfigurationPrivateLinkServiceConnectionState(ConnectionStatus? status, string description, ActionsRequired? actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> The private link service connection status. </summary>
        public ConnectionStatus? Status { get; set; }
        /// <summary> The private link service connection description. </summary>
        public string Description { get; set; }
        /// <summary> Any action that is required beyond basic workflow (approve/ reject/ disconnect). </summary>
        public ActionsRequired? ActionsRequired { get; }
    }
}
