namespace Spyglass.Models.Admin
{
    /// <summary>
    /// The result of an attempt to lookup an ip for an authenticated client.
    /// </summary>
    public class AuthenticatedIpResult : ApiResult
    {
        /// <summary>
        /// The ip address that was looked up.
        /// </summary>
        public string IpAddress { get; set; } = null!;

        /// <summary>
        /// List of authenticated requests that match the ip address.
        /// </summary>
        public List<AuthenticatedRequestData> Matches { get; set; } = new List<AuthenticatedRequestData>();
    }
}

