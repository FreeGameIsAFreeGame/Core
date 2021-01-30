using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class DiscordPostedDeal : IDiscordPostedDeal
    {
        public int Id { get; set; }
        public int DealId { get; set; }
        public int GuildId { get; set; }
        public PostStatus Status { get; set; }
    }
}
