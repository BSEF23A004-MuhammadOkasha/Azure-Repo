﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.WebJobs.Extensions.Storage.Blobs.Bindings
{
    /// <summary>
    /// TODO
    /// </summary>
    internal class CacheAfterWriteStream : Stream, ICacheAfterWriteStream
    {
        private readonly SharedMemoryMetadata _sharedMemoryMeta;

#pragma warning disable CA2213 // Disposable fields should be disposed
        private readonly IFunctionDataCache _functionDataCache;
#pragma warning restore CA2213 // Disposable fields should be disposed

        private readonly BlobWithContainer<BlobBaseClient> _blob;

        private readonly Stream _inner;

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="sharedMemoryMeta"></param>
        /// <param name="functionDataCache"></param>
        /// <param name="blob"></param>
        /// <param name="innerStream"></param>
        public CacheAfterWriteStream(SharedMemoryMetadata sharedMemoryMeta, IFunctionDataCache functionDataCache, BlobWithContainer<BlobBaseClient> blob, Stream innerStream)
        {
            _sharedMemoryMeta = sharedMemoryMeta;
            _functionDataCache = functionDataCache;
            _blob = blob;
            _inner = innerStream;
        }

        public async Task<bool> TryPutToFunctionDataCacheAsync()
        {
            if (_sharedMemoryMeta == null)
            {
                return false;
            }

            BlobProperties properties = await _blob.BlobClient.FetchPropertiesOrNullIfNotExistAsync().ConfigureAwait(false);
            return TryPutToFunctionDataCacheCore(properties);
        }

        private bool TryPutToFunctionDataCacheCore(BlobProperties properties)
        {
            string eTag = properties.ETag.ToString();
            string id = _blob.BlobClient.Uri.ToString();
            FunctionDataCacheKey cacheKey = new FunctionDataCacheKey(id, eTag);
            return _functionDataCache.TryPut(cacheKey, _sharedMemoryMeta, isIncrementActiveReference: false);
        }

        public override bool CanRead
        {
            get { return _inner.CanRead; }
        }

        public override bool CanSeek
        {
            get { return _inner.CanSeek; }
        }

        public override bool CanTimeout
        {
            get { return _inner.CanTimeout; }
        }

        public override bool CanWrite
        {
            get { return _inner.CanWrite; }
        }

        public override long Length
        {
            get { return _inner.Length; }
        }

        public override long Position
        {
            get { return _inner.Position; }
            set { _inner.Position = value; }
        }

        public override int ReadTimeout
        {
            get { return _inner.ReadTimeout; }
            set { _inner.ReadTimeout = value; }
        }

        public override int WriteTimeout
        {
            get { return _inner.WriteTimeout; }
            set { _inner.WriteTimeout = value; }
        }

        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback,
            object state)
        {
            return _inner.BeginRead(buffer, offset, count, callback, state);
        }

        public override int EndRead(IAsyncResult asyncResult)
        {
            return _inner.EndRead(asyncResult);
        }

        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback,
            object state)
        {
            return _inner.BeginWrite(buffer, offset, count, callback, state);
        }

        public override void EndWrite(IAsyncResult asyncResult)
        {
            _inner.EndWrite(asyncResult);
        }

        public override void Close()
        {
            _inner.Close();
        }

        public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
        {
            return _inner.CopyToAsync(destination, bufferSize, cancellationToken);
        }

        public override void Flush()
        {
            _inner.Flush();
        }

        public override Task FlushAsync(CancellationToken cancellationToken)
        {
            return _inner.FlushAsync(cancellationToken);
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return _inner.Read(buffer, offset, count);
        }

        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return _inner.ReadAsync(buffer, offset, count, cancellationToken);
        }

        public override int ReadByte()
        {
            return _inner.ReadByte();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _inner.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _inner.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _inner.Write(buffer, offset, count);
        }

        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return _inner.WriteAsync(buffer, offset, count, cancellationToken);
        }

        public override void WriteByte(byte value)
        {
            _inner.WriteByte(value);
        }
    }
}
