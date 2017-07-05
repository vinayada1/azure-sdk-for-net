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
    /// Effective network security group.
    /// </summary>
    public partial class EffectiveNetworkSecurityGroup
    {
        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityGroup
        /// class.
        /// </summary>
        public EffectiveNetworkSecurityGroup()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityGroup
        /// class.
        /// </summary>
        /// <param name="networkSecurityGroup">The ID of network security group
        /// that is applied.</param>
        /// <param name="effectiveSecurityRules">A collection of effective
        /// security rules.</param>
        public EffectiveNetworkSecurityGroup(SubResource networkSecurityGroup = default(SubResource), EffectiveNetworkSecurityGroupAssociation association = default(EffectiveNetworkSecurityGroupAssociation), IList<EffectiveNetworkSecurityRule> effectiveSecurityRules = default(IList<EffectiveNetworkSecurityRule>))
        {
            NetworkSecurityGroup = networkSecurityGroup;
            Association = association;
            EffectiveSecurityRules = effectiveSecurityRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of network security group that is applied.
        /// </summary>
        [JsonProperty(PropertyName = "networkSecurityGroup")]
        public SubResource NetworkSecurityGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "association")]
        public EffectiveNetworkSecurityGroupAssociation Association { get; set; }

        /// <summary>
        /// Gets or sets a collection of effective security rules.
        /// </summary>
        [JsonProperty(PropertyName = "effectiveSecurityRules")]
        public IList<EffectiveNetworkSecurityRule> EffectiveSecurityRules { get; set; }

    }
}
