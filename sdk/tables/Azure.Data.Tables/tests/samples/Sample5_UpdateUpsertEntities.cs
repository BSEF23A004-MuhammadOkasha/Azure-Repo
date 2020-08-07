// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using NUnit.Framework;
using Azure.Data.Tables.Tests;
using System.Collections.Generic;

namespace Azure.Data.Tables.Samples
{
    [LiveOnly]
    public partial class TablesSamples : TablesTestEnvironment
    {
        [Test]
        public void UpdateUpsertEntities()
        {
            string storageUri = StorageUri;
            string accountName = StorageAccountName;
            string storageAccountKey = PrimaryStorageAccountKey;
            string tableName = "OfficeSupplies5p1";
            string partitionKey = "Stationery";
            string rowKey = "A1";

            var serviceClient = new TableServiceClient(
                new Uri(storageUri),
                new TableSharedKeyCredential(accountName, storageAccountKey));

            serviceClient.CreateTable(tableName);
            var client = serviceClient.GetTableClient(tableName);

            #region Snippet:TablesSample5UpsertEntity
            var entity = new TableEntity(partitionKey, rowKey)
            {
                {"Product", "Markers" },
                {"Price", 5.00 },
                {"Brand", "myCompany" }
            };

            // Entity doesn't exist in table, so invoking UpsertEntity will simply insert the entity.
            client.UpsertEntity(entity);
            #endregion

            #region Snippet:TablesSample5UpsertWithReplace
            // Delete an entity property.
            entity.Remove("Brand");

            // Entity does exist in the table, so invoking UpsertEntity will update using the given UpdateMode, which defaults to Merge if not given.
            // Since UpdateMode.Replace was passed, the existing entity will be replaced and delete the "Brand" property.
            client.UpsertEntity(entity, TableUpdateMode.Replace);
            #endregion

            #region Snippet:TablesSample5UpdateEntity
            // Get the entity to update.
            TableEntity qEntity = client.GetEntity<TableEntity>(partitionKey, rowKey);
            qEntity["Price"] = 7.00;

            // Since no UpdateMode was passed, the request will default to Merge.
            client.UpdateEntity(qEntity, qEntity.ETag);

            TableEntity updatedEntity = client.GetEntity<TableEntity>(partitionKey, rowKey);
            Console.WriteLine($"'Price' before updating: ${entity.GetDouble("Price")}");
            Console.WriteLine($"'Price' after updating: ${updatedEntity.GetDouble("Price")}");
            #endregion

            serviceClient.DeleteTable(tableName);
        }
    }
}
