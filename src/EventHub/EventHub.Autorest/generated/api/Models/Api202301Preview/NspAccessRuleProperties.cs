// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    /// <summary>Properties of Access Rule</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.DoNotFormat]
    public partial class NspAccessRuleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INspAccessRuleProperties,
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INspAccessRulePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AddressPrefix" /> property.</summary>
        private string[] _addressPrefix;

        /// <summary>Address prefixes in the CIDR format for inbound rules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string[] AddressPrefix { get => this._addressPrefix; set => this._addressPrefix = value; }

        /// <summary>Backing field for <see cref="Direction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.NspAccessRuleDirection? _direction;

        /// <summary>Direction of Access Rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.NspAccessRuleDirection? Direction { get => this._direction; set => this._direction = value; }

        /// <summary>Backing field for <see cref="FullyQualifiedDomainName" /> property.</summary>
        private string[] _fullyQualifiedDomainName;

        /// <summary>FQDN for outbound rules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string[] FullyQualifiedDomainName { get => this._fullyQualifiedDomainName; }

        /// <summary>Internal Acessors for FullyQualifiedDomainName</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INspAccessRulePropertiesInternal.FullyQualifiedDomainName { get => this._fullyQualifiedDomainName; set { {_fullyQualifiedDomainName = value;} } }

        /// <summary>Internal Acessors for NetworkSecurityPerimeter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INetworkSecurityPerimeter[] Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INspAccessRulePropertiesInternal.NetworkSecurityPerimeter { get => this._networkSecurityPerimeter; set { {_networkSecurityPerimeter = value;} } }

        /// <summary>Backing field for <see cref="NetworkSecurityPerimeter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INetworkSecurityPerimeter[] _networkSecurityPerimeter;

        /// <summary>NetworkSecurityPerimeters for inbound rules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INetworkSecurityPerimeter[] NetworkSecurityPerimeter { get => this._networkSecurityPerimeter; }

        /// <summary>Backing field for <see cref="Subscription" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INspAccessRulePropertiesSubscriptionsItem[] _subscription;

        /// <summary>Subscriptions for inbound rules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INspAccessRulePropertiesSubscriptionsItem[] Subscription { get => this._subscription; set => this._subscription = value; }

        /// <summary>Creates an new <see cref="NspAccessRuleProperties" /> instance.</summary>
        public NspAccessRuleProperties()
        {

        }
    }
    /// Properties of Access Rule
    public partial interface INspAccessRuleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.IJsonSerializable
    {
        /// <summary>Address prefixes in the CIDR format for inbound rules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Address prefixes in the CIDR format for inbound rules",
        SerializedName = @"addressPrefixes",
        PossibleTypes = new [] { typeof(string) })]
        string[] AddressPrefix { get; set; }
        /// <summary>Direction of Access Rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Direction of Access Rule",
        SerializedName = @"direction",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.NspAccessRuleDirection) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.NspAccessRuleDirection? Direction { get; set; }
        /// <summary>FQDN for outbound rules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"FQDN for outbound rules",
        SerializedName = @"fullyQualifiedDomainNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] FullyQualifiedDomainName { get;  }
        /// <summary>NetworkSecurityPerimeters for inbound rules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"NetworkSecurityPerimeters for inbound rules",
        SerializedName = @"networkSecurityPerimeters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INetworkSecurityPerimeter) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INetworkSecurityPerimeter[] NetworkSecurityPerimeter { get;  }
        /// <summary>Subscriptions for inbound rules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscriptions for inbound rules",
        SerializedName = @"subscriptions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INspAccessRulePropertiesSubscriptionsItem) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INspAccessRulePropertiesSubscriptionsItem[] Subscription { get; set; }

    }
    /// Properties of Access Rule
    internal partial interface INspAccessRulePropertiesInternal

    {
        /// <summary>Address prefixes in the CIDR format for inbound rules</summary>
        string[] AddressPrefix { get; set; }
        /// <summary>Direction of Access Rule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.NspAccessRuleDirection? Direction { get; set; }
        /// <summary>FQDN for outbound rules</summary>
        string[] FullyQualifiedDomainName { get; set; }
        /// <summary>NetworkSecurityPerimeters for inbound rules</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INetworkSecurityPerimeter[] NetworkSecurityPerimeter { get; set; }
        /// <summary>Subscriptions for inbound rules</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.INspAccessRulePropertiesSubscriptionsItem[] Subscription { get; set; }

    }
}