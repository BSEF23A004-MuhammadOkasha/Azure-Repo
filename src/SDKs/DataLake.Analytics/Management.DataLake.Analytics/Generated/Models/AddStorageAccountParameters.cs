// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Storage account parameters for a storage account being added to a Data
    /// Lake Analytics account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AddStorageAccountParameters
    {
        /// <summary>
        /// Initializes a new instance of the AddStorageAccountParameters
        /// class.
        /// </summary>
        public AddStorageAccountParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddStorageAccountParameters
        /// class.
        /// </summary>
        /// <param name="accessKey">the access key associated with this Azure
        /// Storage account that will be used to connect to it.</param>
        /// <param name="suffix">the optional suffix for the storage
        /// account.</param>
        public AddStorageAccountParameters(string accessKey, string suffix = default(string))
        {
            AccessKey = accessKey;
            Suffix = suffix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the access key associated with this Azure Storage
        /// account that will be used to connect to it.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessKey")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or sets the optional suffix for the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AccessKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessKey");
            }
        }
    }
}
