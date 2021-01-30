using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class PlatformMention : IPlatformMention
    {
        public int Id { get; set; }
        public int GuildId { get; set; }
        public int PlatformId { get; set; }
        public ulong? SnowflakeInitial { get; set; }
        public ulong? SnowflakeReminder { get; set; }
    }
}
