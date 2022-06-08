// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> The ModelState. </summary>
    public partial class ModelState
    {
        /// <summary> Initializes a new instance of <see cref="ModelState"/>. </summary>
        internal ModelState()
        {
            EpochIds = new ChangeTrackingList<int>();
            TrainLosses = new ChangeTrackingList<float>();
            ValidationLosses = new ChangeTrackingList<float>();
            LatenciesInSeconds = new ChangeTrackingList<float>();
        }

        /// <summary> Initializes a new instance of <see cref="ModelState"/>. </summary>
        /// <param name="epochIds"> Epoch id. </param>
        /// <param name="trainLosses"></param>
        /// <param name="validationLosses"></param>
        /// <param name="latenciesInSeconds"></param>
        internal ModelState(IReadOnlyList<int> epochIds, IReadOnlyList<float> trainLosses, IReadOnlyList<float> validationLosses, IReadOnlyList<float> latenciesInSeconds)
        {
            EpochIds = epochIds;
            TrainLosses = trainLosses;
            ValidationLosses = validationLosses;
            LatenciesInSeconds = latenciesInSeconds;
        }

        /// <summary> Epoch id. </summary>
        public IReadOnlyList<int> EpochIds { get; }
        /// <summary> Gets the train losses. </summary>
        public IReadOnlyList<float> TrainLosses { get; }
        /// <summary> Gets the validation losses. </summary>
        public IReadOnlyList<float> ValidationLosses { get; }
        /// <summary> Gets the latencies in seconds. </summary>
        public IReadOnlyList<float> LatenciesInSeconds { get; }
    }
}
