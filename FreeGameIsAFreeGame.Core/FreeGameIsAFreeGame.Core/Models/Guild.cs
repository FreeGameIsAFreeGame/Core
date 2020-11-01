using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class Guild
    {
        public int Id { get; set; }
        public ulong Snowflake { get; set; }
    }
}
