﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable enable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Core.Serialization
{
    //internal partial class MergePatchDictionary<T> : IModelJsonSerializable<MergePatchDictionary<T>>
    //{
    //    #region Serialize
    //    void IModelJsonSerializable<MergePatchDictionary<T>>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
    //    {
    //        ModelSerializerHelper.ValidatePatchFormat(this, options.Format);

    //        if (options.Format.ToString() == ModelSerializerFormat.Json ||
    //            options.Format.ToString() == ModelSerializerFormat.Wire)
    //        {
    //            SerializeFull(writer);
    //        }
    //        else if (options.Format.ToString() == ModelSerializerFormat.JsonMergePatch)
    //        {
    //            SerializePatch(writer);
    //        }
    //    }

    //    BinaryData IModelSerializable<MergePatchDictionary<T>>.Serialize(ModelSerializerOptions options)
    //    {
    //        ModelSerializerHelper.ValidatePatchFormat(this, options.Format);
    //        return ModelSerializer.SerializeCore(this, options);
    //    }

    //    private void SerializeFull(Utf8JsonWriter writer)
    //    {
    //        writer.WriteStartObject();

    //        foreach (KeyValuePair<string, T?> kvp in _dictionary)
    //        {
    //            if (kvp.Value == null)
    //            {
    //                writer.WritePropertyName(kvp.Key);
    //                writer.WriteNullValue();
    //            }
    //            else
    //            {
    //                writer.WritePropertyName(kvp.Key);
    //                _serializeItem(writer, kvp.Value);
    //            }
    //        }

    //        writer.WriteEndObject();
    //    }

    //    private void SerializePatch(Utf8JsonWriter writer)
    //    {
    //        writer.WriteStartObject();

    //        foreach (KeyValuePair<string, bool> kvp in _changed)
    //        {
    //            if (kvp.Value)
    //            {
    //                if (!_dictionary.TryGetValue(kvp.Key, out T? value) || value == null)
    //                {
    //                    writer.WritePropertyName(kvp.Key);
    //                    writer.WriteNullValue();
    //                }
    //                else if (_itemHasChanges == null || _itemHasChanges(value))
    //                {
    //                    writer.WritePropertyName(kvp.Key);
    //                    _serializeItem(writer, value);
    //                }
    //            }
    //        }

    //        writer.WriteEndObject();
    //    }
    //    #endregion

    //    #region Deserialize

    //    public static MergePatchDictionary<T> Deserialize(JsonElement element,
    //        Func<JsonElement, T?> deserializeItem,
    //        Action<Utf8JsonWriter, T?> serializeItem,
    //        Func<T?, bool>? itemHasChanges = default)
    //    {
    //        return new MergePatchDictionary<T>(element, deserializeItem, serializeItem, itemHasChanges);
    //    }

    //    MergePatchDictionary<T> IModelJsonSerializable<MergePatchDictionary<T>>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
    //    {
    //        using JsonDocument doc = JsonDocument.ParseValue(ref reader);
    //        return Deserialize(doc.RootElement,
    //            _deserializeItem,
    //            _serializeItem,
    //            _itemHasChanges);
    //    }

    //    MergePatchDictionary<T> IModelSerializable<MergePatchDictionary<T>>.Deserialize(BinaryData data, ModelSerializerOptions options)
    //    {
    //        using JsonDocument doc = JsonDocument.Parse(data);
    //        return Deserialize(doc.RootElement,
    //            _deserializeItem,
    //            _serializeItem,
    //            _itemHasChanges);
    //    }

    //    #endregion
    //}
}
