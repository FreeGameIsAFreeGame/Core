using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class DiscordPostedReminder : IDiscordPostedReminder
    {
        public int Id { get; set; }
        public int DealId { get; set; }
        public int GuildId { get; set; }
        public int Status { get; set; }
    }
}