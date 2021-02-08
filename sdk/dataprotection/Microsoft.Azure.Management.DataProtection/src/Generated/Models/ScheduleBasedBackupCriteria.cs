// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ScheduleBasedBackupCriteria
    /// </summary>
    /// <remarks>
    /// Schedule based backup criteria
    /// </remarks>
    [Newtonsoft.Json.JsonObject("ScheduleBasedBackupCriteria")]
    public partial class ScheduleBasedBackupCriteria : BackupCriteria
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleBasedBackupCriteria
        /// class.
        /// </summary>
        public ScheduleBasedBackupCriteria()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleBasedBackupCriteria
        /// class.
        /// </summary>
        /// <param name="absoluteCriteria">it contains absolute values like
        /// "AllBackup" / "FirstOfDay" / "FirstOfWeek" / "FirstOfMonth"
        /// and should be part of AbsoluteMarker enum</param>
        /// <param name="daysOfMonth">This is day of the month from 1 to 28
        /// other wise last of month</param>
        /// <param name="daysOfTheWeek">It should be
        /// Sunday/Monday/T..../Saturday</param>
        /// <param name="monthsOfYear">It should be
        /// January/February/....../December</param>
        /// <param name="scheduleTimes">List of schedule times for
        /// backup</param>
        /// <param name="weeksOfTheMonth">It should be
        /// First/Second/Third/Fourth/Last</param>
        public ScheduleBasedBackupCriteria(IList<string> absoluteCriteria = default(IList<string>), IList<Day> daysOfMonth = default(IList<Day>), IList<string> daysOfTheWeek = default(IList<string>), IList<string> monthsOfYear = default(IList<string>), IList<System.DateTime?> scheduleTimes = default(IList<System.DateTime?>), IList<string> weeksOfTheMonth = default(IList<string>))
        {
            AbsoluteCriteria = absoluteCriteria;
            DaysOfMonth = daysOfMonth;
            DaysOfTheWeek = daysOfTheWeek;
            MonthsOfYear = monthsOfYear;
            ScheduleTimes = scheduleTimes;
            WeeksOfTheMonth = weeksOfTheMonth;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets it contains absolute values like "AllBackup" /
        /// "FirstOfDay" / "FirstOfWeek" / "FirstOfMonth"
        /// and should be part of AbsoluteMarker enum
        /// </summary>
        [JsonProperty(PropertyName = "absoluteCriteria")]
        public IList<string> AbsoluteCriteria { get; set; }

        /// <summary>
        /// Gets or sets this is day of the month from 1 to 28 other wise last
        /// of month
        /// </summary>
        [JsonProperty(PropertyName = "daysOfMonth")]
        public IList<Day> DaysOfMonth { get; set; }

        /// <summary>
        /// Gets or sets it should be Sunday/Monday/T..../Saturday
        /// </summary>
        [JsonProperty(PropertyName = "daysOfTheWeek")]
        public IList<string> DaysOfTheWeek { get; set; }

        /// <summary>
        /// Gets or sets it should be January/February/....../December
        /// </summary>
        [JsonProperty(PropertyName = "monthsOfYear")]
        public IList<string> MonthsOfYear { get; set; }

        /// <summary>
        /// Gets or sets list of schedule times for backup
        /// </summary>
        [JsonProperty(PropertyName = "scheduleTimes")]
        public IList<System.DateTime?> ScheduleTimes { get; set; }

        /// <summary>
        /// Gets or sets it should be First/Second/Third/Fourth/Last
        /// </summary>
        [JsonProperty(PropertyName = "weeksOfTheMonth")]
        public IList<string> WeeksOfTheMonth { get; set; }

    }
}
