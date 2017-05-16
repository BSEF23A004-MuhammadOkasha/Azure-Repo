// %~6

namespace Microsoft.Azure.Management.Relay.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Relay;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of HybridConnection Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HybridConnection : Resource
    {
        /// <summary>
        /// Initializes a new instance of the HybridConnection class.
        /// </summary>
        public HybridConnection()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HybridConnection class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="createdAt">The time the HybridConnection was
        /// created.</param>
        /// <param name="updatedAt">The time the namespace was updated.</param>
        /// <param name="listenerCount">The number of listeners for this
        /// HybridConnection. min : 1 and max:25 supported</param>
        /// <param name="requiresClientAuthorization">true if client
        /// authorization is needed for this HybridConnection; otherwise,
        /// false.</param>
        /// <param name="userMetadata">usermetadata is a placeholder to store
        /// user-defined string data for the HybridConnection endpoint.e.g. it
        /// can be used to store  descriptive data, such as list of teams and
        /// their contact information also user-defined configuration settings
        /// can be stored.</param>
        public HybridConnection(string id = default(string), string name = default(string), string type = default(string), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), int? listenerCount = default(int?), bool? requiresClientAuthorization = default(bool?), string userMetadata = default(string))
            : base(id, name, type)
        {
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ListenerCount = listenerCount;
            RequiresClientAuthorization = requiresClientAuthorization;
            UserMetadata = userMetadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the time the HybridConnection was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets the time the namespace was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets the number of listeners for this HybridConnection. min : 1 and
        /// max:25 supported
        /// </summary>
        [JsonProperty(PropertyName = "properties.listenerCount")]
        public int? ListenerCount { get; private set; }

        /// <summary>
        /// Gets or sets true if client authorization is needed for this
        /// HybridConnection; otherwise, false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiresClientAuthorization")]
        public bool? RequiresClientAuthorization { get; set; }

        /// <summary>
        /// Gets or sets usermetadata is a placeholder to store user-defined
        /// string data for the HybridConnection endpoint.e.g. it can be used
        /// to store  descriptive data, such as list of teams and their contact
        /// information also user-defined configuration settings can be stored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userMetadata")]
        public string UserMetadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ListenerCount > 25)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "ListenerCount", 25);
            }
            if (ListenerCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "ListenerCount", 1);
            }
        }
    }
}
