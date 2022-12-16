using Newtonsoft.Json;

namespace Spyglass.Models
{
    /// <summary>
    /// Base class for API response results.
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// Whether or not the API request was successful.
        /// </summary>
        [JsonProperty]
        public bool Success { get; init; }
        
        /// <summary>
        /// The message that was returned by the API for the error.
        /// </summary>
        [JsonProperty]
        public string? Error { get; init; } = null!;

        /// <summary>
        /// Creates a new ApiResult object that designates a successful operation.
        /// </summary>
        public static ApiResult FromSuccess()
        {
            return new ApiResult
            {
                Success = true
            };
        }

        /// <summary>
        /// Creates a new ApiResult object that designates a failed operation, with an error message.
        /// <param name="error"> The error to pass into the ApiResult object. </param>
        /// </summary>
        public static ApiResult FromError(string error)
        {
            return new ApiResult
            {
                Success = false,
                Error = error
            };
        }
    }
}
