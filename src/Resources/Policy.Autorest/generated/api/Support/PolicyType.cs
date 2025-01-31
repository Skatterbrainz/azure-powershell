// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Support
{

    /// <summary>
    /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
    /// </summary>
    public partial struct PolicyType :
        System.IEquatable<PolicyType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.PolicyType BuiltIn = @"BuiltIn";

        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.PolicyType Custom = @"Custom";

        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.PolicyType NotSpecified = @"NotSpecified";

        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.PolicyType Static = @"Static";

        /// <summary>the value for an instance of the <see cref="PolicyType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PolicyType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PolicyType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PolicyType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PolicyType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.PolicyType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type PolicyType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PolicyType && Equals((PolicyType)obj);
        }

        /// <summary>Returns hashCode for enum PolicyType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="PolicyType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PolicyType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PolicyType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PolicyType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PolicyType" />.</param>

        public static implicit operator PolicyType(string value)
        {
            return new PolicyType(value);
        }

        /// <summary>Implicit operator to convert PolicyType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PolicyType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.PolicyType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PolicyType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.PolicyType e1, Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.PolicyType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PolicyType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.PolicyType e1, Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.PolicyType e2)
        {
            return e2.Equals(e1);
        }
    }
}