namespace Spyglass.Models.Admin
{
    /// <summary>
    /// Contains the result of a maintainer's authentication attempt.
    /// </summary>
    public class MaintainerAuthenticationResult : ApiResult
    {
        /// <summary>
        /// The authentication ticket that was created on success.
        /// </summary>
        public MaintainerAuthenticationTicket? Ticket { get; set; } = null;
    }
}

