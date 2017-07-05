// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace compositeNetworkClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Usage details for subnet.
    /// </summary>
    public partial class VirtualNetworkUsage
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkUsage class.
        /// </summary>
        public VirtualNetworkUsage()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkUsage class.
        /// </summary>
        /// <param name="currentValue">Indicates number of IPs used from the
        /// Subnet.</param>
        /// <param name="id">Subnet identifier.</param>
        /// <param name="limit">Indicates the size of the subnet.</param>
        /// <param name="name">The name containing common and localized value
        /// for usage.</param>
        /// <param name="unit">Usage units. Returns 'Count'</param>
        public VirtualNetworkUsage(double? currentValue = default(double?), string id = default(string), double? limit = default(double?), VirtualNetworkUsageName name = default(VirtualNetworkUsageName), string unit = default(string))
        {
            CurrentValue = currentValue;
            Id = id;
            Limit = limit;
            Name = name;
            Unit = unit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets indicates number of IPs used from the Subnet.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public double? CurrentValue { get; private set; }

        /// <summary>
        /// Gets subnet identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets indicates the size of the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public double? Limit { get; private set; }

        /// <summary>
        /// Gets the name containing common and localized value for usage.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public VirtualNetworkUsageName Name { get; private set; }

        /// <summary>
        /// Gets usage units. Returns 'Count'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

    }
}
