// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class UserListResult
    {
        internal static UserListResult DeserializeUserListResult(JsonElement element)
        {
            Optional<IReadOnlyList<User>> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<User> array = new List<User>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(User.DeserializeUser(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("odata.nextLink"))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new UserListResult(Optional.ToList(value), odataNextLink.Value);
        }
    }
}
