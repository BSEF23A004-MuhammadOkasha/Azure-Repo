// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The instance view of the container group. Only valid in response. </summary>
    public partial class ContainerGroupPropertiesInstanceView
    {
        /// <summary> Initializes a new instance of ContainerGroupPropertiesInstanceView. </summary>
        internal ContainerGroupPropertiesInstanceView()
        {
            Events = new ChangeTrackingList<ContainerEvent>();
        }

        /// <summary> Initializes a new instance of ContainerGroupPropertiesInstanceView. </summary>
        /// <param name="events"> The events of this container group. </param>
        /// <param name="state"> The state of the container group. Only valid in response. </param>
        internal ContainerGroupPropertiesInstanceView(IReadOnlyList<ContainerEvent> events, string state)
        {
            Events = events;
            State = state;
        }

        /// <summary> The events of this container group. </summary>
        public IReadOnlyList<ContainerEvent> Events { get; }
        /// <summary> The state of the container group. Only valid in response. </summary>
        public string State { get; }
    }
}
