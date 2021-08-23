// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information for connecting to Oracle server
    /// </summary>
    [Newtonsoft.Json.JsonObject("OracleConnectionInfo")]
    public partial class OracleConnectionInfo : ConnectionInfo
    {
        /// <summary>
        /// Initializes a new instance of the OracleConnectionInfo class.
        /// </summary>
        public OracleConnectionInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OracleConnectionInfo class.
        /// </summary>
        /// <param name="dataSource">EZConnect or TNSName connection
        /// string.</param>
        /// <param name="userName">User name</param>
        /// <param name="password">Password credential.</param>
        public OracleConnectionInfo(string dataSource, string userName = default(string), string password = default(string))
            : base(userName, password)
        {
            DataSource = dataSource;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets eZConnect or TNSName connection string.
        /// </summary>
        [JsonProperty(PropertyName = "dataSource")]
        public string DataSource { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataSource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSource");
            }
        }
    }
}
