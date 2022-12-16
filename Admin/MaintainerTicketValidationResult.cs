namespace Spyglass.Models.Admin
{
    /// <summary>
    /// The result of an attempt to validate a maintainer's authentication token.
    /// </summary>
    public class MaintainerTicketValidationResult : ApiResult
    {
        /// <summary>
        /// Whether or not the authentication token is valid.
        /// </summary>
        public bool IsValid { get; set; }
    }
}

