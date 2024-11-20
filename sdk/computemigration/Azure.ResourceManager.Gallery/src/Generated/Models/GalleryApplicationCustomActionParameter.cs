// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Gallery.Models
{
    /// <summary> The definition of a parameter that can be passed to a custom action of a Gallery Application Version. </summary>
    public partial class GalleryApplicationCustomActionParameter
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationCustomActionParameter"/>. </summary>
        /// <param name="name"> The name of the custom action.  Must be unique within the Gallery Application Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public GalleryApplicationCustomActionParameter(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationCustomActionParameter"/>. </summary>
        /// <param name="name"> The name of the custom action.  Must be unique within the Gallery Application Version. </param>
        /// <param name="isRequired"> Indicates whether this parameter must be passed when running the custom action. </param>
        /// <param name="parameterType"> Specifies the type of the custom action parameter. Possible values are: String, ConfigurationDataBlob or LogOutputBlob. </param>
        /// <param name="defaultValue"> The default value of the parameter.  Only applies to string types. </param>
        /// <param name="description"> A description to help users understand what this parameter means. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryApplicationCustomActionParameter(string name, bool? isRequired, GalleryApplicationCustomActionParameterType? parameterType, string defaultValue, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            IsRequired = isRequired;
            ParameterType = parameterType;
            DefaultValue = defaultValue;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationCustomActionParameter"/> for deserialization. </summary>
        internal GalleryApplicationCustomActionParameter()
        {
        }

        /// <summary> The name of the custom action.  Must be unique within the Gallery Application Version. </summary>
        public string Name { get; set; }
        /// <summary> Indicates whether this parameter must be passed when running the custom action. </summary>
        public bool? IsRequired { get; set; }
        /// <summary> Specifies the type of the custom action parameter. Possible values are: String, ConfigurationDataBlob or LogOutputBlob. </summary>
        public GalleryApplicationCustomActionParameterType? ParameterType { get; set; }
        /// <summary> The default value of the parameter.  Only applies to string types. </summary>
        public string DefaultValue { get; set; }
        /// <summary> A description to help users understand what this parameter means. </summary>
        public string Description { get; set; }
    }
}
