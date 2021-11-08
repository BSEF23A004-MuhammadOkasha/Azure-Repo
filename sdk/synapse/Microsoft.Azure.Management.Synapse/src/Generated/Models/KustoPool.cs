// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing a Kusto kusto pool.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class KustoPool : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the KustoPool class.
        /// </summary>
        public KustoPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KustoPool class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="sku">The SKU of the kusto pool.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="state">The state of the resource. Possible values
        /// include: 'Creating', 'Unavailable', 'Running', 'Deleting',
        /// 'Deleted', 'Stopping', 'Stopped', 'Starting', 'Updating'</param>
        /// <param name="provisioningState">The provisioned state of the
        /// resource. Possible values include: 'Running', 'Creating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Moving', 'Canceled'</param>
        /// <param name="uri">The Kusto Pool URI.</param>
        /// <param name="dataIngestionUri">The Kusto Pool data ingestion
        /// URI.</param>
        /// <param name="stateReason">The reason for the Kusto Pool's current
        /// state.</param>
        /// <param name="optimizedAutoscale">Optimized auto scale
        /// definition.</param>
        /// <param name="enableStreamingIngest">A boolean value that indicates
        /// if the streaming ingest is enabled.</param>
        /// <param name="enablePurge">A boolean value that indicates if the
        /// purge operations are enabled.</param>
        /// <param name="languageExtensions">List of the Kusto Pool's language
        /// extensions.</param>
        /// <param name="workspaceUID">The workspace unique identifier.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        public KustoPool(string location, AzureSku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string state = default(string), string provisioningState = default(string), string uri = default(string), string dataIngestionUri = default(string), string stateReason = default(string), OptimizedAutoscale optimizedAutoscale = default(OptimizedAutoscale), bool? enableStreamingIngest = default(bool?), bool? enablePurge = default(bool?), LanguageExtensionsList languageExtensions = default(LanguageExtensionsList), string workspaceUID = default(string), string etag = default(string), SystemData systemData = default(SystemData))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            State = state;
            ProvisioningState = provisioningState;
            Uri = uri;
            DataIngestionUri = dataIngestionUri;
            StateReason = stateReason;
            OptimizedAutoscale = optimizedAutoscale;
            EnableStreamingIngest = enableStreamingIngest;
            EnablePurge = enablePurge;
            LanguageExtensions = languageExtensions;
            WorkspaceUID = workspaceUID;
            Etag = etag;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU of the kusto pool.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public AzureSku Sku { get; set; }

        /// <summary>
        /// Gets the state of the resource. Possible values include:
        /// 'Creating', 'Unavailable', 'Running', 'Deleting', 'Deleted',
        /// 'Stopping', 'Stopped', 'Starting', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets or sets the provisioned state of the resource. Possible values
        /// include: 'Running', 'Creating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Moving', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets the Kusto Pool URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uri")]
        public string Uri { get; private set; }

        /// <summary>
        /// Gets the Kusto Pool data ingestion URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataIngestionUri")]
        public string DataIngestionUri { get; private set; }

        /// <summary>
        /// Gets the reason for the Kusto Pool's current state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.stateReason")]
        public string StateReason { get; private set; }

        /// <summary>
        /// Gets or sets optimized auto scale definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.optimizedAutoscale")]
        public OptimizedAutoscale OptimizedAutoscale { get; set; }

        /// <summary>
        /// Gets or sets a boolean value that indicates if the streaming ingest
        /// is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableStreamingIngest")]
        public bool? EnableStreamingIngest { get; set; }

        /// <summary>
        /// Gets or sets a boolean value that indicates if the purge operations
        /// are enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enablePurge")]
        public bool? EnablePurge { get; set; }

        /// <summary>
        /// Gets list of the Kusto Pool's language extensions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.languageExtensions")]
        public LanguageExtensionsList LanguageExtensions { get; private set; }

        /// <summary>
        /// Gets or sets the workspace unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.workspaceUID")]
        public string WorkspaceUID { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets azure Resource Manager metadata containing createdBy and
        /// modifiedBy information.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (OptimizedAutoscale != null)
            {
                OptimizedAutoscale.Validate();
            }
        }
    }
}
