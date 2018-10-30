// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Job finished event data
    /// </summary>
    public partial class MediaJobFinishedEventData : MediaJobStateChangeEventData
    {
        /// <summary>
        /// Initializes a new instance of the MediaJobFinishedEventData class.
        /// </summary>
        public MediaJobFinishedEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaJobFinishedEventData class.
        /// </summary>
        /// <param name="previousState">The previous state of the Job. Possible
        /// values include: 'Canceled', 'Canceling', 'Error', 'Finished',
        /// 'Processing', 'Queued', 'Scheduled'</param>
        /// <param name="state">The new state of the Job. Possible values
        /// include: 'Canceled', 'Canceling', 'Error', 'Finished',
        /// 'Processing', 'Queued', 'Scheduled'</param>
        /// <param name="correlationData">Gets the Job correlation
        /// data.</param>
        /// <param name="outputs">Gets the Job outputs.</param>
        public MediaJobFinishedEventData(MediaJobState previousState = default(MediaJobState), MediaJobState state = default(MediaJobState), IDictionary<string, string> correlationData = default(IDictionary<string, string>), IList<MediaJobOutput> outputs = default(IList<MediaJobOutput>))
            : base(previousState, state, correlationData)
        {
            Outputs = outputs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Job outputs.
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public IList<MediaJobOutput> Outputs { get; set; }

    }
}
