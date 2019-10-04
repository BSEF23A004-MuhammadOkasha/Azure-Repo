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
    /// An ADLS Gen 1 folder dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AdlsGen1Folder")]
    [Rest.Serialization.JsonTransformation]
    public partial class ADLSGen1FolderDataSet : DataSet
    {
        /// <summary>
        /// Initializes a new instance of the ADLSGen1FolderDataSet class.
        /// </summary>
        public ADLSGen1FolderDataSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ADLSGen1FolderDataSet class.
        /// </summary>
        /// <param name="accountName">The ADLS account name.</param>
        /// <param name="folderPath">The folder path within the ADLS
        /// account.</param>
        /// <param name="resourceGroup">Resource group of ADLS account.</param>
        /// <param name="subscriptionId">Subscription id of ADLS
        /// account.</param>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="dataSetId">Unique id for identifying a data set
        /// resource</param>
        public ADLSGen1FolderDataSet(string accountName, string folderPath, string resourceGroup, string subscriptionId, string id = default(string), string name = default(string), string type = default(string), string dataSetId = default(string))
            : base(id, name, type)
        {
            AccountName = accountName;
            DataSetId = dataSetId;
            FolderPath = folderPath;
            ResourceGroup = resourceGroup;
            SubscriptionId = subscriptionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ADLS account name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets unique id for identifying a data set resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetId")]
        public string DataSetId { get; private set; }

        /// <summary>
        /// Gets or sets the folder path within the ADLS account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.folderPath")]
        public string FolderPath { get; set; }

        /// <summary>
        /// Gets or sets resource group of ADLS account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroup")]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets subscription id of ADLS account.
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
            if (AccountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccountName");
            }
            if (FolderPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FolderPath");
            }
            if (ResourceGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceGroup");
            }
            if (SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubscriptionId");
            }
        }
    }
}
