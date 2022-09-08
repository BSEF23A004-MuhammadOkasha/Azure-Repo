// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Alert modification item. </summary>
    public partial class ServiceAlertModificationItemInfo
    {
        /// <summary> Initializes a new instance of ServiceAlertModificationItemInfo. </summary>
        public ServiceAlertModificationItemInfo()
        {
        }

        /// <summary> Initializes a new instance of ServiceAlertModificationItemInfo. </summary>
        /// <param name="modificationEvent"> Reason for the modification. </param>
        /// <param name="oldValue"> Old value. </param>
        /// <param name="newValue"> New value. </param>
        /// <param name="modifiedAt"> Modified date and time. </param>
        /// <param name="modifiedBy"> Modified user details (Principal client name). </param>
        /// <param name="comments"> Modification comments. </param>
        /// <param name="description"> Description of the modification. </param>
        internal ServiceAlertModificationItemInfo(ServiceAlertModificationEvent? modificationEvent, string oldValue, string newValue, string modifiedAt, string modifiedBy, string comments, string description)
        {
            ModificationEvent = modificationEvent;
            OldValue = oldValue;
            NewValue = newValue;
            ModifiedAt = modifiedAt;
            ModifiedBy = modifiedBy;
            Comments = comments;
            Description = description;
        }

        /// <summary> Reason for the modification. </summary>
        public ServiceAlertModificationEvent? ModificationEvent { get; set; }
        /// <summary> Old value. </summary>
        public string OldValue { get; set; }
        /// <summary> New value. </summary>
        public string NewValue { get; set; }
        /// <summary> Modified date and time. </summary>
        public string ModifiedAt { get; set; }
        /// <summary> Modified user details (Principal client name). </summary>
        public string ModifiedBy { get; set; }
        /// <summary> Modification comments. </summary>
        public string Comments { get; set; }
        /// <summary> Description of the modification. </summary>
        public string Description { get; set; }
    }
}
