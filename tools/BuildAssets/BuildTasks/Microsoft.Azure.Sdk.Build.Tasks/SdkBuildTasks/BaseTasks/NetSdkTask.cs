﻿namespace Microsoft.Azure.Sdk.Build.Tasks.BaseTasks
{
    using System;
    using Microsoft.Build.Utilities;
    using Microsoft.Azure.Sdk.Build.Tasks.Utilities;
    using Microsoft.Build.Framework;

    public abstract class NetSdkTask : Task, INetSdkTask
    {
        NetSdkTaskLogger _taskLogger;
        string _netSdkTaskName;
        public bool DebugTrace { get; set; }

        public string BuildScope { get; set; }

        public virtual string NetSdkTaskName { get { return "NetSdkTask"; } }

        /// <summary>
        /// Task instance of each derived task.
        /// This is required for the base services like TaskLogger to be provided from the base class.
        /// </summary>
        protected abstract INetSdkTask TaskInstance { get; }

        internal virtual NetSdkTaskLogger TaskLogger
        {
            get
            {
                if(_taskLogger == null)
                {
                    _taskLogger = new NetSdkTaskLogger(TaskInstance, DebugTrace);
                }

                return _taskLogger;
            }
        }

        public override bool Execute()
        {
            throw new NotImplementedException();
        }
    }

    public interface INetSdkTask : ITask
    {
        string NetSdkTaskName { get; }
    }
}
