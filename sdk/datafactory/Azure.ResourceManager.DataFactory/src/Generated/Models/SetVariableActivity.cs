// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Set value for a Variable. </summary>
    public partial class SetVariableActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of SetVariableActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public SetVariableActivity(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            ActivityType = "SetVariable";
        }

        /// <summary> Initializes a new instance of SetVariableActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="variableName"> Name of the variable whose value needs to be set. </param>
        /// <param name="value"> Value to be set. Could be a static value or Expression. </param>
        internal SetVariableActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, string variableName, BinaryData value) : base(name, activityType, description, dependsOn, userProperties, additionalProperties)
        {
            VariableName = variableName;
            Value = value;
            ActivityType = activityType ?? "SetVariable";
        }

        /// <summary> Name of the variable whose value needs to be set. </summary>
        public string VariableName { get; set; }
        /// <summary> Value to be set. Could be a static value or Expression. </summary>
        public BinaryData Value { get; set; }
    }
}
