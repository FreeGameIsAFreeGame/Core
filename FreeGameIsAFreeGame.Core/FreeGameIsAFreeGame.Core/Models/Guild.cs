using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class Guild : IGuild
    {
        /// <inheritdoc />
        public int Id { get; set; }
        /// <inheritdoc />
        public ulong Snowflake { get; set; }
    }
}
