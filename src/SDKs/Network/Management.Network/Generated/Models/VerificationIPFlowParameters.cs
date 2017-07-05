// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace compositeNetworkClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters that define the IP flow to be verified.
    /// </summary>
    public partial class VerificationIPFlowParameters
    {
        /// <summary>
        /// Initializes a new instance of the VerificationIPFlowParameters
        /// class.
        /// </summary>
        public VerificationIPFlowParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VerificationIPFlowParameters
        /// class.
        /// </summary>
        /// <param name="targetResourceId">The ID of the target resource to
        /// perform next-hop on.</param>
        /// <param name="direction">The direction of the packet represented as
        /// a 5-tuple. Possible values include: 'Inbound', 'Outbound'</param>
        /// <param name="protocol">Protocol to be verified on. Possible values
        /// include: 'TCP', 'UDP'</param>
        /// <param name="localPort">The local port. Acceptable values are a
        /// single integer in the range (0-65535). Support for * for the source
        /// port, which depends on the direction.</param>
        /// <param name="remotePort">The remote port. Acceptable values are a
        /// single integer in the range (0-65535). Support for * for the source
        /// port, which depends on the direction.</param>
        /// <param name="localIPAddress">The local IP address. Acceptable
        /// values are valid IPv4 addresses.</param>
        /// <param name="remoteIPAddress">The remote IP address. Acceptable
        /// values are valid IPv4 addresses.</param>
        /// <param name="targetNicResourceId">The NIC ID. (If VM has multiple
        /// NICs and IP forwarding is enabled on any of them, then this
        /// parameter must be specified. Otherwise optional).</param>
        public VerificationIPFlowParameters(string targetResourceId, string direction, string protocol, string localPort, string remotePort, string localIPAddress, string remoteIPAddress, string targetNicResourceId = default(string))
        {
            TargetResourceId = targetResourceId;
            Direction = direction;
            Protocol = protocol;
            LocalPort = localPort;
            RemotePort = remotePort;
            LocalIPAddress = localIPAddress;
            RemoteIPAddress = remoteIPAddress;
            TargetNicResourceId = targetNicResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the target resource to perform next-hop on.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Gets or sets the direction of the packet represented as a 5-tuple.
        /// Possible values include: 'Inbound', 'Outbound'
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets protocol to be verified on. Possible values include:
        /// 'TCP', 'UDP'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the local port. Acceptable values are a single integer
        /// in the range (0-65535). Support for * for the source port, which
        /// depends on the direction.
        /// </summary>
        [JsonProperty(PropertyName = "localPort")]
        public string LocalPort { get; set; }

        /// <summary>
        /// Gets or sets the remote port. Acceptable values are a single
        /// integer in the range (0-65535). Support for * for the source port,
        /// which depends on the direction.
        /// </summary>
        [JsonProperty(PropertyName = "remotePort")]
        public string RemotePort { get; set; }

        /// <summary>
        /// Gets or sets the local IP address. Acceptable values are valid IPv4
        /// addresses.
        /// </summary>
        [JsonProperty(PropertyName = "localIPAddress")]
        public string LocalIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the remote IP address. Acceptable values are valid
        /// IPv4 addresses.
        /// </summary>
        [JsonProperty(PropertyName = "remoteIPAddress")]
        public string RemoteIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the NIC ID. (If VM has multiple NICs and IP forwarding
        /// is enabled on any of them, then this parameter must be specified.
        /// Otherwise optional).
        /// </summary>
        [JsonProperty(PropertyName = "targetNicResourceId")]
        public string TargetNicResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetResourceId");
            }
            if (Direction == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Direction");
            }
            if (Protocol == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Protocol");
            }
            if (LocalPort == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LocalPort");
            }
            if (RemotePort == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RemotePort");
            }
            if (LocalIPAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LocalIPAddress");
            }
            if (RemoteIPAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RemoteIPAddress");
            }
        }
    }
}
