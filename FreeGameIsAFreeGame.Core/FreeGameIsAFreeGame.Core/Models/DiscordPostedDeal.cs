using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class DiscordPostedDeal : IDiscordPostedDeal
    {
        /// <summary>
        /// The database entry id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The database entry id of the deal
        /// </summary>
        public int DealId { get; set; }
        /// <summary>
        /// The database entry id of the guild
        /// </summary>
        public int GuildId { get; set; }
        /// <summary>
        /// The status of the posted deal
        /// </summary>
        public PostStatus Status { get; set; }
    }
}
