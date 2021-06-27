namespace FreeGameIsAFreeGame.Core
{
    public interface IPlatformMention : IModel
    {
        /// <summary>
        /// The database entry id of the guild
        /// </summary>
        int GuildId { get; set; }
        /// <summary>
        /// The database entry id of the platform
        /// </summary>
        int PlatformId { get; set; }
        /// <summary>
        /// The discord id of the role to mention
        /// </summary>
        ulong? SnowflakeInitial { get; set; }
        /// <summary>
        /// The discord id of the role to mention
        /// </summary>
        ulong? SnowflakeReminder { get; set; }
    }
}
