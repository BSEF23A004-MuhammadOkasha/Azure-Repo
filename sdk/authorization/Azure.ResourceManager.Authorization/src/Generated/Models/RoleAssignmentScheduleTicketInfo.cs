// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Ticket Info of the role assignment. </summary>
    public partial class RoleAssignmentScheduleTicketInfo
    {
        /// <summary> Initializes a new instance of RoleAssignmentScheduleTicketInfo. </summary>
        public RoleAssignmentScheduleTicketInfo()
        {
        }

        /// <summary> Initializes a new instance of RoleAssignmentScheduleTicketInfo. </summary>
        /// <param name="ticketNumber"> Ticket number for the role assignment. </param>
        /// <param name="ticketSystem"> Ticket system name for the role assignment. </param>
        internal RoleAssignmentScheduleTicketInfo(string ticketNumber, string ticketSystem)
        {
            TicketNumber = ticketNumber;
            TicketSystem = ticketSystem;
        }

        /// <summary> Ticket number for the role assignment. </summary>
        public string TicketNumber { get; set; }
        /// <summary> Ticket system name for the role assignment. </summary>
        public string TicketSystem { get; set; }
    }
}
