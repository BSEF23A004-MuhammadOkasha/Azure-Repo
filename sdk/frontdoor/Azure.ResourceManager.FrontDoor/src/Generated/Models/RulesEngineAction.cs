// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> One or more actions that will execute, modifying the request and/or response. </summary>
    public partial class RulesEngineAction
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RulesEngineAction"/>. </summary>
        public RulesEngineAction()
        {
            RequestHeaderActions = new ChangeTrackingList<RulesEngineHeaderAction>();
            ResponseHeaderActions = new ChangeTrackingList<RulesEngineHeaderAction>();
        }

        /// <summary> Initializes a new instance of <see cref="RulesEngineAction"/>. </summary>
        /// <param name="requestHeaderActions"> A list of header actions to apply from the request from AFD to the origin. </param>
        /// <param name="responseHeaderActions"> A list of header actions to apply from the response from AFD to the client. </param>
        /// <param name="routeConfigurationOverride">
        /// Override the route configuration.
        /// Please note <see cref="RouteConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ForwardingConfiguration"/> and <see cref="RedirectConfiguration"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RulesEngineAction(IList<RulesEngineHeaderAction> requestHeaderActions, IList<RulesEngineHeaderAction> responseHeaderActions, RouteConfiguration routeConfigurationOverride, Dictionary<string, BinaryData> rawData)
        {
            RequestHeaderActions = requestHeaderActions;
            ResponseHeaderActions = responseHeaderActions;
            RouteConfigurationOverride = routeConfigurationOverride;
            _rawData = rawData;
        }

        /// <summary> A list of header actions to apply from the request from AFD to the origin. </summary>
        public IList<RulesEngineHeaderAction> RequestHeaderActions { get; }
        /// <summary> A list of header actions to apply from the response from AFD to the client. </summary>
        public IList<RulesEngineHeaderAction> ResponseHeaderActions { get; }
        /// <summary>
        /// Override the route configuration.
        /// Please note <see cref="RouteConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ForwardingConfiguration"/> and <see cref="RedirectConfiguration"/>.
        /// </summary>
        public RouteConfiguration RouteConfigurationOverride { get; set; }
    }
}
