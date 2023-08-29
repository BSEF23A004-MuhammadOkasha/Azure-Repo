// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for the task that validates the connection to and provides information about a MongoDB server. </summary>
    public partial class ConnectToMongoDBTaskProperties : ProjectTaskProperties
    {
        /// <summary> Initializes a new instance of <see cref="ConnectToMongoDBTaskProperties"/>. </summary>
        public ConnectToMongoDBTaskProperties()
        {
            Output = new ChangeTrackingList<MongoDBClusterInfo>();
            TaskType = TaskType.ConnectMongoDB;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToMongoDBTaskProperties"/>. </summary>
        /// <param name="taskType"> Task type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the task. This is ignored if submitted. </param>
        /// <param name="commands">
        /// Array of command properties.
        /// Please note <see cref="CommandProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateMISyncCompleteCommandProperties"/>, <see cref="MigrateSyncCompleteCommandProperties"/>, <see cref="MongoDBCancelCommand"/>, <see cref="MongoDBFinishCommand"/> and <see cref="MongoDBRestartCommand"/>.
        /// </param>
        /// <param name="clientData"> Key value pairs of client data to attach meta data information to task. </param>
        /// <param name="input"> Describes a connection to a MongoDB data source. </param>
        /// <param name="output"> An array containing a single MongoDbClusterInfo object. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectToMongoDBTaskProperties(TaskType taskType, IReadOnlyList<ODataError> errors, TaskState? state, IReadOnlyList<CommandProperties> commands, IDictionary<string, string> clientData, MongoDBConnectionInfo input, IReadOnlyList<MongoDBClusterInfo> output, Dictionary<string, BinaryData> rawData) : base(taskType, errors, state, commands, clientData, rawData)
        {
            Input = input;
            Output = output;
            TaskType = taskType;
        }

        /// <summary> Describes a connection to a MongoDB data source. </summary>
        public MongoDBConnectionInfo Input { get; set; }
        /// <summary> An array containing a single MongoDbClusterInfo object. </summary>
        public IReadOnlyList<MongoDBClusterInfo> Output { get; }
    }
}
