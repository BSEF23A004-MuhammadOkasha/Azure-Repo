// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Daily retention format. </summary>
    internal partial class DailyRetentionFormat
    {
        /// <summary> Initializes a new instance of DailyRetentionFormat. </summary>
        public DailyRetentionFormat()
        {
            DaysOfTheMonth = new ChangeTrackingList<BackupDay>();
        }

        /// <summary> Initializes a new instance of DailyRetentionFormat. </summary>
        /// <param name="daysOfTheMonth"> List of days of the month. </param>
        internal DailyRetentionFormat(IList<BackupDay> daysOfTheMonth)
        {
            DaysOfTheMonth = daysOfTheMonth;
        }

        /// <summary> List of days of the month. </summary>
        public IList<BackupDay> DaysOfTheMonth { get; }
    }
}
