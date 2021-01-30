using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class PlatformChannel : IPlatformChannel
    {
        /// <summary>
        /// The database entry id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The database entry id of the guild
        /// </summary>
        public int GuildId { get; set; }
        /// <summary>
        /// The database entry id of the platform
        /// </summary>
        public int PlatformId { get; set; }
        /// <summary>
        /// The discord id of the channel
        /// </summary>
        public ulong Snowflake { get; set; }
    }
}
