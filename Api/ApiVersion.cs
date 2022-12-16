using Newtonsoft.Json;

namespace Spyglass.Models
{
    /// <summary>
    /// Contains data about the API's current version, and the minimum client version required to interact with it.
    /// </summary>
    public class ApiVersion : ApiResult
    {
        /// <summary>
        /// The current version of the Spyglass API.
        /// </summary>
        [JsonProperty]
        public string Version { get; set; } = default!;

        /// <summary>
        /// The minimum client version required to interact with this API.
        /// </summary>
        [JsonProperty]
        public string MinimumVersion { get; set; } = default!;
    }
}
