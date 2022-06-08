// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Validate messages of the configuration service git repositories. </summary>
    public partial class ValidationMessages
    {
        /// <summary> Initializes a new instance of <see cref="ValidationMessages"/>. </summary>
        internal ValidationMessages()
        {
            Messages = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ValidationMessages"/>. </summary>
        /// <param name="name"> The name of the configuration service git repository. </param>
        /// <param name="messages"> Detailed validation messages. </param>
        internal ValidationMessages(string name, IReadOnlyList<string> messages)
        {
            Name = name;
            Messages = messages;
        }

        /// <summary> The name of the configuration service git repository. </summary>
        public string Name { get; }
        /// <summary> Detailed validation messages. </summary>
        public IReadOnlyList<string> Messages { get; }
    }
}
