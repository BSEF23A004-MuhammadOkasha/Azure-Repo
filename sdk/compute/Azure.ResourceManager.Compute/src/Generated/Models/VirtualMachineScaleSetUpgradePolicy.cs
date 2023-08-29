// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes an upgrade policy - automatic, manual, or rolling. </summary>
    public partial class VirtualMachineScaleSetUpgradePolicy
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpgradePolicy"/>. </summary>
        public VirtualMachineScaleSetUpgradePolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpgradePolicy"/>. </summary>
        /// <param name="mode"> Specifies the mode of an upgrade to virtual machines in the scale set.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the application of updates to virtual machines in the scale set. You do this by using the manualUpgrade action.&lt;br /&gt;&lt;br /&gt; **Automatic** - All virtual machines in the scale set are  automatically updated at the same time. </param>
        /// <param name="rollingUpgradePolicy"> The configuration parameters used while performing a rolling upgrade. </param>
        /// <param name="automaticOSUpgradePolicy"> Configuration parameters used for performing automatic OS Upgrade. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetUpgradePolicy(VirtualMachineScaleSetUpgradeMode? mode, RollingUpgradePolicy rollingUpgradePolicy, AutomaticOSUpgradePolicy automaticOSUpgradePolicy, Dictionary<string, BinaryData> rawData)
        {
            Mode = mode;
            RollingUpgradePolicy = rollingUpgradePolicy;
            AutomaticOSUpgradePolicy = automaticOSUpgradePolicy;
            _rawData = rawData;
        }

        /// <summary> Specifies the mode of an upgrade to virtual machines in the scale set.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the application of updates to virtual machines in the scale set. You do this by using the manualUpgrade action.&lt;br /&gt;&lt;br /&gt; **Automatic** - All virtual machines in the scale set are  automatically updated at the same time. </summary>
        public VirtualMachineScaleSetUpgradeMode? Mode { get; set; }
        /// <summary> The configuration parameters used while performing a rolling upgrade. </summary>
        public RollingUpgradePolicy RollingUpgradePolicy { get; set; }
        /// <summary> Configuration parameters used for performing automatic OS Upgrade. </summary>
        public AutomaticOSUpgradePolicy AutomaticOSUpgradePolicy { get; set; }
    }
}
