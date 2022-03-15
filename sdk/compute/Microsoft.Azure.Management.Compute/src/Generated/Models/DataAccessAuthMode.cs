// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{

    /// <summary>
    /// Defines values for DataAccessAuthMode.
    /// </summary>
    public static class DataAccessAuthMode
    {
        /// <summary>
        /// When export/upload URL is used, the system checks if the user has
        /// an identity in Azure Active Directory and has necessary permissions
        /// to export/upload the data. Please refer to aka.ms/DisksAzureADAuth.
        /// </summary>
        public const string AzureActiveDirectory = "AzureActiveDirectory";
        /// <summary>
        /// No additional authentication would be performed when accessing
        /// export/upload URL.
        /// </summary>
        public const string None = "None";
    }
}
