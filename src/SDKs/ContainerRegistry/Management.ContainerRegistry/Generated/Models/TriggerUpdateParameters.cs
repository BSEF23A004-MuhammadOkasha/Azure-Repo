// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties for updating triggers.
    /// </summary>
    public partial class TriggerUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the TriggerUpdateParameters class.
        /// </summary>
        public TriggerUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TriggerUpdateParameters class.
        /// </summary>
        /// <param name="schedulerTriggers">The collection of scheduler
        /// triggers.</param>
        /// <param name="sourceTriggers">The collection of triggers based on
        /// source code repository.</param>
        /// <param name="baseImageTrigger">The trigger based on base image
        /// dependencies.</param>
        public TriggerUpdateParameters(IList<SchedulerTrigger> schedulerTriggers = default(IList<SchedulerTrigger>), IList<SourceTriggerUpdateParameters> sourceTriggers = default(IList<SourceTriggerUpdateParameters>), BaseImageTriggerUpdateParameters baseImageTrigger = default(BaseImageTriggerUpdateParameters))
        {
            SchedulerTriggers = schedulerTriggers;
            SourceTriggers = sourceTriggers;
            BaseImageTrigger = baseImageTrigger;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the collection of scheduler triggers.
        /// </summary>
        [JsonProperty(PropertyName = "schedulerTriggers")]
        public IList<SchedulerTrigger> SchedulerTriggers { get; set; }

        /// <summary>
        /// Gets or sets the collection of triggers based on source code
        /// repository.
        /// </summary>
        [JsonProperty(PropertyName = "sourceTriggers")]
        public IList<SourceTriggerUpdateParameters> SourceTriggers { get; set; }

        /// <summary>
        /// Gets or sets the trigger based on base image dependencies.
        /// </summary>
        [JsonProperty(PropertyName = "baseImageTrigger")]
        public BaseImageTriggerUpdateParameters BaseImageTrigger { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SchedulerTriggers != null)
            {
                foreach (var element in SchedulerTriggers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (SourceTriggers != null)
            {
                foreach (var element1 in SourceTriggers)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (BaseImageTrigger != null)
            {
                BaseImageTrigger.Validate();
            }
        }
    }
}
