// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A list of Activity Log Alert rule actions. </summary>
    internal partial class ActionList
    {
        /// <summary> Initializes a new instance of ActionList. </summary>
        public ActionList()
        {
            ActionGroups = new ChangeTrackingList<ActionGroupProperties>();
        }

        /// <summary> Initializes a new instance of ActionList. </summary>
        /// <param name="actionGroups"> The list of the Action Groups. </param>
        internal ActionList(IList<ActionGroupProperties> actionGroups)
        {
            ActionGroups = actionGroups;
        }

        /// <summary> The list of the Action Groups. </summary>
        public IList<ActionGroupProperties> ActionGroups { get; }
    }
}
