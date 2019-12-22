// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IaaS VM workload-specific backup policy.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureIaasVM")]
    public partial class AzureIaaSVMProtectionPolicy : ProtectionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMProtectionPolicy
        /// class.
        /// </summary>
        public AzureIaaSVMProtectionPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMProtectionPolicy
        /// class.
        /// </summary>
        /// <param name="protectedItemsCount">Number of items associated with
        /// this policy.</param>
        /// <param name="schedulePolicy">Backup schedule specified as part of
        /// backup policy.</param>
        /// <param name="retentionPolicy">Retention policy with the details on
        /// backup copy retention ranges.</param>
        /// <param name="instantRpRetentionRangeInDays">Instant RP retention
        /// policy range in days</param>
        /// <param name="timeZone">TimeZone optional input as string. For
        /// example: TimeZone = "Pacific Standard Time".</param>
        public AzureIaaSVMProtectionPolicy(int? protectedItemsCount = default(int?), SchedulePolicy schedulePolicy = default(SchedulePolicy), RetentionPolicy retentionPolicy = default(RetentionPolicy), int? instantRpRetentionRangeInDays = default(int?), string timeZone = default(string))
            : base(protectedItemsCount)
        {
            SchedulePolicy = schedulePolicy;
            RetentionPolicy = retentionPolicy;
            InstantRpRetentionRangeInDays = instantRpRetentionRangeInDays;
            TimeZone = timeZone;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backup schedule specified as part of backup policy.
        /// </summary>
        [JsonProperty(PropertyName = "schedulePolicy")]
        public SchedulePolicy SchedulePolicy { get; set; }

        /// <summary>
        /// Gets or sets retention policy with the details on backup copy
        /// retention ranges.
        /// </summary>
        [JsonProperty(PropertyName = "retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

        /// <summary>
        /// Gets or sets instant RP retention policy range in days
        /// </summary>
        [JsonProperty(PropertyName = "instantRpRetentionRangeInDays")]
        public int? InstantRpRetentionRangeInDays { get; set; }

        /// <summary>
        /// Gets or sets timeZone optional input as string. For example:
        /// TimeZone = "Pacific Standard Time".
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

    }
}
