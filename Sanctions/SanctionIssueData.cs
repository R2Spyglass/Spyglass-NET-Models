using SpyglassNET.Utilities;

namespace Spyglass.Models
{
    /// <summary>
    /// Data about a sanction to issue to a player.
    /// </summary>
    public class SanctionIssueData
    {
        /// <summary>
        /// The unique id of the player the sanction belongs to.
        /// </summary>
        public string UniqueId { get; set; } = null!;

        /// <summary>
        /// The username of the player who the sanction will be issued to.
        /// Only used to create the user if they don't exist already.
        /// </summary>
        public string Username { get; set; } = null!;

        /// <summary>
        /// The unique id of the player who issued the id.
        /// </summary>
        public string IssuerId { get; set; } = null!;

        /// <summary>
        /// The time at which this sanction expires, if any.
        /// Null or otherwise empty values mean this sanction is permanent.
        /// </summary>
        public DateTimeOffset? ExpiresAt { get; set; }
        
        /// <summary>
        /// The reason why this sanction was applied to the player.
        /// </summary>
        public string Reason { get; set; } = null!;

        /// <summary>
        /// The type of infraction that led to this sanction.
        /// </summary>
        public InfractionType Type { get; set; }

        /// <summary>
        /// The punishment that should be applied for this sanction.
        /// </summary>
        public SanctionType PunishmentType { get; set; }

        public bool IsValid(out string errorMessage)
        {
            if (!SpyglassUtils.ValidateUniqueId(UniqueId))
            {
                errorMessage = "Invalid player uid.";
                return false;
            }

            if (!SpyglassUtils.ValidateUniqueId(IssuerId))
            {
                errorMessage = "Invalid issuer uid.";
                return false;
            }

            if (ulong.Parse(UniqueId) == ulong.Parse(IssuerId))
            {
                errorMessage = "Cannot apply sanction to yourself.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Reason))
            {
                errorMessage = "A valid reason must be specified.";
                return false;
            }

            errorMessage = "";
            return true;
        }
    }
}

