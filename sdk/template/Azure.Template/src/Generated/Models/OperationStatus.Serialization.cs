// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace Azure.Template.Models
{
    internal static class OperationStatusExtensions
    {
        public static string ToSerialString(this OperationStatus value) => value switch
        {
            OperationStatus.NotStarted => "notStarted",
            OperationStatus.Running => "running",
            OperationStatus.Succeeded => "succeeded",
            OperationStatus.Failed => "failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OperationStatus value.")
        };

        public static OperationStatus ToOperationStatus(this string value) => value switch
        {
            "notStarted" => OperationStatus.NotStarted,
            "running" => OperationStatus.Running,
            "succeeded" => OperationStatus.Succeeded,
            "failed" => OperationStatus.Failed,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OperationStatus value.")
        };
    }
}
