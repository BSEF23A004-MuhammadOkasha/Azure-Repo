// MIT

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// SKU properties.
    /// </summary>
    public partial class IotHubSkuDescription
    {
        /// <summary>
        /// Initializes a new instance of the IotHubSkuDescription class.
        /// </summary>
        public IotHubSkuDescription() { }

        /// <summary>
        /// Initializes a new instance of the IotHubSkuDescription class.
        /// </summary>
        public IotHubSkuDescription(IotHubSkuInfo sku, IotHubCapacity capacity, string resourceType = default(string))
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
        }

        /// <summary>
        /// The type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public IotHubSkuInfo Sku { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public IotHubCapacity Capacity { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Capacity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Capacity");
            }
            if (this.Sku != null)
            {
                this.Sku.Validate();
            }
            if (this.Capacity != null)
            {
                this.Capacity.Validate();
            }
        }
    }
}
