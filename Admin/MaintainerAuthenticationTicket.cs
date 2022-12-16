namespace Spyglass.Models.Admin
{
    public class MaintainerAuthenticationTicket
    {
        /// <summary>
        /// The token used to ensure the authentication attempt is valid.
        /// </summary>
        public string Token { get; set; }
        
        /// <summary>
        /// The time at which this authentication ticket expires.
        /// </summary>
        public DateTimeOffset Expiry { get; set; }
    }
}

