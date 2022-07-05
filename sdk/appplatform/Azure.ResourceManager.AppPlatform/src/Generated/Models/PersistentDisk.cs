// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Persistent disk payload. </summary>
    public partial class PersistentDisk
    {
        /// <summary> Initializes a new instance of PersistentDisk. </summary>
        public PersistentDisk()
        {
        }

        /// <summary> Initializes a new instance of PersistentDisk. </summary>
        /// <param name="sizeInGB"> Size of the persistent disk in GB. </param>
        /// <param name="usedInGB"> Size of the used persistent disk in GB. </param>
        /// <param name="mountPath"> Mount path of the persistent disk. </param>
        internal PersistentDisk(int? sizeInGB, int? usedInGB, string mountPath)
        {
            SizeInGB = sizeInGB;
            UsedInGB = usedInGB;
            MountPath = mountPath;
        }

        /// <summary> Size of the persistent disk in GB. </summary>
        public int? SizeInGB { get; set; }
        /// <summary> Size of the used persistent disk in GB. </summary>
        public int? UsedInGB { get; }
        /// <summary> Mount path of the persistent disk. </summary>
        public string MountPath { get; set; }
    }
}
