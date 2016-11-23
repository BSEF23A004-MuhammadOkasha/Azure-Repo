// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Represents an Azure SQL Database schema.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SchemaInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the SchemaInner class.
        /// </summary>
        public SchemaInner() { }

        /// <summary>
        /// Initializes a new instance of the SchemaInner class.
        /// </summary>
        /// <param name="tables">The tables from this database.</param>
        public SchemaInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), System.Collections.Generic.IList<TableInner> tables = default(System.Collections.Generic.IList<TableInner>))
            : base(location, id, name, type, tags)
        {
            Tables = tables;
        }

        /// <summary>
        /// Gets the tables from this database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tables")]
        public System.Collections.Generic.IList<TableInner> Tables { get; private set; }

    }
}
