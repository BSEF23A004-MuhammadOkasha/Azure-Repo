// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A List custom alert rule.
    /// </summary>
    public partial class ListCustomAlertRule : CustomAlertRule
    {
        /// <summary>
        /// Initializes a new instance of the ListCustomAlertRule class.
        /// </summary>
        public ListCustomAlertRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListCustomAlertRule class.
        /// </summary>
        /// <param name="isEnabled">Status of the custom alert.</param>
        /// <param name="ruleType">The type of the custom alert rule.</param>
        /// <param name="displayName">The display name of the custom
        /// alert.</param>
        /// <param name="description">The description of the custom
        /// alert.</param>
        /// <param name="valueType">The value type of the items in the list.
        /// Possible values include: 'IpCidr', 'String'</param>
        public ListCustomAlertRule(bool isEnabled, string ruleType, string displayName = default(string), string description = default(string), string valueType = default(string))
            : base(isEnabled, ruleType, displayName, description)
        {
            ValueType = valueType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the value type of the items in the list. Possible values
        /// include: 'IpCidr', 'String'
        /// </summary>
        [JsonProperty(PropertyName = "valueType")]
        public string ValueType { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
