// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Configuration for metadata sync
    /// </summary>
    /// <remarks>
    /// Configuration for metadata sync
    /// </remarks>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class MetadataSyncConfig : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the MetadataSyncConfig class.
        /// </summary>
        public MetadataSyncConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetadataSyncConfig class.
        /// </summary>

        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </param>

        /// <param name="name">The name of the resource
        /// </param>

        /// <param name="type">The type of the resource. E.g. &#34;Microsoft.Compute/virtualMachines&#34; or
        /// &#34;Microsoft.Storage/storageAccounts&#34;
        /// </param>

        /// <param name="enabled">Indicates whether the metadata sync is enabled or disabled
        /// </param>

        /// <param name="syncIntervalInMinutes">The Sync Interval in minutes.
        /// </param>
        public MetadataSyncConfig(string id = default(string), string name = default(string), string type = default(string), bool? enabled = default(bool?), int? syncIntervalInMinutes = default(int?))

        : base(id, name, type)
        {
            this.Enabled = enabled;
            this.SyncIntervalInMinutes = syncIntervalInMinutes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets indicates whether the metadata sync is enabled or disabled
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled {get; set; }

        /// <summary>
        /// Gets or sets the Sync Interval in minutes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.syncIntervalInMinutes")]
        public int? SyncIntervalInMinutes {get; set; }
    }
}