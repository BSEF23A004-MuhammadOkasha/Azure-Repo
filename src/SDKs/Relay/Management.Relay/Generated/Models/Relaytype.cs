// %~6

namespace Microsoft.Azure.Management.Relay.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Relay;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Relaytype.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Relaytype
    {
        [EnumMember(Value = "NetTcp")]
        NetTcp,
        [EnumMember(Value = "Http")]
        Http
    }
}
