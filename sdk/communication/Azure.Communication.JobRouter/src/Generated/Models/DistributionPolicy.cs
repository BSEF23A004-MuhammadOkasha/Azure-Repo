// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.JobRouter;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Policy governing how jobs are distributed to workers. </summary>
    public partial class DistributionPolicy
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DistributionPolicy"/>. </summary>
        /// <param name="id"> The unique identifier of the policy. </param>
        /// <param name="name"> The human readable name of the policy. </param>
        /// <param name="offerExpiresAfterSeconds"> The number of seconds after which any offers created under this policy will be expired. </param>
        /// <param name="mode">
        /// Abstract base class for defining a distribution mode
        /// Please note <see cref="DistributionMode"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BestWorkerMode"/>, <see cref="LongestIdleMode"/> and <see cref="RoundRobinMode"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DistributionPolicy(string id, string name, double? offerExpiresAfterSeconds, DistributionMode mode, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            _offerExpiresAfterSeconds = offerExpiresAfterSeconds;
            Mode = mode;
            _rawData = rawData;
        }

        /// <summary> The unique identifier of the policy. </summary>
        public string Id { get; }
    }
}
