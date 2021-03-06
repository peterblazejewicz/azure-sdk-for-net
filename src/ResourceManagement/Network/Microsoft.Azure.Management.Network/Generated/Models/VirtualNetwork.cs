// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Virtual Network resource
    /// </summary>
    [JsonTransformation]
    public partial class VirtualNetwork : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetwork class.
        /// </summary>
        public VirtualNetwork() { }

        /// <summary>
        /// Initializes a new instance of the VirtualNetwork class.
        /// </summary>
        public VirtualNetwork(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), AddressSpace addressSpace = default(AddressSpace), DhcpOptions dhcpOptions = default(DhcpOptions), IList<Subnet> subnets = default(IList<Subnet>), IList<VirtualNetworkPeering> virtualNetworkPeerings = default(IList<VirtualNetworkPeering>), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            AddressSpace = addressSpace;
            DhcpOptions = dhcpOptions;
            Subnets = subnets;
            VirtualNetworkPeerings = virtualNetworkPeerings;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets AddressSpace that contains an array of IP address
        /// ranges that can be used by subnets
        /// </summary>
        [JsonProperty(PropertyName = "properties.addressSpace")]
        public AddressSpace AddressSpace { get; set; }

        /// <summary>
        /// Gets or sets DHCPOptions that contains an array of DNS servers
        /// available to VMs deployed in the virtual network
        /// </summary>
        [JsonProperty(PropertyName = "properties.dhcpOptions")]
        public DhcpOptions DhcpOptions { get; set; }

        /// <summary>
        /// Gets or sets list of subnets in a VirtualNetwork
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnets")]
        public IList<Subnet> Subnets { get; set; }

        /// <summary>
        /// Gets or sets list of peerings in a VirtualNetwork
        /// </summary>
        [JsonProperty(PropertyName = "properties.VirtualNetworkPeerings")]
        public IList<VirtualNetworkPeering> VirtualNetworkPeerings { get; set; }

        /// <summary>
        /// Gets or sets resource guid property of the VirtualNetwork resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
