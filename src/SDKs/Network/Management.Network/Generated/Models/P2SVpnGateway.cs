// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// P2SVpnGateway Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class P2SVpnGateway : Resource
    {
        /// <summary>
        /// Initializes a new instance of the P2SVpnGateway class.
        /// </summary>
        public P2SVpnGateway()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the P2SVpnGateway class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="virtualHub">The VirtualHub to which the gateway
        /// belongs</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="vpnGatewayScaleUnit">The scale unit for this p2s vpn
        /// gateway.</param>
        /// <param name="p2sVpnServerConfiguration">The
        /// P2SVpnServerConfiguration to which the p2sVpnGateway is attached
        /// to.</param>
        /// <param name="vpnClientAddressPool">The reference of the address
        /// space resource which represents Address space for P2S
        /// VpnClient.</param>
        /// <param name="vpnClientConnectionHealth">Collection of the all P2S
        /// vpnclients' connection health status.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public P2SVpnGateway(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SubResource virtualHub = default(SubResource), string provisioningState = default(string), int? vpnGatewayScaleUnit = default(int?), P2SVpnServerConfiguration p2sVpnServerConfiguration = default(P2SVpnServerConfiguration), AddressSpace vpnClientAddressPool = default(AddressSpace), IList<VpnClientConnectionHealth> vpnClientConnectionHealth = default(IList<VpnClientConnectionHealth>), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            VirtualHub = virtualHub;
            ProvisioningState = provisioningState;
            VpnGatewayScaleUnit = vpnGatewayScaleUnit;
            P2sVpnServerConfiguration = p2sVpnServerConfiguration;
            VpnClientAddressPool = vpnClientAddressPool;
            VpnClientConnectionHealth = vpnClientConnectionHealth;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the VirtualHub to which the gateway belongs
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualHub")]
        public SubResource VirtualHub { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the scale unit for this p2s vpn gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnGatewayScaleUnit")]
        public int? VpnGatewayScaleUnit { get; set; }

        /// <summary>
        /// Gets or sets the P2SVpnServerConfiguration to which the
        /// p2sVpnGateway is attached to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.p2sVpnServerConfiguration")]
        public P2SVpnServerConfiguration P2sVpnServerConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the reference of the address space resource which
        /// represents Address space for P2S VpnClient.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnClientAddressPool")]
        public AddressSpace VpnClientAddressPool { get; set; }

        /// <summary>
        /// Gets collection of the all P2S vpnclients' connection health
        /// status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnClientConnectionHealth")]
        public IList<VpnClientConnectionHealth> VpnClientConnectionHealth { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
