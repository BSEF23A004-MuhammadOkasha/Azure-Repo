// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Windows specific update configuration.
    /// </summary>
    public partial class WindowsProperties
    {
        /// <summary>
        /// Initializes a new instance of the WindowsProperties class.
        /// </summary>
        public WindowsProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WindowsProperties class.
        /// </summary>
        /// <param name="includedUpdateClassifications">Update classification
        /// included in the software update configuration. A comma separated
        /// string with required values. Possible values include:
        /// 'Unclassified', 'Critical', 'Security', 'UpdateRollup',
        /// 'FeaturePack', 'ServicePack', 'Definition', 'Tools',
        /// 'Updates'</param>
        /// <param name="excludedKbNumbers">KB numbers excluded from the
        /// software update configuration.</param>
        /// <param name="includedKbNumbers">KB numbers included from the
        /// software update configuration.</param>
        /// <param name="rebootSetting">Reboot setting for the software update
        /// configuration.</param>
        public WindowsProperties(string includedUpdateClassifications = default(string), IList<string> excludedKbNumbers = default(IList<string>), IList<string> includedKbNumbers = default(IList<string>), string rebootSetting = default(string))
        {
            IncludedUpdateClassifications = includedUpdateClassifications;
            ExcludedKbNumbers = excludedKbNumbers;
            IncludedKbNumbers = includedKbNumbers;
            RebootSetting = rebootSetting;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets update classification included in the software update
        /// configuration. A comma separated string with required values.
        /// Possible values include: 'Unclassified', 'Critical', 'Security',
        /// 'UpdateRollup', 'FeaturePack', 'ServicePack', 'Definition',
        /// 'Tools', 'Updates'
        /// </summary>
        [JsonProperty(PropertyName = "includedUpdateClassifications")]
        public string IncludedUpdateClassifications { get; set; }

        /// <summary>
        /// Gets or sets KB numbers excluded from the software update
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "excludedKbNumbers")]
        public IList<string> ExcludedKbNumbers { get; set; }

        /// <summary>
        /// Gets or sets KB numbers included from the software update
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "includedKbNumbers")]
        public IList<string> IncludedKbNumbers { get; set; }

        /// <summary>
        /// Gets or sets reboot setting for the software update configuration.
        /// </summary>
        [JsonProperty(PropertyName = "rebootSetting")]
        public string RebootSetting { get; set; }

    }
}
