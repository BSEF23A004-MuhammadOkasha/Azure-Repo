// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The workflow trigger cron for ComputeStartStop schedule type. </summary>
    public partial class ComputeStartStopCronSchedule
    {
        /// <summary> Initializes a new instance of ComputeStartStopCronSchedule. </summary>
        public ComputeStartStopCronSchedule()
        {
        }

        /// <summary> Initializes a new instance of ComputeStartStopCronSchedule. </summary>
        /// <param name="startTime"> The start time in yyyy-MM-ddTHH:mm:ss format. </param>
        /// <param name="timeZone">
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </param>
        /// <param name="expression">
        /// [Required] Specifies cron expression of schedule.
        /// The expression should follow NCronTab format.
        /// </param>
        internal ComputeStartStopCronSchedule(string startTime, string timeZone, string expression)
        {
            StartTime = startTime;
            TimeZone = timeZone;
            Expression = expression;
        }

        /// <summary> The start time in yyyy-MM-ddTHH:mm:ss format. </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </summary>
        public string TimeZone { get; set; }
        /// <summary>
        /// [Required] Specifies cron expression of schedule.
        /// The expression should follow NCronTab format.
        /// </summary>
        public string Expression { get; set; }
    }
}
