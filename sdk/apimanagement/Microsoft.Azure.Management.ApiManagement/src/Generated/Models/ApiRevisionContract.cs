// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Summary of revision metadata.
    /// </summary>
    public partial class ApiRevisionContract
    {
        /// <summary>
        /// Initializes a new instance of the ApiRevisionContract class.
        /// </summary>
        public ApiRevisionContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiRevisionContract class.
        /// </summary>
        /// <param name="apiId">Identifier of the API Revision.</param>
        /// <param name="apiRevision">Revision number of API.</param>
        /// <param name="createdDateTime">The time the API Revision was
        /// created. The date conforms to the following format:
        /// yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601 standard.</param>
        /// <param name="updatedDateTime">The time the API Revision were
        /// updated. The date conforms to the following format:
        /// yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601 standard.</param>
        /// <param name="description">Description of the API Revision.</param>
        /// <param name="privateUrl">Gateway URL for accessing the non-current
        /// API Revision.</param>
        /// <param name="isOnline">Indicates if API revision is the current api
        /// revision.</param>
        /// <param name="isCurrent">Indicates if API revision is accessible via
        /// the gateway.</param>
        public ApiRevisionContract(string apiId = default(string), string apiRevision = default(string), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? updatedDateTime = default(System.DateTime?), string description = default(string), string privateUrl = default(string), bool? isOnline = default(bool?), bool? isCurrent = default(bool?))
        {
            ApiId = apiId;
            ApiRevision = apiRevision;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
            Description = description;
            PrivateUrl = privateUrl;
            IsOnline = isOnline;
            IsCurrent = isCurrent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets identifier of the API Revision.
        /// </summary>
        [JsonProperty(PropertyName = "apiId")]
        public string ApiId { get; private set; }

        /// <summary>
        /// Gets revision number of API.
        /// </summary>
        [JsonProperty(PropertyName = "apiRevision")]
        public string ApiRevision { get; private set; }

        /// <summary>
        /// Gets the time the API Revision was created. The date conforms to
        /// the following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO
        /// 8601 standard.
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; private set; }

        /// <summary>
        /// Gets the time the API Revision were updated. The date conforms to
        /// the following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO
        /// 8601 standard.
        /// </summary>
        [JsonProperty(PropertyName = "updatedDateTime")]
        public System.DateTime? UpdatedDateTime { get; private set; }

        /// <summary>
        /// Gets description of the API Revision.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets gateway URL for accessing the non-current API Revision.
        /// </summary>
        [JsonProperty(PropertyName = "privateUrl")]
        public string PrivateUrl { get; private set; }

        /// <summary>
        /// Gets indicates if API revision is the current api revision.
        /// </summary>
        [JsonProperty(PropertyName = "isOnline")]
        public bool? IsOnline { get; private set; }

        /// <summary>
        /// Gets indicates if API revision is accessible via the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "isCurrent")]
        public bool? IsCurrent { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ApiRevision != null)
            {
                if (ApiRevision.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiRevision", 100);
                }
                if (ApiRevision.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ApiRevision", 1);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 256);
                }
            }
        }
    }
}
