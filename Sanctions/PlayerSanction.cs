// ReSharper disable UnusedAutoPropertyAccessor.Local
// ReSharper disable UnusedAutoPropertyAccessor.Global

using Newtonsoft.Json;

namespace Spyglass.Models
{
    /**
     * Details about a sanction that was issued to a player.
     */
    public class PlayerSanction
    {
        /// <summary>
        /// The unique id given to this player sanction.
        /// </summary>
        [JsonProperty]
        public int Id { get; set; }

        /// <summary>
        /// The unique id (UID) of the player this sanction belongs to.
        /// </summary>
        [JsonProperty]
        public string UniqueId { get; set; } = default!;

        /// <summary>
        /// The player this sanction belongs to.
        /// </summary>
        [JsonProperty]
        public PlayerInfo OwningPlayer { get; set; } = null!;

        /// <summary>
        /// The unique id (UID) of the player who issued this sanction.
        /// </summary>
        [JsonProperty]
        public string IssuerId { get; set; } = default!;

        /// <summary>
        /// The player who issued this sanction.
        /// </summary>
        [JsonProperty]
        public PlayerInfo IssuerInfo { get; set; } = null!;

        /// <summary>
        /// The time at which this sanction was issued.
        /// </summary>
        [JsonProperty]
        public DateTimeOffset IssuedAt { get; set; }

        /// <summary>
        /// The unix timestamp seconds of the date & time the sanction was issued.
        /// </summary>
        [JsonProperty("issuedAtTimestamp")]
        public long IssuedAtTimestamp => IssuedAt.ToUnixTimeSeconds();

        /// <summary>
        /// The time at which this sanction was issued, in a readable string format.
        /// </summary>
        [JsonProperty]
        public string IssuedAtReadable => IssuedAt.ToString("dd-MMM-yy").ToUpper();
        
        /// <summary>
        /// The time at which this sanction expires, if any.
        /// Null or otherwise empty values mean this sanction is permanent.
        /// </summary>
        [JsonProperty]
        public DateTimeOffset? ExpiresAt { get; set; }
        
        /// <summary>
        /// The unix timestamp seconds of the date & time this sanction expires, if any.
        /// Null or otherwise empty values mean this sanction is permanent.
        /// </summary>
        [JsonProperty("expiresAtTimestamp", NullValueHandling = NullValueHandling.Include)]
        public long? ExpiresAtTimestamp => ExpiresAt?.ToUnixTimeSeconds() ?? null;

        /// <summary>
        /// The time at which this sanction expires, if any, in a readable string format.
        /// </summary>
        [JsonProperty]
        public string ExpiresAtReadable => ExpiresAt?.ToString("R").ToUpper() ?? "Never";

        /// <summary>
        /// The reason why this sanction was applied to the player.
        /// </summary>
        [JsonProperty]
        public string Reason { get; set; } = default!;

        /// <summary>
        /// The type of infraction that led to this sanction.
        /// </summary>
        [JsonProperty]
        public InfractionType Type { get; set; }

        /// <summary>
        /// A human readable, uppercase string of the sanction's infraction type.
        /// Can be used for filtering on the game mod side.
        /// </summary>
        [JsonProperty]
        public string TypeReadable => Enum.GetName(Type)!.ToUpper();

        /// <summary>
        /// The punishment that should be applied for this sanction.
        /// </summary>
        [JsonProperty]
        public SanctionType PunishmentType { get; set; }

        /// <summary>
        /// A human readable, uppercase string of the sanction's punishment type.
        /// </summary>
        [JsonProperty]
        public string PunishmentReadable => Enum.GetName(PunishmentType)!.ToUpper();
    }
}