// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Encryption settings. </summary>
    public partial class NetAppAccountEncryption
    {
        /// <summary> Initializes a new instance of NetAppAccountEncryption. </summary>
        public NetAppAccountEncryption()
        {
        }

        /// <summary> Initializes a new instance of NetAppAccountEncryption. </summary>
        /// <param name="keySource"> The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.NetApp, Microsoft.KeyVault. </param>
        /// <param name="keyVaultProperties"> Properties provided by KeVault. Applicable if keySource is &apos;Microsoft.KeyVault&apos;. </param>
        /// <param name="identity"> Identity used to authenticate to KeyVault. Applicable if keySource is &apos;Microsoft.KeyVault&apos;. </param>
        internal NetAppAccountEncryption(NetAppKeySource? keySource, NetAppKeyVaultProperties keyVaultProperties, NetAppEncryptionIdentity identity)
        {
            KeySource = keySource;
            KeyVaultProperties = keyVaultProperties;
            Identity = identity;
        }

        /// <summary> The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.NetApp, Microsoft.KeyVault. </summary>
        public NetAppKeySource? KeySource { get; set; }
        /// <summary> Properties provided by KeVault. Applicable if keySource is &apos;Microsoft.KeyVault&apos;. </summary>
        public NetAppKeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> Identity used to authenticate to KeyVault. Applicable if keySource is &apos;Microsoft.KeyVault&apos;. </summary>
        public NetAppEncryptionIdentity Identity { get; set; }
    }
}
