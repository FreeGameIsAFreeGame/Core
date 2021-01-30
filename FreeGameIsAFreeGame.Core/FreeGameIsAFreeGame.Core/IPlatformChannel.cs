namespace FreeGameIsAFreeGame.Core
{
    public interface IPlatformChannel
    {
        int Id { get; set; }
        int GuildId { get; set; }
        int PlatformId { get; set; }
        ulong Snowflake { get; set; }
    }
}
