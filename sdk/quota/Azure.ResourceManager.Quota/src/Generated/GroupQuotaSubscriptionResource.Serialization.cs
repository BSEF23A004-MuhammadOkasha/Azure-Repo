// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Quota
{
    public partial class GroupQuotaSubscriptionResource : IJsonModel<GroupQuotaSubscriptionData>
    {
        void IJsonModel<GroupQuotaSubscriptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<GroupQuotaSubscriptionData>)Data).Write(writer, options);

        GroupQuotaSubscriptionData IJsonModel<GroupQuotaSubscriptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<GroupQuotaSubscriptionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<GroupQuotaSubscriptionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        GroupQuotaSubscriptionData IPersistableModel<GroupQuotaSubscriptionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<GroupQuotaSubscriptionData>(data, options);

        string IPersistableModel<GroupQuotaSubscriptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<GroupQuotaSubscriptionData>)Data).GetFormatFromOptions(options);
    }
}
