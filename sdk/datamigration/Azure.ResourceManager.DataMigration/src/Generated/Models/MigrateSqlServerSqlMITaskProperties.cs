// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for task that migrates SQL Server databases to Azure SQL Database Managed Instance. </summary>
    public partial class MigrateSqlServerSqlMITaskProperties : ProjectTaskProperties
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMITaskProperties"/>. </summary>
        public MigrateSqlServerSqlMITaskProperties()
        {
            Output = new ChangeTrackingList<MigrateSqlServerSqlMITaskOutput>();
            TaskType = TaskType.MigrateSqlServerAzureSqlDBMI;
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMITaskProperties"/>. </summary>
        /// <param name="taskType"> Task type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the task. This is ignored if submitted. </param>
        /// <param name="commands">
        /// Array of command properties.
        /// Please note <see cref="CommandProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateMISyncCompleteCommandProperties"/>, <see cref="MigrateSyncCompleteCommandProperties"/>, <see cref="MongoDBCancelCommand"/>, <see cref="MongoDBFinishCommand"/> and <see cref="MongoDBRestartCommand"/>.
        /// </param>
        /// <param name="clientData"> Key value pairs of client data to attach meta data information to task. </param>
        /// <param name="input"> Task input. </param>
        /// <param name="output">
        /// Task output. This is ignored if submitted.
        /// Please note <see cref="MigrateSqlServerSqlMITaskOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateSqlServerSqlMITaskOutputAgentJobLevel"/>, <see cref="MigrateSqlServerSqlMITaskOutputDatabaseLevel"/>, <see cref="MigrateSqlServerSqlMITaskOutputError"/>, <see cref="MigrateSqlServerSqlMITaskOutputLoginLevel"/> and <see cref="MigrateSqlServerSqlMITaskOutputMigrationLevel"/>.
        /// </param>
        /// <param name="taskId"> task id. </param>
        /// <param name="createdOn"> DateTime in UTC when the task was created. </param>
        /// <param name="parentTaskId"> parent task id. </param>
        /// <param name="isCloneable"> whether the task can be cloned or not. </param>
        internal MigrateSqlServerSqlMITaskProperties(TaskType taskType, IReadOnlyList<ODataError> errors, TaskState? state, IReadOnlyList<CommandProperties> commands, IDictionary<string, string> clientData, MigrateSqlServerSqlMITaskInput input, IReadOnlyList<MigrateSqlServerSqlMITaskOutput> output, string taskId, string createdOn, string parentTaskId, bool? isCloneable) : base(taskType, errors, state, commands, clientData)
        {
            Input = input;
            Output = output;
            TaskId = taskId;
            CreatedOn = createdOn;
            ParentTaskId = parentTaskId;
            IsCloneable = isCloneable;
            TaskType = taskType;
        }

        /// <summary> Task input. </summary>
        public MigrateSqlServerSqlMITaskInput Input { get; set; }
        /// <summary>
        /// Task output. This is ignored if submitted.
        /// Please note <see cref="MigrateSqlServerSqlMITaskOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateSqlServerSqlMITaskOutputAgentJobLevel"/>, <see cref="MigrateSqlServerSqlMITaskOutputDatabaseLevel"/>, <see cref="MigrateSqlServerSqlMITaskOutputError"/>, <see cref="MigrateSqlServerSqlMITaskOutputLoginLevel"/> and <see cref="MigrateSqlServerSqlMITaskOutputMigrationLevel"/>.
        /// </summary>
        public IReadOnlyList<MigrateSqlServerSqlMITaskOutput> Output { get; }
        /// <summary> task id. </summary>
        public string TaskId { get; set; }
        /// <summary> DateTime in UTC when the task was created. </summary>
        public string CreatedOn { get; set; }
        /// <summary> parent task id. </summary>
        public string ParentTaskId { get; set; }
        /// <summary> whether the task can be cloned or not. </summary>
        public bool? IsCloneable { get; set; }
    }
}
