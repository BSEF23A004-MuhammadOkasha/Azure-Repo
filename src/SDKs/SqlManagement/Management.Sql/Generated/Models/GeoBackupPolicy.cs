// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A database geo backup policy.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GeoBackupPolicy : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the GeoBackupPolicy class.
        /// </summary>
        public GeoBackupPolicy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoBackupPolicy class.
        /// </summary>
        /// <param name="state">The state of the geo backup policy. Possible
        /// values include: 'Disabled', 'Enabled'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="storageType">The storage type of the geo backup
        /// policy.</param>
        /// <param name="kind">Kind of geo backup policy.  This is metadata
        /// used for the Azure portal experience.</param>
        /// <param name="location">Backup policy location.</param>
        public GeoBackupPolicy(GeoBackupPolicyState state, string id = default(string), string name = default(string), string type = default(string), string storageType = default(string), string kind = default(string), string location = default(string))
            : base(id, name, type)
        {
            State = state;
            StorageType = storageType;
            Kind = kind;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the state of the geo backup policy. Possible values
        /// include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public GeoBackupPolicyState State { get; set; }

        /// <summary>
        /// Gets the storage type of the geo backup policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageType")]
        public string StorageType { get; private set; }

        /// <summary>
        /// Gets kind of geo backup policy.  This is metadata used for the
        /// Azure portal experience.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets backup policy location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
