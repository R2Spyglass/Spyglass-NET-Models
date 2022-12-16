using Spyglass.Models;

namespace Spyglass.Models
{
    /// <summary>
    /// A result of an attempt to issue a sanction to a player.
    /// </summary>
    public class SanctionIssueResult : ApiResult
    {
        /// <summary>
        /// The sanction that was issued to the player, if any.
        /// </summary>
        public PlayerSanction? IssuedSanction { get; set; }
    }
}