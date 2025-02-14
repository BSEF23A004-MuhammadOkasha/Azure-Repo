// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HybridConnectivity
{
    public partial class HybridConnectivityInventoryResource : IJsonModel<HybridConnectivityInventoryResourceData>
    {
        void IJsonModel<HybridConnectivityInventoryResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HybridConnectivityInventoryResourceData>)Data).Write(writer, options);

        HybridConnectivityInventoryResourceData IJsonModel<HybridConnectivityInventoryResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HybridConnectivityInventoryResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<HybridConnectivityInventoryResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        HybridConnectivityInventoryResourceData IPersistableModel<HybridConnectivityInventoryResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HybridConnectivityInventoryResourceData>(data, options);

        string IPersistableModel<HybridConnectivityInventoryResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HybridConnectivityInventoryResourceData>)Data).GetFormatFromOptions(options);
    }
}
