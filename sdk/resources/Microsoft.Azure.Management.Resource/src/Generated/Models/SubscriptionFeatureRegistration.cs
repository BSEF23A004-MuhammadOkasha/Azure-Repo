// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Subscription feature registration details
    /// </summary>
    public partial class SubscriptionFeatureRegistration : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionFeatureRegistration
        /// class.
        /// </summary>
        public SubscriptionFeatureRegistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionFeatureRegistration
        /// class.
        /// </summary>
        /// <param name="id">Azure resource Id.</param>
        /// <param name="name">Azure resource name.</param>
        /// <param name="type">Azure resource type.</param>
        /// <param name="properties">Azure resource properties.</param>
        public SubscriptionFeatureRegistration(string id = default(string), string name = default(string), string type = default(string), SubscriptionFeatureRegistrationProperties properties = default(SubscriptionFeatureRegistrationProperties))
            : base(id, name, type)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Azure resource properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public SubscriptionFeatureRegistrationProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
