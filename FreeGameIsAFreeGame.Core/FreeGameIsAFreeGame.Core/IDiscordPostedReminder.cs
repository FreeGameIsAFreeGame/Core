namespace FreeGameIsAFreeGame.Core
{
    public interface IDiscordPostedReminder
    {
        int Id { get; set; }
        int DealId { get; set; }
        int GuildId { get; set; }
        int Status { get; set; }
    }
}