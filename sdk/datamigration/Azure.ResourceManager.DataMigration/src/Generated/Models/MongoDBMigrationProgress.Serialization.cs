// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDBMigrationProgress
    {
        internal static MongoDBMigrationProgress DeserializeMongoDBMigrationProgress(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, MongoDBDatabaseProgress>> databases = default;
            long bytesCopied = default;
            long documentsCopied = default;
            string elapsedTime = default;
            IReadOnlyDictionary<string, MongoDBError> errors = default;
            long eventsPending = default;
            long eventsReplayed = default;
            Optional<DateTimeOffset> lastEventTime = default;
            Optional<DateTimeOffset> lastReplayTime = default;
            Optional<string> name = default;
            Optional<string> qualifiedName = default;
            MongoDBProgressResultType resultType = default;
            MongoDBMigrationState state = default;
            long totalBytes = default;
            long totalDocuments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, MongoDBDatabaseProgress> dictionary = new Dictionary<string, MongoDBDatabaseProgress>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MongoDBDatabaseProgress.DeserializeMongoDBDatabaseProgress(property0.Value));
                    }
                    databases = dictionary;
                    continue;
                }
                if (property.NameEquals("bytesCopied"u8))
                {
                    bytesCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("documentsCopied"u8))
                {
                    documentsCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("elapsedTime"u8))
                {
                    elapsedTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    Dictionary<string, MongoDBError> dictionary = new Dictionary<string, MongoDBError>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MongoDBError.DeserializeMongoDBError(property0.Value));
                    }
                    errors = dictionary;
                    continue;
                }
                if (property.NameEquals("eventsPending"u8))
                {
                    eventsPending = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("eventsReplayed"u8))
                {
                    eventsReplayed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastEventTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEventTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastReplayTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastReplayTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"u8))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = new MongoDBProgressResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = new MongoDBMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalBytes"u8))
                {
                    totalBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalDocuments"u8))
                {
                    totalDocuments = property.Value.GetInt64();
                    continue;
                }
            }
            return new MongoDBMigrationProgress(bytesCopied, documentsCopied, elapsedTime, errors, eventsPending, eventsReplayed, Optional.ToNullable(lastEventTime), Optional.ToNullable(lastReplayTime), name.Value, qualifiedName.Value, resultType, state, totalBytes, totalDocuments, Optional.ToDictionary(databases));
        }
    }
}
