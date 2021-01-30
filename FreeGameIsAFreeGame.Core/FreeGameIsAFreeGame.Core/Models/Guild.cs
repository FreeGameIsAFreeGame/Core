using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class Guild : IGuild
    {
        /// <summary>
        /// The database entry id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The discord id of the guild
        /// </summary>
        public ulong Snowflake { get; set; }
    }
}
