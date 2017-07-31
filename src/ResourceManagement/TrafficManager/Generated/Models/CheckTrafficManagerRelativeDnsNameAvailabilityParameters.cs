// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.TrafficManager;
    using Microsoft.Azure.Management.TrafficManager.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to check Traffic Manager name operation.
    /// </summary>
    public partial class CheckTrafficManagerRelativeDnsNameAvailabilityParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CheckTrafficManagerRelativeDnsNameAvailabilityParameters class.
        /// </summary>
        public CheckTrafficManagerRelativeDnsNameAvailabilityParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CheckTrafficManagerRelativeDnsNameAvailabilityParameters class.
        /// </summary>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        public CheckTrafficManagerRelativeDnsNameAvailabilityParameters(string name = default(string), string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
