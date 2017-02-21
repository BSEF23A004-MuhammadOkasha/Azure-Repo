// MIT

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties of the Azure Storage endpoint for file upload.
    /// </summary>
    public partial class StorageEndpointProperties
    {
        /// <summary>
        /// Initializes a new instance of the StorageEndpointProperties class.
        /// </summary>
        public StorageEndpointProperties() { }

        /// <summary>
        /// Initializes a new instance of the StorageEndpointProperties class.
        /// </summary>
        public StorageEndpointProperties(string connectionString, string containerName, TimeSpan? sasTtlAsIso8601 = default(TimeSpan?))
        {
            SasTtlAsIso8601 = sasTtlAsIso8601;
            ConnectionString = connectionString;
            ContainerName = containerName;
        }

        /// <summary>
        /// The period of time for which the the SAS URI generated by IoT Hub
        /// for file upload is valid. See:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-file-upload#file-upload-notification-configuration-options.
        /// </summary>
        [JsonProperty(PropertyName = "sasTtlAsIso8601")]
        public TimeSpan? SasTtlAsIso8601 { get; set; }

        /// <summary>
        /// The connection string for the Azure Storage account to which files
        /// are uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// The name of the root container where you upload files. The
        /// container need not exist but should be creatable using the
        /// connectionString specified.
        /// </summary>
        [JsonProperty(PropertyName = "containerName")]
        public string ContainerName { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ConnectionString == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionString");
            }
            if (ContainerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContainerName");
            }
        }
    }
}
