// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ClientDiscoveryValueForSingleApi
    /// </summary>
    /// <remarks>
    /// Available operation details.
    /// </remarks>
    [Rest.Serialization.JsonTransformation]
    public partial class ClientDiscoveryValueForSingleApi
    {
        /// <summary>
        /// Initializes a new instance of the ClientDiscoveryValueForSingleApi
        /// class.
        /// </summary>
        public ClientDiscoveryValueForSingleApi()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClientDiscoveryValueForSingleApi
        /// class.
        /// </summary>
        /// <param name="display">Contains the localized display information
        /// for this particular operation</param>
        /// <param name="name">Name of the Operation.</param>
        /// <param name="isDataAction">Indicates whether the operation is a
        /// data action</param>
        /// <param name="origin">The intended executor of the operation;governs
        /// the display of the operation in the RBAC UX and the audit logs
        /// UX</param>
        /// <param name="serviceSpecification">Operation properties.</param>
        public ClientDiscoveryValueForSingleApi(ClientDiscoveryDisplay display = default(ClientDiscoveryDisplay), string name = default(string), bool? isDataAction = default(bool?), string origin = default(string), ClientDiscoveryForServiceSpecification serviceSpecification = default(ClientDiscoveryForServiceSpecification))
        {
            Display = display;
            Name = name;
            IsDataAction = isDataAction;
            Origin = origin;
            ServiceSpecification = serviceSpecification;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets contains the localized display information for this
        /// particular operation
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public ClientDiscoveryDisplay Display { get; set; }

        /// <summary>
        /// Gets or sets name of the Operation.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the operation is a data action
        /// </summary>
        [JsonProperty(PropertyName = "isDataAction")]
        public bool? IsDataAction { get; set; }

        /// <summary>
        /// Gets or sets the intended executor of the operation;governs the
        /// display of the operation in the RBAC UX and the audit logs UX
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets operation properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceSpecification")]
        public ClientDiscoveryForServiceSpecification ServiceSpecification { get; set; }

    }
}
