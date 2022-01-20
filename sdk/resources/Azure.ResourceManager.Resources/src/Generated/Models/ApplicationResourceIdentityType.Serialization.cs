// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    internal static partial class ApplicationResourceIdentityTypeExtensions
    {
        public static string ToSerialString(this ApplicationResourceIdentityType value) => value switch
        {
            ApplicationResourceIdentityType.SystemAssigned => "SystemAssigned",
            ApplicationResourceIdentityType.UserAssigned => "UserAssigned",
            ApplicationResourceIdentityType.SystemAssignedUserAssigned => "SystemAssigned, UserAssigned",
            ApplicationResourceIdentityType.None => "None",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ApplicationResourceIdentityType value.")
        };

        public static ApplicationResourceIdentityType ToApplicationResourceIdentityType(this string value)
        {
            if (string.Equals(value, "SystemAssigned", StringComparison.InvariantCultureIgnoreCase)) return ApplicationResourceIdentityType.SystemAssigned;
            if (string.Equals(value, "UserAssigned", StringComparison.InvariantCultureIgnoreCase)) return ApplicationResourceIdentityType.UserAssigned;
            if (string.Equals(value, "SystemAssigned, UserAssigned", StringComparison.InvariantCultureIgnoreCase)) return ApplicationResourceIdentityType.SystemAssignedUserAssigned;
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return ApplicationResourceIdentityType.None;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ApplicationResourceIdentityType value.");
        }
    }
}
