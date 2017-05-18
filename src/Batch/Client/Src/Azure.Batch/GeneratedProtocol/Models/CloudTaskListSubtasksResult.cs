// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// The result of listing the subtasks of a task.
    /// </summary>
    public partial class CloudTaskListSubtasksResult
    {
        /// <summary>
        /// Initializes a new instance of the CloudTaskListSubtasksResult
        /// class.
        /// </summary>
        public CloudTaskListSubtasksResult() { }

        /// <summary>
        /// Initializes a new instance of the CloudTaskListSubtasksResult
        /// class.
        /// </summary>
        /// <param name="value">The list of subtasks.</param>
        public CloudTaskListSubtasksResult(System.Collections.Generic.IList<SubtaskInformation> value = default(System.Collections.Generic.IList<SubtaskInformation>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the list of subtasks.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<SubtaskInformation> Value { get; set; }

    }
}
