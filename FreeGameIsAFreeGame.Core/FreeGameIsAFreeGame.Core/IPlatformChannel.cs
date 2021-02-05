namespace FreeGameIsAFreeGame.Core
{
    public interface IPlatformChannel
    {
        /// <summary>
        /// The database entry id
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// The database entry id of the guild
        /// </summary>
        int GuildId { get; set; }
        /// <summary>
        /// The database entry id of the platform
        /// </summary>
        int PlatformId { get; set; }
        /// <summary>
        /// The discord id of the channel for the initial message for the platform
        /// </summary>
        ulong? SnowflakeInitial { get; set; }
        /// <summary>
        /// The discord id of the channel for the reminder message for the platform
        /// </summary>
        ulong? SnowflakeReminder { get; set; }
    }
}
