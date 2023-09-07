// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The estimated price info for using a VM. </summary>
    public partial class MachineLearningEstimatedVmPrices
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningEstimatedVmPrices"/>. </summary>
        /// <param name="billingCurrency"> Three lettered code specifying the currency of the VM price. Example: USD. </param>
        /// <param name="unitOfMeasure"> The unit of time measurement for the specified VM price. Example: OneHour. </param>
        /// <param name="values"> The list of estimated prices for using a VM of a particular OS type, tier, etc. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="values"/> is null. </exception>
        internal MachineLearningEstimatedVmPrices(MachineLearningBillingCurrency billingCurrency, MachineLearningUnitOfMeasure unitOfMeasure, IEnumerable<MachineLearningEstimatedVmPrice> values)
        {
            Argument.AssertNotNull(values, nameof(values));

            BillingCurrency = billingCurrency;
            UnitOfMeasure = unitOfMeasure;
            Values = values.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEstimatedVmPrices"/>. </summary>
        /// <param name="billingCurrency"> Three lettered code specifying the currency of the VM price. Example: USD. </param>
        /// <param name="unitOfMeasure"> The unit of time measurement for the specified VM price. Example: OneHour. </param>
        /// <param name="values"> The list of estimated prices for using a VM of a particular OS type, tier, etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningEstimatedVmPrices(MachineLearningBillingCurrency billingCurrency, MachineLearningUnitOfMeasure unitOfMeasure, IReadOnlyList<MachineLearningEstimatedVmPrice> values, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BillingCurrency = billingCurrency;
            UnitOfMeasure = unitOfMeasure;
            Values = values;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEstimatedVmPrices"/> for deserialization. </summary>
        internal MachineLearningEstimatedVmPrices()
        {
        }

        /// <summary> Three lettered code specifying the currency of the VM price. Example: USD. </summary>
        public MachineLearningBillingCurrency BillingCurrency { get; }
        /// <summary> The unit of time measurement for the specified VM price. Example: OneHour. </summary>
        public MachineLearningUnitOfMeasure UnitOfMeasure { get; }
        /// <summary> The list of estimated prices for using a VM of a particular OS type, tier, etc. </summary>
        public IReadOnlyList<MachineLearningEstimatedVmPrice> Values { get; }
    }
}
