// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The content of the event request message. </summary>
    public partial class ContainerRegistryEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEventData"/>. </summary>
        internal ContainerRegistryEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEventData"/>. </summary>
        /// <param name="id"> The event ID. </param>
        /// <param name="timestamp"> The time at which the event occurred. </param>
        /// <param name="action"> The action that encompasses the provided event. </param>
        /// <param name="location"> The location of the event. </param>
        /// <param name="target"> The target of the event. </param>
        /// <param name="request"> The request that generated the event. </param>
        /// <param name="actor"> The agent that initiated the event. For most situations, this could be from the authorization context of the request. </param>
        /// <param name="source"> The registry node that generated the event. Put differently, while the actor initiates the event, the source generates it. </param>
        /// <param name="connectedRegistry"> The connected registry information if the event is generated by a connected registry. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryEventData(string id, DateTimeOffset? timestamp, string action, string location, ContainerRegistryEventTarget target, ContainerRegistryEventRequest request, ContainerRegistryEventActor actor, ContainerRegistryEventSource source, ContainerRegistryEventConnectedRegistry connectedRegistry, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Timestamp = timestamp;
            Action = action;
            Location = location;
            Target = target;
            Request = request;
            Actor = actor;
            Source = source;
            ConnectedRegistry = connectedRegistry;
            _rawData = rawData;
        }

        /// <summary> The event ID. </summary>
        public string Id { get; }
        /// <summary> The time at which the event occurred. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The action that encompasses the provided event. </summary>
        public string Action { get; }
        /// <summary> The location of the event. </summary>
        public string Location { get; }
        /// <summary> The target of the event. </summary>
        public ContainerRegistryEventTarget Target { get; }
        /// <summary> The request that generated the event. </summary>
        public ContainerRegistryEventRequest Request { get; }
        /// <summary> The agent that initiated the event. For most situations, this could be from the authorization context of the request. </summary>
        public ContainerRegistryEventActor Actor { get; }
        /// <summary> The registry node that generated the event. Put differently, while the actor initiates the event, the source generates it. </summary>
        public ContainerRegistryEventSource Source { get; }
        /// <summary> The connected registry information if the event is generated by a connected registry. </summary>
        public ContainerRegistryEventConnectedRegistry ConnectedRegistry { get; }
    }
}
