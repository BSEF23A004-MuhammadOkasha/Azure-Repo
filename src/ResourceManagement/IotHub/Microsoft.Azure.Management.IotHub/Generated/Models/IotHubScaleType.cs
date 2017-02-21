// MIT

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IotHubScaleType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IotHubScaleType
    {
        [EnumMember(Value = "Automatic")]
        Automatic,
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "None")]
        None
    }
}
