// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// StorageSetting
    /// </summary>
    /// <remarks>
    /// Storage setting
    /// </remarks>
    public partial class StorageSetting
    {
        /// <summary>
        /// Initializes a new instance of the StorageSetting class.
        /// </summary>
        public StorageSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageSetting class.
        /// </summary>
        /// <param name="dataStoreType">Gets or sets the type of the datastore.
        /// Possible values include: 'ArchiveStore', 'SnapshotStore',
        /// 'VaultStore'</param>
        /// <param name="type">Gets or sets the type. Possible values include:
        /// 'GeoRedundant', 'LocallyRedundant'</param>
        public StorageSetting(string dataStoreType = default(string), string type = default(string))
        {
            DataStoreType = dataStoreType;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of the datastore. Possible values include:
        /// 'ArchiveStore', 'SnapshotStore', 'VaultStore'
        /// </summary>
        [JsonProperty(PropertyName = "dataStoreType")]
        public string DataStoreType { get; set; }

        /// <summary>
        /// Gets or sets the type. Possible values include: 'GeoRedundant',
        /// 'LocallyRedundant'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
