// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    /// <summary> An Azure Storage Queue. </summary>
    public partial class QueueItem
    {
        /// <summary> Initializes a new instance of QueueItem. </summary>
        /// <param name="name"> The name of the Queue. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal QueueItem(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of QueueItem. </summary>
        /// <param name="name"> The name of the Queue. </param>
        /// <param name="metadata"> Dictionary of &lt;string&gt;. </param>
        internal QueueItem(string name, IDictionary<string, string> metadata)
        {
            Name = name;
            Metadata = metadata;
        }
    }
}
