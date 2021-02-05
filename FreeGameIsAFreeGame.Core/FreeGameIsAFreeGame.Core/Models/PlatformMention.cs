using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class PlatformMention : IPlatformMention
    {
        /// <inheritdoc />
        public int Id { get; set; }
        /// <inheritdoc />
        public int GuildId { get; set; }
        /// <inheritdoc />
        public int PlatformId { get; set; }
        /// <inheritdoc />
        public ulong? SnowflakeInitial { get; set; }
        /// <inheritdoc />
        public ulong? SnowflakeReminder { get; set; }
    }
}
