// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> A class representing the KeyValue data model. </summary>
    public partial class KeyValueData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="KeyValueData"/>. </summary>
        public KeyValueData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="KeyValueData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="key">
        /// The primary identifier of a key-value.
        /// The key is used in unison with the label to uniquely identify a key-value.
        /// </param>
        /// <param name="label">
        /// A value used to group key-values.
        /// The label is used in unison with the key to uniquely identify a key-value.
        /// </param>
        /// <param name="value"> The value of the key-value. </param>
        /// <param name="contentType">
        /// The content type of the key-value&apos;s value.
        /// Providing a proper content-type can enable transformations of values when they are retrieved by applications.
        /// </param>
        /// <param name="eTag"> An ETag indicating the state of a key-value within a configuration store. </param>
        /// <param name="lastModified"> The last time a modifying operation was performed on the given key-value. </param>
        /// <param name="locked">
        /// A value indicating whether the key-value is locked.
        /// A locked key-value may not be modified until it is unlocked.
        /// </param>
        /// <param name="tags"> A dictionary of tags that can help identify what a key-value may be applicable for. </param>
        internal KeyValueData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string key, string label, string value, string contentType, string eTag, DateTimeOffset? lastModified, bool? locked, IDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            Key = key;
            Label = label;
            Value = value;
            ContentType = contentType;
            ETag = eTag;
            LastModified = lastModified;
            Locked = locked;
            Tags = tags;
        }

        /// <summary>
        /// The primary identifier of a key-value.
        /// The key is used in unison with the label to uniquely identify a key-value.
        /// </summary>
        public string Key { get; }
        /// <summary>
        /// A value used to group key-values.
        /// The label is used in unison with the key to uniquely identify a key-value.
        /// </summary>
        public string Label { get; }
        /// <summary> The value of the key-value. </summary>
        public string Value { get; set; }
        /// <summary>
        /// The content type of the key-value&apos;s value.
        /// Providing a proper content-type can enable transformations of values when they are retrieved by applications.
        /// </summary>
        public string ContentType { get; set; }
        /// <summary> An ETag indicating the state of a key-value within a configuration store. </summary>
        public string ETag { get; }
        /// <summary> The last time a modifying operation was performed on the given key-value. </summary>
        public DateTimeOffset? LastModified { get; }
        /// <summary>
        /// A value indicating whether the key-value is locked.
        /// A locked key-value may not be modified until it is unlocked.
        /// </summary>
        public bool? Locked { get; }
        /// <summary> A dictionary of tags that can help identify what a key-value may be applicable for. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
