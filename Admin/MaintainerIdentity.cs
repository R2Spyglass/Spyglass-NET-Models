namespace Spyglass.Models.Admin
{
    /// <summary>
    /// The identity of a maintainer.
    /// Each maintainer may have multiple linked uids.
    /// </summary>
    public class MaintainerIdentity
    {
        /// <summary>
        /// The client id of the maintainer.
        /// </summary>
        public string ClientId { get; set; } = null!;

        /// <summary>
        /// The unique id of the maintainer's account.
        /// </summary>
        public string UniqueId { get; set; } = null!;
    }
}

