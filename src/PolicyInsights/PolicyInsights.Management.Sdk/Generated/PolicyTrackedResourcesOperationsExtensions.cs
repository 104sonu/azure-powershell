// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.PolicyInsights
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for PolicyTrackedResourcesOperations
    /// </summary>
    public static partial class PolicyTrackedResourcesOperationsExtensions
    {
        /// <summary>
        /// Queries policy tracked resources under the management group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='queryOptions'>
        /// 
        /// </param>
        /// <param name='managementGroupName'>
        /// Management group name.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<PolicyTrackedResource> ListQueryResultsForManagementGroup(this IPolicyTrackedResourcesOperations operations, string managementGroupName, QueryOptions queryOptions = default(QueryOptions))
        {
                return ((IPolicyTrackedResourcesOperations)operations).ListQueryResultsForManagementGroupAsync(managementGroupName, queryOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries policy tracked resources under the management group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='queryOptions'>
        /// 
        /// </param>
        /// <param name='managementGroupName'>
        /// Management group name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<PolicyTrackedResource>> ListQueryResultsForManagementGroupAsync(this IPolicyTrackedResourcesOperations operations, string managementGroupName, QueryOptions queryOptions = default(QueryOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListQueryResultsForManagementGroupWithHttpMessagesAsync(managementGroupName, queryOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Queries policy tracked resources under the subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='queryOptions'>
        /// 
        /// </param>
        public static Microsoft.Rest.Azure.IPage<PolicyTrackedResource> ListQueryResultsForSubscription(this IPolicyTrackedResourcesOperations operations, QueryOptions queryOptions = default(QueryOptions))
        {
                return ((IPolicyTrackedResourcesOperations)operations).ListQueryResultsForSubscriptionAsync(queryOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries policy tracked resources under the subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='queryOptions'>
        /// 
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<PolicyTrackedResource>> ListQueryResultsForSubscriptionAsync(this IPolicyTrackedResourcesOperations operations, QueryOptions queryOptions = default(QueryOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListQueryResultsForSubscriptionWithHttpMessagesAsync(queryOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Queries policy tracked resources under the resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='queryOptions'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// Resource group name.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<PolicyTrackedResource> ListQueryResultsForResourceGroup(this IPolicyTrackedResourcesOperations operations, string resourceGroupName, QueryOptions queryOptions = default(QueryOptions))
        {
                return ((IPolicyTrackedResourcesOperations)operations).ListQueryResultsForResourceGroupAsync(resourceGroupName, queryOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries policy tracked resources under the resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='queryOptions'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// Resource group name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<PolicyTrackedResource>> ListQueryResultsForResourceGroupAsync(this IPolicyTrackedResourcesOperations operations, string resourceGroupName, QueryOptions queryOptions = default(QueryOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListQueryResultsForResourceGroupWithHttpMessagesAsync(resourceGroupName, queryOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Queries policy tracked resources under the resource.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='queryOptions'>
        /// 
        /// </param>
        /// <param name='resourceId'>
        /// Resource ID.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<PolicyTrackedResource> ListQueryResultsForResource(this IPolicyTrackedResourcesOperations operations, string resourceId, QueryOptions queryOptions = default(QueryOptions))
        {
                return ((IPolicyTrackedResourcesOperations)operations).ListQueryResultsForResourceAsync(resourceId, queryOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries policy tracked resources under the resource.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='queryOptions'>
        /// 
        /// </param>
        /// <param name='resourceId'>
        /// Resource ID.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<PolicyTrackedResource>> ListQueryResultsForResourceAsync(this IPolicyTrackedResourcesOperations operations, string resourceId, QueryOptions queryOptions = default(QueryOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListQueryResultsForResourceWithHttpMessagesAsync(resourceId, queryOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Queries policy tracked resources under the management group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<PolicyTrackedResource> ListQueryResultsForManagementGroupNext(this IPolicyTrackedResourcesOperations operations, string nextPageLink)
        {
                return ((IPolicyTrackedResourcesOperations)operations).ListQueryResultsForManagementGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries policy tracked resources under the management group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<PolicyTrackedResource>> ListQueryResultsForManagementGroupNextAsync(this IPolicyTrackedResourcesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListQueryResultsForManagementGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Queries policy tracked resources under the subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<PolicyTrackedResource> ListQueryResultsForSubscriptionNext(this IPolicyTrackedResourcesOperations operations, string nextPageLink)
        {
                return ((IPolicyTrackedResourcesOperations)operations).ListQueryResultsForSubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries policy tracked resources under the subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<PolicyTrackedResource>> ListQueryResultsForSubscriptionNextAsync(this IPolicyTrackedResourcesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListQueryResultsForSubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Queries policy tracked resources under the resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<PolicyTrackedResource> ListQueryResultsForResourceGroupNext(this IPolicyTrackedResourcesOperations operations, string nextPageLink)
        {
                return ((IPolicyTrackedResourcesOperations)operations).ListQueryResultsForResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries policy tracked resources under the resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<PolicyTrackedResource>> ListQueryResultsForResourceGroupNextAsync(this IPolicyTrackedResourcesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListQueryResultsForResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Queries policy tracked resources under the resource.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<PolicyTrackedResource> ListQueryResultsForResourceNext(this IPolicyTrackedResourcesOperations operations, string nextPageLink)
        {
                return ((IPolicyTrackedResourcesOperations)operations).ListQueryResultsForResourceNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries policy tracked resources under the resource.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<PolicyTrackedResource>> ListQueryResultsForResourceNextAsync(this IPolicyTrackedResourcesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListQueryResultsForResourceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
