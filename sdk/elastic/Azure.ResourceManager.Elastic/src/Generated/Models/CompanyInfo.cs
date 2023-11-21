// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> Company information of the user to be passed to partners. </summary>
    public partial class CompanyInfo
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

        /// <summary> Initializes a new instance of <see cref="CompanyInfo"/>. </summary>
        public CompanyInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CompanyInfo"/>. </summary>
        /// <param name="domain"> Domain of the company. </param>
        /// <param name="business"> Business of the company. </param>
        /// <param name="employeesNumber"> Number of employees in the company. </param>
        /// <param name="state"> State of the company location. </param>
        /// <param name="country"> Country of the company location. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CompanyInfo(string domain, string business, string employeesNumber, string state, string country, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Domain = domain;
            Business = business;
            EmployeesNumber = employeesNumber;
            State = state;
            Country = country;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Domain of the company. </summary>
        public string Domain { get; set; }
        /// <summary> Business of the company. </summary>
        public string Business { get; set; }
        /// <summary> Number of employees in the company. </summary>
        public string EmployeesNumber { get; set; }
        /// <summary> State of the company location. </summary>
        public string State { get; set; }
        /// <summary> Country of the company location. </summary>
        public string Country { get; set; }
    }
}
