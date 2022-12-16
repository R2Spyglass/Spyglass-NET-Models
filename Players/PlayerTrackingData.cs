using Newtonsoft.Json;

namespace Spyglass.Models
{
    public class PlayerTrackingData
    {
        /// <summary>
        /// The hostname of the server making the tracking request. 
        /// </summary>
        [JsonProperty]
        public string Hostname { get; set; }
        
        /// <summary>
        /// The players the server is currently tracking.
        /// </summary>
        [JsonProperty]
        public List<PlayerIdentity> Players { get; set; }
    }
}

