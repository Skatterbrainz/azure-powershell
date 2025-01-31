// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The state of a private link service connection.</summary>
    public partial class PrivateLinkServiceConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPrivateLinkServiceConnectionState,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPrivateLinkServiceConnectionStateInternal
    {

        /// <summary>Backing field for <see cref="ActionsRequired" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ActionsRequired? _actionsRequired;

        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ActionsRequired? ActionsRequired { get => this._actionsRequired; set => this._actionsRequired = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>
        /// The description for connection status. For example if connection is rejected it can indicate reason for rejection.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectionStatus? _status;

        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectionStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="PrivateLinkServiceConnectionState" /> instance.</summary>
        public PrivateLinkServiceConnectionState()
        {

        }
    }
    /// The state of a private link service connection.
    public partial interface IPrivateLinkServiceConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A message indicating if changes on the service provider require any updates on the consumer.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ActionsRequired) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ActionsRequired? ActionsRequired { get; set; }
        /// <summary>
        /// The description for connection status. For example if connection is rejected it can indicate reason for rejection.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description for connection status. For example if connection is rejected it can indicate reason for rejection.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The private link service connection status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectionStatus? Status { get; set; }

    }
    /// The state of a private link service connection.
    internal partial interface IPrivateLinkServiceConnectionStateInternal

    {
        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ActionsRequired? ActionsRequired { get; set; }
        /// <summary>
        /// The description for connection status. For example if connection is rejected it can indicate reason for rejection.
        /// </summary>
        string Description { get; set; }
        /// <summary>The private link service connection status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectionStatus? Status { get; set; }

    }
}