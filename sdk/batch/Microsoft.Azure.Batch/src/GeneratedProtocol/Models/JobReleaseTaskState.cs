// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobReleaseTaskState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobReleaseTaskState
    {
        /// <summary>
        /// The Task is currently running (including retrying).
        /// </summary>
        [EnumMember(Value = "running")]
        Running,
        /// <summary>
        /// The Task has exited with exit code 0, or the Task has exhausted its
        /// retry limit, or the Batch service was unable to start the Task due
        /// to Task preparation errors (such as resource file download
        /// failures).
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed
    }
    internal static class JobReleaseTaskStateEnumExtension
    {
        internal static string ToSerializedValue(this JobReleaseTaskState? value)
        {
            return value == null ? null : ((JobReleaseTaskState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobReleaseTaskState value)
        {
            switch( value )
            {
                case JobReleaseTaskState.Running:
                    return "running";
                case JobReleaseTaskState.Completed:
                    return "completed";
            }
            return null;
        }

        internal static JobReleaseTaskState? ParseJobReleaseTaskState(this string value)
        {
            switch( value )
            {
                case "running":
                    return JobReleaseTaskState.Running;
                case "completed":
                    return JobReleaseTaskState.Completed;
            }
            return null;
        }
    }
}
