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
    /// Properties of the alert modification item.
    /// </summary>
    public partial class AlertModificationProperties
    {
        /// <summary>
        /// Initializes a new instance of the AlertModificationProperties
        /// class.
        /// </summary>
        public AlertModificationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertModificationProperties
        /// class.
        /// </summary>
        /// <param name="alertId">Unique Id of the alert for which the history
        /// is being retrieved</param>
        /// <param name="modifications">Modification details</param>
        public AlertModificationProperties(string alertId = default(string), IList<AlertModificationItem> modifications = default(IList<AlertModificationItem>))
        {
            AlertId = alertId;
            Modifications = modifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unique Id of the alert for which the history is being
        /// retrieved
        /// </summary>
        [JsonProperty(PropertyName = "alertId")]
        public string AlertId { get; private set; }

        /// <summary>
        /// Gets or sets modification details
        /// </summary>
        [JsonProperty(PropertyName = "modifications")]
        public IList<AlertModificationItem> Modifications { get; set; }

    }
}
