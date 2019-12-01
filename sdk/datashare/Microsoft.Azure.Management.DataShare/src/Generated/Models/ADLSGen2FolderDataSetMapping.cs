// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An ADLS Gen2 folder data set mapping.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AdlsGen2Folder")]
    [Rest.Serialization.JsonTransformation]
    public partial class ADLSGen2FolderDataSetMapping : DataSetMapping
    {
        /// <summary>
        /// Initializes a new instance of the ADLSGen2FolderDataSetMapping
        /// class.
        /// </summary>
        public ADLSGen2FolderDataSetMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ADLSGen2FolderDataSetMapping
        /// class.
        /// </summary>
        /// <param name="dataSetId">The id of the source data set.</param>
        /// <param name="fileSystem">File system to which the folder
        /// belongs.</param>
        /// <param name="folderPath">Folder path within the file
        /// system.</param>
        /// <param name="resourceGroup">Resource group of storage
        /// account.</param>
        /// <param name="storageAccountName">Storage account name of the source
        /// data set.</param>
        /// <param name="subscriptionId">Subscription id of storage
        /// account.</param>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="dataSetMappingStatus">Gets the status of the data set
        /// mapping. Possible values include: 'Ok', 'Broken'</param>
        /// <param name="provisioningState">Provisioning state of the data set
        /// mapping. Possible values include: 'Succeeded', 'Creating',
        /// 'Deleting', 'Moving', 'Failed'</param>
        public ADLSGen2FolderDataSetMapping(string dataSetId, string fileSystem, string folderPath, string resourceGroup, string storageAccountName, string subscriptionId, string id = default(string), string name = default(string), string type = default(string), string dataSetMappingStatus = default(string), string provisioningState = default(string))
            : base(id, name, type)
        {
            DataSetId = dataSetId;
            DataSetMappingStatus = dataSetMappingStatus;
            FileSystem = fileSystem;
            FolderPath = folderPath;
            ProvisioningState = provisioningState;
            ResourceGroup = resourceGroup;
            StorageAccountName = storageAccountName;
            SubscriptionId = subscriptionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the source data set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetId")]
        public string DataSetId { get; set; }

        /// <summary>
        /// Gets the status of the data set mapping. Possible values include:
        /// 'Ok', 'Broken'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetMappingStatus")]
        public string DataSetMappingStatus { get; private set; }

        /// <summary>
        /// Gets or sets file system to which the folder belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fileSystem")]
        public string FileSystem { get; set; }

        /// <summary>
        /// Gets or sets folder path within the file system.
        /// </summary>
        [JsonProperty(PropertyName = "properties.folderPath")]
        public string FolderPath { get; set; }

        /// <summary>
        /// Gets provisioning state of the data set mapping. Possible values
        /// include: 'Succeeded', 'Creating', 'Deleting', 'Moving', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets resource group of storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroup")]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets storage account name of the source data set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountName")]
        public string StorageAccountName { get; set; }

        /// <summary>
        /// Gets or sets subscription id of storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataSetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSetId");
            }
            if (FileSystem == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileSystem");
            }
            if (FolderPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FolderPath");
            }
            if (ResourceGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceGroup");
            }
            if (StorageAccountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountName");
            }
            if (SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubscriptionId");
            }
        }
    }
}
