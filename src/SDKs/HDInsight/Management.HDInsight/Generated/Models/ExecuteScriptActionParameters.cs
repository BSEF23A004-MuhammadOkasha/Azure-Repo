// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters for the script actions to execute on a running cluster.
    /// </summary>
    public partial class ExecuteScriptActionParameters
    {
        /// <summary>
        /// Initializes a new instance of the ExecuteScriptActionParameters
        /// class.
        /// </summary>
        public ExecuteScriptActionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecuteScriptActionParameters
        /// class.
        /// </summary>
        /// <param name="persistOnSuccess">Gets or sets if the scripts needs to
        /// be persisted.</param>
        /// <param name="scriptActions">The list of run time script
        /// actions.</param>
        public ExecuteScriptActionParameters(bool persistOnSuccess, IList<RuntimeScriptAction> scriptActions = default(IList<RuntimeScriptAction>))
        {
            ScriptActions = scriptActions;
            PersistOnSuccess = persistOnSuccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of run time script actions.
        /// </summary>
        [JsonProperty(PropertyName = "scriptActions")]
        public IList<RuntimeScriptAction> ScriptActions { get; set; }

        /// <summary>
        /// Gets or sets if the scripts needs to be persisted.
        /// </summary>
        [JsonProperty(PropertyName = "persistOnSuccess")]
        public bool PersistOnSuccess { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ScriptActions != null)
            {
                foreach (var element in ScriptActions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
