// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Dynamic delivery attribute mapping details. </summary>
    public partial class DynamicDeliveryAttributeMapping : DeliveryAttributeMapping
    {
        /// <summary> Initializes a new instance of DynamicDeliveryAttributeMapping. </summary>
        public DynamicDeliveryAttributeMapping()
        {
            MappingType = DeliveryAttributeMappingType.Dynamic;
        }

        /// <summary> Initializes a new instance of DynamicDeliveryAttributeMapping. </summary>
        /// <param name="name"> Name of the delivery attribute or header. </param>
        /// <param name="mappingType"> Type of the delivery attribute or header name. </param>
        /// <param name="sourceField"> JSON path in the event which contains attribute value. </param>
        internal DynamicDeliveryAttributeMapping(string name, DeliveryAttributeMappingType mappingType, string sourceField) : base(name, mappingType)
        {
            SourceField = sourceField;
            MappingType = mappingType;
        }

        /// <summary> JSON path in the event which contains attribute value. </summary>
        public string SourceField { get; set; }
    }
}
