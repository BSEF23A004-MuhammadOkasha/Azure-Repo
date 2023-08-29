// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The source image used for creating the disk. </summary>
    public partial class ImageDiskReference
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ImageDiskReference"/>. </summary>
        public ImageDiskReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageDiskReference"/>. </summary>
        /// <param name="id"> A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image reference. </param>
        /// <param name="sharedGalleryImageId"> A relative uri containing a direct shared Azure Compute Gallery image reference. </param>
        /// <param name="communityGalleryImageId"> A relative uri containing a community Azure Compute Gallery image reference. </param>
        /// <param name="lun"> If the disk is created from an image's data disk, this is an index that indicates which of the data disks in the image to use. For OS disks, this field is null. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageDiskReference(ResourceIdentifier id, string sharedGalleryImageId, string communityGalleryImageId, int? lun, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            SharedGalleryImageId = sharedGalleryImageId;
            CommunityGalleryImageId = communityGalleryImageId;
            Lun = lun;
            _rawData = rawData;
        }

        /// <summary> A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image reference. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> A relative uri containing a direct shared Azure Compute Gallery image reference. </summary>
        public string SharedGalleryImageId { get; set; }
        /// <summary> A relative uri containing a community Azure Compute Gallery image reference. </summary>
        public string CommunityGalleryImageId { get; set; }
        /// <summary> If the disk is created from an image's data disk, this is an index that indicates which of the data disks in the image to use. For OS disks, this field is null. </summary>
        public int? Lun { get; set; }
    }
}
