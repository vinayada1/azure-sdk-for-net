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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The data stored in Avro format.
    /// </summary>
    public partial class AvroFormat : DatasetStorageFormat
    {
        /// <summary>
        /// Initializes a new instance of the AvroFormat class.
        /// </summary>
        public AvroFormat()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvroFormat class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="serializer">Serializer. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="deserializer">Deserializer. Type: string (or
        /// Expression with resultType string).</param>
        public AvroFormat(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object serializer = default(object), object deserializer = default(object))
            : base(additionalProperties, serializer, deserializer)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
