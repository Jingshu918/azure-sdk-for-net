// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the NetworkSecurityGroup data model. </summary>
    public partial class NetworkSecurityGroupData : Resource
    {
        /// <summary> Initializes a new instance of NetworkSecurityGroupData. </summary>
        public NetworkSecurityGroupData()
        {
            SecurityRules = new ChangeTrackingList<SecurityRuleData>();
            DefaultSecurityRules = new ChangeTrackingList<SecurityRuleData>();
            NetworkInterfaces = new ChangeTrackingList<NetworkInterfaceData>();
            Subnets = new ChangeTrackingList<SubnetData>();
            FlowLogs = new ChangeTrackingList<FlowLogData>();
        }

        /// <summary> Initializes a new instance of NetworkSecurityGroupData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="securityRules"> A collection of security rules of the network security group. </param>
        /// <param name="defaultSecurityRules"> The default security rules of network security group. </param>
        /// <param name="networkInterfaces"> A collection of references to network interfaces. </param>
        /// <param name="subnets"> A collection of references to subnets. </param>
        /// <param name="flowLogs"> A collection of references to flow log resources. </param>
        /// <param name="resourceGuid"> The resource GUID property of the network security group resource. </param>
        /// <param name="provisioningState"> The provisioning state of the network security group resource. </param>
        internal NetworkSecurityGroupData(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, IList<SecurityRuleData> securityRules, IReadOnlyList<SecurityRuleData> defaultSecurityRules, IReadOnlyList<NetworkInterfaceData> networkInterfaces, IReadOnlyList<SubnetData> subnets, IReadOnlyList<FlowLogData> flowLogs, string resourceGuid, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Etag = etag;
            SecurityRules = securityRules;
            DefaultSecurityRules = defaultSecurityRules;
            NetworkInterfaces = networkInterfaces;
            Subnets = subnets;
            FlowLogs = flowLogs;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> A collection of security rules of the network security group. </summary>
        public IList<SecurityRuleData> SecurityRules { get; }
        /// <summary> The default security rules of network security group. </summary>
        public IReadOnlyList<SecurityRuleData> DefaultSecurityRules { get; }
        /// <summary> A collection of references to network interfaces. </summary>
        public IReadOnlyList<NetworkInterfaceData> NetworkInterfaces { get; }
        /// <summary> A collection of references to subnets. </summary>
        public IReadOnlyList<SubnetData> Subnets { get; }
        /// <summary> A collection of references to flow log resources. </summary>
        public IReadOnlyList<FlowLogData> FlowLogs { get; }
        /// <summary> The resource GUID property of the network security group resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the network security group resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
