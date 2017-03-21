// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
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
    /// Import database parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ImportExtensionRequestParameters
    {
        /// <summary>
        /// Initializes a new instance of the ImportExtensionRequestParameters
        /// class.
        /// </summary>
        public ImportExtensionRequestParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportExtensionRequestParameters
        /// class.
        /// </summary>
        /// <param name="storageKeyType">The type of the storage key to use.
        /// Valid values are StorageAccessKey and SharedAccessKey. Possible
        /// values include: 'StorageAccessKey', 'SharedAccessKey'</param>
        /// <param name="storageKey">The storage key to use.</param>
        /// <param name="storageUri">The storage uri to use.</param>
        /// <param name="administratorLogin">The name of the SQL
        /// administrator.</param>
        /// <param name="administratorLoginPassword">The password of the SQL
        /// administrator.</param>
        /// <param name="name">The name of the extension.</param>
        /// <param name="type">The type of the extension.</param>
        /// <param name="authenticationType">The authentication type - if not
        /// specified, will default to SQL. Possible values include: 'SQL',
        /// 'ADPassword'</param>
        public ImportExtensionRequestParameters(StorageKeyType storageKeyType, string storageKey, string storageUri, string administratorLogin, string administratorLoginPassword, string name = default(string), string type = default(string), AuthenticationType? authenticationType = default(AuthenticationType?))
        {
            Name = name;
            Type = type;
            StorageKeyType = storageKeyType;
            StorageKey = storageKey;
            StorageUri = storageUri;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            AuthenticationType = authenticationType;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for ImportExtensionRequestParameters class.
        /// </summary>
        static ImportExtensionRequestParameters()
        {
            OperationMode = "Import";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the extension.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the extension.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the type of the storage key to use. Valid values are
        /// StorageAccessKey and SharedAccessKey. Possible values include:
        /// 'StorageAccessKey', 'SharedAccessKey'
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageKeyType")]
        public StorageKeyType StorageKeyType { get; set; }

        /// <summary>
        /// Gets or sets the storage key to use.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageKey")]
        public string StorageKey { get; set; }

        /// <summary>
        /// Gets or sets the storage uri to use.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageUri")]
        public string StorageUri { get; set; }

        /// <summary>
        /// Gets or sets the name of the SQL administrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets the password of the SQL administrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Gets or sets the authentication type - if not specified, will
        /// default to SQL. Possible values include: 'SQL', 'ADPassword'
        /// </summary>
        [JsonProperty(PropertyName = "properties.authenticationType")]
        public AuthenticationType? AuthenticationType { get; set; }

        /// <summary>
        /// The type of Import/Export operation being performed.  This is
        /// always Import.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationMode")]
        public static string OperationMode { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageKey");
            }
            if (StorageUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageUri");
            }
            if (AdministratorLogin == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AdministratorLogin");
            }
            if (AdministratorLoginPassword == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AdministratorLoginPassword");
            }
        }
    }
}
