// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The properties of the benefit recommendations when scope is 'Single'. </summary>
    public partial class SingleScopeBenefitRecommendationProperties : BenefitRecommendationProperties
    {
        /// <summary> Initializes a new instance of <see cref="SingleScopeBenefitRecommendationProperties"/>. </summary>
        public SingleScopeBenefitRecommendationProperties()
        {
            Scope = BenefitRecommendationScope.Single;
        }

        /// <summary> Initializes a new instance of <see cref="SingleScopeBenefitRecommendationProperties"/>. </summary>
        /// <param name="firstConsumptionOn"> The first usage date used for looking back for computing the recommendations. </param>
        /// <param name="lastConsumptionOn"> The last usage date used for looking back for computing the recommendations. </param>
        /// <param name="lookBackPeriod"> The number of days of usage evaluated for computing the recommendations. </param>
        /// <param name="totalHours"> The total hours for which the cost is covered. Its equal to number of records in a property 'properties/usage/charges'. </param>
        /// <param name="usage"> On-demand charges between firstConsumptionDate and lastConsumptionDate that were used for computing benefit recommendations. </param>
        /// <param name="armSkuName"> ARM SKU name. 'Compute_Savings_Plan' for SavingsPlan. </param>
        /// <param name="term"> Term period of the benefit. For example, P1Y or P3Y. </param>
        /// <param name="commitmentGranularity"> Grain of the proposed commitment amount. Supported values: 'Hourly'. </param>
        /// <param name="currencyCode"> An ISO 4217 currency code identifier for the costs and savings amounts. </param>
        /// <param name="costWithoutBenefit"> The current cost without benefit, corresponds to 'totalHours' in the look-back period. </param>
        /// <param name="recommendationDetails"> The details of the proposed recommendation. </param>
        /// <param name="allRecommendationDetails"> The list of all benefit recommendations with the recommendation details. </param>
        /// <param name="scope"> Benefit scope. For example, Single or Shared. </param>
        /// <param name="subscriptionId"> The subscription ID that this single scope recommendation is for. Applicable only if recommendation is for 'Single' scope. </param>
        /// <param name="resourceGroup"> The resource group that this single scope recommendation is for. Applicable only if recommendation is for 'Single' scope and 'ResourceGroup' request scope. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SingleScopeBenefitRecommendationProperties(DateTimeOffset? firstConsumptionOn, DateTimeOffset? lastConsumptionOn, LookBackPeriod? lookBackPeriod, int? totalHours, RecommendationUsageDetails usage, string armSkuName, BenefitRecommendationPeriodTerm? term, BenefitRecommendationUsageGrain? commitmentGranularity, string currencyCode, decimal? costWithoutBenefit, AllSavingsBenefitDetails recommendationDetails, AllSavingsList allRecommendationDetails, BenefitRecommendationScope scope, string subscriptionId, string resourceGroup, Dictionary<string, BinaryData> rawData) : base(firstConsumptionOn, lastConsumptionOn, lookBackPeriod, totalHours, usage, armSkuName, term, commitmentGranularity, currencyCode, costWithoutBenefit, recommendationDetails, allRecommendationDetails, scope, rawData)
        {
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            Scope = scope;
        }

        /// <summary> The subscription ID that this single scope recommendation is for. Applicable only if recommendation is for 'Single' scope. </summary>
        public string SubscriptionId { get; }
        /// <summary> The resource group that this single scope recommendation is for. Applicable only if recommendation is for 'Single' scope and 'ResourceGroup' request scope. </summary>
        public string ResourceGroup { get; }
    }
}
