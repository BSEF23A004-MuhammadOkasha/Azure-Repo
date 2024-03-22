// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class HDInsightOnDemandLinkedService : IUtf8JsonSerializable, IJsonModel<HDInsightOnDemandLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightOnDemandLinkedService>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightOnDemandLinkedService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightOnDemandLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightOnDemandLinkedService)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LinkedServiceType);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue<IntegrationRuntimeReference>(ConnectVia, options);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue<EntityParameterSpecification>(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("clusterSize"u8);
            JsonSerializer.Serialize(writer, ClusterSize);
            writer.WritePropertyName("timeToLive"u8);
            JsonSerializer.Serialize(writer, TimeToLiveExpression);
            writer.WritePropertyName("version"u8);
            JsonSerializer.Serialize(writer, Version);
            writer.WritePropertyName("linkedServiceName"u8);
            JsonSerializer.Serialize(writer, LinkedServiceName);
            writer.WritePropertyName("hostSubscriptionId"u8);
            JsonSerializer.Serialize(writer, HostSubscriptionId);
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalKey);
            }
            writer.WritePropertyName("tenant"u8);
            JsonSerializer.Serialize(writer, Tenant);
            writer.WritePropertyName("clusterResourceGroup"u8);
            JsonSerializer.Serialize(writer, ClusterResourceGroup);
            if (Optional.IsDefined(ClusterNamePrefix))
            {
                writer.WritePropertyName("clusterNamePrefix"u8);
                JsonSerializer.Serialize(writer, ClusterNamePrefix);
            }
            if (Optional.IsDefined(ClusterUserName))
            {
                writer.WritePropertyName("clusterUserName"u8);
                JsonSerializer.Serialize(writer, ClusterUserName);
            }
            if (Optional.IsDefined(ClusterPassword))
            {
                writer.WritePropertyName("clusterPassword"u8);
                JsonSerializer.Serialize(writer, ClusterPassword);
            }
            if (Optional.IsDefined(ClusterSshUserName))
            {
                writer.WritePropertyName("clusterSshUserName"u8);
                JsonSerializer.Serialize(writer, ClusterSshUserName);
            }
            if (Optional.IsDefined(ClusterSshPassword))
            {
                writer.WritePropertyName("clusterSshPassword"u8);
                JsonSerializer.Serialize(writer, ClusterSshPassword);
            }
            if (Optional.IsCollectionDefined(AdditionalLinkedServiceNames))
            {
                writer.WritePropertyName("additionalLinkedServiceNames"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalLinkedServiceNames)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HcatalogLinkedServiceName))
            {
                writer.WritePropertyName("hcatalogLinkedServiceName"u8);
                JsonSerializer.Serialize(writer, HcatalogLinkedServiceName);
            }
            if (Optional.IsDefined(ClusterType))
            {
                writer.WritePropertyName("clusterType"u8);
                JsonSerializer.Serialize(writer, ClusterType);
            }
            if (Optional.IsDefined(SparkVersion))
            {
                writer.WritePropertyName("sparkVersion"u8);
                JsonSerializer.Serialize(writer, SparkVersion);
            }
            if (Optional.IsDefined(CoreConfiguration))
            {
                writer.WritePropertyName("coreConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CoreConfiguration);
#else
                using (JsonDocument document = JsonDocument.Parse(CoreConfiguration))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(HBaseConfiguration))
            {
                writer.WritePropertyName("hBaseConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(HBaseConfiguration);
#else
                using (JsonDocument document = JsonDocument.Parse(HBaseConfiguration))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(HdfsConfiguration))
            {
                writer.WritePropertyName("hdfsConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(HdfsConfiguration);
#else
                using (JsonDocument document = JsonDocument.Parse(HdfsConfiguration))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(HiveConfiguration))
            {
                writer.WritePropertyName("hiveConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(HiveConfiguration);
#else
                using (JsonDocument document = JsonDocument.Parse(HiveConfiguration))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(MapReduceConfiguration))
            {
                writer.WritePropertyName("mapReduceConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MapReduceConfiguration);
#else
                using (JsonDocument document = JsonDocument.Parse(MapReduceConfiguration))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(OozieConfiguration))
            {
                writer.WritePropertyName("oozieConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(OozieConfiguration);
#else
                using (JsonDocument document = JsonDocument.Parse(OozieConfiguration))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(StormConfiguration))
            {
                writer.WritePropertyName("stormConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(StormConfiguration);
#else
                using (JsonDocument document = JsonDocument.Parse(StormConfiguration))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(YarnConfiguration))
            {
                writer.WritePropertyName("yarnConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(YarnConfiguration);
#else
                using (JsonDocument document = JsonDocument.Parse(YarnConfiguration))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteStringValue(EncryptedCredential);
            }
            if (Optional.IsDefined(HeadNodeSize))
            {
                writer.WritePropertyName("headNodeSize"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(HeadNodeSize);
#else
                using (JsonDocument document = JsonDocument.Parse(HeadNodeSize))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(DataNodeSize))
            {
                writer.WritePropertyName("dataNodeSize"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DataNodeSize);
#else
                using (JsonDocument document = JsonDocument.Parse(DataNodeSize))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(ZookeeperNodeSize))
            {
                writer.WritePropertyName("zookeeperNodeSize"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ZookeeperNodeSize);
#else
                using (JsonDocument document = JsonDocument.Parse(ZookeeperNodeSize))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(ScriptActions))
            {
                writer.WritePropertyName("scriptActions"u8);
                writer.WriteStartArray();
                foreach (var item in ScriptActions)
                {
                    writer.WriteObjectValue<DataFactoryScriptAction>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VirtualNetworkId))
            {
                writer.WritePropertyName("virtualNetworkId"u8);
                JsonSerializer.Serialize(writer, VirtualNetworkId);
            }
            if (Optional.IsDefined(SubnetName))
            {
                writer.WritePropertyName("subnetName"u8);
                JsonSerializer.Serialize(writer, SubnetName);
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue<DataFactoryCredentialReference>(Credential, options);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        HDInsightOnDemandLinkedService IJsonModel<HDInsightOnDemandLinkedService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightOnDemandLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightOnDemandLinkedService)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightOnDemandLinkedService(document.RootElement, options);
        }

        internal static HDInsightOnDemandLinkedService DeserializeHDInsightOnDemandLinkedService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            IntegrationRuntimeReference connectVia = default;
            string description = default;
            IDictionary<string, EntityParameterSpecification> parameters = default;
            IList<BinaryData> annotations = default;
            DataFactoryElement<int> clusterSize = default;
            DataFactoryElement<string> timeToLive = default;
            DataFactoryElement<string> version = default;
            DataFactoryLinkedServiceReference linkedServiceName = default;
            DataFactoryElement<string> hostSubscriptionId = default;
            DataFactoryElement<string> servicePrincipalId = default;
            DataFactorySecret servicePrincipalKey = default;
            DataFactoryElement<string> tenant = default;
            DataFactoryElement<string> clusterResourceGroup = default;
            DataFactoryElement<string> clusterNamePrefix = default;
            DataFactoryElement<string> clusterUserName = default;
            DataFactorySecret clusterPassword = default;
            DataFactoryElement<string> clusterSshUserName = default;
            DataFactorySecret clusterSshPassword = default;
            IList<DataFactoryLinkedServiceReference> additionalLinkedServiceNames = default;
            DataFactoryLinkedServiceReference hcatalogLinkedServiceName = default;
            DataFactoryElement<string> clusterType = default;
            DataFactoryElement<string> sparkVersion = default;
            BinaryData coreConfiguration = default;
            BinaryData hBaseConfiguration = default;
            BinaryData hdfsConfiguration = default;
            BinaryData hiveConfiguration = default;
            BinaryData mapReduceConfiguration = default;
            BinaryData oozieConfiguration = default;
            BinaryData stormConfiguration = default;
            BinaryData yarnConfiguration = default;
            string encryptedCredential = default;
            BinaryData headNodeSize = default;
            BinaryData dataNodeSize = default;
            BinaryData zookeeperNodeSize = default;
            IList<DataFactoryScriptAction> scriptActions = default;
            DataFactoryElement<string> virtualNetworkId = default;
            DataFactoryElement<string> subnetName = default;
            DataFactoryCredentialReference credential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("clusterSize"u8))
                        {
                            clusterSize = JsonSerializer.Deserialize<DataFactoryElement<int>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("timeToLive"u8))
                        {
                            timeToLive = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("linkedServiceName"u8))
                        {
                            linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hostSubscriptionId"u8))
                        {
                            hostSubscriptionId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalKey = JsonSerializer.Deserialize<DataFactorySecret>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("tenant"u8))
                        {
                            tenant = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterResourceGroup"u8))
                        {
                            clusterResourceGroup = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterNamePrefix"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterNamePrefix = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterUserName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterUserName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterPassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterPassword = JsonSerializer.Deserialize<DataFactorySecret>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterSshUserName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterSshUserName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterSshPassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterSshPassword = JsonSerializer.Deserialize<DataFactorySecret>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("additionalLinkedServiceNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataFactoryLinkedServiceReference> array = new List<DataFactoryLinkedServiceReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(item.GetRawText()));
                            }
                            additionalLinkedServiceNames = array;
                            continue;
                        }
                        if (property0.NameEquals("hcatalogLinkedServiceName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hcatalogLinkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterType = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sparkVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sparkVersion = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("coreConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coreConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hBaseConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hBaseConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hdfsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hdfsConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hiveConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hiveConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("mapReduceConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mapReduceConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("oozieConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            oozieConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("stormConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stormConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("yarnConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            yarnConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            encryptedCredential = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("headNodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            headNodeSize = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("dataNodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataNodeSize = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("zookeeperNodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zookeeperNodeSize = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("scriptActions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataFactoryScriptAction> array = new List<DataFactoryScriptAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataFactoryScriptAction.DeserializeDataFactoryScriptAction(item, options));
                            }
                            scriptActions = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("subnetName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = DataFactoryCredentialReference.DeserializeDataFactoryCredentialReference(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HDInsightOnDemandLinkedService(
                type,
                connectVia,
                description,
                parameters ?? new ChangeTrackingDictionary<string, EntityParameterSpecification>(),
                annotations ?? new ChangeTrackingList<BinaryData>(),
                additionalProperties,
                clusterSize,
                timeToLive,
                version,
                linkedServiceName,
                hostSubscriptionId,
                servicePrincipalId,
                servicePrincipalKey,
                tenant,
                clusterResourceGroup,
                clusterNamePrefix,
                clusterUserName,
                clusterPassword,
                clusterSshUserName,
                clusterSshPassword,
                additionalLinkedServiceNames ?? new ChangeTrackingList<DataFactoryLinkedServiceReference>(),
                hcatalogLinkedServiceName,
                clusterType,
                sparkVersion,
                coreConfiguration,
                hBaseConfiguration,
                hdfsConfiguration,
                hiveConfiguration,
                mapReduceConfiguration,
                oozieConfiguration,
                stormConfiguration,
                yarnConfiguration,
                encryptedCredential,
                headNodeSize,
                dataNodeSize,
                zookeeperNodeSize,
                scriptActions ?? new ChangeTrackingList<DataFactoryScriptAction>(),
                virtualNetworkId,
                subnetName,
                credential);
        }

        BinaryData IPersistableModel<HDInsightOnDemandLinkedService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightOnDemandLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightOnDemandLinkedService)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightOnDemandLinkedService IPersistableModel<HDInsightOnDemandLinkedService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightOnDemandLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightOnDemandLinkedService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightOnDemandLinkedService)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightOnDemandLinkedService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
