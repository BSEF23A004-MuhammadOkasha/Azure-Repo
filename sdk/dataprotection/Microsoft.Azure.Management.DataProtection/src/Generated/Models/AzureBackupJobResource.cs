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
    /// AzureBackup Job Resource Class
    /// </summary>
    public partial class AzureBackupJobResource : DppResource
    {
        /// <summary>
        /// Initializes a new instance of the AzureBackupJobResource class.
        /// </summary>
        public AzureBackupJobResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureBackupJobResource class.
        /// </summary>
        /// <param name="id">Resource Id represents the complete path to the
        /// resource.</param>
        /// <param name="name">Resource name associated with the
        /// resource.</param>
        /// <param name="type">Resource type represents the complete path of
        /// the form Namespace/ResourceType/ResourceType/...</param>
        /// <param name="properties">AzureBackupJobResource properties</param>
        public AzureBackupJobResource(string id = default(string), string name = default(string), string type = default(string), AzureBackupJob properties = default(AzureBackupJob))
            : base(id, name, type)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azureBackupJobResource properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public AzureBackupJob Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
