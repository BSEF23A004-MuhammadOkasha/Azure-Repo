// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Batch;
    using Microsoft.Azure.Management.Batch.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains information about an Azure Batch account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BatchAccountInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccountInner class.
        /// </summary>
        public BatchAccountInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchAccountInner class.
        /// </summary>
        /// <param name="coreQuota">The core quota for this Batch
        /// account.</param>
        /// <param name="poolQuota">The pool quota for this Batch
        /// account.</param>
        /// <param name="activeJobAndJobScheduleQuota">The active job and job
        /// schedule quota for this Batch account.</param>
        /// <param name="accountEndpoint">The endpoint used by this account to
        /// interact with the Batch services.</param>
        /// <param name="provisioningState">The provisioned state of the
        /// resource. Possible values include: 'Invalid', 'Creating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Cancelled'</param>
        /// <param name="autoStorage">The properties and status of any auto
        /// storage account associated with the account.</param>
        public BatchAccountInner(int coreQuota, int poolQuota, int activeJobAndJobScheduleQuota, string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string accountEndpoint = default(string), ProvisioningState? provisioningState = default(ProvisioningState?), AutoStorageProperties autoStorage = default(AutoStorageProperties))
            : base(location, id, name, type, tags)
        {
            AccountEndpoint = accountEndpoint;
            ProvisioningState = provisioningState;
            AutoStorage = autoStorage;
            CoreQuota = coreQuota;
            PoolQuota = poolQuota;
            ActiveJobAndJobScheduleQuota = activeJobAndJobScheduleQuota;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the endpoint used by this account to interact with the Batch
        /// services.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountEndpoint")]
        public string AccountEndpoint { get; private set; }

        /// <summary>
        /// Gets or sets the provisioned state of the resource. Possible values
        /// include: 'Invalid', 'Creating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Cancelled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the properties and status of any auto storage account
        /// associated with the account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoStorage")]
        public AutoStorageProperties AutoStorage { get; set; }

        /// <summary>
        /// Gets or sets the core quota for this Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.coreQuota")]
        public int CoreQuota { get; set; }

        /// <summary>
        /// Gets or sets the pool quota for this Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.poolQuota")]
        public int PoolQuota { get; set; }

        /// <summary>
        /// Gets or sets the active job and job schedule quota for this Batch
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.activeJobAndJobScheduleQuota")]
        public int ActiveJobAndJobScheduleQuota { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AutoStorage != null)
            {
                AutoStorage.Validate();
            }
        }
    }
}
