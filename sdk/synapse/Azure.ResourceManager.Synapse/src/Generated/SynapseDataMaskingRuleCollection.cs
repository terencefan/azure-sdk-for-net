// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseDataMaskingRuleResource" /> and their operations.
    /// Each <see cref="SynapseDataMaskingRuleResource" /> in the collection will belong to the same instance of <see cref="SynapseDataMaskingPolicyResource" />.
    /// To get a <see cref="SynapseDataMaskingRuleCollection" /> instance call the GetSynapseDataMaskingRules method from an instance of <see cref="SynapseDataMaskingPolicyResource" />.
    /// </summary>
    public partial class SynapseDataMaskingRuleCollection : ArmCollection, IEnumerable<SynapseDataMaskingRuleResource>, IAsyncEnumerable<SynapseDataMaskingRuleResource>
    {
        private readonly ClientDiagnostics _synapseDataMaskingRuleDataMaskingRulesClientDiagnostics;
        private readonly DataMaskingRulesRestOperations _synapseDataMaskingRuleDataMaskingRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseDataMaskingRuleCollection"/> class for mocking. </summary>
        protected SynapseDataMaskingRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseDataMaskingRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseDataMaskingRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseDataMaskingRuleDataMaskingRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseDataMaskingRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseDataMaskingRuleResource.ResourceType, out string synapseDataMaskingRuleDataMaskingRulesApiVersion);
            _synapseDataMaskingRuleDataMaskingRulesRestClient = new DataMaskingRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseDataMaskingRuleDataMaskingRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseDataMaskingPolicyResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseDataMaskingPolicyResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Sql pool data masking rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/dataMaskingPolicies/{dataMaskingPolicyName}/rules/{dataMaskingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataMaskingRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataMaskingRuleName"> The name of the data masking rule. </param>
        /// <param name="data"> The required parameters for creating or updating a data masking rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataMaskingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataMaskingRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseDataMaskingRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataMaskingRuleName, SynapseDataMaskingRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataMaskingRuleName, nameof(dataMaskingRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseDataMaskingRuleDataMaskingRulesClientDiagnostics.CreateScope("SynapseDataMaskingRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseDataMaskingRuleDataMaskingRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, dataMaskingRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseDataMaskingRuleResource>(Response.FromValue(new SynapseDataMaskingRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a Sql pool data masking rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/dataMaskingPolicies/{dataMaskingPolicyName}/rules/{dataMaskingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataMaskingRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataMaskingRuleName"> The name of the data masking rule. </param>
        /// <param name="data"> The required parameters for creating or updating a data masking rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataMaskingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataMaskingRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseDataMaskingRuleResource> CreateOrUpdate(WaitUntil waitUntil, string dataMaskingRuleName, SynapseDataMaskingRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataMaskingRuleName, nameof(dataMaskingRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseDataMaskingRuleDataMaskingRulesClientDiagnostics.CreateScope("SynapseDataMaskingRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseDataMaskingRuleDataMaskingRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, dataMaskingRuleName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseDataMaskingRuleResource>(Response.FromValue(new SynapseDataMaskingRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specific Sql pool data masking rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/dataMaskingPolicies/{dataMaskingPolicyName}/rules/{dataMaskingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataMaskingRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataMaskingRuleName"> The name of the data masking rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataMaskingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataMaskingRuleName"/> is null. </exception>
        public virtual async Task<Response<SynapseDataMaskingRuleResource>> GetAsync(string dataMaskingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataMaskingRuleName, nameof(dataMaskingRuleName));

            using var scope = _synapseDataMaskingRuleDataMaskingRulesClientDiagnostics.CreateScope("SynapseDataMaskingRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseDataMaskingRuleDataMaskingRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, dataMaskingRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseDataMaskingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specific Sql pool data masking rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/dataMaskingPolicies/{dataMaskingPolicyName}/rules/{dataMaskingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataMaskingRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataMaskingRuleName"> The name of the data masking rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataMaskingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataMaskingRuleName"/> is null. </exception>
        public virtual Response<SynapseDataMaskingRuleResource> Get(string dataMaskingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataMaskingRuleName, nameof(dataMaskingRuleName));

            using var scope = _synapseDataMaskingRuleDataMaskingRulesClientDiagnostics.CreateScope("SynapseDataMaskingRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseDataMaskingRuleDataMaskingRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, dataMaskingRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseDataMaskingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of Sql pool data masking rules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/dataMaskingPolicies/{dataMaskingPolicyName}/rules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataMaskingRules_ListBySqlPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseDataMaskingRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseDataMaskingRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseDataMaskingRuleDataMaskingRulesRestClient.CreateListBySqlPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new SynapseDataMaskingRuleResource(Client, SynapseDataMaskingRuleData.DeserializeSynapseDataMaskingRuleData(e)), _synapseDataMaskingRuleDataMaskingRulesClientDiagnostics, Pipeline, "SynapseDataMaskingRuleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets a list of Sql pool data masking rules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/dataMaskingPolicies/{dataMaskingPolicyName}/rules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataMaskingRules_ListBySqlPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseDataMaskingRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseDataMaskingRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseDataMaskingRuleDataMaskingRulesRestClient.CreateListBySqlPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new SynapseDataMaskingRuleResource(Client, SynapseDataMaskingRuleData.DeserializeSynapseDataMaskingRuleData(e)), _synapseDataMaskingRuleDataMaskingRulesClientDiagnostics, Pipeline, "SynapseDataMaskingRuleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/dataMaskingPolicies/{dataMaskingPolicyName}/rules/{dataMaskingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataMaskingRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataMaskingRuleName"> The name of the data masking rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataMaskingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataMaskingRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataMaskingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataMaskingRuleName, nameof(dataMaskingRuleName));

            using var scope = _synapseDataMaskingRuleDataMaskingRulesClientDiagnostics.CreateScope("SynapseDataMaskingRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseDataMaskingRuleDataMaskingRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, dataMaskingRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/dataMaskingPolicies/{dataMaskingPolicyName}/rules/{dataMaskingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataMaskingRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataMaskingRuleName"> The name of the data masking rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataMaskingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataMaskingRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataMaskingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataMaskingRuleName, nameof(dataMaskingRuleName));

            using var scope = _synapseDataMaskingRuleDataMaskingRulesClientDiagnostics.CreateScope("SynapseDataMaskingRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseDataMaskingRuleDataMaskingRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, dataMaskingRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseDataMaskingRuleResource> IEnumerable<SynapseDataMaskingRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseDataMaskingRuleResource> IAsyncEnumerable<SynapseDataMaskingRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
