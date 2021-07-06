// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> HDInsight Pig activity type. </summary>
    public partial class HDInsightPigActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of HDInsightPigActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public HDInsightPigActivity(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            StorageLinkedServices = new ChangeTrackingList<LinkedServiceReference>();
            Defines = new ChangeTrackingDictionary<string, object>();
            Type = "HDInsightPig";
        }

        /// <summary> Initializes a new instance of HDInsightPigActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="storageLinkedServices"> Storage linked service references. </param>
        /// <param name="arguments"> User specified arguments to HDInsightActivity. Type: array (or Expression with resultType array). </param>
        /// <param name="getDebugInfo"> Debug info option. </param>
        /// <param name="scriptPath"> Script path. Type: string (or Expression with resultType string). </param>
        /// <param name="scriptLinkedService"> Script linked service reference. </param>
        /// <param name="defines"> Allows user to specify defines for Pig job request. </param>
        internal HDInsightPigActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, IList<LinkedServiceReference> storageLinkedServices, object arguments, HDInsightActivityDebugInfoOption? getDebugInfo, object scriptPath, LinkedServiceReference scriptLinkedService, IDictionary<string, object> defines) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            ScriptPath = scriptPath;
            ScriptLinkedService = scriptLinkedService;
            Defines = defines;
            Type = type ?? "HDInsightPig";
        }

        /// <summary> Storage linked service references. </summary>
        public IList<LinkedServiceReference> StorageLinkedServices { get; }
        /// <summary> User specified arguments to HDInsightActivity. Type: array (or Expression with resultType array). </summary>
        public object Arguments { get; set; }
        /// <summary> Debug info option. </summary>
        public HDInsightActivityDebugInfoOption? GetDebugInfo { get; set; }
        /// <summary> Script path. Type: string (or Expression with resultType string). </summary>
        public object ScriptPath { get; set; }
        /// <summary> Script linked service reference. </summary>
        public LinkedServiceReference ScriptLinkedService { get; set; }
        /// <summary> Allows user to specify defines for Pig job request. </summary>
        public IDictionary<string, object> Defines { get; }
    }
}
