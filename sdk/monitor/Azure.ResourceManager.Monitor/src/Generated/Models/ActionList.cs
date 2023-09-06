// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A list of Activity Log Alert rule actions. </summary>
    internal partial class ActionList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ActionList"/>. </summary>
        public ActionList()
        {
            ActionGroups = new ChangeTrackingList<ActivityLogAlertActionGroup>();
        }

        /// <summary> Initializes a new instance of <see cref="ActionList"/>. </summary>
        /// <param name="actionGroups"> The list of the Action Groups. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ActionList(IList<ActivityLogAlertActionGroup> actionGroups, Dictionary<string, BinaryData> rawData)
        {
            ActionGroups = actionGroups;
            _rawData = rawData;
        }

        /// <summary> The list of the Action Groups. </summary>
        public IList<ActivityLogAlertActionGroup> ActionGroups { get; }
    }
}
