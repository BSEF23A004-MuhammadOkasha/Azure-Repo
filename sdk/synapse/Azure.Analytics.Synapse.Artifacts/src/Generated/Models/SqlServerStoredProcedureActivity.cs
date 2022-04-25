// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> SQL stored procedure activity type. </summary>
    public partial class SqlServerStoredProcedureActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of SqlServerStoredProcedureActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="storedProcedureName"> Stored procedure name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="storedProcedureName"/> is null. </exception>
        public SqlServerStoredProcedureActivity(string name, object storedProcedureName) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (storedProcedureName == null)
            {
                throw new ArgumentNullException(nameof(storedProcedureName));
            }

            StoredProcedureName = storedProcedureName;
            Type = "SqlServerStoredProcedure";
        }

        /// <summary> Initializes a new instance of SqlServerStoredProcedureActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="storedProcedureName"> Stored procedure name. Type: string (or Expression with resultType string). </param>
        /// <param name="storedProcedureParameters"> Value and type setting for stored procedure parameters. Example: &quot;{Parameter1: {value: &quot;1&quot;, type: &quot;int&quot;}}&quot;. </param>
        internal SqlServerStoredProcedureActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, object storedProcedureName, object storedProcedureParameters) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            StoredProcedureName = storedProcedureName;
            StoredProcedureParameters = storedProcedureParameters;
            Type = type ?? "SqlServerStoredProcedure";
        }

        /// <summary> Stored procedure name. Type: string (or Expression with resultType string). </summary>
        public object StoredProcedureName { get; set; }
        /// <summary> Value and type setting for stored procedure parameters. Example: &quot;{Parameter1: {value: &quot;1&quot;, type: &quot;int&quot;}}&quot;. </summary>
        public object StoredProcedureParameters { get; set; }
    }
}
