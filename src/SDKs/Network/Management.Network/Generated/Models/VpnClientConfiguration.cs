// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace compositeNetworkClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VpnClientConfiguration for P2S client.
    /// </summary>
    public partial class VpnClientConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the VpnClientConfiguration class.
        /// </summary>
        public VpnClientConfiguration()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnClientConfiguration class.
        /// </summary>
        /// <param name="vpnClientAddressPool">The reference of the address
        /// space resource which represents Address space for P2S
        /// VpnClient.</param>
        /// <param name="vpnClientRootCertificates">VpnClientRootCertificate
        /// for virtual network gateway.</param>
        /// <param
        /// name="vpnClientRevokedCertificates">VpnClientRevokedCertificate for
        /// Virtual network gateway.</param>
        /// <param name="vpnClientProtocols">VpnClientProtocols for Virtual
        /// network gateway.</param>
        public VpnClientConfiguration(AddressSpace vpnClientAddressPool = default(AddressSpace), IList<VpnClientRootCertificate> vpnClientRootCertificates = default(IList<VpnClientRootCertificate>), IList<VpnClientRevokedCertificate> vpnClientRevokedCertificates = default(IList<VpnClientRevokedCertificate>), IList<string> vpnClientProtocols = default(IList<string>))
        {
            VpnClientAddressPool = vpnClientAddressPool;
            VpnClientRootCertificates = vpnClientRootCertificates;
            VpnClientRevokedCertificates = vpnClientRevokedCertificates;
            VpnClientProtocols = vpnClientProtocols;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reference of the address space resource which
        /// represents Address space for P2S VpnClient.
        /// </summary>
        [JsonProperty(PropertyName = "vpnClientAddressPool")]
        public AddressSpace VpnClientAddressPool { get; set; }

        /// <summary>
        /// Gets or sets vpnClientRootCertificate for virtual network gateway.
        /// </summary>
        [JsonProperty(PropertyName = "vpnClientRootCertificates")]
        public IList<VpnClientRootCertificate> VpnClientRootCertificates { get; set; }

        /// <summary>
        /// Gets or sets vpnClientRevokedCertificate for Virtual network
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "vpnClientRevokedCertificates")]
        public IList<VpnClientRevokedCertificate> VpnClientRevokedCertificates { get; set; }

        /// <summary>
        /// Gets or sets vpnClientProtocols for Virtual network gateway.
        /// </summary>
        [JsonProperty(PropertyName = "vpnClientProtocols")]
        public IList<string> VpnClientProtocols { get; set; }

    }
}
