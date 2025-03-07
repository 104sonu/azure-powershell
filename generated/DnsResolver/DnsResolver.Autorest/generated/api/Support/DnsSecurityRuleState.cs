// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support
{

    /// <summary>The state of DNS security rule.</summary>
    public partial struct DnsSecurityRuleState :
        System.IEquatable<DnsSecurityRuleState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsSecurityRuleState Disabled = @"Disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsSecurityRuleState Enabled = @"Enabled";

        /// <summary>the value for an instance of the <see cref="DnsSecurityRuleState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DnsSecurityRuleState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DnsSecurityRuleState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DnsSecurityRuleState(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DnsSecurityRuleState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DnsSecurityRuleState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DnsSecurityRuleState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsSecurityRuleState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DnsSecurityRuleState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DnsSecurityRuleState && Equals((DnsSecurityRuleState)obj);
        }

        /// <summary>Returns hashCode for enum DnsSecurityRuleState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DnsSecurityRuleState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DnsSecurityRuleState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DnsSecurityRuleState" />.</param>

        public static implicit operator DnsSecurityRuleState(string value)
        {
            return new DnsSecurityRuleState(value);
        }

        /// <summary>Implicit operator to convert DnsSecurityRuleState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DnsSecurityRuleState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsSecurityRuleState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DnsSecurityRuleState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsSecurityRuleState e1, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsSecurityRuleState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DnsSecurityRuleState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsSecurityRuleState e1, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsSecurityRuleState e2)
        {
            return e2.Equals(e1);
        }
    }
}