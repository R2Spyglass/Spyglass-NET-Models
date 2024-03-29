﻿using Newtonsoft.Json;

namespace Spyglass.Models
{
    /// <summary>
    /// Pairs a player's unique id (UID) with their username.
    /// Used on privileged scopes to update a player's information.
    /// </summary>
    public class PlayerIdentity
    {
        /// <summary>
        /// The unique id (UID) of the player.
        /// </summary>
        [JsonProperty]
        public string UniqueID { get; set; }
        
        /// <summary>
        /// The username the player currently has.
        /// </summary>
        [JsonProperty]
        public string Username { get; set; }
    }
}

