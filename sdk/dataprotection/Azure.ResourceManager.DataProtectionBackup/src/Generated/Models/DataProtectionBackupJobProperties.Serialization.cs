// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBackupJobProperties : IUtf8JsonSerializable, IModelJsonSerializable<DataProtectionBackupJobProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataProtectionBackupJobProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataProtectionBackupJobProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionBackupJobProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("activityID"u8);
            writer.WriteStringValue(ActivityId);
            writer.WritePropertyName("backupInstanceFriendlyName"u8);
            writer.WriteStringValue(BackupInstanceFriendlyName);
            writer.WritePropertyName("dataSourceId"u8);
            writer.WriteStringValue(DataSourceId);
            writer.WritePropertyName("dataSourceLocation"u8);
            writer.WriteStringValue(DataSourceLocation);
            writer.WritePropertyName("dataSourceName"u8);
            writer.WriteStringValue(DataSourceName);
            if (Optional.IsDefined(DataSourceSetName))
            {
                writer.WritePropertyName("dataSourceSetName"u8);
                writer.WriteStringValue(DataSourceSetName);
            }
            writer.WritePropertyName("dataSourceType"u8);
            writer.WriteStringValue(DataSourceType);
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "c");
            }
            writer.WritePropertyName("isUserTriggered"u8);
            writer.WriteBooleanValue(IsUserTriggered);
            writer.WritePropertyName("operation"u8);
            writer.WriteStringValue(Operation);
            writer.WritePropertyName("operationCategory"u8);
            writer.WriteStringValue(OperationCategory);
            writer.WritePropertyName("progressEnabled"u8);
            writer.WriteBooleanValue(IsProgressEnabled);
            writer.WritePropertyName("sourceResourceGroup"u8);
            writer.WriteStringValue(SourceResourceGroup);
            writer.WritePropertyName("sourceSubscriptionID"u8);
            writer.WriteStringValue(SourceSubscriptionId);
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status);
            writer.WritePropertyName("subscriptionId"u8);
            writer.WriteStringValue(SubscriptionId);
            writer.WritePropertyName("supportedActions"u8);
            writer.WriteStartArray();
            foreach (var item in SupportedActions)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("vaultName"u8);
            writer.WriteStringValue(VaultName);
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(SourceDataStoreName))
            {
                writer.WritePropertyName("sourceDataStoreName"u8);
                writer.WriteStringValue(SourceDataStoreName);
            }
            if (Optional.IsDefined(DestinationDataStoreName))
            {
                writer.WritePropertyName("destinationDataStoreName"u8);
                writer.WriteStringValue(DestinationDataStoreName);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static DataProtectionBackupJobProperties DeserializeDataProtectionBackupJobProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string activityId = default;
            string backupInstanceFriendlyName = default;
            Optional<ResourceIdentifier> backupInstanceId = default;
            ResourceIdentifier dataSourceId = default;
            AzureLocation dataSourceLocation = default;
            string dataSourceName = default;
            Optional<string> dataSourceSetName = default;
            string dataSourceType = default;
            Optional<TimeSpan> duration = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<IReadOnlyList<ResponseError>> errorDetails = default;
            Optional<BackupJobExtendedInfo> extendedInfo = default;
            bool isUserTriggered = default;
            string operation = default;
            string operationCategory = default;
            Optional<ResourceIdentifier> policyId = default;
            Optional<string> policyName = default;
            bool progressEnabled = default;
            Optional<Uri> progressUrl = default;
            Optional<string> restoreType = default;
            string sourceResourceGroup = default;
            string sourceSubscriptionId = default;
            DateTimeOffset startTime = default;
            string status = default;
            string subscriptionId = default;
            IList<string> supportedActions = default;
            string vaultName = default;
            Optional<ETag> etag = default;
            Optional<string> sourceDataStoreName = default;
            Optional<string> destinationDataStoreName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activityID"u8))
                {
                    activityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupInstanceFriendlyName"u8))
                {
                    backupInstanceFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupInstanceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupInstanceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceId"u8))
                {
                    dataSourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceLocation"u8))
                {
                    dataSourceLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceName"u8))
                {
                    dataSourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceSetName"u8))
                {
                    dataSourceSetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceType"u8))
                {
                    dataSourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResponseError> array = new List<ResponseError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<ResponseError>(item.GetRawText()));
                    }
                    errorDetails = array;
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = BackupJobExtendedInfo.DeserializeBackupJobExtendedInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("isUserTriggered"u8))
                {
                    isUserTriggered = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("operation"u8))
                {
                    operation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationCategory"u8))
                {
                    operationCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("progressEnabled"u8))
                {
                    progressEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("progressUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("restoreType"u8))
                {
                    restoreType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceResourceGroup"u8))
                {
                    sourceResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceSubscriptionID"u8))
                {
                    sourceSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedActions"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedActions = array;
                    continue;
                }
                if (property.NameEquals("vaultName"u8))
                {
                    vaultName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceDataStoreName"u8))
                {
                    sourceDataStoreName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationDataStoreName"u8))
                {
                    destinationDataStoreName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataProtectionBackupJobProperties(activityId, backupInstanceFriendlyName, backupInstanceId.Value, dataSourceId, dataSourceLocation, dataSourceName, dataSourceSetName.Value, dataSourceType, Optional.ToNullable(duration), Optional.ToNullable(endTime), Optional.ToList(errorDetails), extendedInfo.Value, isUserTriggered, operation, operationCategory, policyId.Value, policyName.Value, progressEnabled, progressUrl.Value, restoreType.Value, sourceResourceGroup, sourceSubscriptionId, startTime, status, subscriptionId, supportedActions, vaultName, Optional.ToNullable(etag), sourceDataStoreName.Value, destinationDataStoreName.Value, rawData);
        }

        DataProtectionBackupJobProperties IModelJsonSerializable<DataProtectionBackupJobProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionBackupJobProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupJobProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataProtectionBackupJobProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionBackupJobProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataProtectionBackupJobProperties IModelSerializable<DataProtectionBackupJobProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionBackupJobProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataProtectionBackupJobProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataProtectionBackupJobProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataProtectionBackupJobProperties"/> to convert. </param>
        public static implicit operator RequestContent(DataProtectionBackupJobProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataProtectionBackupJobProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataProtectionBackupJobProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataProtectionBackupJobProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
