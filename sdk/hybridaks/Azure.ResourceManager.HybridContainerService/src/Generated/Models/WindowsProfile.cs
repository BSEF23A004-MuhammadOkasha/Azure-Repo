// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> WindowsProfile - Profile for Windows VMs in the container service cluster. </summary>
    public partial class WindowsProfile : WindowsProfileResponse
    {
        /// <summary> Initializes a new instance of <see cref="WindowsProfile"/>. </summary>
        public WindowsProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WindowsProfile"/>. </summary>
        /// <param name="adminUsername"> AdminUsername - Specifies the name of the administrator account. &lt;br&gt;&lt;br&gt; **restriction:** Cannot end in "." &lt;br&gt;&lt;br&gt; **Disallowed values:** "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console", "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5". &lt;br&gt;&lt;br&gt; **Minimum-length:** 1 character &lt;br&gt;&lt;br&gt; **Max-length:** 20 characters. </param>
        /// <param name="enableCsiProxy"> EnableCSIProxy - Whether to enable CSI proxy. </param>
        /// <param name="licenseType"> LicenseType - The licenseType to use for Windows VMs. Windows_Server is used to enable Azure Hybrid User Benefits for Windows VMs. Possible values include: 'None', 'Windows_Server'. </param>
        /// <param name="adminPassword"> AdminPassword - Specifies the password of the administrator account. &lt;br&gt;&lt;br&gt; **Minimum-length:** 8 characters &lt;br&gt;&lt;br&gt; **Max-length:** 123 characters &lt;br&gt;&lt;br&gt; **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled &lt;br&gt; Has lower characters &lt;br&gt;Has upper characters &lt;br&gt; Has a digit &lt;br&gt; Has a special character (Regex match [\W_]) &lt;br&gt;&lt;br&gt; **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WindowsProfile(string adminUsername, bool? enableCsiProxy, LicenseType? licenseType, string adminPassword, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(adminUsername, enableCsiProxy, licenseType, serializedAdditionalRawData)
        {
            AdminPassword = adminPassword;
        }

        /// <summary> AdminPassword - Specifies the password of the administrator account. &lt;br&gt;&lt;br&gt; **Minimum-length:** 8 characters &lt;br&gt;&lt;br&gt; **Max-length:** 123 characters &lt;br&gt;&lt;br&gt; **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled &lt;br&gt; Has lower characters &lt;br&gt;Has upper characters &lt;br&gt; Has a digit &lt;br&gt; Has a special character (Regex match [\W_]) &lt;br&gt;&lt;br&gt; **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!". </summary>
        public string AdminPassword { get; set; }
    }
}
