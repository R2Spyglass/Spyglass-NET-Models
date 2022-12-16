using Newtonsoft.Json;

namespace Spyglass.Models
{
    /// <summary>
    /// Basic information about a tracked Titanfall 2 player.
    /// </summary>
    public class PlayerInfo
    {
        /// <summary>
        /// The unique id (UID) of the player.
        /// </summary>
        public string UniqueID { get; set; } = default!;

        /// <summary>
        /// The username this player was initially seen with.
        /// </summary>
        public string Username { get; set; } = default!;

        /// <summary>
        /// Whether or not this player is a maintainer for Spyglass.
        /// </summary>
        public bool IsMaintainer { get; set; } = false;
        
        /// <summary>
        /// The date and time at which this player was added to the Spyglass database.
        /// </summary>
        [JsonIgnore]
        public DateTimeOffset CreatedAt { get; private set; }
        
        /// <summary>
        /// The unix timestamp seconds of the date & time the player was added.
        /// </summary>
        [JsonProperty("createdAt")]
        public long CreatedAtTimestamp => CreatedAt.ToUnixTimeSeconds();

        /// <summary>
        /// The time at which the player was added, in a readable string format.
        /// </summary>
        public string CreatedAtReadable => CreatedAt.ToString("dd-MMM-yy").ToUpper();
        
        /// <summary>
        /// The date and time at which this player was last seen at.
        /// </summary>
        [JsonIgnore]
        public DateTimeOffset LastSeenAt { get; set; }
        
        /// <summary>
        /// The unix timestamp seconds of the date & time the player was last seen at.
        /// </summary>
        [JsonProperty("lastSeenAt")]
        public long LastSeenAtTimestamp => LastSeenAt.ToUnixTimeSeconds();

        /// <summary>
        /// The time at which this player was last seen at, in a readable string format.
        /// </summary>
        public string LastSeenAtReadable => LastSeenAt.ToString("dd-MMM-yy h:mm:ss tt zz").ToUpper();
        
        /// <summary>
        /// The name of the server this player was last seen on.
        /// </summary>
        public string? LastSeenOnServer { get; set; }

        /// <summary>
        /// List of known username aliases for this player.
        /// </summary>
        [JsonIgnore]
        public List<PlayerAlias>? Aliases { get; private set; } = null!;

        /// <summary>
        /// List of known username aliases for this player, in string form only.
        /// </summary>
        public List<string>? KnownAliases => Aliases?.Select(a => a.Alias).ToList() ?? null;
        
        /// <summary>
        /// List of known sanctions for this player.
        /// </summary>
        public List<PlayerSanction> Sanctions { get; private set; }
    }
}

