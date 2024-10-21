// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// For schedules like: &apos;recur every month on the 15th&apos; or
/// &apos;recur every 3 months on the 20th&apos;.
/// </summary>
public partial class ContainerServiceMaintenanceAbsoluteMonthlySchedule : ProvisionableConstruct
{
    /// <summary>
    /// Specifies the number of months between each set of occurrences.
    /// </summary>
    public BicepValue<int> IntervalMonths { get => _intervalMonths; set => _intervalMonths.Assign(value); }
    private readonly BicepValue<int> _intervalMonths;

    /// <summary>
    /// The date of the month.
    /// </summary>
    public BicepValue<int> DayOfMonth { get => _dayOfMonth; set => _dayOfMonth.Assign(value); }
    private readonly BicepValue<int> _dayOfMonth;

    /// <summary>
    /// Creates a new ContainerServiceMaintenanceAbsoluteMonthlySchedule.
    /// </summary>
    public ContainerServiceMaintenanceAbsoluteMonthlySchedule()
    {
        _intervalMonths = BicepValue<int>.DefineProperty(this, "IntervalMonths", ["intervalMonths"]);
        _dayOfMonth = BicepValue<int>.DefineProperty(this, "DayOfMonth", ["dayOfMonth"]);
    }
}
