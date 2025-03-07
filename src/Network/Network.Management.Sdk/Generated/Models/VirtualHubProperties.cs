// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters for VirtualHub.
    /// </summary>
    public partial class VirtualHubProperties
    {
        /// <summary>
        /// Initializes a new instance of the VirtualHubProperties class.
        /// </summary>
        public VirtualHubProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualHubProperties class.
        /// </summary>

        /// <param name="virtualWan">The VirtualWAN to which the VirtualHub belongs.
        /// </param>

        /// <param name="vpnGateway">The VpnGateway associated with this VirtualHub.
        /// </param>

        /// <param name="p2SVpnGateway">The P2SVpnGateway associated with this VirtualHub.
        /// </param>

        /// <param name="expressRouteGateway">The expressRouteGateway associated with this VirtualHub.
        /// </param>

        /// <param name="azureFirewall">The azureFirewall associated with this VirtualHub.
        /// </param>

        /// <param name="securityPartnerProvider">The securityPartnerProvider associated with this VirtualHub.
        /// </param>

        /// <param name="addressPrefix">Address-prefix for this VirtualHub.
        /// </param>

        /// <param name="routeTable">The routeTable associated with this virtual hub.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the virtual hub resource.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>

        /// <param name="securityProviderName">The Security Provider name.
        /// </param>

        /// <param name="virtualHubRouteTableV2S">List of all virtual hub route table v2s associated with this VirtualHub.
        /// </param>

        /// <param name="sku">The sku of this VirtualHub.
        /// </param>

        /// <param name="routingState">The routing state.
        /// Possible values include: &#39;None&#39;, &#39;Provisioned&#39;, &#39;Provisioning&#39;, &#39;Failed&#39;</param>

        /// <param name="bgpConnections">List of references to Bgp Connections.
        /// </param>

        /// <param name="ipConfigurations">List of references to IpConfigurations.
        /// </param>

        /// <param name="routeMaps">List of references to RouteMaps.
        /// </param>

        /// <param name="virtualRouterAsn">VirtualRouter ASN.
        /// </param>

        /// <param name="virtualRouterIps">VirtualRouter IPs.
        /// </param>

        /// <param name="allowBranchToBranchTraffic">Flag to control transit for VirtualRouter hub.
        /// </param>

        /// <param name="preferredRoutingGateway">The preferred gateway to route on-prem traffic
        /// Possible values include: &#39;ExpressRoute&#39;, &#39;VpnGateway&#39;, &#39;None&#39;</param>

        /// <param name="hubRoutingPreference">The hubRoutingPreference of this VirtualHub.
        /// Possible values include: &#39;ExpressRoute&#39;, &#39;VpnGateway&#39;, &#39;ASPath&#39;</param>

        /// <param name="virtualRouterAutoScaleConfiguration">The VirtualHub Router autoscale configuration.
        /// </param>
        public VirtualHubProperties(SubResource virtualWan = default(SubResource), SubResource vpnGateway = default(SubResource), SubResource p2SVpnGateway = default(SubResource), SubResource expressRouteGateway = default(SubResource), SubResource azureFirewall = default(SubResource), SubResource securityPartnerProvider = default(SubResource), string addressPrefix = default(string), VirtualHubRouteTable routeTable = default(VirtualHubRouteTable), string provisioningState = default(string), string securityProviderName = default(string), System.Collections.Generic.IList<VirtualHubRouteTableV2> virtualHubRouteTableV2S = default(System.Collections.Generic.IList<VirtualHubRouteTableV2>), string sku = default(string), string routingState = default(string), System.Collections.Generic.IList<SubResource> bgpConnections = default(System.Collections.Generic.IList<SubResource>), System.Collections.Generic.IList<SubResource> ipConfigurations = default(System.Collections.Generic.IList<SubResource>), System.Collections.Generic.IList<SubResource> routeMaps = default(System.Collections.Generic.IList<SubResource>), long? virtualRouterAsn = default(long?), System.Collections.Generic.IList<string> virtualRouterIps = default(System.Collections.Generic.IList<string>), bool? allowBranchToBranchTraffic = default(bool?), string preferredRoutingGateway = default(string), string hubRoutingPreference = default(string), VirtualRouterAutoScaleConfiguration virtualRouterAutoScaleConfiguration = default(VirtualRouterAutoScaleConfiguration))

        {
            this.VirtualWan = virtualWan;
            this.VpnGateway = vpnGateway;
            this.P2SVpnGateway = p2SVpnGateway;
            this.ExpressRouteGateway = expressRouteGateway;
            this.AzureFirewall = azureFirewall;
            this.SecurityPartnerProvider = securityPartnerProvider;
            this.AddressPrefix = addressPrefix;
            this.RouteTable = routeTable;
            this.ProvisioningState = provisioningState;
            this.SecurityProviderName = securityProviderName;
            this.VirtualHubRouteTableV2S = virtualHubRouteTableV2S;
            this.Sku = sku;
            this.RoutingState = routingState;
            this.BgpConnections = bgpConnections;
            this.IPConfigurations = ipConfigurations;
            this.RouteMaps = routeMaps;
            this.VirtualRouterAsn = virtualRouterAsn;
            this.VirtualRouterIps = virtualRouterIps;
            this.AllowBranchToBranchTraffic = allowBranchToBranchTraffic;
            this.PreferredRoutingGateway = preferredRoutingGateway;
            this.HubRoutingPreference = hubRoutingPreference;
            this.VirtualRouterAutoScaleConfiguration = virtualRouterAutoScaleConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the VirtualWAN to which the VirtualHub belongs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "virtualWan")]
        public SubResource VirtualWan {get; set; }

        /// <summary>
        /// Gets or sets the VpnGateway associated with this VirtualHub.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vpnGateway")]
        public SubResource VpnGateway {get; set; }

        /// <summary>
        /// Gets or sets the P2SVpnGateway associated with this VirtualHub.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "p2SVpnGateway")]
        public SubResource P2SVpnGateway {get; set; }

        /// <summary>
        /// Gets or sets the expressRouteGateway associated with this VirtualHub.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expressRouteGateway")]
        public SubResource ExpressRouteGateway {get; set; }

        /// <summary>
        /// Gets or sets the azureFirewall associated with this VirtualHub.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "azureFirewall")]
        public SubResource AzureFirewall {get; set; }

        /// <summary>
        /// Gets or sets the securityPartnerProvider associated with this VirtualHub.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "securityPartnerProvider")]
        public SubResource SecurityPartnerProvider {get; set; }

        /// <summary>
        /// Gets or sets address-prefix for this VirtualHub.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "addressPrefix")]
        public string AddressPrefix {get; set; }

        /// <summary>
        /// Gets or sets the routeTable associated with this virtual hub.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "routeTable")]
        public VirtualHubRouteTable RouteTable {get; set; }

        /// <summary>
        /// Gets the provisioning state of the virtual hub resource. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets the Security Provider name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "securityProviderName")]
        public string SecurityProviderName {get; set; }

        /// <summary>
        /// Gets or sets list of all virtual hub route table v2s associated with this
        /// VirtualHub.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "virtualHubRouteTableV2s")]
        public System.Collections.Generic.IList<VirtualHubRouteTableV2> VirtualHubRouteTableV2S {get; set; }

        /// <summary>
        /// Gets or sets the sku of this VirtualHub.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public string Sku {get; set; }

        /// <summary>
        /// Gets the routing state. Possible values include: &#39;None&#39;, &#39;Provisioned&#39;, &#39;Provisioning&#39;, &#39;Failed&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "routingState")]
        public string RoutingState {get; private set; }

        /// <summary>
        /// Gets list of references to Bgp Connections.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "bgpConnections")]
        public System.Collections.Generic.IList<SubResource> BgpConnections {get; private set; }

        /// <summary>
        /// Gets list of references to IpConfigurations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipConfigurations")]
        public System.Collections.Generic.IList<SubResource> IPConfigurations {get; private set; }

        /// <summary>
        /// Gets list of references to RouteMaps.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "routeMaps")]
        public System.Collections.Generic.IList<SubResource> RouteMaps {get; private set; }

        /// <summary>
        /// Gets or sets virtualRouter ASN.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "virtualRouterAsn")]
        public long? VirtualRouterAsn {get; set; }

        /// <summary>
        /// Gets or sets virtualRouter IPs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "virtualRouterIps")]
        public System.Collections.Generic.IList<string> VirtualRouterIps {get; set; }

        /// <summary>
        /// Gets or sets flag to control transit for VirtualRouter hub.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "allowBranchToBranchTraffic")]
        public bool? AllowBranchToBranchTraffic {get; set; }

        /// <summary>
        /// Gets or sets the preferred gateway to route on-prem traffic Possible values include: &#39;ExpressRoute&#39;, &#39;VpnGateway&#39;, &#39;None&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "preferredRoutingGateway")]
        public string PreferredRoutingGateway {get; set; }

        /// <summary>
        /// Gets or sets the hubRoutingPreference of this VirtualHub. Possible values include: &#39;ExpressRoute&#39;, &#39;VpnGateway&#39;, &#39;ASPath&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "hubRoutingPreference")]
        public string HubRoutingPreference {get; set; }

        /// <summary>
        /// Gets or sets the VirtualHub Router autoscale configuration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "virtualRouterAutoScaleConfiguration")]
        public VirtualRouterAutoScaleConfiguration VirtualRouterAutoScaleConfiguration {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
















            if (this.VirtualRouterAsn != null)
            {
                if (this.VirtualRouterAsn > 4294967295)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "VirtualRouterAsn", 4294967295);
                }
                if (this.VirtualRouterAsn < 0)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "VirtualRouterAsn", 0);
                }
            }



            if (this.VirtualRouterAutoScaleConfiguration != null)
            {
                this.VirtualRouterAutoScaleConfiguration.Validate();
            }
        }
    }
}