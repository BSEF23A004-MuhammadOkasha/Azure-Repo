﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Core
{
    /// <summary> The Tags service client. </summary>
    public class TagsOperations : ResourceOperationsBase<SubscriptionResourceIdentifier, Tags>
    {
        /// <summary>
        /// The resource type for Tags
        /// </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/subscriptions";

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsOperations"/> class for mocking.
        /// </summary>
        protected TagsOperations()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsOperations"/> class.
        /// </summary>
        /// <param name="clientContext"></param>
        /// <param name="subscriptionGuid"> The Guid of the subscription. </param>
        internal TagsOperations(ClientContext clientContext, string subscriptionGuid)
            : base(clientContext, new SubscriptionResourceIdentifier(subscriptionGuid))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsOperations"/> class.
        /// </summary>
        /// <param name="operations"> The resource operations to copy the options from. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TagsOperations(OperationsBase operations, SubscriptionResourceIdentifier id)
            : base(operations, id)
        {
        }

        /// <summary>
        /// Gets the valid resource type for this operation class.
        /// </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        private TagsRestOperations RestClient => new TagsRestOperations(Diagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> This operation allows deleting a value from the list of predefined values for an existing predefined tag name. The value being deleted must not be in use as a tag value for the given tag name for any resource. </summary>
        /// <param name="tagName"> The name of the tag. </param>
        /// <param name="tagValue"> The value of the tag to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteValueAsync(string tagName, string tagValue, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("TagsOperations.DeleteValue");
            scope.Start();
            try
            {
                return await RestClient.DeleteValueAsync(tagName, tagValue, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation allows deleting a value from the list of predefined values for an existing predefined tag name. The value being deleted must not be in use as a tag value for the given tag name for any resource. </summary>
        /// <param name="tagName"> The name of the tag. </param>
        /// <param name="tagValue"> The value of the tag to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteValue(string tagName, string tagValue, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("TagsOperations.DeleteValue");
            scope.Start();
            try
            {
                return RestClient.DeleteValue(tagName, tagValue, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation allows adding a value to the list of predefined values for an existing predefined tag name. A tag value can have a maximum of 256 characters. </summary>
        /// <param name="tagName"> The name of the tag. </param>
        /// <param name="tagValue"> The value of the tag to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TagValue>> CreateOrUpdateValueAsync(string tagName, string tagValue, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("TagsOperations.CreateOrUpdateValue");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateValueAsync(tagName, tagValue, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation allows adding a value to the list of predefined values for an existing predefined tag name. A tag value can have a maximum of 256 characters. </summary>
        /// <param name="tagName"> The name of the tag. </param>
        /// <param name="tagValue"> The value of the tag to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TagValue> CreateOrUpdateValue(string tagName, string tagValue, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("TagsOperations.CreateOrUpdateValue");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdateValue(tagName, tagValue, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation allows adding a name to the list of predefined tag names for the given subscription. A tag name can have a maximum of 512 characters and is case-insensitive. Tag names cannot have the following prefixes which are reserved for Azure use: &apos;microsoft&apos;, &apos;azure&apos;, &apos;windows&apos;. </summary>
        /// <param name="tagName"> The name of the tag to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TagDetails>> CreateOrUpdateAsync(string tagName, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("TagsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(tagName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation allows adding a name to the list of predefined tag names for the given subscription. A tag name can have a maximum of 512 characters and is case-insensitive. Tag names cannot have the following prefixes which are reserved for Azure use: &apos;microsoft&apos;, &apos;azure&apos;, &apos;windows&apos;. </summary>
        /// <param name="tagName"> The name of the tag to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TagDetails> CreateOrUpdate(string tagName, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("TagsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(tagName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation allows deleting a name from the list of predefined tag names for the given subscription. The name being deleted must not be in use as a tag name for any resource. All predefined values for the given name must have already been deleted. </summary>
        /// <param name="tagName"> The name of the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string tagName, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("TagsOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(tagName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation allows deleting a name from the list of predefined tag names for the given subscription. The name being deleted must not be in use as a tag name for any resource. All predefined values for the given name must have already been deleted. </summary>
        /// <param name="tagName"> The name of the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string tagName, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("TagsOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(tagName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation allows adding or replacing the entire set of tags on the specified resource or subscription. The specified entity can have a maximum of 50 tags. </summary>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="parameters"> The TagsResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TagsResource>> CreateOrUpdateAtScopeAsync(string scope, TagsResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope0 = Diagnostics.CreateScope("TagsOperations.CreateOrUpdateAtScope");
            scope0.Start();
            try
            {
                return await RestClient.CreateOrUpdateAtScopeAsync(scope, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> This operation allows adding or replacing the entire set of tags on the specified resource or subscription. The specified entity can have a maximum of 50 tags. </summary>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="parameters"> The TagsResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TagsResource> CreateOrUpdateAtScope(string scope, TagsResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope0 = Diagnostics.CreateScope("TagsOperations.CreateOrUpdateAtScope");
            scope0.Start();
            try
            {
                return RestClient.CreateOrUpdateAtScope(scope, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> This operation allows replacing, merging or selectively deleting tags on the specified resource or subscription. The specified entity can have a maximum of 50 tags at the end of the operation. The &apos;replace&apos; option replaces the entire set of existing tags with a new set. The &apos;merge&apos; option allows adding tags with new names and updating the values of tags with existing names. The &apos;delete&apos; option allows selectively deleting tags based on given names or name/value pairs. </summary>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="parameters"> The TagsPatchResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TagsResource>> UpdateAtScopeAsync(string scope, TagsPatchResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope0 = Diagnostics.CreateScope("TagsOperations.UpdateAtScope");
            scope0.Start();
            try
            {
                return await RestClient.UpdateAtScopeAsync(scope, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> This operation allows replacing, merging or selectively deleting tags on the specified resource or subscription. The specified entity can have a maximum of 50 tags at the end of the operation. The &apos;replace&apos; option replaces the entire set of existing tags with a new set. The &apos;merge&apos; option allows adding tags with new names and updating the values of tags with existing names. The &apos;delete&apos; option allows selectively deleting tags based on given names or name/value pairs. </summary>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="parameters"> The TagsPatchResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TagsResource> UpdateAtScope(string scope, TagsPatchResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope0 = Diagnostics.CreateScope("TagsOperations.UpdateAtScope");
            scope0.Start();
            try
            {
                return RestClient.UpdateAtScope(scope, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the entire set of tags on a resource or subscription. </summary>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TagsResource>> GetAtScopeAsync(string scope, CancellationToken cancellationToken = default)
        {
            using var scope0 = Diagnostics.CreateScope("TagsOperations.GetAtScope");
            scope0.Start();
            try
            {
                return await RestClient.GetAtScopeAsync(scope, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the entire set of tags on a resource or subscription. </summary>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TagsResource> GetAtScope(string scope, CancellationToken cancellationToken = default)
        {
            using var scope0 = Diagnostics.CreateScope("TagsOperations.GetAtScope");
            scope0.Start();
            try
            {
                return RestClient.GetAtScope(scope, cancellationToken);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the entire set of tags on a resource or subscription. </summary>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAtScopeAsync(string scope, CancellationToken cancellationToken = default)
        {
            using var scope0 = Diagnostics.CreateScope("TagsOperations.DeleteAtScope");
            scope0.Start();
            try
            {
                return await RestClient.DeleteAtScopeAsync(scope, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the entire set of tags on a resource or subscription. </summary>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteAtScope(string scope, CancellationToken cancellationToken = default)
        {
            using var scope0 = Diagnostics.CreateScope("TagsOperations.DeleteAtScope");
            scope0.Start();
            try
            {
                return RestClient.DeleteAtScope(scope, cancellationToken);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> This operation performs a union of predefined tags, resource tags, resource group tags and subscription tags, and returns a summary of usage for each tag name and value under the given subscription. In case of a large number of tags, this operation may return a previously cached result. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<TagDetails> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<TagDetails>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = Diagnostics.CreateScope("TagsOperations.List");
                scope0.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            async Task<Page<TagDetails>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = Diagnostics.CreateScope("TagsOperations.List");
                scope0.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation performs a union of predefined tags, resource tags, resource group tags and subscription tags, and returns a summary of usage for each tag name and value under the given subscription. In case of a large number of tags, this operation may return a previously cached result. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<TagDetails> List(CancellationToken cancellationToken = default)
        {
            Page<TagDetails> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = Diagnostics.CreateScope("TagsOperations.List");
                scope0.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            Page<TagDetails> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = Diagnostics.CreateScope("TagsOperations.List");
                scope0.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <inheritdoc/>
        public override Response<Tags> Get(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override Task<Response<Tags>> GetAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
