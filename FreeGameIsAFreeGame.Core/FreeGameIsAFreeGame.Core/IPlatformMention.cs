namespace FreeGameIsAFreeGame.Core
{
    public interface IPlatformMention
    {
        int Id { get; set; }
        int GuildId { get; set; }
        int PlatformId { get; set; }
        ulong? SnowflakeInitial { get; set; }
        ulong? SnowflakeReminder { get; set; }
    }
}
