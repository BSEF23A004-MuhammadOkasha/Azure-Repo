// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The kill chain related intent behind the alert. For list of supported values, and explanations of Azure Security Center's supported kill chain intents. </summary>
    public readonly partial struct KillChainIntent : IEquatable<KillChainIntent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KillChainIntent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KillChainIntent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string PreAttackValue = "PreAttack";
        private const string InitialAccessValue = "InitialAccess";
        private const string PersistenceValue = "Persistence";
        private const string PrivilegeEscalationValue = "PrivilegeEscalation";
        private const string DefenseEvasionValue = "DefenseEvasion";
        private const string CredentialAccessValue = "CredentialAccess";
        private const string DiscoveryValue = "Discovery";
        private const string LateralMovementValue = "LateralMovement";
        private const string ExecutionValue = "Execution";
        private const string CollectionValue = "Collection";
        private const string ExfiltrationValue = "Exfiltration";
        private const string CommandAndControlValue = "CommandAndControl";
        private const string ImpactValue = "Impact";
        private const string ProbingValue = "Probing";
        private const string ExploitationValue = "Exploitation";

        /// <summary> Unknown. </summary>
        public static KillChainIntent Unknown { get; } = new KillChainIntent(UnknownValue);
        /// <summary> PreAttack could be either an attempt to access a certain resource regardless of a malicious intent, or a failed attempt to gain access to a target system to gather information prior to exploitation. This step is usually detected as an attempt, originating from outside the network, to scan the target system and find a way in.  Further details on the PreAttack stage can be read in [MITRE Pre-Att&amp;ck matrix](https://attack.mitre.org/matrices/pre/). </summary>
        public static KillChainIntent PreAttack { get; } = new KillChainIntent(PreAttackValue);
        /// <summary> InitialAccess is the stage where an attacker manages to get foothold on the attacked resource. </summary>
        public static KillChainIntent InitialAccess { get; } = new KillChainIntent(InitialAccessValue);
        /// <summary> Persistence is any access, action, or configuration change to a system that gives a threat actor a persistent presence on that system. </summary>
        public static KillChainIntent Persistence { get; } = new KillChainIntent(PersistenceValue);
        /// <summary> Privilege escalation is the result of actions that allow an adversary to obtain a higher level of permissions on a system or network. </summary>
        public static KillChainIntent PrivilegeEscalation { get; } = new KillChainIntent(PrivilegeEscalationValue);
        /// <summary> Defense evasion consists of techniques an adversary may use to evade detection or avoid other defenses. </summary>
        public static KillChainIntent DefenseEvasion { get; } = new KillChainIntent(DefenseEvasionValue);
        /// <summary> Credential access represents techniques resulting in access to or control over system, domain, or service credentials that are used within an enterprise environment. </summary>
        public static KillChainIntent CredentialAccess { get; } = new KillChainIntent(CredentialAccessValue);
        /// <summary> Discovery consists of techniques that allow the adversary to gain knowledge about the system and internal network. </summary>
        public static KillChainIntent Discovery { get; } = new KillChainIntent(DiscoveryValue);
        /// <summary> Lateral movement consists of techniques that enable an adversary to access and control remote systems on a network and could, but does not necessarily, include execution of tools on remote systems. </summary>
        public static KillChainIntent LateralMovement { get; } = new KillChainIntent(LateralMovementValue);
        /// <summary> The execution tactic represents techniques that result in execution of adversary-controlled code on a local or remote system. </summary>
        public static KillChainIntent Execution { get; } = new KillChainIntent(ExecutionValue);
        /// <summary> Collection consists of techniques used to identify and gather information, such as sensitive files, from a target network prior to exfiltration. </summary>
        public static KillChainIntent Collection { get; } = new KillChainIntent(CollectionValue);
        /// <summary> Exfiltration refers to techniques and attributes that result or aid in the adversary removing files and information from a target network. </summary>
        public static KillChainIntent Exfiltration { get; } = new KillChainIntent(ExfiltrationValue);
        /// <summary> The command and control tactic represents how adversaries communicate with systems under their control within a target network. </summary>
        public static KillChainIntent CommandAndControl { get; } = new KillChainIntent(CommandAndControlValue);
        /// <summary> Impact events primarily try to directly reduce the availability or integrity of a system, service, or network; including manipulation of data to impact a business or operational process. </summary>
        public static KillChainIntent Impact { get; } = new KillChainIntent(ImpactValue);
        /// <summary> Probing could be either an attempt to access a certain resource regardless of a malicious intent, or a failed attempt to gain access to a target system to gather information prior to exploitation. </summary>
        public static KillChainIntent Probing { get; } = new KillChainIntent(ProbingValue);
        /// <summary> Exploitation is the stage where an attacker manages to get a foothold on the attacked resource. This stage is relevant for compute hosts and resources such as user accounts, certificates etc. </summary>
        public static KillChainIntent Exploitation { get; } = new KillChainIntent(ExploitationValue);
        /// <summary> Determines if two <see cref="KillChainIntent"/> values are the same. </summary>
        public static bool operator ==(KillChainIntent left, KillChainIntent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KillChainIntent"/> values are not the same. </summary>
        public static bool operator !=(KillChainIntent left, KillChainIntent right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KillChainIntent"/>. </summary>
        public static implicit operator KillChainIntent(string value) => new KillChainIntent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KillChainIntent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KillChainIntent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
