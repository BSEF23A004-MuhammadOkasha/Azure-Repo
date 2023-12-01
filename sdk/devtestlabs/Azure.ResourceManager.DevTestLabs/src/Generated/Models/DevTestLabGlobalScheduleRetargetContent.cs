// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties for retargeting a virtual machine schedule. </summary>
    public partial class DevTestLabGlobalScheduleRetargetContent
    {
        /// <summary> Initializes a new instance of <see cref="DevTestLabGlobalScheduleRetargetContent"/>. </summary>
        public DevTestLabGlobalScheduleRetargetContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabGlobalScheduleRetargetContent"/>. </summary>
        /// <param name="currentResourceId"> The resource Id of the virtual machine on which the schedule operates. </param>
        /// <param name="targetResourceId"> The resource Id of the virtual machine that the schedule should be retargeted to. </param>
        internal DevTestLabGlobalScheduleRetargetContent(ResourceIdentifier currentResourceId, ResourceIdentifier targetResourceId)
        {
            CurrentResourceId = currentResourceId;
            TargetResourceId = targetResourceId;
        }

        /// <summary> The resource Id of the virtual machine on which the schedule operates. </summary>
        public ResourceIdentifier CurrentResourceId { get; set; }
        /// <summary> The resource Id of the virtual machine that the schedule should be retargeted to. </summary>
        public ResourceIdentifier TargetResourceId { get; set; }
    }
}
