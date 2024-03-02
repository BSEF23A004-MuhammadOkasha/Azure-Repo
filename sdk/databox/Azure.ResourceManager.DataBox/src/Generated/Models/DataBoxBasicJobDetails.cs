// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary>
    /// Job details.
    /// Please note <see cref="DataBoxBasicJobDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataBoxJobDetails"/>, <see cref="DataBoxCustomerDiskJobDetails"/>, <see cref="DataBoxDiskJobDetails"/> and <see cref="DataBoxHeavyJobDetails"/>.
    /// </summary>
    public abstract partial class DataBoxBasicJobDetails
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxBasicJobDetails"/>. </summary>
        /// <param name="contactDetails"> Contact details for notification and shipping. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contactDetails"/> is null. </exception>
        protected DataBoxBasicJobDetails(DataBoxContactDetails contactDetails)
        {
            if (contactDetails == null)
            {
                throw new ArgumentNullException(nameof(contactDetails));
            }

            JobStages = new ChangeTrackingList<DataBoxJobStage>();
            ContactDetails = contactDetails;
            DataImportDetails = new ChangeTrackingList<DataImportDetails>();
            DataExportDetails = new ChangeTrackingList<DataExportDetails>();
            CopyLogDetails = new ChangeTrackingList<CopyLogDetails>();
            Actions = new ChangeTrackingList<CustomerResolutionCode>();
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxBasicJobDetails"/>. </summary>
        /// <param name="jobStages"> List of stages that run in the job. </param>
        /// <param name="contactDetails"> Contact details for notification and shipping. </param>
        /// <param name="shippingAddress"> Shipping address of the customer. </param>
        /// <param name="deliveryPackage"> Delivery package shipping details. </param>
        /// <param name="returnPackage"> Return package shipping details. </param>
        /// <param name="dataImportDetails"> Details of the data to be imported into azure. </param>
        /// <param name="dataExportDetails"> Details of the data to be exported from azure. </param>
        /// <param name="jobDetailsType"> Indicates the type of job details. </param>
        /// <param name="preferences"> Preferences for the order. </param>
        /// <param name="reverseShippingDetails"> Optional Reverse Shipping details for order. </param>
        /// <param name="copyLogDetails">
        /// List of copy log details.
        /// Please note <see cref="Models.CopyLogDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataBoxAccountCopyLogDetails"/>, <see cref="DataBoxCustomerDiskCopyLogDetails"/>, <see cref="DataBoxDiskCopyLogDetails"/> and <see cref="DataBoxHeavyAccountCopyLogDetails"/>.
        /// </param>
        /// <param name="reverseShipmentLabelSasKey"> Shared access key to download the return shipment label. </param>
        /// <param name="chainOfCustodySasKey"> Shared access key to download the chain of custody logs. </param>
        /// <param name="deviceErasureDetails"> Holds device data erasure details. </param>
        /// <param name="keyEncryptionKey"> Details about which key encryption type is being used. </param>
        /// <param name="expectedDataSizeInTerabytes"> The expected size of the data, which needs to be transferred in this job, in terabytes. </param>
        /// <param name="actions"> Available actions on the job. </param>
        /// <param name="lastMitigationActionOnJob"> Last mitigation action performed on the job. </param>
        /// <param name="dataCenterAddress">
        /// Datacenter address to ship to, for the given sku and storage location.
        /// Please note <see cref="DataCenterAddressResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataCenterAddressInstructionResult"/> and <see cref="DataCenterAddressLocationResult"/>.
        /// </param>
        /// <param name="dataCenterCode"> DataCenter code. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxBasicJobDetails(IReadOnlyList<DataBoxJobStage> jobStages, DataBoxContactDetails contactDetails, DataBoxShippingAddress shippingAddress, PackageShippingDetails deliveryPackage, PackageShippingDetails returnPackage, IList<DataImportDetails> dataImportDetails, IList<DataExportDetails> dataExportDetails, DataBoxOrderType jobDetailsType, DataBoxOrderPreferences preferences, ReverseShippingDetails reverseShippingDetails, IReadOnlyList<CopyLogDetails> copyLogDetails, string reverseShipmentLabelSasKey, string chainOfCustodySasKey, DeviceErasureDetails deviceErasureDetails, DataBoxKeyEncryptionKey keyEncryptionKey, int? expectedDataSizeInTerabytes, IReadOnlyList<CustomerResolutionCode> actions, LastMitigationActionOnJob lastMitigationActionOnJob, DataCenterAddressResult dataCenterAddress, DataCenterCode? dataCenterCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            JobStages = jobStages;
            ContactDetails = contactDetails;
            ShippingAddress = shippingAddress;
            DeliveryPackage = deliveryPackage;
            ReturnPackage = returnPackage;
            DataImportDetails = dataImportDetails;
            DataExportDetails = dataExportDetails;
            JobDetailsType = jobDetailsType;
            Preferences = preferences;
            ReverseShippingDetails = reverseShippingDetails;
            CopyLogDetails = copyLogDetails;
            ReverseShipmentLabelSasKey = reverseShipmentLabelSasKey;
            ChainOfCustodySasKey = chainOfCustodySasKey;
            DeviceErasureDetails = deviceErasureDetails;
            KeyEncryptionKey = keyEncryptionKey;
            ExpectedDataSizeInTerabytes = expectedDataSizeInTerabytes;
            Actions = actions;
            LastMitigationActionOnJob = lastMitigationActionOnJob;
            DataCenterAddress = dataCenterAddress;
            DataCenterCode = dataCenterCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxBasicJobDetails"/> for deserialization. </summary>
        internal DataBoxBasicJobDetails()
        {
        }

        /// <summary> List of stages that run in the job. </summary>
        public IReadOnlyList<DataBoxJobStage> JobStages { get; }
        /// <summary> Contact details for notification and shipping. </summary>
        public DataBoxContactDetails ContactDetails { get; set; }
        /// <summary> Shipping address of the customer. </summary>
        public DataBoxShippingAddress ShippingAddress { get; set; }
        /// <summary> Delivery package shipping details. </summary>
        public PackageShippingDetails DeliveryPackage { get; }
        /// <summary> Return package shipping details. </summary>
        public PackageShippingDetails ReturnPackage { get; }
        /// <summary> Details of the data to be imported into azure. </summary>
        public IList<DataImportDetails> DataImportDetails { get; }
        /// <summary> Details of the data to be exported from azure. </summary>
        public IList<DataExportDetails> DataExportDetails { get; }
        /// <summary> Indicates the type of job details. </summary>
        internal DataBoxOrderType JobDetailsType { get; set; }
        /// <summary> Preferences for the order. </summary>
        public DataBoxOrderPreferences Preferences { get; set; }
        /// <summary> Optional Reverse Shipping details for order. </summary>
        public ReverseShippingDetails ReverseShippingDetails { get; set; }
        /// <summary>
        /// List of copy log details.
        /// Please note <see cref="Models.CopyLogDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataBoxAccountCopyLogDetails"/>, <see cref="DataBoxCustomerDiskCopyLogDetails"/>, <see cref="DataBoxDiskCopyLogDetails"/> and <see cref="DataBoxHeavyAccountCopyLogDetails"/>.
        /// </summary>
        public IReadOnlyList<CopyLogDetails> CopyLogDetails { get; }
        /// <summary> Shared access key to download the return shipment label. </summary>
        public string ReverseShipmentLabelSasKey { get; }
        /// <summary> Shared access key to download the chain of custody logs. </summary>
        public string ChainOfCustodySasKey { get; }
        /// <summary> Holds device data erasure details. </summary>
        public DeviceErasureDetails DeviceErasureDetails { get; }
        /// <summary> Details about which key encryption type is being used. </summary>
        public DataBoxKeyEncryptionKey KeyEncryptionKey { get; set; }
        /// <summary> The expected size of the data, which needs to be transferred in this job, in terabytes. </summary>
        public int? ExpectedDataSizeInTerabytes { get; set; }
        /// <summary> Available actions on the job. </summary>
        public IReadOnlyList<CustomerResolutionCode> Actions { get; }
        /// <summary> Last mitigation action performed on the job. </summary>
        public LastMitigationActionOnJob LastMitigationActionOnJob { get; }
        /// <summary>
        /// Datacenter address to ship to, for the given sku and storage location.
        /// Please note <see cref="DataCenterAddressResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataCenterAddressInstructionResult"/> and <see cref="DataCenterAddressLocationResult"/>.
        /// </summary>
        public DataCenterAddressResult DataCenterAddress { get; }
        /// <summary> DataCenter code. </summary>
        public DataCenterCode? DataCenterCode { get; }
    }
}
