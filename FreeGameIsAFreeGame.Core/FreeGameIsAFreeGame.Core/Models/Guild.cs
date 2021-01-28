using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class Guild : IGuild
    {
        public int Id { get; set; }
        public ulong Snowflake { get; set; }
    }
}
