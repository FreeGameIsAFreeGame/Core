using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class PlatformChannel : IPlatformChannel
    {
        public int Id { get; set; }
        public int GuildId { get; set; }
        public int PlatformId { get; set; }
        public ulong Snowflake { get; set; }
    }
}
