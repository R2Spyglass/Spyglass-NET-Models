using Newtonsoft.Json;

namespace Spyglass.Models
{
    /// <summary>
    /// A username alias for a given player.
    /// </summary>
    public class PlayerAlias
    {
        /// <summary>
        /// The unique id (UID) of the player for whom this username alias belongs to.
        /// </summary>
        [JsonProperty]
        public string UniqueID { get; set; }
        
        /// <summary>
        /// The additional username this player has over their primary one.
        /// </summary>
        [JsonProperty]
        public string Alias { get; set; }

        /// <summary>
        /// The player that this alias belongs to.
        /// </summary>
        [JsonProperty]
        public PlayerInfo OwningPlayer { get; set; }
    }   
}