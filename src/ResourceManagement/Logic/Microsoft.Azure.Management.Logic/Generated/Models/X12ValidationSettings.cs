// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The X12 agreement validation settings.
    /// </summary>
    public partial class X12ValidationSettings
    {
        /// <summary>
        /// Initializes a new instance of the X12ValidationSettings class.
        /// </summary>
        public X12ValidationSettings() { }

        /// <summary>
        /// Initializes a new instance of the X12ValidationSettings class.
        /// </summary>
        public X12ValidationSettings(bool? validateCharacterSet = default(bool?), bool? checkDuplicateInterchangeControlNumber = default(bool?), int? interchangeControlNumberValidityDays = default(int?), bool? checkDuplicateGroupControlNumber = default(bool?), bool? checkDuplicateTransactionSetControlNumber = default(bool?), bool? validateEDITypes = default(bool?), bool? validateXSDTypes = default(bool?), bool? allowLeadingAndTrailingSpacesAndZeroes = default(bool?), bool? trimLeadingAndTrailingSpacesAndZeroes = default(bool?), TrailingSeparatorPolicy? trailingSeparatorPolicy = default(TrailingSeparatorPolicy?))
        {
            ValidateCharacterSet = validateCharacterSet;
            CheckDuplicateInterchangeControlNumber = checkDuplicateInterchangeControlNumber;
            InterchangeControlNumberValidityDays = interchangeControlNumberValidityDays;
            CheckDuplicateGroupControlNumber = checkDuplicateGroupControlNumber;
            CheckDuplicateTransactionSetControlNumber = checkDuplicateTransactionSetControlNumber;
            ValidateEDITypes = validateEDITypes;
            ValidateXSDTypes = validateXSDTypes;
            AllowLeadingAndTrailingSpacesAndZeroes = allowLeadingAndTrailingSpacesAndZeroes;
            TrimLeadingAndTrailingSpacesAndZeroes = trimLeadingAndTrailingSpacesAndZeroes;
            TrailingSeparatorPolicy = trailingSeparatorPolicy;
        }

        /// <summary>
        /// Gets or sets the value indicating whether to validate character
        /// set in the message.
        /// </summary>
        [JsonProperty(PropertyName = "validateCharacterSet")]
        public bool? ValidateCharacterSet { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to check for duplicate
        /// interchange control number.
        /// </summary>
        [JsonProperty(PropertyName = "checkDuplicateInterchangeControlNumber")]
        public bool? CheckDuplicateInterchangeControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the validity period of interchange control number.
        /// </summary>
        [JsonProperty(PropertyName = "interchangeControlNumberValidityDays")]
        public int? InterchangeControlNumberValidityDays { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to check for duplicate
        /// group control number.
        /// </summary>
        [JsonProperty(PropertyName = "checkDuplicateGroupControlNumber")]
        public bool? CheckDuplicateGroupControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to check for duplicate
        /// transaction set control number.
        /// </summary>
        [JsonProperty(PropertyName = "checkDuplicateTransactionSetControlNumber")]
        public bool? CheckDuplicateTransactionSetControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to Whether to validate
        /// EDI types.
        /// </summary>
        [JsonProperty(PropertyName = "validateEDITypes")]
        public bool? ValidateEDITypes { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to Whether to validate
        /// XSD types.
        /// </summary>
        [JsonProperty(PropertyName = "validateXSDTypes")]
        public bool? ValidateXSDTypes { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to allow leading and
        /// trailing spaces and zeroes.
        /// </summary>
        [JsonProperty(PropertyName = "allowLeadingAndTrailingSpacesAndZeroes")]
        public bool? AllowLeadingAndTrailingSpacesAndZeroes { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to trim leading and
        /// trailing spaces and zeroes.
        /// </summary>
        [JsonProperty(PropertyName = "trimLeadingAndTrailingSpacesAndZeroes")]
        public bool? TrimLeadingAndTrailingSpacesAndZeroes { get; set; }

        /// <summary>
        /// Gets or sets the trailing separator policy. Possible values
        /// include: 'NotSpecified', 'NotAllowed', 'Optional', 'Mandatory'
        /// </summary>
        [JsonProperty(PropertyName = "trailingSeparatorPolicy")]
        public TrailingSeparatorPolicy? TrailingSeparatorPolicy { get; set; }

    }
}
