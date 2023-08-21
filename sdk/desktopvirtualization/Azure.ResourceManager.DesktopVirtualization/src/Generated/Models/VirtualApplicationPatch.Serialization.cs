// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class VirtualApplicationPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("filePath"u8);
                writer.WriteStringValue(FilePath);
            }
            if (Optional.IsDefined(CommandLineSetting))
            {
                writer.WritePropertyName("commandLineSetting"u8);
                writer.WriteStringValue(CommandLineSetting.Value.ToString());
            }
            if (Optional.IsDefined(CommandLineArguments))
            {
                writer.WritePropertyName("commandLineArguments"u8);
                writer.WriteStringValue(CommandLineArguments);
            }
            if (Optional.IsDefined(ShowInPortal))
            {
                writer.WritePropertyName("showInPortal"u8);
                writer.WriteBooleanValue(ShowInPortal.Value);
            }
            if (Optional.IsDefined(IconPath))
            {
                writer.WritePropertyName("iconPath"u8);
                writer.WriteStringValue(IconPath);
            }
            if (Optional.IsDefined(IconIndex))
            {
                writer.WritePropertyName("iconIndex"u8);
                writer.WriteNumberValue(IconIndex.Value);
            }
            if (Optional.IsDefined(MsixPackageFamilyName))
            {
                if (MsixPackageFamilyName != null)
                {
                    writer.WritePropertyName("msixPackageFamilyName"u8);
                    writer.WriteStringValue(MsixPackageFamilyName);
                }
                else
                {
                    writer.WriteNull("msixPackageFamilyName");
                }
            }
            if (Optional.IsDefined(MsixPackageApplicationId))
            {
                if (MsixPackageApplicationId != null)
                {
                    writer.WritePropertyName("msixPackageApplicationId"u8);
                    writer.WriteStringValue(MsixPackageApplicationId);
                }
                else
                {
                    writer.WriteNull("msixPackageApplicationId");
                }
            }
            if (Optional.IsDefined(ApplicationType))
            {
                writer.WritePropertyName("applicationType"u8);
                writer.WriteStringValue(ApplicationType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
