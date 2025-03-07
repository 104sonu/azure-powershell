// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// DdosProtectionPlansOperations operations.
    /// </summary>
    public partial interface IDdosProtectionPlansOperations
    {
        /// <summary>
        /// Deletes the specified DDoS protection plan.
        /// </summary>
        /// <remarks>
        /// Deletes the specified DDoS protection plan.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='ddosProtectionPlanName'>
        /// The name of the DDoS protection plan.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<DdosProtectionPlansDeleteHeaders>> DeleteWithHttpMessagesAsync(string resourceGroupName, string ddosProtectionPlanName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets information about the specified DDoS protection plan.
        /// </summary>
        /// <remarks>
        /// Gets information about the specified DDoS protection plan.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='ddosProtectionPlanName'>
        /// The name of the DDoS protection plan.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<DdosProtectionPlan>> GetWithHttpMessagesAsync(string resourceGroupName, string ddosProtectionPlanName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates or updates a DDoS protection plan.
        /// </summary>
        /// <remarks>
        /// Creates or updates a DDoS protection plan.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='ddosProtectionPlanName'>
        /// The name of the DDoS protection plan.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create or update operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<DdosProtectionPlan>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string ddosProtectionPlanName, DdosProtectionPlan parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update a DDoS protection plan tags.
        /// </summary>
        /// <remarks>
        /// Update a DDoS protection plan tags.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='ddosProtectionPlanName'>
        /// The name of the DDoS protection plan.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the update DDoS protection plan resource tags.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<DdosProtectionPlan>> UpdateTagsWithHttpMessagesAsync(string resourceGroupName, string ddosProtectionPlanName, TagsObject parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets all DDoS protection plans in a subscription.
        /// </summary>
        /// <remarks>
        /// Gets all DDoS protection plans in a subscription.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<DdosProtectionPlan>>> ListWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets all the DDoS protection plans in a resource group.
        /// </summary>
        /// <remarks>
        /// Gets all the DDoS protection plans in a resource group.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<DdosProtectionPlan>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes the specified DDoS protection plan.
        /// </summary>
        /// <remarks>
        /// Deletes the specified DDoS protection plan.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='ddosProtectionPlanName'>
        /// The name of the DDoS protection plan.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<DdosProtectionPlansDeleteHeaders>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string ddosProtectionPlanName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates or updates a DDoS protection plan.
        /// </summary>
        /// <remarks>
        /// Creates or updates a DDoS protection plan.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='ddosProtectionPlanName'>
        /// The name of the DDoS protection plan.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create or update operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<DdosProtectionPlan>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string ddosProtectionPlanName, DdosProtectionPlan parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets all DDoS protection plans in a subscription.
        /// </summary>
        /// <remarks>
        /// Gets all DDoS protection plans in a subscription.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<DdosProtectionPlan>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets all the DDoS protection plans in a resource group.
        /// </summary>
        /// <remarks>
        /// Gets all the DDoS protection plans in a resource group.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<DdosProtectionPlan>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}