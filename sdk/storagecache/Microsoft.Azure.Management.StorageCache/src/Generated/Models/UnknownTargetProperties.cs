// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Storage container for use as an Unknown Storage Target.
    /// </summary>
    [Newtonsoft.Json.JsonObject("unknown")]
    public partial class UnknownTargetProperties : StorageTargetProperties
    {
        /// <summary>
        /// Initializes a new instance of the UnknownTargetProperties class.
        /// </summary>
        public UnknownTargetProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UnknownTargetProperties class.
        /// </summary>
        /// <param name="junctions">List of Cache namespace junctions to target
        /// for namespace associations.</param>
        /// <param name="targetType">Type of the Storage Target.</param>
        /// <param name="provisioningState">ARM provisioning state, see
        /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property.
        /// Possible values include: 'Succeeded', 'Failed', 'Cancelled',
        /// 'Creating', 'Deleting', 'Updating'</param>
        /// <param name="nfs3">Properties when targetType is nfs3.</param>
        /// <param name="clfs">Properties when targetType is clfs.</param>
        /// <param name="unknown">Properties when targetType is
        /// unknown.</param>
        public UnknownTargetProperties(IList<NamespaceJunction> junctions = default(IList<NamespaceJunction>), string targetType = default(string), string provisioningState = default(string), Nfs3Target nfs3 = default(Nfs3Target), ClfsTarget clfs = default(ClfsTarget), UnknownTarget unknown = default(UnknownTarget))
            : base(junctions, targetType, provisioningState, nfs3, clfs, unknown)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
