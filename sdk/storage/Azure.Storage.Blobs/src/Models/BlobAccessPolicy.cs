﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Azure.Storage.Blobs.Models
{
    /// <summary>
    /// An Access policy for Blob Containers
    /// </summary>
    public partial class BlobAccessPolicy
    {
        /// <summary>
        /// The date-time the policy is active.
        /// This value is non-nullable, please use <see cref="PolicyStartsOn"/>.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public System.DateTimeOffset StartsOn
        {
            get
            {
                return PolicyStartsOn == default ?
                    StartsOn :
                    (DateTimeOffset)PolicyStartsOn;
            }
            set
            {
                PolicyStartsOn = value;
            }
        }

        /// <summary>
        /// The date-time the policy expires.
        /// This value is non-nullable, please use <see cref="PolicyExpiresOn"/>.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public System.DateTimeOffset ExpiresOn
        {
            get
            {
                return PolicyExpiresOn == default ?
                    ExpiresOn :
                    (DateTimeOffset)PolicyExpiresOn;
            }
            set
            {
                PolicyExpiresOn = value;
            }
        }
    }
}
