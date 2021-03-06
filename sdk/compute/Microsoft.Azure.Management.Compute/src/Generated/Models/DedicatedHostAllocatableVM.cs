// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents the dedicated host unutilized capacity in terms of a
    /// specific VM size.
    /// </summary>
    public partial class DedicatedHostAllocatableVM
    {
        /// <summary>
        /// Initializes a new instance of the DedicatedHostAllocatableVM class.
        /// </summary>
        public DedicatedHostAllocatableVM()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DedicatedHostAllocatableVM class.
        /// </summary>
        /// <param name="vmSize">VM size in terms of which the unutilized
        /// capacity is represented.</param>
        /// <param name="count">Maximum number of VMs of size vmSize that can
        /// fit in the dedicated host's remaining capacity.</param>
        public DedicatedHostAllocatableVM(string vmSize = default(string), double? count = default(double?))
        {
            VmSize = vmSize;
            Count = count;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets VM size in terms of which the unutilized capacity is
        /// represented.
        /// </summary>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets maximum number of VMs of size vmSize that can fit in
        /// the dedicated host's remaining capacity.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public double? Count { get; set; }

    }
}
