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
        /// <inheritdoc />
        public bool Enabled { get; set; }
        /// <inheritdoc />
        public ulong? CommandChannel { get; set; }
        /// <inheritdoc />
        public ulong? CommandRole { get; set; }
        /// <inheritdoc />
        public ulong PostChannel { get; set; }
    }
}
