// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Defines a Sampling Algorithm that generates values randomly. </summary>
    public partial class RandomSamplingAlgorithm : SamplingAlgorithm
    {
        /// <summary> Initializes a new instance of <see cref="RandomSamplingAlgorithm"/>. </summary>
        public RandomSamplingAlgorithm()
        {
            SamplingAlgorithmType = SamplingAlgorithmType.Random;
        }

        /// <summary> Initializes a new instance of <see cref="RandomSamplingAlgorithm"/>. </summary>
        /// <param name="samplingAlgorithmType"> [Required] The algorithm used for generating hyperparameter values, along with configuration properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="seed"> An optional integer to use as the seed for random number generation. </param>
        /// <param name="rule"> The specific type of random algorithm. </param>
        internal RandomSamplingAlgorithm(SamplingAlgorithmType samplingAlgorithmType, IDictionary<string, BinaryData> serializedAdditionalRawData, int? seed, RandomSamplingAlgorithmRule? rule) : base(samplingAlgorithmType, serializedAdditionalRawData)
        {
            Seed = seed;
            Rule = rule;
            SamplingAlgorithmType = samplingAlgorithmType;
        }

        /// <summary> An optional integer to use as the seed for random number generation. </summary>
        [WirePath("seed")]
        public int? Seed { get; set; }
        /// <summary> The specific type of random algorithm. </summary>
        [WirePath("rule")]
        public RandomSamplingAlgorithmRule? Rule { get; set; }
    }
}
