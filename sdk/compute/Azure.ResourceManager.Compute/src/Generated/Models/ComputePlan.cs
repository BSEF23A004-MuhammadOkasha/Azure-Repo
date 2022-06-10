// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </summary>
    public partial class ComputePlan
    {
        /// <summary> Initializes a new instance of ComputePlan. </summary>
        public ComputePlan()
        {
        }

        /// <summary> Initializes a new instance of ComputePlan. </summary>
        /// <param name="name"> The plan ID. </param>
        /// <param name="publisher"> The publisher ID. </param>
        /// <param name="product"> Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element. </param>
        /// <param name="promotionCode"> The promotion code. </param>
        internal ComputePlan(string name, string publisher, string product, string promotionCode)
        {
            Name = name;
            Publisher = publisher;
            Product = product;
            PromotionCode = promotionCode;
        }

        /// <summary> The plan ID. </summary>
        public string Name { get; set; }
        /// <summary> The publisher ID. </summary>
        public string Publisher { get; set; }
        /// <summary> Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element. </summary>
        public string Product { get; set; }
        /// <summary> The promotion code. </summary>
        public string PromotionCode { get; set; }
    }
}
