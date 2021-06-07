// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a data disk.
    /// </summary>
    public partial class DataDisk
    {
        /// <summary>
        /// Initializes a new instance of the DataDisk class.
        /// </summary>
        public DataDisk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataDisk class.
        /// </summary>
        /// <param name="lun">Specifies the logical unit number of the data
        /// disk. This value is used to identify data disks within the VM and
        /// therefore must be unique for each data disk attached to a
        /// VM.</param>
        /// <param name="createOption">Specifies how the virtual machine should
        /// be created.&lt;br&gt;&lt;br&gt; Possible values
        /// are:&lt;br&gt;&lt;br&gt; **Attach** \u2013 This value is used when
        /// you are using a specialized disk to create the virtual
        /// machine.&lt;br&gt;&lt;br&gt; **FromImage** \u2013 This value is
        /// used when you are using an image to create the virtual machine. If
        /// you are using a platform image, you also use the imageReference
        /// element described above. If you are using a marketplace image, you
        /// also use the plan element previously described. Possible values
        /// include: 'FromImage', 'Empty', 'Attach'</param>
        /// <param name="name">The disk name.</param>
        /// <param name="vhd">The virtual hard disk.</param>
        /// <param name="image">The source user image virtual hard disk. The
        /// virtual hard disk will be copied before being attached to the
        /// virtual machine. If SourceImage is provided, the destination
        /// virtual hard drive must not exist.</param>
        /// <param name="caching">Specifies the caching requirements.
        /// &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt;
        /// **None** &lt;br&gt;&lt;br&gt; **ReadOnly** &lt;br&gt;&lt;br&gt;
        /// **ReadWrite** &lt;br&gt;&lt;br&gt; Default: **None for Standard
        /// storage. ReadOnly for Premium storage**. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'</param>
        /// <param name="writeAcceleratorEnabled">Specifies whether
        /// writeAccelerator should be enabled or disabled on the disk.</param>
        /// <param name="diskSizeGB">Specifies the size of an empty data disk
        /// in gigabytes. This element can be used to overwrite the size of the
        /// disk in a virtual machine image. &lt;br&gt;&lt;br&gt; This value
        /// cannot be larger than 1023 GB</param>
        /// <param name="managedDisk">The managed disk parameters.</param>
        /// <param name="toBeDetached">Specifies whether the data disk is in
        /// process of detachment from the
        /// VirtualMachine/VirtualMachineScaleset</param>
        /// <param name="diskIOPSReadWrite">Specifies the Read-Write IOPS for
        /// the managed disk when StorageAccountType is UltraSSD_LRS. Returned
        /// only for VirtualMachine ScaleSet VM disks. Can be updated only via
        /// updates to the VirtualMachine Scale Set.</param>
        /// <param name="diskMBpsReadWrite">Specifies the bandwidth in MB per
        /// second for the managed disk when StorageAccountType is
        /// UltraSSD_LRS. Returned only for VirtualMachine ScaleSet VM disks.
        /// Can be updated only via updates to the VirtualMachine Scale
        /// Set.</param>
        /// <param name="detachOption">Specifies the detach behavior to be used
        /// while detaching a disk or which is already in the process of
        /// detachment from the virtual machine. Supported values:
        /// **ForceDetach**. &lt;br&gt;&lt;br&gt; detachOption: **ForceDetach**
        /// is applicable only for managed data disks. If a previous detachment
        /// attempt of the data disk did not complete due to an unexpected
        /// failure from the virtual machine and the disk is still not released
        /// then use force-detach as a last resort option to detach the disk
        /// forcibly from the VM. All writes might not have been flushed when
        /// using this detach behavior. &lt;br&gt;&lt;br&gt; This feature is
        /// still in preview mode and is not supported for
        /// VirtualMachineScaleSet. To force-detach a data disk update
        /// toBeDetached to 'true' along with setting detachOption:
        /// 'ForceDetach'. Possible values include: 'ForceDetach'</param>
        /// <param name="deleteOption">Specifies whether data disk should be
        /// deleted or detached upon VM deletion.&lt;br&gt;&lt;br&gt; Possible
        /// values: &lt;br&gt;&lt;br&gt; **Delete** If this value is used, the
        /// data disk is deleted when VM is deleted.&lt;br&gt;&lt;br&gt;
        /// **Detach** If this value is used, the data disk is retained after
        /// VM is deleted.&lt;br&gt;&lt;br&gt; The default value is set to
        /// **detach**. Possible values include: 'Delete', 'Detach'</param>
        public DataDisk(int lun, string createOption, string name = default(string), VirtualHardDisk vhd = default(VirtualHardDisk), VirtualHardDisk image = default(VirtualHardDisk), CachingTypes? caching = default(CachingTypes?), bool? writeAcceleratorEnabled = default(bool?), int? diskSizeGB = default(int?), ManagedDiskParameters managedDisk = default(ManagedDiskParameters), bool? toBeDetached = default(bool?), long? diskIOPSReadWrite = default(long?), long? diskMBpsReadWrite = default(long?), string detachOption = default(string), string deleteOption = default(string))
        {
            Lun = lun;
            Name = name;
            Vhd = vhd;
            Image = image;
            Caching = caching;
            WriteAcceleratorEnabled = writeAcceleratorEnabled;
            CreateOption = createOption;
            DiskSizeGB = diskSizeGB;
            ManagedDisk = managedDisk;
            ToBeDetached = toBeDetached;
            DiskIOPSReadWrite = diskIOPSReadWrite;
            DiskMBpsReadWrite = diskMBpsReadWrite;
            DetachOption = detachOption;
            DeleteOption = deleteOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the logical unit number of the data disk.
        /// This value is used to identify data disks within the VM and
        /// therefore must be unique for each data disk attached to a VM.
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public int Lun { get; set; }

        /// <summary>
        /// Gets or sets the disk name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the virtual hard disk.
        /// </summary>
        [JsonProperty(PropertyName = "vhd")]
        public VirtualHardDisk Vhd { get; set; }

        /// <summary>
        /// Gets or sets the source user image virtual hard disk. The virtual
        /// hard disk will be copied before being attached to the virtual
        /// machine. If SourceImage is provided, the destination virtual hard
        /// drive must not exist.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public VirtualHardDisk Image { get; set; }

        /// <summary>
        /// Gets or sets specifies the caching requirements.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values are:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **None**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **ReadOnly**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **ReadWrite**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Default: **None for Standard
        /// storage. ReadOnly for Premium storage**. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'
        /// </summary>
        [JsonProperty(PropertyName = "caching")]
        public CachingTypes? Caching { get; set; }

        /// <summary>
        /// Gets or sets specifies whether writeAccelerator should be enabled
        /// or disabled on the disk.
        /// </summary>
        [JsonProperty(PropertyName = "writeAcceleratorEnabled")]
        public bool? WriteAcceleratorEnabled { get; set; }

        /// <summary>
        /// Gets or sets specifies how the virtual machine should be
        /// created.&amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values
        /// are:&amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Attach** \u2013 This
        /// value is used when you are using a specialized disk to create the
        /// virtual machine.&amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **FromImage**
        /// \u2013 This value is used when you are using an image to create the
        /// virtual machine. If you are using a platform image, you also use
        /// the imageReference element described above. If you are using a
        /// marketplace image, you  also use the plan element previously
        /// described. Possible values include: 'FromImage', 'Empty', 'Attach'
        /// </summary>
        [JsonProperty(PropertyName = "createOption")]
        public string CreateOption { get; set; }

        /// <summary>
        /// Gets or sets specifies the size of an empty data disk in gigabytes.
        /// This element can be used to overwrite the size of the disk in a
        /// virtual machine image. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; This
        /// value cannot be larger than 1023 GB
        /// </summary>
        [JsonProperty(PropertyName = "diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets the managed disk parameters.
        /// </summary>
        [JsonProperty(PropertyName = "managedDisk")]
        public ManagedDiskParameters ManagedDisk { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the data disk is in process of
        /// detachment from the VirtualMachine/VirtualMachineScaleset
        /// </summary>
        [JsonProperty(PropertyName = "toBeDetached")]
        public bool? ToBeDetached { get; set; }

        /// <summary>
        /// Gets specifies the Read-Write IOPS for the managed disk when
        /// StorageAccountType is UltraSSD_LRS. Returned only for
        /// VirtualMachine ScaleSet VM disks. Can be updated only via updates
        /// to the VirtualMachine Scale Set.
        /// </summary>
        [JsonProperty(PropertyName = "diskIOPSReadWrite")]
        public long? DiskIOPSReadWrite { get; private set; }

        /// <summary>
        /// Gets specifies the bandwidth in MB per second for the managed disk
        /// when StorageAccountType is UltraSSD_LRS. Returned only for
        /// VirtualMachine ScaleSet VM disks. Can be updated only via updates
        /// to the VirtualMachine Scale Set.
        /// </summary>
        [JsonProperty(PropertyName = "diskMBpsReadWrite")]
        public long? DiskMBpsReadWrite { get; private set; }

        /// <summary>
        /// Gets or sets specifies the detach behavior to be used while
        /// detaching a disk or which is already in the process of detachment
        /// from the virtual machine. Supported values: **ForceDetach**.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; detachOption: **ForceDetach**
        /// is applicable only for managed data disks. If a previous detachment
        /// attempt of the data disk did not complete due to an unexpected
        /// failure from the virtual machine and the disk is still not released
        /// then use force-detach as a last resort option to detach the disk
        /// forcibly from the VM. All writes might not have been flushed when
        /// using this detach behavior. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;
        /// This feature is still in preview mode and is not supported for
        /// VirtualMachineScaleSet. To force-detach a data disk update
        /// toBeDetached to 'true' along with setting detachOption:
        /// 'ForceDetach'. Possible values include: 'ForceDetach'
        /// </summary>
        [JsonProperty(PropertyName = "detachOption")]
        public string DetachOption { get; set; }

        /// <summary>
        /// Gets or sets specifies whether data disk should be deleted or
        /// detached upon VM deletion.&amp;lt;br&amp;gt;&amp;lt;br&amp;gt;
        /// Possible values: &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Delete** If
        /// this value is used, the data disk is deleted when VM is
        /// deleted.&amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Detach** If this
        /// value is used, the data disk is retained after VM is
        /// deleted.&amp;lt;br&amp;gt;&amp;lt;br&amp;gt; The default value is
        /// set to **detach**. Possible values include: 'Delete', 'Detach'
        /// </summary>
        [JsonProperty(PropertyName = "deleteOption")]
        public string DeleteOption { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CreateOption == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CreateOption");
            }
        }
    }
}
