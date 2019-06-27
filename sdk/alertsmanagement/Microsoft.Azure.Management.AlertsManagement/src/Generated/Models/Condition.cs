// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// condition to trigger an action rule
    /// </summary>
    public partial class Condition
    {
        /// <summary>
        /// Initializes a new instance of the Condition class.
        /// </summary>
        public Condition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Condition class.
        /// </summary>
        /// <param name="operatorProperty">operator for a given condition.
        /// Possible values include: 'Equals', 'NotEquals', 'Contains',
        /// 'DoesNotContain'</param>
        /// <param name="values">list of values to match for a given
        /// condition.</param>
        public Condition(string operatorProperty = default(string), IList<string> values = default(IList<string>))
        {
            OperatorProperty = operatorProperty;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operator for a given condition. Possible values
        /// include: 'Equals', 'NotEquals', 'Contains', 'DoesNotContain'
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// Gets or sets list of values to match for a given condition.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }

    }
}
