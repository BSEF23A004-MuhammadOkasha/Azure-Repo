// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.Security.KeyVault.Administration.Models;
using Azure.Security.KeyVault.Administration.Tests;
using NUnit.Framework;

namespace Azure.Security.KeyVault.Administration.Samples
{
    /// <summary>
    /// Samples that are used in the associated README.md file.
    /// </summary>
    public class HelloWorld : AccessControlTestBase
    {
        public HelloWorld(bool isAsync) : base(isAsync, RecordedTestMode.Playback /* To record tests, change this argument to RecordedTestMode.Record */)
        { }

#pragma warning disable IDE1006 // Naming Styles
        private KeyVaultAccessControlClient client;
        private string objectId;
        private string roleDefinitionId;
#pragma warning restore IDE1006 // Naming Styles

        [SetUp]
        public void TestSetup()
        {
            objectId = TestEnvironment.ClientObjectId;
        }

        [Test]
        [SyncOnly]
        public void CreateClient()
        {
            // Environment variable with the Key Vault endpoint.
            string keyVaultUrl = TestEnvironment.KeyVaultUrl;

            #region Snippet:HelloCreateKeyVaultAccessControlClient
            KeyVaultAccessControlClient client = new KeyVaultAccessControlClient(new Uri(keyVaultUrl), new DefaultAzureCredential());
            #endregion
            client = Client;
        }

        [Test]
        [SyncOnly]
        public void GetDefinitionsAndAssignmentsSync()
        {
            // Replace client with the Instrumented Client.
            client = Client;

            // Retrieve all the role definitions.
            #region Snippet:GetRoleDefinitionsSync
            List<RoleDefinition> roleDefinitions = client.GetRoleDefinitions(RoleAssignmentScope.Global).ToList();
            #endregion

            // Retrieve all the role assignments.
            #region Snippet:GetRoleAssignmentsSync
            List<RoleAssignment> roleAssignments = client.GetRoleAssignments(RoleAssignmentScope.Global).ToList();
            #endregion

        }

        [Test]
        [AsyncOnly]
        public async Task GetDefinitionsAndAssignmentsAsync()
        {
            // Replace client with the Instrumented Client.
            client = Client;

            // Retrieve all the role definitions.
            #region Snippet:GetRoleDefinitionsAsync
            List<RoleDefinition> roleDefinitions = new List<RoleDefinition>();
            await foreach (var definition in client.GetRoleDefinitionsAsync(RoleAssignmentScope.Global))
            {
                roleDefinitions.Add(definition);
            }
            #endregion

            // Retrieve all the role assignments.
            #region Snippet:GetRoleAssignmentsAsync
            List<RoleAssignment> roleAssignments = new List<RoleAssignment>();
            await foreach (var assignment in client.GetRoleAssignmentsAsync(RoleAssignmentScope.Global))
            {
                roleAssignments.Add(assignment);
            }
            #endregion
        }

        [Test]
        [SyncOnly]
        public void CreateRoleAssignment()
        {
            // Replace client with the Instrumented Client.
            client = Client;

            List<RoleDefinition> definitions = client.GetRoleDefinitions(RoleAssignmentScope.Global).ToList();
            roleDefinitionId = definitions.FirstOrDefault(d => d.RoleName == roleName).Id;

            // Replace roleDefinitionId with a role definition Id from the definitions returned from GetRoleAssignments.
            string definitionIdToAssign = roleDefinitionId;

            // Replace objectId with the service principal object id.
            string servicePrincipalObjectId = objectId;

            #region Snippet:CreateRoleAssignment
            //@@string definitionIdToAssign = <roleDefinitionId>;
            //@@string servicePrincipalObjectId = <objectId>;

            RoleAssignmentProperties properties = new RoleAssignmentProperties(definitionIdToAssign, servicePrincipalObjectId);
            //@@RoleAssignment createdAssignment = client.CreateRoleAssignment(RoleAssignmentScope.Global, properties);
            /*@@*/RoleAssignment createdAssignment = client.CreateRoleAssignment(RoleAssignmentScope.Global, properties, roleAssignmentId);
            #endregion

            #region Snippet:GetRoleAssignment
            RoleAssignment fetchedAssignment = client.GetRoleAssignment(RoleAssignmentScope.Global, createdAssignment.Name);
            #endregion

            #region Snippet:DeleteRoleAssignment
            RoleAssignment deletedAssignment = client.DeleteRoleAssignment(RoleAssignmentScope.Global, createdAssignment.Name);
            #endregion
        }

        [Test]
        [AsyncOnly]
        public async Task CreateRoleAssignmentAsync()
        {
            // Replace client with the Instrumented Client.
            client = Client;

            List<RoleDefinition> definitions = await client.GetRoleDefinitionsAsync(RoleAssignmentScope.Global).ToEnumerableAsync().ConfigureAwait(false);
            roleDefinitionId = definitions.FirstOrDefault(d => d.RoleName == roleName).Id;

            // Replace roleDefinitionId with a role definition Id from the definitions returned from GetRoleDefinitionsAsync.
            string definitionIdToAssign = roleDefinitionId;

            // Replace objectId with the service principal object id.
            string servicePrincipalObjectId = objectId;

            #region Snippet:CreateRoleAssignmentAsync
            //@@string definitionIdToAssign = <roleDefinitionId>;
            //@@string servicePrincipalObjectId = <objectId>;

            RoleAssignmentProperties properties = new RoleAssignmentProperties(definitionIdToAssign, servicePrincipalObjectId);
            //@@RoleAssignment createdAssignment = await client.CreateRoleAssignmentAsync(RoleAssignmentScope.Global, properties).ConfigureAwait(false);
            /*@@*/RoleAssignment createdAssignment = await client.CreateRoleAssignmentAsync(RoleAssignmentScope.Global, properties, roleAssignmentId).ConfigureAwait(false);
            #endregion

            #region Snippet:GetRoleAssignmentAsync
            RoleAssignment fetchedAssignment = await client.GetRoleAssignmentAsync(RoleAssignmentScope.Global, createdAssignment.Name).ConfigureAwait(false);
            #endregion

            #region Snippet:DeleteRoleAssignmentAsync
            RoleAssignment deletedAssignment = await client.DeleteRoleAssignmentAsync(RoleAssignmentScope.Global, createdAssignment.Name).ConfigureAwait(false);
            #endregion
        }
    }
}
