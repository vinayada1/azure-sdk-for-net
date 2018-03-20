// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity HDFS source.
    /// </summary>
    public partial class HdfsSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the HdfsSource class.
        /// </summary>
        public HdfsSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HdfsSource class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="recursive">If true, files under the folder path will
        /// be read recursively. Default is true. Type: boolean (or Expression
        /// with resultType boolean).</param>
        /// <param name="distcpSettings">Specifies Distcp-related
        /// settings.</param>
        public HdfsSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object recursive = default(object), DistcpSettings distcpSettings = default(DistcpSettings))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait)
        {
            Recursive = recursive;
            DistcpSettings = distcpSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if true, files under the folder path will be read
        /// recursively. Default is true. Type: boolean (or Expression with
        /// resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "recursive")]
        public object Recursive { get; set; }

        /// <summary>
        /// Gets or sets specifies Distcp-related settings.
        /// </summary>
        [JsonProperty(PropertyName = "distcpSettings")]
        public DistcpSettings DistcpSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DistcpSettings != null)
            {
                DistcpSettings.Validate();
            }
        }
    }
}
