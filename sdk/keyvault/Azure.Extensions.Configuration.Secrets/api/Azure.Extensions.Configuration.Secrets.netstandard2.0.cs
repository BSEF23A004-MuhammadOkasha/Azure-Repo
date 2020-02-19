namespace Azure.Extensions.Configuration.Secrets
{
    public partial class AzureKeyVaultConfigurationOptions
    {
        public AzureKeyVaultConfigurationOptions() { }
        public AzureKeyVaultConfigurationOptions(System.Uri vaultUri, Azure.Core.TokenCredential credential) { }
        public Azure.Security.KeyVault.Secrets.SecretClient Client { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Azure.Extensions.Configuration.Secrets.IKeyVaultSecretManager Manager { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public System.TimeSpan? ReloadInterval { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
    }
    public partial class DefaultKeyVaultSecretManager : Azure.Extensions.Configuration.Secrets.IKeyVaultSecretManager
    {
        public DefaultKeyVaultSecretManager() { }
        public virtual string GetKey(Azure.Security.KeyVault.Secrets.KeyVaultSecret secret) { throw null; }
        public virtual bool Load(Azure.Security.KeyVault.Secrets.SecretProperties secret) { throw null; }
    }
    public partial interface IKeyVaultSecretManager
    {
        string GetKey(Azure.Security.KeyVault.Secrets.KeyVaultSecret secret);
        bool Load(Azure.Security.KeyVault.Secrets.SecretProperties secret);
    }
}
namespace Microsoft.Extensions.Configuration
{
    public static partial class AzureKeyVaultConfigurationExtensions
    {
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddAzureKeyVault(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, Azure.Extensions.Configuration.Secrets.AzureKeyVaultConfigurationOptions options) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddAzureKeyVault(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, Azure.Security.KeyVault.Secrets.SecretClient client, Azure.Extensions.Configuration.Secrets.IKeyVaultSecretManager manager) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddAzureKeyVault(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, System.Uri vaultUri) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddAzureKeyVault(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, System.Uri vaultUri, Azure.Core.TokenCredential credential) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddAzureKeyVault(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, System.Uri vaultUri, Azure.Core.TokenCredential credential, Azure.Extensions.Configuration.Secrets.IKeyVaultSecretManager manager) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddAzureKeyVault(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, System.Uri vaultUri, Azure.Extensions.Configuration.Secrets.IKeyVaultSecretManager manager) { throw null; }
    }
}
