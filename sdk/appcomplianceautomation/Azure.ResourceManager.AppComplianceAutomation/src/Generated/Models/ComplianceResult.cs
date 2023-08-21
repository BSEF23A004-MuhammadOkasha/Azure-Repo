// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> A class represent the compliance result. </summary>
    public partial class ComplianceResult
    {
        /// <summary> Initializes a new instance of ComplianceResult. </summary>
        internal ComplianceResult()
        {
            Categories = new Core.ChangeTrackingList<Category>();
        }

        /// <summary> Initializes a new instance of ComplianceResult. </summary>
        /// <param name="complianceName"> The name of the compliance. e.g. "M365". </param>
        /// <param name="categories"> List of categories. </param>
        internal ComplianceResult(string complianceName, IReadOnlyList<Category> categories)
        {
            ComplianceName = complianceName;
            Categories = categories;
        }

        /// <summary> The name of the compliance. e.g. "M365". </summary>
        public string ComplianceName { get; }
        /// <summary> List of categories. </summary>
        public IReadOnlyList<Category> Categories { get; }
    }
}
