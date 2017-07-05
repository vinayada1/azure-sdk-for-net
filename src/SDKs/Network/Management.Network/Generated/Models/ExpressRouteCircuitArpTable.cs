// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace compositeNetworkClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The ARP table associated with the ExpressRouteCircuit.
    /// </summary>
    public partial class ExpressRouteCircuitArpTable
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitArpTable
        /// class.
        /// </summary>
        public ExpressRouteCircuitArpTable()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitArpTable
        /// class.
        /// </summary>
        /// <param name="age">Age</param>
        /// <param name="interfaceProperty">Interface</param>
        /// <param name="ipAddress">The IP address.</param>
        /// <param name="macAddress">The MAC address.</param>
        public ExpressRouteCircuitArpTable(int? age = default(int?), string interfaceProperty = default(string), string ipAddress = default(string), string macAddress = default(string))
        {
            Age = age;
            InterfaceProperty = interfaceProperty;
            IpAddress = ipAddress;
            MacAddress = macAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets age
        /// </summary>
        [JsonProperty(PropertyName = "age")]
        public int? Age { get; set; }

        /// <summary>
        /// Gets or sets interface
        /// </summary>
        [JsonProperty(PropertyName = "interface")]
        public string InterfaceProperty { get; set; }

        /// <summary>
        /// Gets or sets the IP address.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the MAC address.
        /// </summary>
        [JsonProperty(PropertyName = "macAddress")]
        public string MacAddress { get; set; }

    }
}
