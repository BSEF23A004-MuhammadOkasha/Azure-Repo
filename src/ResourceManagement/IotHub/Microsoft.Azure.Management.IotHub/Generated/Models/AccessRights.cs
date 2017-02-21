// MIT

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AccessRights.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccessRights
    {
        [EnumMember(Value = "RegistryRead")]
        RegistryRead,
        [EnumMember(Value = "RegistryWrite")]
        RegistryWrite,
        [EnumMember(Value = "ServiceConnect")]
        ServiceConnect,
        [EnumMember(Value = "DeviceConnect")]
        DeviceConnect,
        [EnumMember(Value = "RegistryRead, RegistryWrite")]
        RegistryReadRegistryWrite,
        [EnumMember(Value = "RegistryRead, ServiceConnect")]
        RegistryReadServiceConnect,
        [EnumMember(Value = "RegistryRead, DeviceConnect")]
        RegistryReadDeviceConnect,
        [EnumMember(Value = "RegistryWrite, ServiceConnect")]
        RegistryWriteServiceConnect,
        [EnumMember(Value = "RegistryWrite, DeviceConnect")]
        RegistryWriteDeviceConnect,
        [EnumMember(Value = "ServiceConnect, DeviceConnect")]
        ServiceConnectDeviceConnect,
        [EnumMember(Value = "RegistryRead, RegistryWrite, ServiceConnect")]
        RegistryReadRegistryWriteServiceConnect,
        [EnumMember(Value = "RegistryRead, RegistryWrite, DeviceConnect")]
        RegistryReadRegistryWriteDeviceConnect,
        [EnumMember(Value = "RegistryRead, ServiceConnect, DeviceConnect")]
        RegistryReadServiceConnectDeviceConnect,
        [EnumMember(Value = "RegistryWrite, ServiceConnect, DeviceConnect")]
        RegistryWriteServiceConnectDeviceConnect,
        [EnumMember(Value = "RegistryRead, RegistryWrite, ServiceConnect, DeviceConnect")]
        RegistryReadRegistryWriteServiceConnectDeviceConnect
    }
}
