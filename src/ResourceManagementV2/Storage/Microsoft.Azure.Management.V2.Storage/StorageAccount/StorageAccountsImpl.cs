﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Storage;
using Microsoft.Azure.Management.Storage.Models;
using Microsoft.Azure.Management.V2.Resource.Core;

namespace Microsoft.Azure.Management.V2.Storage
{
    internal class StorageAccountsImpl :
        GroupableResources<
                IStorageAccount,
                StorageAccountImpl,
                Management.Storage.Models.StorageAccountInner,
                IStorageAccountsOperations,
                StorageManager>,
        IStorageAccounts
    {
        internal StorageAccountsImpl(IStorageAccountsOperations innerCollection, StorageManager manager) : base(innerCollection, manager)
        {}

        public StorageAccount.Definition.IBlank Define(string name)
        {
            Management.Storage.Models.StorageAccountInner innerObject = new Management.Storage.Models.StorageAccountInner();
            StorageAccountImpl wrapped = new StorageAccountImpl(name, 
                innerObject, 
                InnerCollection,
                MyManager);
            wrapped.WithSku(SkuName.StandardGRS)
                   .WithGeneralPurposeAccountKind();
            return wrapped;
        }

        public override Task<IStorageAccount> GetByGroup(string groupName, string name)
        {
            throw new NotImplementedException();
        }

        public PagedList<IStorageAccount> List()
        {
            // var storageAccounts = await InnerCollection.ListAsync();
            // return new PagedList<Management.Storage.Models.StorageAccount>(storageAccounts);
            throw new NotImplementedException();
        }

        protected override IStorageAccount WrapModel(Management.Storage.Models.StorageAccountInner inner)
        {
            return new StorageAccountImpl(inner.Name,
                inner,
                InnerCollection,
                MyManager);
        }

        protected override StorageAccountImpl WrapModel(string name)
        {
            Management.Storage.Models.StorageAccountInner innerObject = new Management.Storage.Models.StorageAccountInner();
            return new StorageAccountImpl(name,
                innerObject,
                InnerCollection,
                MyManager
            );
        }
    }
}
