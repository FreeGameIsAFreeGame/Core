using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class PlatformChannel : IPlatformChannel
    {
        /// <inheritdoc />
        public int Id { get; set; }
        /// <inheritdoc />
        public int GuildId { get; set; }
        /// <inheritdoc />
        public int PlatformId { get; set; }
        /// <inheritdoc />
        public ulong? Snowflake { get; set; }
    }
}
