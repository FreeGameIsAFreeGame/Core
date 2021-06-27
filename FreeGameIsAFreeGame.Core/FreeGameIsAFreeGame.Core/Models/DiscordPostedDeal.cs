using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class DiscordPostedDeal : IDiscordPostedDeal
    {
        /// <inheritdoc />
        public int Id { get; set; }
        /// <inheritdoc />
        public int DealId { get; set; }
        /// <inheritdoc />
        public int GuildId { get; set; }
        /// <inheritdoc />
        public PostStatus Status { get; set; }
    }
}
