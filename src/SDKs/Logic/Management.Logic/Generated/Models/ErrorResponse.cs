// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error reponse indicates Logic service is not able to process the
    /// incoming request. The error property contains the error details.
    /// </summary>
    public partial class ErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        public ErrorResponse() { }

        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        /// <param name="error">The error properties.</param>
        public ErrorResponse(ErrorProperties error = default(ErrorProperties))
        {
            Error = error;
        }

        /// <summary>
        /// Gets or sets the error properties.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorProperties Error { get; set; }

    }
}

