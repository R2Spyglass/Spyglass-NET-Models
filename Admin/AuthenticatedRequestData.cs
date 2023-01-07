using System.Net;
using NpgsqlTypes;

namespace Spyglass.Models.Admin
{
    public class AuthenticatedRequestData
    {
        /// <summary>
        /// The id of the client that made the request.
        /// </summary>
        public string ClientId { get; set; } = null!;
        
        /// <summary>
        /// If available, the name of the server that made this request.
        /// </summary>
        public string? ServerName { get; set; }

        /// <summary>
        /// IP address of the client that made the authenticated request.
        /// </summary>
        public string IpAddress { get; set; } = null!;
        
        /// <summary>
        /// The date and time at which the request from this client and ip was first made at.
        /// </summary>
        public DateTimeOffset RequestTime { get; set; }
    }
}

