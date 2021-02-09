namespace Azure.Communication.PhoneNumbers
{
    public partial class PhoneNumbersClient
    {
        protected PhoneNumbersClient() { }
        public PhoneNumbersClient(string connectionString) { }
        public PhoneNumbersClient(string connectionString, Azure.Communication.PhoneNumbers.PhoneNumbersClientOptions options) { }
        public PhoneNumbersClient(System.Uri endpoint, Azure.AzureKeyCredential keyCredential, Azure.Communication.PhoneNumbers.PhoneNumbersClientOptions options = null) { }
        public PhoneNumbersClient(System.Uri endpoint, Azure.Core.TokenCredential tokenCredential, Azure.Communication.PhoneNumbers.PhoneNumbersClientOptions options = null) { }
        public virtual Azure.Response<Azure.Communication.PhoneNumbers.Models.AcquiredPhoneNumber> GetPhoneNumber(string phoneNumber, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.PhoneNumbers.Models.AcquiredPhoneNumber>> GetPhoneNumberAsync(string phoneNumber, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.Communication.PhoneNumbers.Models.AcquiredPhoneNumber> ListPhoneNumbers(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Communication.PhoneNumbers.Models.AcquiredPhoneNumber> ListPhoneNumbersAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Communication.PhoneNumbers.Models.PurchasePhoneNumbersOperation StartPurchasePhoneNumbers(string searchId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Communication.PhoneNumbers.Models.PurchasePhoneNumbersOperation> StartPurchasePhoneNumbersAsync(string searchId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Communication.PhoneNumbers.Models.ReleasePhoneNumberOperation StartReleasePhoneNumber(string phoneNumber, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Communication.PhoneNumbers.Models.ReleasePhoneNumberOperation> StartReleasePhoneNumberAsync(string phoneNumber, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Communication.PhoneNumbers.Models.SearchAvailablePhoneNumbersOperation StartSearchAvailablePhoneNumbers(string threeLetterISOCountryName, Azure.Communication.PhoneNumbers.Models.PhoneNumberSearchRequest searchRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Communication.PhoneNumbers.Models.SearchAvailablePhoneNumbersOperation> StartSearchAvailablePhoneNumbersAsync(string threeLetterISOCountryName, Azure.Communication.PhoneNumbers.Models.PhoneNumberSearchRequest searchRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Communication.PhoneNumbers.Models.UpdateCapabilitiesOperation StartUpdateCapabilities(string phoneNumber, Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue? calling = default(Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue?), Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue? sms = default(Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Communication.PhoneNumbers.Models.UpdateCapabilitiesOperation> StartUpdateCapabilitiesAsync(string phoneNumber, Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue? calling = default(Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue?), Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue? sms = default(Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class PhoneNumbersClientOptions : Azure.Core.ClientOptions
    {
        public const Azure.Communication.PhoneNumbers.PhoneNumbersClientOptions.ServiceVersion LatestVersion = Azure.Communication.PhoneNumbers.PhoneNumbersClientOptions.ServiceVersion.V2021_03_07;
        public PhoneNumbersClientOptions(Azure.Communication.PhoneNumbers.PhoneNumbersClientOptions.ServiceVersion version = Azure.Communication.PhoneNumbers.PhoneNumbersClientOptions.ServiceVersion.V2021_03_07) { }
        public enum ServiceVersion
        {
            V2021_03_07 = 1,
        }
    }
}
namespace Azure.Communication.PhoneNumbers.Models
{
    public partial class AcquiredPhoneNumber
    {
        internal AcquiredPhoneNumber() { }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType AssignmentType { get { throw null; } }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilities Capabilities { get { throw null; } }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberCost Cost { get { throw null; } }
        public string CountryCode { get { throw null; } }
        public string Id { get { throw null; } }
        public string PhoneNumber { get { throw null; } }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberType PhoneNumberType { get { throw null; } }
        public System.DateTimeOffset? PurchaseDate { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingFrequency : System.IEquatable<Azure.Communication.PhoneNumbers.Models.BillingFrequency>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingFrequency(string value) { throw null; }
        public static Azure.Communication.PhoneNumbers.Models.BillingFrequency Monthly { get { throw null; } }
        public bool Equals(Azure.Communication.PhoneNumbers.Models.BillingFrequency other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.PhoneNumbers.Models.BillingFrequency left, Azure.Communication.PhoneNumbers.Models.BillingFrequency right) { throw null; }
        public static implicit operator Azure.Communication.PhoneNumbers.Models.BillingFrequency (string value) { throw null; }
        public static bool operator !=(Azure.Communication.PhoneNumbers.Models.BillingFrequency left, Azure.Communication.PhoneNumbers.Models.BillingFrequency right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CommunicationError
    {
        internal CommunicationError() { }
        public string Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Communication.PhoneNumbers.Models.CommunicationError> Details { get { throw null; } }
        public Azure.Communication.PhoneNumbers.Models.CommunicationError InnerError { get { throw null; } }
        public string Message { get { throw null; } }
        public string Target { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PhoneNumberAssignmentType : System.IEquatable<Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PhoneNumberAssignmentType(string value) { throw null; }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType Application { get { throw null; } }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType User { get { throw null; } }
        public bool Equals(Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType left, Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType right) { throw null; }
        public static implicit operator Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType (string value) { throw null; }
        public static bool operator !=(Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType left, Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PhoneNumberCapabilities
    {
        public PhoneNumberCapabilities(Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue calling, Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue sms) { }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue Calling { get { throw null; } set { } }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue Sms { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PhoneNumberCapabilityValue : System.IEquatable<Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PhoneNumberCapabilityValue(string value) { throw null; }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue Inbound { get { throw null; } }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue InboundOutbound { get { throw null; } }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue None { get { throw null; } }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue Outbound { get { throw null; } }
        public bool Equals(Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue left, Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue right) { throw null; }
        public static implicit operator Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue (string value) { throw null; }
        public static bool operator !=(Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue left, Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilityValue right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PhoneNumberCost
    {
        internal PhoneNumberCost() { }
        public double Amount { get { throw null; } }
        public Azure.Communication.PhoneNumbers.Models.BillingFrequency BillingFrequency { get { throw null; } }
        public string ISOCurrencySymbol { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PhoneNumberOperationStatus : System.IEquatable<Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PhoneNumberOperationStatus(string value) { throw null; }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationStatus Failed { get { throw null; } }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationStatus NotStarted { get { throw null; } }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationStatus Running { get { throw null; } }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationStatus left, Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationStatus right) { throw null; }
        public static implicit operator Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationStatus (string value) { throw null; }
        public static bool operator !=(Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationStatus left, Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PhoneNumberOperationType : System.IEquatable<Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PhoneNumberOperationType(string value) { throw null; }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationType Purchase { get { throw null; } }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationType ReleasePhoneNumber { get { throw null; } }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationType Search { get { throw null; } }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationType UpdatePhoneNumberCapabilities { get { throw null; } }
        public bool Equals(Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationType left, Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationType right) { throw null; }
        public static implicit operator Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationType (string value) { throw null; }
        public static bool operator !=(Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationType left, Azure.Communication.PhoneNumbers.Models.PhoneNumberOperationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PhoneNumberSearchRequest
    {
        public PhoneNumberSearchRequest(Azure.Communication.PhoneNumbers.Models.PhoneNumberType phoneNumberType, Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType assignmentType, Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilities capabilities) { }
        public string AreaCode { get { throw null; } set { } }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType AssignmentType { get { throw null; } }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilities Capabilities { get { throw null; } }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberType PhoneNumberType { get { throw null; } }
        public int? Quantity { get { throw null; } set { } }
    }
    public partial class PhoneNumberSearchResult
    {
        internal PhoneNumberSearchResult() { }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType AssignmentType { get { throw null; } }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilities Capabilities { get { throw null; } }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberCost Cost { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> PhoneNumbers { get { throw null; } }
        public Azure.Communication.PhoneNumbers.Models.PhoneNumberType PhoneNumberType { get { throw null; } }
        public System.DateTimeOffset? SearchExpiresBy { get { throw null; } }
        public string SearchId { get { throw null; } }
    }
    public static partial class PhoneNumbersModelFactory
    {
        public static Azure.Communication.PhoneNumbers.Models.AcquiredPhoneNumber AcquiredPhoneNumber(string id, string phoneNumber, string countryCode, Azure.Communication.PhoneNumbers.Models.PhoneNumberType phoneNumberType, Azure.Communication.PhoneNumbers.Models.PhoneNumberCapabilities capabilities, Azure.Communication.PhoneNumbers.Models.PhoneNumberAssignmentType assignmentType, System.DateTimeOffset? purchaseDate, string callbackUri, string applicationId, Azure.Communication.PhoneNumbers.Models.PhoneNumberCost cost) { throw null; }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberCost PhoneNumberCost(double amount, string currencyCode, string billingFrequency) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PhoneNumberType : System.IEquatable<Azure.Communication.PhoneNumbers.Models.PhoneNumberType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PhoneNumberType(string value) { throw null; }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberType Geographic { get { throw null; } }
        public static Azure.Communication.PhoneNumbers.Models.PhoneNumberType TollFree { get { throw null; } }
        public bool Equals(Azure.Communication.PhoneNumbers.Models.PhoneNumberType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.PhoneNumbers.Models.PhoneNumberType left, Azure.Communication.PhoneNumbers.Models.PhoneNumberType right) { throw null; }
        public static implicit operator Azure.Communication.PhoneNumbers.Models.PhoneNumberType (string value) { throw null; }
        public static bool operator !=(Azure.Communication.PhoneNumbers.Models.PhoneNumberType left, Azure.Communication.PhoneNumbers.Models.PhoneNumberType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PurchasePhoneNumbersOperation : Azure.Operation<Azure.Communication.PhoneNumbers.Models.PhoneNumberSearchResult>
    {
        internal PurchasePhoneNumbersOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Communication.PhoneNumbers.Models.PhoneNumberSearchResult Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.Communication.PhoneNumbers.Models.PhoneNumberSearchResult>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.Communication.PhoneNumbers.Models.PhoneNumberSearchResult>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ReleasePhoneNumberOperation : Azure.Operation<Azure.Response>
    {
        internal ReleasePhoneNumberOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Response Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.Response>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.Response>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SearchAvailablePhoneNumbersOperation : Azure.Operation<Azure.Communication.PhoneNumbers.Models.PhoneNumberSearchResult>
    {
        internal SearchAvailablePhoneNumbersOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Communication.PhoneNumbers.Models.PhoneNumberSearchResult Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.Communication.PhoneNumbers.Models.PhoneNumberSearchResult>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.Communication.PhoneNumbers.Models.PhoneNumberSearchResult>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class UpdateCapabilitiesOperation : Azure.Operation<Azure.Communication.PhoneNumbers.Models.AcquiredPhoneNumber>
    {
        internal UpdateCapabilitiesOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Communication.PhoneNumbers.Models.AcquiredPhoneNumber Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.Communication.PhoneNumbers.Models.AcquiredPhoneNumber>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.Communication.PhoneNumbers.Models.AcquiredPhoneNumber>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
