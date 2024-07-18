namespace Spyglass.Models
{
    /// <summary>
    /// Contains the result to a query for all Spyglass sanctions.
    /// </summary>
    public class SanctionResult : ApiResult
    {
        /// <summary>
        /// List of all sanctions currently available in the database.
        /// </summary>
        public List<PlayerSanction>? Sanctions { get; set; }
    }
}