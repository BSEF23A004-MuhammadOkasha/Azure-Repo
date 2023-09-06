// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Health.Insights.CancerProfiling
{
    /// <summary> A piece of clinical information, expressed as a code in a clinical coding system. </summary>
    public partial class ClinicalCodedElement
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of ClinicalCodedElement. </summary>
        /// <param name="system"> The clinical coding system, e.g. ICD-10, SNOMED-CT, UMLS. </param>
        /// <param name="code"> The code within the given clinical coding system. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="system"/> or <paramref name="code"/> is null. </exception>
        public ClinicalCodedElement(string system, string code)
        {
            Argument.AssertNotNull(system, nameof(system));
            Argument.AssertNotNull(code, nameof(code));

            System = system;
            Code = code;
        }

        /// <summary> Initializes a new instance of ClinicalCodedElement. </summary>
        /// <param name="system"> The clinical coding system, e.g. ICD-10, SNOMED-CT, UMLS. </param>
        /// <param name="code"> The code within the given clinical coding system. </param>
        /// <param name="name"> The name of this coded concept in the coding system. </param>
        /// <param name="value"> A value associated with the code within the given clinical coding system. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ClinicalCodedElement(string system, string code, string name, string value, Dictionary<string, BinaryData> rawData)
        {
            System = system;
            Code = code;
            Name = name;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalCodedElement"/> for deserialization. </summary>
        internal ClinicalCodedElement()
        {
        }

        /// <summary> The clinical coding system, e.g. ICD-10, SNOMED-CT, UMLS. </summary>
        public string System { get; set; }
        /// <summary> The code within the given clinical coding system. </summary>
        public string Code { get; set; }
        /// <summary> The name of this coded concept in the coding system. </summary>
        public string Name { get; set; }
        /// <summary> A value associated with the code within the given clinical coding system. </summary>
        public string Value { get; set; }
    }
}
