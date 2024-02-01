// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceCertificateOrderPatch : IUtf8JsonSerializable, IJsonModel<AppServiceCertificateOrderPatch>, IPersistableModel<AppServiceCertificateOrderPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceCertificateOrderPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceCertificateOrderPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceCertificateOrderPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceCertificateOrderPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates"u8);
                writer.WriteStartObject();
                foreach (var item in Certificates)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(DistinguishedName))
            {
                writer.WritePropertyName("distinguishedName"u8);
                writer.WriteStringValue(DistinguishedName);
            }
            if (options.Format != "W" && Optional.IsDefined(DomainVerificationToken))
            {
                writer.WritePropertyName("domainVerificationToken"u8);
                writer.WriteStringValue(DomainVerificationToken);
            }
            if (Optional.IsDefined(ValidityInYears))
            {
                writer.WritePropertyName("validityInYears"u8);
                writer.WriteNumberValue(ValidityInYears.Value);
            }
            if (Optional.IsDefined(KeySize))
            {
                writer.WritePropertyName("keySize"u8);
                writer.WriteNumberValue(KeySize.Value);
            }
            if (Optional.IsDefined(ProductType))
            {
                writer.WritePropertyName("productType"u8);
                writer.WriteStringValue(ProductType.Value.ToSerialString());
            }
            if (Optional.IsDefined(IsAutoRenew))
            {
                writer.WritePropertyName("autoRenew"u8);
                writer.WriteBooleanValue(IsAutoRenew.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(SignedCertificate))
            {
                writer.WritePropertyName("signedCertificate"u8);
                writer.WriteObjectValue(SignedCertificate);
            }
            if (Optional.IsDefined(Csr))
            {
                writer.WritePropertyName("csr"u8);
                writer.WriteStringValue(Csr);
            }
            if (options.Format != "W" && Optional.IsDefined(Intermediate))
            {
                writer.WritePropertyName("intermediate"u8);
                writer.WriteObjectValue(Intermediate);
            }
            if (options.Format != "W" && Optional.IsDefined(Root))
            {
                writer.WritePropertyName("root"u8);
                writer.WriteObjectValue(Root);
            }
            if (options.Format != "W" && Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteStringValue(SerialNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(LastCertificateIssuanceOn))
            {
                writer.WritePropertyName("lastCertificateIssuanceTime"u8);
                writer.WriteStringValue(LastCertificateIssuanceOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(IsPrivateKeyExternal))
            {
                writer.WritePropertyName("isPrivateKeyExternal"u8);
                writer.WriteBooleanValue(IsPrivateKeyExternal.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AppServiceCertificateNotRenewableReasons))
            {
                writer.WritePropertyName("appServiceCertificateNotRenewableReasons"u8);
                writer.WriteStartArray();
                foreach (var item in AppServiceCertificateNotRenewableReasons)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(NextAutoRenewalTimeStamp))
            {
                writer.WritePropertyName("nextAutoRenewalTimeStamp"u8);
                writer.WriteStringValue(NextAutoRenewalTimeStamp.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Contact))
            {
                writer.WritePropertyName("contact"u8);
                writer.WriteObjectValue(Contact);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
            }
            writer.WriteEndObject();
        }

        AppServiceCertificateOrderPatch IJsonModel<AppServiceCertificateOrderPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceCertificateOrderPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceCertificateOrderPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceCertificateOrderPatch(document.RootElement, options);
        }

        internal static AppServiceCertificateOrderPatch DeserializeAppServiceCertificateOrderPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IDictionary<string, AppServiceCertificateProperties>> certificates = default;
            Optional<string> distinguishedName = default;
            Optional<string> domainVerificationToken = default;
            Optional<int> validityInYears = default;
            Optional<int> keySize = default;
            Optional<CertificateProductType> productType = default;
            Optional<bool> autoRenew = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<CertificateOrderStatus> status = default;
            Optional<AppServiceCertificateDetails> signedCertificate = default;
            Optional<string> csr = default;
            Optional<AppServiceCertificateDetails> intermediate = default;
            Optional<AppServiceCertificateDetails> root = default;
            Optional<string> serialNumber = default;
            Optional<DateTimeOffset> lastCertificateIssuanceTime = default;
            Optional<DateTimeOffset> expirationTime = default;
            Optional<bool> isPrivateKeyExternal = default;
            Optional<IReadOnlyList<AppServiceCertificateNotRenewableReason>> appServiceCertificateNotRenewableReasons = default;
            Optional<DateTimeOffset> nextAutoRenewalTimeStamp = default;
            Optional<CertificateOrderContact> contact = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("certificates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, AppServiceCertificateProperties> dictionary = new Dictionary<string, AppServiceCertificateProperties>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, AppServiceCertificateProperties.DeserializeAppServiceCertificateProperties(property1.Value));
                            }
                            certificates = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("distinguishedName"u8))
                        {
                            distinguishedName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainVerificationToken"u8))
                        {
                            domainVerificationToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("validityInYears"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validityInYears = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("keySize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keySize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("productType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            productType = property0.Value.GetString().ToCertificateProductType();
                            continue;
                        }
                        if (property0.NameEquals("autoRenew"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoRenew = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToCertificateOrderStatus();
                            continue;
                        }
                        if (property0.NameEquals("signedCertificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            signedCertificate = AppServiceCertificateDetails.DeserializeAppServiceCertificateDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("csr"u8))
                        {
                            csr = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("intermediate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            intermediate = AppServiceCertificateDetails.DeserializeAppServiceCertificateDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("root"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            root = AppServiceCertificateDetails.DeserializeAppServiceCertificateDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastCertificateIssuanceTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastCertificateIssuanceTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("isPrivateKeyExternal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPrivateKeyExternal = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("appServiceCertificateNotRenewableReasons"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceCertificateNotRenewableReason> array = new List<AppServiceCertificateNotRenewableReason>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new AppServiceCertificateNotRenewableReason(item.GetString()));
                            }
                            appServiceCertificateNotRenewableReasons = array;
                            continue;
                        }
                        if (property0.NameEquals("nextAutoRenewalTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nextAutoRenewalTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("contact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contact = CertificateOrderContact.DeserializeCertificateOrderContact(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceCertificateOrderPatch(id, name, type, systemData.Value, Optional.ToDictionary(certificates), distinguishedName.Value, domainVerificationToken.Value, Optional.ToNullable(validityInYears), Optional.ToNullable(keySize), Optional.ToNullable(productType), Optional.ToNullable(autoRenew), Optional.ToNullable(provisioningState), Optional.ToNullable(status), signedCertificate.Value, csr.Value, intermediate.Value, root.Value, serialNumber.Value, Optional.ToNullable(lastCertificateIssuanceTime), Optional.ToNullable(expirationTime), Optional.ToNullable(isPrivateKeyExternal), Optional.ToList(appServiceCertificateNotRenewableReasons), Optional.ToNullable(nextAutoRenewalTimeStamp), contact.Value, kind.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(Certificates))
            {
                builder.Append("  certificates:");
                builder.AppendLine(" {");
                foreach (var item in Certificates)
                {
                    builder.Append($"    {item.Key}: ");

                    AppendChildObject(builder, item.Value, options, 4);
                }
                builder.AppendLine("  }");
            }

            if (Optional.IsDefined(DistinguishedName))
            {
                builder.Append("  distinguishedName:");
                builder.AppendLine($" '{DistinguishedName}'");
            }

            if (Optional.IsDefined(DomainVerificationToken))
            {
                builder.Append("  domainVerificationToken:");
                builder.AppendLine($" '{DomainVerificationToken}'");
            }

            if (Optional.IsDefined(ValidityInYears))
            {
                builder.Append("  validityInYears:");
                builder.AppendLine($" '{ValidityInYears.Value.ToString()}'");
            }

            if (Optional.IsDefined(KeySize))
            {
                builder.Append("  keySize:");
                builder.AppendLine($" '{KeySize.Value.ToString()}'");
            }

            if (Optional.IsDefined(ProductType))
            {
                builder.Append("  productType:");
                builder.AppendLine($" '{ProductType.ToString()}'");
            }

            if (Optional.IsDefined(IsAutoRenew))
            {
                builder.Append("  autoRenew:");
                var boolValue = IsAutoRenew.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("  provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                builder.AppendLine($" '{Status.ToString()}'");
            }

            if (Optional.IsDefined(SignedCertificate))
            {
                builder.Append("  signedCertificate:");
                AppendChildObject(builder, SignedCertificate, options, 2);
            }

            if (Optional.IsDefined(Csr))
            {
                builder.Append("  csr:");
                builder.AppendLine($" '{Csr}'");
            }

            if (Optional.IsDefined(Intermediate))
            {
                builder.Append("  intermediate:");
                AppendChildObject(builder, Intermediate, options, 2);
            }

            if (Optional.IsDefined(Root))
            {
                builder.Append("  root:");
                AppendChildObject(builder, Root, options, 2);
            }

            if (Optional.IsDefined(SerialNumber))
            {
                builder.Append("  serialNumber:");
                builder.AppendLine($" '{SerialNumber}'");
            }

            if (Optional.IsDefined(LastCertificateIssuanceOn))
            {
                builder.Append("  lastCertificateIssuanceTime:");
                builder.AppendLine($" '{LastCertificateIssuanceOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(ExpireOn))
            {
                builder.Append("  expirationTime:");
                builder.AppendLine($" '{ExpireOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(IsPrivateKeyExternal))
            {
                builder.Append("  isPrivateKeyExternal:");
                var boolValue = IsPrivateKeyExternal.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsCollectionDefined(AppServiceCertificateNotRenewableReasons))
            {
                builder.Append("  appServiceCertificateNotRenewableReasons:");
                builder.AppendLine(" [");
                foreach (var item in AppServiceCertificateNotRenewableReasons)
                {
                    builder.AppendLine($"    '{item.ToString()}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(NextAutoRenewalTimeStamp))
            {
                builder.Append("  nextAutoRenewalTimeStamp:");
                builder.AppendLine($" '{NextAutoRenewalTimeStamp.Value.ToString()}'");
            }

            if (Optional.IsDefined(Contact))
            {
                builder.Append("  contact:");
                AppendChildObject(builder, Contact, options, 2);
            }

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<AppServiceCertificateOrderPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceCertificateOrderPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceCertificateOrderPatch)} does not support '{options.Format}' format.");
            }
        }

        AppServiceCertificateOrderPatch IPersistableModel<AppServiceCertificateOrderPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceCertificateOrderPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceCertificateOrderPatch(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AppServiceCertificateOrderPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceCertificateOrderPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
