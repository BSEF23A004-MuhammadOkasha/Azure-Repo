// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Execution of a process that isn't allowed. Allow list consists of process names to allow. </summary>
    public partial class ProcessNotAllowed : AllowlistCustomAlertRule
    {
        /// <summary> Initializes a new instance of <see cref="ProcessNotAllowed"/>. </summary>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="allowlistValues"> The values to allow. The format of the values depends on the rule type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allowlistValues"/> is null. </exception>
        public ProcessNotAllowed(bool isEnabled, IEnumerable<string> allowlistValues) : base(isEnabled, allowlistValues)
        {
            if (allowlistValues == null)
            {
                throw new ArgumentNullException(nameof(allowlistValues));
            }

            RuleType = "ProcessNotAllowed";
        }

        /// <summary> Initializes a new instance of <see cref="ProcessNotAllowed"/>. </summary>
        /// <param name="displayName"> The display name of the custom alert. </param>
        /// <param name="description"> The description of the custom alert. </param>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="ruleType"> The type of the custom alert rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="valueType"> The value type of the items in the list. </param>
        /// <param name="allowlistValues"> The values to allow. The format of the values depends on the rule type. </param>
        internal ProcessNotAllowed(string displayName, string description, bool isEnabled, string ruleType, IDictionary<string, BinaryData> serializedAdditionalRawData, SecurityValueType? valueType, IList<string> allowlistValues) : base(displayName, description, isEnabled, ruleType, serializedAdditionalRawData, valueType, allowlistValues)
        {
            RuleType = ruleType ?? "ProcessNotAllowed";
        }

        /// <summary> Initializes a new instance of <see cref="ProcessNotAllowed"/> for deserialization. </summary>
        internal ProcessNotAllowed()
        {
        }
    }
}
