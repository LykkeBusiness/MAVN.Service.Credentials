using Lykke.SettingsReader.Attributes;

namespace MAVN.Service.Credentials.Client 
{
    /// <summary>
    /// Credentials client settings.
    /// </summary>
    public class CredentialsServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
