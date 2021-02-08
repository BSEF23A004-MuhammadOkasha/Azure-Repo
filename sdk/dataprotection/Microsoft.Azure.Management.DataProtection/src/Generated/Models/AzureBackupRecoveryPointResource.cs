// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using System.Linq;

    /// <summary>
    /// AzureBackupRecoveryPointResource
    /// </summary>
    /// <remarks>
    /// Azure backup recoveryPoint resource
    /// </remarks>
    public partial class AzureBackupRecoveryPointResource : DppResource
    {
        /// <summary>
        /// Initializes a new instance of the AzureBackupRecoveryPointResource
        /// class.
        /// </summary>
        public AzureBackupRecoveryPointResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureBackupRecoveryPointResource
        /// class.
        /// </summary>
        /// <param name="id">Resource Id represents the complete path to the
        /// resource.</param>
        /// <param name="name">Resource name associated with the
        /// resource.</param>
        /// <param name="type">Resource type represents the complete path of
        /// the form Namespace/ResourceType/ResourceType/...</param>
        public AzureBackupRecoveryPointResource(string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
