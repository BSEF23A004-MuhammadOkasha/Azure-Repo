// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> Detailed runtime information of the rollout. </summary>
    public partial class RolloutOperationInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RolloutOperationInfo"/>. </summary>
        internal RolloutOperationInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RolloutOperationInfo"/>. </summary>
        /// <param name="retryAttempt"> The ordinal count of the number of retry attempts on a rollout. 0 if no retries of the rollout have been performed. If the rollout is updated with a PUT, this count is reset to 0. </param>
        /// <param name="skipSucceededOnRetry"> True, if all steps that succeeded on the previous run/attempt were chosen to be skipped in this retry attempt. False, otherwise. </param>
        /// <param name="startOn"> The start time of the rollout in UTC. </param>
        /// <param name="endOn"> The start time of the rollout in UTC. This property will not be set if the rollout has not completed yet. </param>
        /// <param name="error"> The detailed error information for any failure. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RolloutOperationInfo(int? retryAttempt, bool? skipSucceededOnRetry, DateTimeOffset? startOn, DateTimeOffset? endOn, ResponseError error, Dictionary<string, BinaryData> rawData)
        {
            RetryAttempt = retryAttempt;
            SkipSucceededOnRetry = skipSucceededOnRetry;
            StartOn = startOn;
            EndOn = endOn;
            Error = error;
            _rawData = rawData;
        }

        /// <summary> The ordinal count of the number of retry attempts on a rollout. 0 if no retries of the rollout have been performed. If the rollout is updated with a PUT, this count is reset to 0. </summary>
        public int? RetryAttempt { get; }
        /// <summary> True, if all steps that succeeded on the previous run/attempt were chosen to be skipped in this retry attempt. False, otherwise. </summary>
        public bool? SkipSucceededOnRetry { get; }
        /// <summary> The start time of the rollout in UTC. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The start time of the rollout in UTC. This property will not be set if the rollout has not completed yet. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The detailed error information for any failure. </summary>
        public ResponseError Error { get; }
    }
}
