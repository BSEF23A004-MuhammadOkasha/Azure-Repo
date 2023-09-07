// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Body of a reset password request. </summary>
    public partial class LabVirtualMachineResetPasswordContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineResetPasswordContent"/>. </summary>
        /// <param name="username"> The user whose password is being reset. </param>
        /// <param name="password"> The password. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> or <paramref name="password"/> is null. </exception>
        public LabVirtualMachineResetPasswordContent(string username, string password)
        {
            Argument.AssertNotNull(username, nameof(username));
            Argument.AssertNotNull(password, nameof(password));

            Username = username;
            Password = password;
        }

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineResetPasswordContent"/>. </summary>
        /// <param name="username"> The user whose password is being reset. </param>
        /// <param name="password"> The password. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LabVirtualMachineResetPasswordContent(string username, string password, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Username = username;
            Password = password;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineResetPasswordContent"/> for deserialization. </summary>
        internal LabVirtualMachineResetPasswordContent()
        {
        }

        /// <summary> The user whose password is being reset. </summary>
        public string Username { get; }
        /// <summary> The password. </summary>
        public string Password { get; }
    }
}
