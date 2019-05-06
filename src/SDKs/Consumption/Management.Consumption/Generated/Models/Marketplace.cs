// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An marketplace resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Marketplace : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Marketplace class.
        /// </summary>
        public Marketplace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Marketplace class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="billingPeriodId">The id of the billing period resource
        /// that the usage belongs to.</param>
        /// <param name="usageStart">The start of the date time range covered
        /// by the usage detail.</param>
        /// <param name="usageEnd">The end of the date time range covered by
        /// the usage detail.</param>
        /// <param name="resourceRate">The marketplace resource rate.</param>
        /// <param name="offerName">The type of offer.</param>
        /// <param name="resourceGroup">The name of resource group.</param>
        /// <param name="orderNumber">The order number.</param>
        /// <param name="instanceName">The name of the resource instance that
        /// the usage is about.</param>
        /// <param name="instanceId">The uri of the resource instance that the
        /// usage is about.</param>
        /// <param name="currency">The ISO currency in which the meter is
        /// charged, for example, USD.</param>
        /// <param name="consumedQuantity">The quantity of usage.</param>
        /// <param name="unitOfMeasure">The unit of measure.</param>
        /// <param name="pretaxCost">The amount of cost before tax.</param>
        /// <param name="isEstimated">The estimated usage is subject to
        /// change.</param>
        /// <param name="meterId">The meter id (GUID).</param>
        /// <param name="subscriptionGuid">Subscription guid.</param>
        /// <param name="subscriptionName">Subscription name.</param>
        /// <param name="accountName">Account name.</param>
        /// <param name="departmentName">Department name.</param>
        /// <param name="consumedService">Consumed service name.</param>
        /// <param name="costCenter">The cost center of this department if it
        /// is a department and a costcenter exists</param>
        /// <param name="additionalProperties">Additional details of this usage
        /// item. By default this is not populated, unless it's specified in
        /// $expand.</param>
        /// <param name="publisherName">The name of publisher.</param>
        /// <param name="planName">The name of plan.</param>
        /// <param name="isRecurringCharge">Flag indicating whether this is a
        /// recurring charge or not.</param>
        public Marketplace(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string billingPeriodId = default(string), System.DateTime? usageStart = default(System.DateTime?), System.DateTime? usageEnd = default(System.DateTime?), decimal? resourceRate = default(decimal?), string offerName = default(string), string resourceGroup = default(string), string orderNumber = default(string), string instanceName = default(string), string instanceId = default(string), string currency = default(string), decimal? consumedQuantity = default(decimal?), string unitOfMeasure = default(string), decimal? pretaxCost = default(decimal?), bool? isEstimated = default(bool?), System.Guid? meterId = default(System.Guid?), System.Guid? subscriptionGuid = default(System.Guid?), string subscriptionName = default(string), string accountName = default(string), string departmentName = default(string), string consumedService = default(string), string costCenter = default(string), string additionalProperties = default(string), string publisherName = default(string), string planName = default(string), bool? isRecurringCharge = default(bool?))
            : base(id, name, type, tags)
        {
            BillingPeriodId = billingPeriodId;
            UsageStart = usageStart;
            UsageEnd = usageEnd;
            ResourceRate = resourceRate;
            OfferName = offerName;
            ResourceGroup = resourceGroup;
            OrderNumber = orderNumber;
            InstanceName = instanceName;
            InstanceId = instanceId;
            Currency = currency;
            ConsumedQuantity = consumedQuantity;
            UnitOfMeasure = unitOfMeasure;
            PretaxCost = pretaxCost;
            IsEstimated = isEstimated;
            MeterId = meterId;
            SubscriptionGuid = subscriptionGuid;
            SubscriptionName = subscriptionName;
            AccountName = accountName;
            DepartmentName = departmentName;
            ConsumedService = consumedService;
            CostCenter = costCenter;
            AdditionalProperties = additionalProperties;
            PublisherName = publisherName;
            PlanName = planName;
            IsRecurringCharge = isRecurringCharge;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the id of the billing period resource that the usage belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingPeriodId")]
        public string BillingPeriodId { get; private set; }

        /// <summary>
        /// Gets the start of the date time range covered by the usage detail.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageStart")]
        public System.DateTime? UsageStart { get; private set; }

        /// <summary>
        /// Gets the end of the date time range covered by the usage detail.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageEnd")]
        public System.DateTime? UsageEnd { get; private set; }

        /// <summary>
        /// Gets the marketplace resource rate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceRate")]
        public decimal? ResourceRate { get; private set; }

        /// <summary>
        /// Gets the type of offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.offerName")]
        public string OfferName { get; private set; }

        /// <summary>
        /// Gets the name of resource group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroup")]
        public string ResourceGroup { get; private set; }

        /// <summary>
        /// Gets the order number.
        /// </summary>
        [JsonProperty(PropertyName = "properties.orderNumber")]
        public string OrderNumber { get; private set; }

        /// <summary>
        /// Gets the name of the resource instance that the usage is about.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceName")]
        public string InstanceName { get; private set; }

        /// <summary>
        /// Gets the uri of the resource instance that the usage is about.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceId")]
        public string InstanceId { get; private set; }

        /// <summary>
        /// Gets the ISO currency in which the meter is charged, for example,
        /// USD.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// Gets the quantity of usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.consumedQuantity")]
        public decimal? ConsumedQuantity { get; private set; }

        /// <summary>
        /// Gets the unit of measure.
        /// </summary>
        [JsonProperty(PropertyName = "properties.unitOfMeasure")]
        public string UnitOfMeasure { get; private set; }

        /// <summary>
        /// Gets the amount of cost before tax.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pretaxCost")]
        public decimal? PretaxCost { get; private set; }

        /// <summary>
        /// Gets the estimated usage is subject to change.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEstimated")]
        public bool? IsEstimated { get; private set; }

        /// <summary>
        /// Gets the meter id (GUID).
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterId")]
        public System.Guid? MeterId { get; private set; }

        /// <summary>
        /// Gets subscription guid.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionGuid")]
        public System.Guid? SubscriptionGuid { get; private set; }

        /// <summary>
        /// Gets subscription name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionName")]
        public string SubscriptionName { get; private set; }

        /// <summary>
        /// Gets account name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountName")]
        public string AccountName { get; private set; }

        /// <summary>
        /// Gets department name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.departmentName")]
        public string DepartmentName { get; private set; }

        /// <summary>
        /// Gets consumed service name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.consumedService")]
        public string ConsumedService { get; private set; }

        /// <summary>
        /// Gets the cost center of this department if it is a department and a
        /// costcenter exists
        /// </summary>
        [JsonProperty(PropertyName = "properties.costCenter")]
        public string CostCenter { get; private set; }

        /// <summary>
        /// Gets additional details of this usage item. By default this is not
        /// populated, unless it's specified in $expand.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalProperties")]
        public string AdditionalProperties { get; private set; }

        /// <summary>
        /// Gets the name of publisher.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisherName")]
        public string PublisherName { get; private set; }

        /// <summary>
        /// Gets the name of plan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.planName")]
        public string PlanName { get; private set; }

        /// <summary>
        /// Gets flag indicating whether this is a recurring charge or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isRecurringCharge")]
        public bool? IsRecurringCharge { get; private set; }

    }
}
